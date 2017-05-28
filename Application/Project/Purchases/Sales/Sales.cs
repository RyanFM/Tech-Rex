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

namespace Sales
{
    public partial class Sales : Form
    {

        /***************  field  *************************/
        private int id;
        private string rfidTag;
        RFID UserRFID;


        public Sales()
        {
            InitializeComponent();


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
            catch (PhidgetException pe)
            {

            }
        }

        //About Tag
        public void AttcahTag(object sender, TagEventArgs e)
        {
            //method called before detach
            rfidTag = e.Tag.ToString();

        }
        public void DetachTag(object sender, TagEventArgs e)
        {
            //method called after detach
        }
        //Above about tag
    }
}
