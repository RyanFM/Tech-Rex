using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;
using MySql.Data.MySqlClient;
using System.Timers;

namespace Entrance
{
    public partial class Form_Gate : Form
    {
        private int id;
        private string rfidTag;
        RFID UserRFID;
        DatabaseConnector DB;
        
        public Form_Gate()
        {
            InitializeComponent();

            DB = new DatabaseConnector();
            if (DB.IsConnected())
            {
                DB.databaseConnection.Close();
            }
            else
            {
                pnlScan.BackColor = Color.Red;
                lbScan.Text = "Out of server.";
            }

            //---

            UserRFID = new RFID();

            try
            {
                //RFID part
                UserRFID.open();
                UserRFID.waitForAttachment(3000);
                UserRFID.Antenna = true;
                UserRFID.LED = true;
                UserRFID.Tag += new TagEventHandler(AttcahTag);
            }
            catch (PhidgetException)
            {
                pnlScan.BackColor = Color.Red;
                lbScan.Text = "Out of server.";
            }

            //--
        }
        public void ResetForm()
        {
            lbScan.Text = "Scan your tag to enter";
            lbScan.ForeColor = SystemColors.ControlText;
            pnlScan.BackColor = Color.PaleGoldenrod;
        }
        public void ExecuteIn(int milliseconds)
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Tick += (s, e) =>
            {
                ((System.Windows.Forms.Timer)s).Stop(); //s is the Timer
                ResetForm();

            };
            timer.Interval = milliseconds;
            timer.Start();
        }

        public void AttcahTag(object sender, TagEventArgs e)
        {
            rfidTag = e.Tag.ToString();
            DB.databaseConnection.Open();
            string queryID = "SELECT visitor_id FROM visitor WHERE rfid='" + rfidTag + "'";

            MySqlCommand commandID = new MySqlCommand(queryID, DB.databaseConnection);
            MySqlDataReader reader = commandID.ExecuteReader();

            try
            {
                reader.Read();
                id = Convert.ToInt32(reader[0]);

            }
            catch
            {
                MessageBox.Show("Read failed");
            }
            reader.Close();

            if (ValidateStatus() == true)
            {
                pnlScan.BackColor = Color.DarkSeaGreen;
                lbScan.ForeColor = Color.Azure;
                lbScan.Text = "PASS";
                
                string query = "UPDATE visitor SET status='Checked-in' WHERE rfid='" + rfidTag + "'";
                MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
                command.ExecuteNonQuery();
                DB.databaseConnection.Close();

                ExecuteIn(1500);

            }
            else
            {
                pnlScan.BackColor = Color.Maroon;
                lbScan.ForeColor = Color.Azure;
                lbScan.Text = "Denied";

                ExecuteIn(1500);
                //label_Line1.Text = "Scan your tag to enter";
                //label_Line1.ForeColor = SystemColors.ControlText;
                //this.BackColor = Color.Gold;
                DB.databaseConnection.Close();

            }
            

        }

        public bool ValidateStatus()
        {
            string status = "";

           

            string query = "SELECT status FROM visitor WHERE rfid='" + rfidTag + "'";
            MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);


            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                status = reader[0].ToString();
                reader.Close();

            }
            catch
            {
                pnlScan.BackColor = Color.Red;
                lbScan.Text = "Out of server.";
            }
            
            if (status == "Registered" )
            {
                return true;
            }
            else if (status == "Checked-out")
            {

               
                return true;
            }
            else
            {
                return false;
            }
           
        }


        //---------------------------------------------
        private void OpenGate()
        {

        }

        private void Form_Gate_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserRFID.close();
        }
    }
}
