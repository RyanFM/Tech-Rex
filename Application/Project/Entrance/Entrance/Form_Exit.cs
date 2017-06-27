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
using System.Timers;

namespace Entrance
{
    public partial class Form_Exit : Form
    {
        /***************  field  *************************/
        private int id;
        private string rfidTag;
        RFID UserRFID;
        DatabaseConnector DB;
        double Total = 0.00;
        double subTotal = 0.00;
        bool insufficient = false;



        //Constructor
        public Form_Exit()
        {
            InitializeComponent();
            //Form patr
            //label_status.Text = "Scan RFID Tag";
            //RFID part
            UserRFID = new RFID();
            //UserRFID.Attach += new AttachEventHandler(ShowAttachInfo);
            //UserRFID.Detach += new DetachEventHandler(ShowDetachInfo);
            //DB part
            DB = new DatabaseConnector();
            if (DB.IsConnected())
            {
                //label_databasestatus.Text = "Database Connected";
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
            catch (PhidgetException)
            {
                //label_SystemStatus.Text = "This Phidget is not opened and attached";
                //label_status.Text = "Please contact Technical staff";
            }

        }


        /******************************  method  ********************************/


        //
        public void ResetForm()
        {
            lbRent.Text = "Please scan tag";
            lbRent.ForeColor = SystemColors.ActiveCaptionText;
            gbRent.BackColor = SystemColors.ControlLight;

            lbMoney.ForeColor = SystemColors.ControlText;
            lbTotal.ForeColor = SystemColors.ControlText;
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

        public void DisplayListInfo()
        {
            if (insufficient == false)
            {
                listView_main.Items.Clear();


                string sql = "SELECT p.product_name, p.deposit, r.amount,  r.days_rented , ((p.deposit * r.amount) - (r.days_rented * 20) * amount)" +
                             "FROM product p JOIN rented_products r ON(p.product_id = r.product_id) " +
                             "JOIN visitor v ON (v.visitor_id = r.visitor_id) " +
                             "WHERE v.visitor_id = " + id;





                MySqlCommand commandList = new MySqlCommand(sql, DB.databaseConnection);




                try
                {

                    MySqlDataReader reader = commandList.ExecuteReader();


                    while (reader.Read())

                    {


                        ListViewItem item = new ListViewItem(reader[0].ToString());
                        item.SubItems.Add(reader[1].ToString());
                        item.SubItems.Add(reader[2].ToString());
                        item.SubItems.Add(reader[3].ToString());
                        item.SubItems.Add(reader[4].ToString());


                        listView_main.Items.Add(item);

                    }
                    reader.Close();
                    for (int i = 0; i < listView_main.Items.Count; i++)
                    {

                        if (Convert.ToDouble(listView_main.Items[i].SubItems[4].Text) < 0)
                        {
                            double newPrice = 0 - Convert.ToDouble(listView_main.Items[i].SubItems[4].Text);
                            listView_main.Items[i].SubItems[4].Text = newPrice.ToString();


                        }

                    }


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                UpdateTotalPrice();
            }
            
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
        //Above show system status


        public double GetNewBalance()
        {

            double updatedBalance = 99999;
            subTotal = Convert.ToDouble(listView_main.SelectedItems[0].SubItems[4].Text);
            double Deposit = Convert.ToDouble(listView_main.SelectedItems[0].SubItems[1].Text);
            int Amount = Convert.ToInt32(listView_main.SelectedItems[0].SubItems[2].Text);
            int DaysRented = Convert.ToInt32(listView_main.SelectedItems[0].SubItems[3].Text);



            string sqlError = "Select balance FROM visitor WHERE visitor_id = " + id;
            if (((Deposit * Amount) - (DaysRented * 20) * Amount) < 0)
            {
                string sqlReceive = "SELECT (balance - " + subTotal + ") FROM visitor WHERE visitor_id = " + id;
                MySqlCommand commandReceive = new MySqlCommand(sqlReceive, DB.databaseConnection);
                updatedBalance = Convert.ToDouble(commandReceive.ExecuteScalar());
                if (updatedBalance < 0)
                {
                    MessageBox.Show("Insufficient funds!");

                    insufficient = true;
                }
                else
                {
                    insufficient = false;
                }
            }
            else
            {
                string sqlReturn = "SELECT (balance + " + subTotal + ") FROM visitor WHERE visitor_id = " + id;
                MySqlCommand commandReturn = new MySqlCommand(sqlReturn, DB.databaseConnection);
                updatedBalance = Convert.ToDouble(commandReturn.ExecuteScalar());
            }


            return updatedBalance;
        }
        public void ReturnStatus()
        {
            if (Total < 0)
            {
                lbMoney.Text = "Visitor pays:";
                lbTotal.Text = "€" + (0 - Total).ToString();

            }
            else
            {
                lbMoney.Text = "Visitor receives:";
                lbTotal.Text = "€" + Total.ToString();

            }
        }
        public void UpdateTotalPrice()

        {

            Total = 0;

            for (int i = 0; i < listView_main.Items.Count; i++)
            {

                double Deposit = Convert.ToDouble(listView_main.Items[i].SubItems[1].Text);
                int Amount = Convert.ToInt32(listView_main.Items[i].SubItems[2].Text);
                int DaysRented = Convert.ToInt32(listView_main.Items[i].SubItems[3].Text);

                subTotal = (Deposit * Amount) - (DaysRented * 20) * Amount;

                Total += subTotal;



                //string sqlBalance = "UPDATE visitor SET balance = (balance - " + subTotal + ") WHERE visitor_id = " + visitorID;
                //MySqlCommand command = new MySqlCommand(sqlBalance, databaseConnection);
                //command.ExecuteNonQuery();

            }
            ReturnStatus();
        }

        public void UpdateDB()
        {

            int amount;
            int productID;
            double Deposit = Convert.ToDouble(listView_main.SelectedItems[0].SubItems[1].Text);
            int DaysRented = Convert.ToInt32(listView_main.SelectedItems[0].SubItems[3].Text);
            string productName = "";



            

            productName = listView_main.SelectedItems[0].SubItems[0].Text;
            
            string sqlPID = "SELECT product_id FROM product WHERE product_name = '" + productName + "'";
            MySqlCommand commandPID = new MySqlCommand(sqlPID, DB.databaseConnection);
            productID = Convert.ToInt32(commandPID.ExecuteScalar());
            

            amount = Convert.ToInt32(listView_main.SelectedItems[0].SubItems[2].Text);

            double UpdatedBalance = GetNewBalance();

            if (UpdatedBalance == 99999 || insufficient == true)
            {
                
                
                listView_main.Items.Clear();
                Total = 0;
                ReturnStatus();
                ExecuteIn(1500);
                
            }
            else
            {
                string sqlBalance = "UPDATE visitor SET balance = " + UpdatedBalance + " WHERE visitor_id = " + id;

                string sqlRemoveProduct = "DELETE FROM rented_products WHERE product_id = " + productID + " AND visitor_id = " + id;

                //string sqlStockUpdate = "UPDATE shop_inventory SET amount = (amount + " + amount + ") WHERE shop_id = " + shopID + " AND product_id = " + productID;


                MySqlCommand commandUpdateBalace = new MySqlCommand(sqlBalance, DB.databaseConnection);
                //MySqlCommand commandUpdateStock = new MySqlCommand(sqlStockUpdate, databaseConnection);
                MySqlCommand commandDeleteProduct = new MySqlCommand(sqlRemoveProduct, DB.databaseConnection);

                
                //commandUpdateStock.ExecuteNonQuery();
                commandDeleteProduct.ExecuteNonQuery();
                commandUpdateBalace.ExecuteNonQuery();
                

                Total -= Convert.ToDouble(listView_main.SelectedItems[0].SubItems[4].Text);
                listView_main.SelectedItems[0].Remove();

            }


        }

        public void ChangeText()
        {
            if (insufficient == false)
            {

                if (listView_main.Items.Count == 0)
                {
                    lbRent.Text = "PASS";

                    lbRent.ForeColor = Color.DarkGreen;
                    gbRent.BackColor = Color.DarkSeaGreen;
                    lbMoney.ForeColor = Color.DarkGreen;
                    lbTotal.ForeColor = Color.DarkGreen;
                    UpdateSQL();
                    ExecuteIn(1500);
                }
                else
                {
                    lbRent.Text = "Please return these items";

                    lbRent.ForeColor = Color.Red;
                    gbRent.BackColor = Color.Maroon;
                    lbMoney.ForeColor = Color.Red;
                    lbTotal.ForeColor = Color.Red;
                }
            }
            else
            {
                insufficient = false;
            }
        }
        //About Tag



        public void AttcahTag(object sender, TagEventArgs e)
        {
            rfidTag = e.Tag.ToString();
            string query = "SELECT visitor_id FROM visitor WHERE rfid='" + rfidTag + "'";

            MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);


            MySqlDataReader reader = command.ExecuteReader();

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

            //label_RFIDnr.Text += " " + rfidTag;
            //label_status.Text = "RFID scanned.";
            DisplayListInfo();
            ChangeText();
        }
        public void DetachTag(object sender, TagEventArgs e)
        {
            //label_RFIDnr.Text = "RFID number:";
            //label_status.Text = "RFID number stored";
            if (listView_main.Items.Count == 0)
                UpdateSQL();
        }
        //Above about tag

        public void UpdateSQL()
        {

            string query = "UPDATE visitor SET status='Checked-out' WHERE rfid='" + rfidTag + "'";
            MySqlCommand command = new MySqlCommand(query, DB.databaseConnection);
            command.ExecuteNonQuery();
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
            }
            else
            {
                //go to return or buy it 
            }
            //Check-out

        }

        // purchase unreturn items button
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDB();
            DisplayListInfo();
            ChangeText();
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

        private void Form_Exit_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserRFID.close();

        }

        //------------------------------------------------------------------------------------------------------------//

    }
}
