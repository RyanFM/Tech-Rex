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

namespace Camping
{
    public partial class Form_Entrance : Form
    {
        /*************** feild *****************/
        //private int NumberScanned;
        private string rfidTag;
        RFID UserRFID;
        DatabaseConnector DB;



        //Constrctor
        public Form_Entrance()
        {
            InitializeComponent();

            UserRFID = new RFID();

            DB = new DatabaseConnector();

            if (DB.IsConnected())
            {
                MessageBox.Show("Database Connected");
                DB.databaseConnection.Close();
            }
            else
            {
                MessageBox.Show("Database Connecttion failed");
            }

            try
            {
                UserRFID.open();
                UserRFID.waitForAttachment(3000);
                UserRFID.Antenna = true;
                UserRFID.LED = true;
            }
            catch
            {
                listBox_member.Items.Clear();
                listBox_member.Items.Add("Device connected failed");
            }

            UserRFID.Tag+= new TagEventHandler(AttachTag);
            UserRFID.TagLost += new TagEventHandler(DetachTag);

        }

        /***************************  method  *********************/

        public void AttachTag(object sender,TagEventArgs e)
        {
            rfidTag = e.Tag.ToString();
            //listBox_member.Items.Add(e.Tag.ToString());



        }
        public void DetachTag(object sender, TagEventArgs e)
        {
            if (IsReserved() == true)
            {
                Checkin();
            }
            else
            {
                Deny();
            }
        }


        public bool IsReserved()
        {
            string camp = "OHHHH SHIT";

            string query = "SELECT camping_spot FROM visitor WHERE rfid='" + rfidTag + "'";
            DB.databaseConnection.Open();
            MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
            MySqlDataReader reader = command.ExecuteReader();

            try
            {
                reader.Read();
                camp = reader[0].ToString();

                ;listBox_member.Items.Clear();
 
                // listBox_member.Items.Add("RFID number " + rfidTag + ", Camping sopt: " + camp);
                
            }
            catch
            {
                MessageBox.Show("Read failed");
            }
            finally
            {
                DB.databaseConnection.Close();
            }

            if (camp == "")
            {
                listBox_member.Items.Add("Camping sopt Not found");
                return false;
            }
            else
            {

                listBox_member.Items.Add("Camping sopt: " + camp);
                return true;
            }




        }

        public void Checkin()
        {
            //MessageBox.Show("Pass allowed.", "Pass");
            listBox_member.Items.Add("Pass--- Pass allowed");
        }
        public void Deny()
        {
            //MessageBox.Show("No reservsation found.", "Deny");
            listBox_member.Items.Add("Deny--- No reservsation found");
        }

    }
}
