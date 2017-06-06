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

namespace Purchases
{
    public partial class Return : Form
    {
        private string rfidTag;
        RFID UserRFID;
        string connectionString = "server=studmysql01.fhict.local;" + "Database=dbi350130;" + "Uid=dbi350130;" + "Pwd=Techrex;" + "connect timeout=30;";

        int visitorID = 1;
        double Total = 0.00;
        double subTotal = 0.00;
        bool insufficient = false;
        public Return()
        {
            InitializeComponent();
            DisplayShopID();

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
                MessageBox.Show("Device connected failed");
            }

            UserRFID.Tag += new TagEventHandler(AttachTag);
        }

        // methods
        public void AttachTag(object sender, TagEventArgs e)
        {
            rfidTag = e.Tag.ToString();

            string query = "SELECT visitor_id FROM visitor WHERE rfid='" + rfidTag + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();

            MySqlDataReader reader = command.ExecuteReader();

            try
            {
                reader.Read();
                visitorID = Convert.ToInt32(reader[0]);

            }
            catch
            {
                MessageBox.Show("Read failed");
            }
            finally
            {
                databaseConnection.Close();
            }
            if (Total != 0)
            {
                UpdateDB();
            }

            DisplayListInfo();

        }
        public void DisplayShopID()
        {
            string sql = "SELECT shop_id FROM shop WHERE type = 'rent'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandCombo = new MySqlCommand(sql, databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = commandCombo.ExecuteReader();

                while (reader.Read())
                {
                    cbShop.Items.Add(reader[0].ToString());
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();

            }
        }

        public void ReturnStatus()
        {
            if (Total < 0)
            {
                lbMoney.Text = "To receive:";
                lbTotal.Text = "€" + (0 - Total).ToString();

            }
            else
            {
                lbMoney.Text = "To return:";
                lbTotal.Text = "€" + Total.ToString();

            }
        }
        public void UpdateTotalPrice()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            Total = 0;

            for (int i = 0; i < listView_Return.Items.Count; i++)
            {

                double Deposit = Convert.ToDouble(listView_Return.Items[i].SubItems[1].Text);
                int Amount = Convert.ToInt32(listView_Return.Items[i].SubItems[2].Text);
                int DaysRented = Convert.ToInt32(listView_Return.Items[i].SubItems[3].Text);

                subTotal = (Deposit * Amount) - (DaysRented * 20) * Amount;

                Total += subTotal;

               

                //string sqlBalance = "UPDATE visitor SET balance = (balance - " + subTotal + ") WHERE visitor_id = " + visitorID;
                //MySqlCommand command = new MySqlCommand(sqlBalance, databaseConnection);
                //command.ExecuteNonQuery();

            }
            ReturnStatus();
        }
        public double GetNewBalance()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            double updatedBalance = 99999;
            subTotal = Convert.ToDouble(listView_Return.SelectedItems[0].SubItems[4].Text);
            double Deposit = Convert.ToDouble(listView_Return.SelectedItems[0].SubItems[1].Text);
            int Amount = Convert.ToInt32(listView_Return.SelectedItems[0].SubItems[2].Text);
            int DaysRented = Convert.ToInt32(listView_Return.SelectedItems[0].SubItems[3].Text);


            databaseConnection.Open();
            string sqlError = "Select balance FROM visitor WHERE visitor_id = " + visitorID;
            if (((Deposit * Amount) - (DaysRented * 20) * Amount) < 0 )
            {
                string sqlReceive = "SELECT (balance - " + subTotal + ") FROM visitor WHERE visitor_id = " + visitorID;
                MySqlCommand commandReceive = new MySqlCommand(sqlReceive, databaseConnection);
                updatedBalance = Convert.ToDouble(commandReceive.ExecuteScalar());
                if (updatedBalance < 0)
                {
                    MessageBox.Show("Insufficient funds!");
                    
                    insufficient = true;
                }
            }
            else 
            {
                string sqlReturn = "SELECT (balance + " + subTotal + ") FROM visitor WHERE visitor_id = " + visitorID;
                MySqlCommand commandReturn = new MySqlCommand(sqlReturn, databaseConnection);
                updatedBalance = Convert.ToDouble(commandReturn.ExecuteScalar());
            }
           
            databaseConnection.Close();
            return updatedBalance;
        }
        public void UpdateBalance()
        {


        }
        public void UpdateDB()
        {
            int shopID = Convert.ToInt32(cbShop.SelectedItem);
            int amount;
            int productID;
            double Deposit = Convert.ToDouble(listView_Return.SelectedItems[0].SubItems[1].Text);
            int DaysRented = Convert.ToInt32(listView_Return.SelectedItems[0].SubItems[3].Text);
            string productName = "";
            if (shopID > 0)
            {

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                productName = listView_Return.SelectedItems[0].SubItems[0].Text;
                databaseConnection.Open();
                string sqlPID = "SELECT product_id FROM product WHERE product_name = '" + productName + "'";
                MySqlCommand commandPID = new MySqlCommand(sqlPID, databaseConnection);
                productID = Convert.ToInt32(commandPID.ExecuteScalar());
                databaseConnection.Close();

                amount = Convert.ToInt32(listView_Return.SelectedItems[0].SubItems[2].Text);

                double UpdatedBalance = GetNewBalance();

                if (UpdatedBalance == 99999 || insufficient == true)
                {
                    MessageBox.Show("Please try again");
                    insufficient = false;
                }
                else
                {
                    string sqlBalance = "UPDATE visitor SET balance = " + UpdatedBalance + " WHERE visitor_id = " + visitorID;

                    string sqlRemoveProduct = "DELETE FROM rented_products WHERE product_id = " + productID + " AND visitor_id = " + visitorID;

                    string sqlStockUpdate = "UPDATE shop_inventory SET amount = (amount + " + amount + ") WHERE shop_id = " + shopID + " AND product_id = " + productID;


                    MySqlCommand commandUpdateBalace = new MySqlCommand(sqlBalance, databaseConnection);
                    MySqlCommand commandUpdateStock = new MySqlCommand(sqlStockUpdate, databaseConnection);
                    MySqlCommand commandDeleteProduct = new MySqlCommand(sqlRemoveProduct, databaseConnection);

                    databaseConnection.Open();
                    commandUpdateStock.ExecuteNonQuery();
                    commandDeleteProduct.ExecuteNonQuery();
                    commandUpdateBalace.ExecuteNonQuery();
                    databaseConnection.Close();

                    Total -= Convert.ToDouble(listView_Return.SelectedItems[0].SubItems[4].Text);
                    listView_Return.SelectedItems[0].Remove();

                }

            }
            else
            {
                MessageBox.Show("Please select the shop");
            }
        }
        public void DisplayListInfo()
        {
            listView_Return.Items.Clear();


            string sql = "SELECT p.product_name, p.deposit, r.amount,  r.days_rented , ((p.deposit * r.amount) - (r.days_rented * 20) * amount)" +
                         "FROM product p JOIN rented_products r ON(p.product_id = r.product_id) " +
                         "JOIN visitor v ON (v.visitor_id = r.visitor_id) " +
                         "WHERE v.visitor_id = " + visitorID;




            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandList = new MySqlCommand(sql, databaseConnection);




            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = commandList.ExecuteReader();


                while (reader.Read())

                {


                    ListViewItem item = new ListViewItem(reader[0].ToString());
                    item.SubItems.Add(reader[1].ToString());
                    item.SubItems.Add(reader[2].ToString());
                    item.SubItems.Add(reader[3].ToString());
                    item.SubItems.Add(reader[4].ToString());


                    listView_Return.Items.Add(item);

                }
                reader.Close();
                for (int i = 0; i < listView_Return.Items.Count; i++)
                {

                    if (Convert.ToDouble(listView_Return.Items[i].SubItems[4].Text) < 0)
                    {
                        double newPrice = 0 - Convert.ToDouble(listView_Return.Items[i].SubItems[4].Text);
                        listView_Return.Items[i].SubItems[4].Text = newPrice.ToString();


                    }

                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();

            }
            UpdateTotalPrice();
        }
        private void Return_Load(object sender, EventArgs e)
        {

        }

        private void button_Finish_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            UserRFID.close();
            this.Hide();
            Form1.ShowDialog();
            this.Close();
        }


        private void button_Return_Click(object sender, EventArgs e)
        {
            UpdateDB();
            DisplayListInfo();
        }
    }
}
