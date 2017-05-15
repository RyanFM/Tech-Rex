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

namespace Camping
{
    public partial class Form_Entrance : Form
    {
        /*************** feild *****************/
        private int RFIDNumber,NumberScanned;
        private int numberOfPeopleOfCampingSpot = 6;
        RFID UserRFID;



        //Constrctor
        public Form_Entrance()
        {
            InitializeComponent();

            UserRFID = new RFID();

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

        }

        /***************************  method  *********************/

        public void AttachTag(object sender,TagEventArgs e)
        {
            
            listBox_member.Items.Add(e.Tag.ToString());

            if (listBox_member.Items.Count > numberOfPeopleOfCampingSpot) listBox_member.Items.Clear();
        }

        private void Form_Entrance_Load(object sender, EventArgs e)
        {
            UserRFID.Tag += new TagEventHandler(AttachTag);
        }

        public void GetRFID()
        {
            //turn RFID scanner
            //Scan RFID
            //get RFID number Contact with database
            //check what type of spot they booked. numberOfPeopleOfCampingSpot = data from database
        }

        //Check what type of spot they booked
        public void GetBookedNumber()
        {
            this.numberOfPeopleOfCampingSpot = 0;//retrive from database;
        }
    }
}
