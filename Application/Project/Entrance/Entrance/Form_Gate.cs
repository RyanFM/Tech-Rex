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

namespace Entrance
{
    public partial class Form_Gate : Form
    {
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

        public void AttcahTag(object sender, TagEventArgs e)
        {
            rfidTag = e.Tag.ToString();
            if (ValidateStatus()==true)
            {
                this.BackColor = Color.Green;
                label_Line1.ForeColor = Color.Azure;
                label_Line1.Text = "PASS";
                DB.databaseConnection.Open();
                string query = "UPDATE visitor SET status='Checked-in' WHERE rfid='" + rfidTag + "'" ;
                MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
                command.ExecuteNonQuery();
                DB.databaseConnection.Close();

            }
            else
            {
                this.BackColor = Color.Red;
                label_Line1.ForeColor = Color.Azure;
                label_Line1.Text = "Deny. Call the staff.";

            }

        }

        public bool ValidateStatus()
        {
            string status = "OHHHHHHHHH SHIT-2";

            DB.databaseConnection.Open();

            string query = "SELECT status FROM visitor WHERE rfid='" + rfidTag+"'";
            MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);


            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                status = reader[0].ToString();

            }
            catch
            {
                this.BackColor = Color.Red;
                label_Line1.Text = "Out of server.";
            }
            finally
            {
                DB.databaseConnection.Close();
            }
            if (status == "Registered")
                return true;
            return false;
        }


//---------------------------------------------
        private void OpenGate()
        {

        }
    }
    }
