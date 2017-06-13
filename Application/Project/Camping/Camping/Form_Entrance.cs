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
        private int id;
        private string camp = "OHHHH SHIT";
        private string ticketType = "";
        RFID UserRFID;
        DatabaseConnector DB;



        //Constrctor
        public Form_Entrance()
        {
            InitializeComponent();
            TransparentLabels();
            InvisibleLabels();
            ShowCampingSpot();
            UserRFID = new RFID();

            DB = new DatabaseConnector();

            if (DB.IsConnected())
            {
                
                DB.databaseConnection.Close();
            }
            else
            {
                MessageBox.Show("Database Connection failed");
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


        public void TransparentLabels() // transparency of labels on camping picturebox. Very large; Don't open.
        {
            var pos1 = this.PointToScreen(lb1.Location);
            pos1 = pbCamping.PointToClient(pos1);
            lb1.Parent = pbCamping;
            lb1.Location = pos1;
            lb1.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(lb2.Location);
            pos2 = pbCamping.PointToClient(pos2);
            lb2.Parent = pbCamping;
            lb2.Location = pos2;
            lb2.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(lb3.Location);
            pos3 = pbCamping.PointToClient(pos3);
            lb3.Parent = pbCamping;
            lb3.Location = pos3;
            lb3.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(lb4.Location);
            pos4 = pbCamping.PointToClient(pos4);
            lb4.Parent = pbCamping;
            lb4.Location = pos4;
            lb4.BackColor = Color.Transparent;

            var pos5 = this.PointToScreen(lb5.Location);
            pos5 = pbCamping.PointToClient(pos5);
            lb5.Parent = pbCamping;
            lb5.Location = pos5;
            lb5.BackColor = Color.Transparent;

            var pos6 = this.PointToScreen(lb6.Location);
            pos6 = pbCamping.PointToClient(pos6);
            lb6.Parent = pbCamping;
            lb6.Location = pos6;
            lb6.BackColor = Color.Transparent;

            var pos7 = this.PointToScreen(lb7.Location);
            pos7 = pbCamping.PointToClient(pos7);
            lb7.Parent = pbCamping;
            lb7.Location = pos7;
            lb7.BackColor = Color.Transparent;

            var pos8 = this.PointToScreen(lb8.Location);
            pos8 = pbCamping.PointToClient(pos8);
            lb8.Parent = pbCamping;
            lb8.Location = pos8;
            lb8.BackColor = Color.Transparent;

            var pos9 = this.PointToScreen(lb9.Location);
            pos9 = pbCamping.PointToClient(pos9);
            lb9.Parent = pbCamping;
            lb9.Location = pos9;
            lb9.BackColor = Color.Transparent;

            var pos10 = this.PointToScreen(lb10.Location);
            pos10 = pbCamping.PointToClient(pos10);
            lb10.Parent = pbCamping;
            lb10.Location = pos10;
            lb10.BackColor = Color.Transparent;

            var pos11 = this.PointToScreen(lb11.Location);
            pos11 = pbCamping.PointToClient(pos11);
            lb11.Parent = pbCamping;
            lb11.Location = pos11;
            lb11.BackColor = Color.Transparent;

            var pos12 = this.PointToScreen(lb12.Location);
            pos12 = pbCamping.PointToClient(pos12);
            lb12.Parent = pbCamping;
            lb12.Location = pos12;
            lb12.BackColor = Color.Transparent;

            var pos13 = this.PointToScreen(lb13.Location);
            pos13 = pbCamping.PointToClient(pos13);
            lb13.Parent = pbCamping;
            lb13.Location = pos13;
            lb13.BackColor = Color.Transparent;

            var pos14 = this.PointToScreen(lb14.Location);
            pos14 = pbCamping.PointToClient(pos14);
            lb14.Parent = pbCamping;
            lb14.Location = pos14;
            lb14.BackColor = Color.Transparent;

            var pos15 = this.PointToScreen(lb15.Location);
            pos15 = pbCamping.PointToClient(pos15);
            lb15.Parent = pbCamping;
            lb15.Location = pos15;
            lb15.BackColor = Color.Transparent;

            var pos16 = this.PointToScreen(lb16.Location);
            pos16 = pbCamping.PointToClient(pos16);
            lb16.Parent = pbCamping;
            lb16.Location = pos16;
            lb16.BackColor = Color.Transparent;

            var pos17 = this.PointToScreen(lb17.Location);
            pos17 = pbCamping.PointToClient(pos17);
            lb17.Parent = pbCamping;
            lb17.Location = pos17;
            lb17.BackColor = Color.Transparent;

            var pos18 = this.PointToScreen(lb18.Location);
            pos18 = pbCamping.PointToClient(pos18);
            lb18.Parent = pbCamping;
            lb18.Location = pos18;
            lb18.BackColor = Color.Transparent;

            var pos19 = this.PointToScreen(lb19.Location);
            pos19 = pbCamping.PointToClient(pos19);
            lb19.Parent = pbCamping;
            lb19.Location = pos19;
            lb19.BackColor = Color.Transparent;

            var pos20 = this.PointToScreen(lb20.Location);
            pos20 = pbCamping.PointToClient(pos20);
            lb20.Parent = pbCamping;
            lb20.Location = pos20;
            lb20.BackColor = Color.Transparent;

            var pos21 = this.PointToScreen(lb21.Location);
            pos21 = pbCamping.PointToClient(pos21);
            lb21.Parent = pbCamping;
            lb21.Location = pos21;
            lb21.BackColor = Color.Transparent;

            var pos22 = this.PointToScreen(lb22.Location);
            pos22 = pbCamping.PointToClient(pos22);
            lb22.Parent = pbCamping;
            lb22.Location = pos22;
            lb22.BackColor = Color.Transparent;

            var pos23 = this.PointToScreen(lb23.Location);
            pos23 = pbCamping.PointToClient(pos23);
            lb23.Parent = pbCamping;
            lb23.Location = pos23;
            lb23.BackColor = Color.Transparent;

            var pos24 = this.PointToScreen(lb24.Location);
            pos24 = pbCamping.PointToClient(pos24);
            lb24.Parent = pbCamping;
            lb24.Location = pos24;
            lb24.BackColor = Color.Transparent;

            var pos25 = this.PointToScreen(lb25.Location);
            pos25 = pbCamping.PointToClient(pos25);
            lb25.Parent = pbCamping;
            lb25.Location = pos25;
            lb25.BackColor = Color.Transparent;


        }

        public void InvisibleLabels() // makes labels invisible. 
        {
            lb1.Visible = false;
            lb2.Visible = false;
            lb3.Visible = false;
            lb4.Visible = false;
            lb5.Visible = false;
            lb6.Visible = false;
            lb7.Visible = false;
            lb8.Visible = false;
            lb9.Visible = false;
            lb10.Visible = false;
            lb11.Visible = false;
            lb12.Visible = false;
            lb13.Visible = false;
            lb14.Visible = false;
            lb15.Visible = false;
            lb16.Visible = false;
            lb17.Visible = false;
            lb18.Visible = false;
            lb19.Visible = false;
            lb20.Visible = false;
            lb21.Visible = false;
            lb22.Visible = false;
            lb23.Visible = false;
            lb24.Visible = false;
            lb25.Visible = false;
        }

        public void ShowCampingSpot() // Display the correct site on the picturebox. Large; Don't open
        {
            InvisibleLabels();

            switch (lbSiteNo.Text)
            {
                case "1":
                    lb1.Visible = true;
                    break;

                case "2":
                    lb2.Visible = true;
                    break;

                case "3":
                    lb3.Visible = true;
                    break;

                case "4":
                    lb4.Visible = true;
                    break;

                case "5":
                    lb5.Visible = true;
                    break;

                case "6":
                    lb6.Visible = true;
                    break;

                case "7":
                    lb7.Visible = true;
                    break;

                case "8":
                    lb8.Visible = true;
                    break;

                case "9":
                    lb9.Visible = true;
                    break;

                case "10":
                    lb10.Visible = true;
                    break;

                case "11":
                    lb11.Visible = true;
                    break;

                case "12":
                    lb12.Visible = true;
                    break;

                case "13":
                    lb13.Visible = true;
                    break;

                case "14":
                    lb14.Visible = true;
                    break;

                case "15":
                    lb15.Visible = true;
                    break;

                case "16":
                    lb16.Visible = true;
                    break;

                case "17":
                    lb17.Visible = true;
                    break;

                case "18":
                    lb18.Visible = true;
                    break;

                case "19":
                    lb19.Visible = true;
                    break;

                case "20":
                    lb20.Visible = true;
                    break;

                case "21":
                    lb21.Visible = true;
                    break;

                case "22":
                    lb22.Visible = true;
                    break;

                case "23":
                    lb23.Visible = true;
                    break;

                case "24":
                    lb24.Visible = true;
                    break;

                case "25":
                    lb25.Visible = true;
                    break;

                default:
                    break;
            }
        }

        public void AttachTag(object sender,TagEventArgs e)
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
            DB.databaseConnection.Close();
            //listBox_member.Items.Add(e.Tag.ToString());



        }
        public void DetachTag(object sender, TagEventArgs e)
        {
            if (IsReserved() == true)
            {
                Check();
            }
            else
            {
                Deny();
            }
        }


        public bool IsReserved()
        {
            

            string query = "SELECT camping_spot FROM visitor WHERE rfid='" + rfidTag + "'";
            string queryTicket = "SELECT ticket_type FROM visitor WHERE rfid='" + rfidTag + "'";
            DB.databaseConnection.Open();
            MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
            MySqlCommand commandTicket = new MySqlCommand(queryTicket, DB.databaseConnection);
            MySqlDataReader reader = command.ExecuteReader();
            

            try
            {
                reader.Read();
                camp = reader[0].ToString();

                listBox_member.Items.Clear();
                reader.Close();

                MySqlDataReader readerTicket = commandTicket.ExecuteReader();
                readerTicket.Read();
                ticketType = readerTicket[0].ToString();
                readerTicket.Close();

 
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
                listBox_member.Items.Add("Camping spot Not found");
                lbSiteNo.Text = "";
                return false;
            }
            else
            {

                listBox_member.Items.Add("Camping sopt: " + camp);
                lbSiteNo.Text = camp;
                lbSiteNo.Visible = false;
                ShowCampingSpot();
                return true;
            }
           
        }

        public bool CheckStatus()
        {
            string status = "";

            DB.databaseConnection.Open();

            string query = "SELECT lower(status) FROM visitor WHERE rfid='" + rfidTag + "'";
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

            if (status == "in-spot")
                return true;
            return false;

        }

        public void Check()
        {
            if (CheckStatus())
            {
                DB.databaseConnection.Open();
                string query = "UPDATE visitor SET status='Checked-in'where rfid='" + rfidTag + "'";

                string queryUpdateSaturday = "UPDATE rented_products r JOIN visitor v ON (v.visitor_id = r.visitor_id) " +
                                            "SET r.days_rented = 2 WHERE r.days_rented = 1 AND v.visitor_id = " + id;


                string queryUpdateSunday = "UPDATE rented_products r JOIN visitor v ON (v.visitor_id = r.visitor_id) " +
                                            "SET r.days_rented = 3 WHERE r.days_rented = 2 AND v.visitor_id = " + id;

                MySqlCommand commandSaturday = new MySqlCommand(queryUpdateSaturday, DB.databaseConnection);
                MySqlCommand commandSunday = new MySqlCommand(queryUpdateSunday, DB.databaseConnection);

                commandSaturday.ExecuteNonQuery();
                commandSunday.ExecuteNonQuery();

                MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
                command.ExecuteNonQuery();
                DB.databaseConnection.Close();
                listBox_member.Items.Add("LEAVE--- Leave spot");
            }
            else
            {
                DB.databaseConnection.Open();
                string query = "UPDATE visitor SET status='In-spot' where rfid='" + rfidTag +"'";
                MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
                command.ExecuteNonQuery();
                DB.databaseConnection.Close();

                gbCamp.BackColor = Color.DarkSeaGreen;
                lbCamp.Text = "PASS";
                lbCamp.ForeColor = Color.DarkGreen;

                lbSiteNoTitle.Visible = true;
                lbSiteNoTitle.ForeColor = Color.DarkGreen;

                lbCampSpot.Visible = true;
                lbCampSpot.Text = camp;
                lbCampSpot.ForeColor = Color.DarkGreen;
                //MessageBox.Show("Pass allowed.", "Pass");
                listBox_member.Items.Add("Pass--- Pass allowed");
            }



        }
        public void Deny()
        {
            //MessageBox.Show("No reservsation found.", "Deny");
            listBox_member.Items.Add("Deny--- No reservsation found");
            gbCamp.BackColor = Color.Maroon;
            lbCamp.Text = "Denied";
            lbCamp.ForeColor = Color.Red;
        }

    }
}
