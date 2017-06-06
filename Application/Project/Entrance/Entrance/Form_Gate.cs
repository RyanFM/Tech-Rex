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
                this.BackColor = Color.Red;
                label_Line1.Text = "Out of server.";
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
                this.BackColor = Color.Red;
                label_Line1.Text = "Out of server.";
            }

            //--
        }
        public void ResetForm()
        {
            label_Line1.Text = "Scan your tag to enter";
            label_Line1.ForeColor = SystemColors.ControlText;
            this.BackColor = Color.Gold;
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
                this.BackColor = Color.Green;
                label_Line1.ForeColor = Color.Azure;
                label_Line1.Text = "PASS";
                
                string query = "UPDATE visitor SET status='Checked-in' WHERE rfid='" + rfidTag + "'";
                MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
                command.ExecuteNonQuery();
                DB.databaseConnection.Close();

                ExecuteIn(1500);

            }
            else
            {
                this.BackColor = Color.Red;
                label_Line1.ForeColor = Color.Azure;
                label_Line1.Text = "Denied";

                ExecuteIn(1500);
                //label_Line1.Text = "Scan your tag to enter";
                //label_Line1.ForeColor = SystemColors.ControlText;
                //this.BackColor = Color.Gold;

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
                this.BackColor = Color.Red;
                label_Line1.Text = "Out of server.";
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
    }
}
