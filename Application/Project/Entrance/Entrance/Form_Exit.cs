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
    public partial class Form_Exit : Form
    {
        /***************  field  *************************/
        private int id;
        private string rfidTag;
        RFID UserRFID;
        DatabaseConnector DB;




        //Constructor
        public Form_Exit()
        {
            InitializeComponent();
            //Form patr
            label_status.Text = "Scan RFID Tag";
            //RFID part
            UserRFID = new RFID();
            UserRFID.Attach += new AttachEventHandler(ShowAttachInfo);
            UserRFID.Detach += new DetachEventHandler(ShowDetachInfo);
            //DB part
            DB = new DatabaseConnector();
            if (DB.IsConnected())
            {
                label_databasestatus.Text = "Database Connected";
            }
            else
            {
                label_databasestatus.Text = "Database Connecttion failed";
                label_status.Text = "Please contact Technical staff";
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
            catch (PhidgetException)
            {
                label_SystemStatus.Text = "This Phidget is not opened and attached";
                label_status.Text = "Please contact Technical staff";
            }

        }


        /******************************  method  ********************************/

        //Show system status 
        public void ShowAttachInfo(object sender, AttachEventArgs e)
        {
            label_SystemStatus.Text = "RFID attached, Serial Number" + e.Device.SerialNumber.ToString();
        }
        public void ShowDetachInfo(object sender, DetachEventArgs e)
        {
            label_SystemStatus.Text = "RFID detached";
        }
        //Above show system status


        //About Tag
        public void AttcahTag(object sender, TagEventArgs e)
        {
            rfidTag = e.Tag.ToString();
            label_RFIDnr.Text += " " + rfidTag;
            label_status.Text = "RFID scanned.";
        }
        public void DetachTag(object sender, TagEventArgs e)
        {
            label_RFIDnr.Text = "RFID number:";
            label_status.Text = "RFID number is: " + rfidTag.ToString();
            UpdateSQL();
        }
        //Above about tag

        public void UpdateSQL()
        {
            string query = "UPDATE visitor SET status='Checked-out' WHERE visitor='" + rfidTag + "'";
            MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
        }


        /*************** Unimportant method **********/
        // Get RFID info
        public void GetRFIDnumber()
        {
            //Scan RFID
            //contact database
            //show details
            //check if anything forgot to return
            if (listView_main == null)
            {
                //check out
            }else
            {
                //go to return or buy it 
            }
            //Check-out

        }

        // purchase unreturn items button
        private void button1_Click(object sender, EventArgs e)
        {
            Purchase();
        }

        // Buy method
        public void Purchase()
        {
            // chekc database connection
            //select item from listview
            //deduct amount for wallet
        }

        // When close this form, trun off Antenna and its LED
        private void Form_Exit_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserRFID.LED = false;
            UserRFID.Antenna = false;
            UserRFID.close();
        }

        //------------------------------------------------------------------------------------------------------------//

    }
}
