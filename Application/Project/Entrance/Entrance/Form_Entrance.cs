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
    public partial class Form1 : Form
    {
        /***************  field  *************************/
        private int id;
        private string rfidTag;
        RFID UserRFID;
        DatabaseConnector DB;

        //Constructor 
        //initiallise random and status
        public Form1()
        {
            InitializeComponent();
            
            UserRFID = new RFID();
            //UserRFID.Attach += new AttachEventHandler(ShowAttachInfo);
            //UserRFID.Detach += new DetachEventHandler(ShowDetachInfo);
            //DB part
            DB = new DatabaseConnector();
            if (DB.IsConnected())
            {
                //label_databasestatus.Text = "Database Connected";
                DB.databaseConnection.Close();
            }
            else
            {
                //label_databasestatus.Text = "Database Connecttion failed";
                //label_status.Text = "Please contact Technical staff";
            }
            

            try
            {
                //RFID part
                UserRFID.open();
                UserRFID.waitForAttachment(3000);
                UserRFID.Antenna = true;
                UserRFID.LED = true;
                UserRFID.Tag += new TagEventHandler(AttcahTag);
                UserRFID.TagLost += new TagEventHandler(DetachTag);
            }
            catch(PhidgetException)
            {
                //label_SystemStatus.Text = "This Phidget is not opened and attached";
                //label_status.Text = "Please contact Technical staff";
            }

        }


        /***********************  method  ***************************/

        public void ResetForm()
        {
            lbScan.Text = "Scan new tag";
            textBox_ID.Text = "";
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
        //Show system status 
        //public void ShowAttachInfo(object sender, AttachEventArgs e)
        //{
        //    label_SystemStatus.Text = "RFID attached, Serial Number" + e.Device.SerialNumber.ToString();
        //}
        //public void ShowDetachInfo(object sender, DetachEventArgs e)
        //{
        //    label_SystemStatus.Text = "RFID detached";
        //}
        ////Above show system status


        //About Tag
        public void AttcahTag(object sender,TagEventArgs e)
        {
            rfidTag = e.Tag.ToString();
            //label_RFIDnr.Text += " "+ rfidTag;
            //label_status.Text = "RFID scanned.";

           // string query = "UPDATE visitor SET status='Checked-in' WHERE visitor_id=1";
           // MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);

        }
        public void DetachTag(object sender,TagEventArgs e)
        {
            //label_RFIDnr.Text = "RFID number:";
            //label_status.Text = "RFID stored. ";//Scan QR code.";
            if (ValidateStatus())
            {
                UpdateSQL();
                lbScan.Text = "Confirmed";
                ExecuteIn(2000);
            }
            else
            {
                MessageBox.Show("Please enter a valid ticket number");
            }
               
        }
        //Above about tag

        //validate
        public bool ValidateStatus()
        {
            int visitorID = 0;

            DB.databaseConnection.Open();
            
            string query = "SELECT visitor_id FROM visitor WHERE visitor_id=" + id;
            MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);


            try
            {
                visitorID = Convert.ToInt32(command.ExecuteScalar());
                

            }
            catch
            {
                MessageBox.Show("Read failed");
            }
            finally
            {
                DB.databaseConnection.Close();
            }
            if (visitorID != 0)
            {
                return true;
            }
            else
                return false;




        }

        //SQL update -- update stasut
        public void UpdateSQL()
        {
            DB.databaseConnection.Open();
            string query = "UPDATE visitor SET rfid='" + rfidTag + "' WHERE visitor_id=" + id;
            MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
            command.ExecuteNonQuery();
            DB.databaseConnection.Close();

        }




        /**************** unimportant method *******************/


        //Status changes
        public void ChangeStatus(string status)
        {
            //label_status.Text = status;
        }

        // When close this form, trun off Antenna and its LED
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserRFID.LED = false;
            UserRFID.Antenna = false;
            UserRFID.close();
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(textBox_ID.Text);
            }
            catch
            {

            }
            if (textBox_ID.Text != "")
            {
                lbScan.Visible = true;
                pnlScan.Visible = true;
            }
            else
            {
                lbScan.Visible = false;
                pnlScan.Visible = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserRFID.close();
        }

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
