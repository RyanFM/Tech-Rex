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
        private int NumberScanned;
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

        }

        /***************************  method  *********************/

        public void AttachTag(object sender,TagEventArgs e)
        {
            
            listBox_member.Items.Add(e.Tag.ToString());
            if (IsReserved() == true)
            {
                Checkin();
            }
            else
            {
                Deny();
            }
            
        }

        private void Form_Entrance_Load(object sender, EventArgs e)
        {
            UserRFID.Tag += new TagEventHandler(AttachTag);
        }

        public bool IsReserved()
        {
            string camp = "";

            string query = "SELECT camping_spot FROM visitor WHERE visitor_id ='" + rfidTag + "'";
            try
            {
                MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    camp = reader[0].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
                if (camp == "1")
                    return true;
                return false;

         
        }

        public void Checkin()
        {
            MessageBox.Show("Pass allowed.", "Pass");
        }
        public void Deny()
        {
            MessageBox.Show("No reservsation found.", "Deny");
        }

    }
}
