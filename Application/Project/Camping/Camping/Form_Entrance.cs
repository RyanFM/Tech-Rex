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
       
        private string rfidTag;
        private int id;
        private string camp = "";
        private string ticketType = "";
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
                MessageBox.Show("Device connection failed");
            }

            UserRFID.Tag+= new TagEventHandler(AttachTag);
            UserRFID.TagLost += new TagEventHandler(DetachTag);

        }

        /***************************  method  *********************/




        public void ResetForm()
        {
            lbCamp.ForeColor = Color.DarkOliveGreen;
            lbCamp.Text = "Please scan tag";
        
            lbPass.Visible = false;
            pnlPass.Visible = false;
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

        public void ShowCampingSpot() 
        {
          
            foreach (Control c in this.Controls)
            {
                if (c.Name == "lb" + camp && c is Label)
                {

                  
                    ((Label)c).Visible = true;
                    ((Label)c).Text = "    ";
                   
                    break;
                }
                else
                {
                    for (int i = 1; i < 26; i++)
                    {
                        
                        foreach (Control c2 in this.Controls)
                        {
                            if (c2.Name == "lb" + i.ToString() && c is Label)
                            {
                                ((Label)c2).Visible = false;
                            }
                        }
                    }
                }
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

              
                reader.Close();

                MySqlDataReader readerTicket = commandTicket.ExecuteReader();
                readerTicket.Read();
                ticketType = readerTicket[0].ToString();
                readerTicket.Close();

 
                
                
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
                
                
                lbCampSpot.Text = "";
                return false;
            }
            else
            {

               
                lbCampSpot.Text = camp;
                lbCampSpot.Visible = true;
                
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
              
                pnlPass.BackColor = Color.DarkOliveGreen;
                pnlPass.Visible = true;

                lbPass.Text = "Now leaving camping";
                lbPass.ForeColor = SystemColors.Menu;
                lbPass.Visible = true;

                ExecuteIn(3000);
            }
            else
            {
                DB.databaseConnection.Open();
                string query = "UPDATE visitor SET status='In-spot' where rfid='" + rfidTag +"'";
                MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
                command.ExecuteNonQuery();
                DB.databaseConnection.Close();

                pnlPass.BackColor = Color.DarkOliveGreen;
                pnlPass.Visible = true;
                
                lbPass.Text = "PASS - View map ->";
                lbPass.ForeColor = SystemColors.Menu;
                lbPass.Visible = true;
                

                lbCampSpot.Visible = true;
                lbCampSpot.Text = camp;
                lbSiteNoTitle.Visible = true;
               
                
                ShowCampingSpot();
            }



        }
        public void Deny()
        {
            //MessageBox.Show("No reservsation found.", "Deny");
            
            pnlPass.BackColor = Color.Maroon;
            pnlPass.Visible = true;

            lbCamp.Text = "Denied";
            lbCamp.ForeColor = Color.Red;

            lbPass.Text = "No reservation found";
            lbPass.ForeColor = Color.Red;
            lbPass.Visible = true;

            ExecuteIn(3000);
        }

        private void lb4_Click(object sender, EventArgs e)
        {

        }

        private void lb6_Click(object sender, EventArgs e)
        {

        }

        private void lb5_Click(object sender, EventArgs e)
        {

        }

        private void lb7_Click(object sender, EventArgs e)
        {

        }

        private void lb8_Click(object sender, EventArgs e)
        {

        }

        private void lb3_Click(object sender, EventArgs e)
        {

        }

        private void lb11_Click(object sender, EventArgs e)
        {

        }

        private void lb9_Click(object sender, EventArgs e)
        {

        }

        private void lb12_Click(object sender, EventArgs e)
        {

        }

        private void listBox_member_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
