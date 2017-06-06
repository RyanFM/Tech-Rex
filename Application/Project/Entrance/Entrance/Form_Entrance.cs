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
                DB.databaseConnection.Close();
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
            catch(PhidgetException)
            {
                label_SystemStatus.Text = "This Phidget is not opened and attached";
                label_status.Text = "Please contact Technical staff";
            }

        }


        /***********************  method  ***************************/

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
        public void AttcahTag(object sender,TagEventArgs e)
        {
            rfidTag = e.Tag.ToString();
            label_RFIDnr.Text += " "+ rfidTag;
            label_status.Text = "RFID scanned.";

           // string query = "UPDATE visitor SET status='Checked-in' WHERE visitor_id=1";
           // MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);

        }
        public void DetachTag(object sender,TagEventArgs e)
        {
            label_RFIDnr.Text = "RFID number:";
            label_status.Text = "RFID stored. ";//Scan QR code.";
            if (ValidateStatus())
            {
                UpdateSQL();
            }
            else
            {
                MessageBox.Show("Ticket may not paid.");
            }
               
        }
        //Above about tag

        //validate
        public bool ValidateStatus()
        {
            string status = "OHHHHHHHHH SHIT";

            DB.databaseConnection.Open();
            
            string query = "SELECT status FROM visitor WHERE visitor_id=" + id;
            MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);


            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                status = reader[0].ToString();

            }
            catch
            {
                MessageBox.Show("Read failed");
            }
            finally
            {
                DB.databaseConnection.Close();
            }
            if (status == "Reserved")
                return false;
            return true;




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
            label_status.Text = status;
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
            
        }
    }
}
