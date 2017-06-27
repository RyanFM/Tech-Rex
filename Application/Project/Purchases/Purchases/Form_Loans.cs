﻿using System;
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

    public partial class Form_Loans : Form, iRFID
    {
        private string rfidTag;
        RFID UserRFID;
        string connectionString = "server=studmysql01.fhict.local;" + "Database=dbi350130;" + "Uid=dbi350130;" + "Pwd=Techrex;" + "connect timeout=30;";
        int shopID;
        int visitorID = 1;
        int proAmount = 0;
        int productID = 0;

        double Total = 0.00;
        double subTotal = 0.00;

        public Form_Loans()
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
                MessageBox.Show("Device connected failed");
            }

            UserRFID.Tag += new TagEventHandler(AttachTag);


        }
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

            Checkout();

        }
       

        public void DisplayListInfo()
        {
            listView_Add.Items.Clear();
           
            
            string sql = "SELECT p.product_id, p.product_name, p.price, si.amount " +
                         "FROM product p , shop_inventory si " +
                         "WHERE p.product_id = si.product_id " +
                         "AND si.shop_id = " + shopID;




            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandList = new MySqlCommand(sql, databaseConnection);




            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = commandList.ExecuteReader();

                if (cbShop.SelectedIndex != -1)
                {
                    while (reader.Read())

                    {


                        ListViewItem item = new ListViewItem(reader[0].ToString());
                        item.SubItems.Add(reader[1].ToString());
                        item.SubItems.Add(reader[2].ToString());
                        item.SubItems.Add(reader[3].ToString());


                        listView_Add.Items.Add(item);

                    }
                    reader.Close();
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
            ResetButtons();
            MenuButtonDisable();
        }




        public void MenuButtonDisable()
        {
            if (listView_Add.Items.Count != 0)
            {
                if (listView_Add.Items[0].SubItems[3].Text == "0")
                {
                    btnUsb.Enabled = false;
                }
                if (listView_Add.Items[1].SubItems[3].Text == "0")
                {
                    btnHeadphone.Enabled = false;
                }
                if (listView_Add.Items[2].SubItems[3].Text == "0")
                {
                    btnCharger.Enabled = false;
                }
                if (listView_Add.Items[3].SubItems[3].Text == "0")
                {
                    btnGoPro.BackgroundImage = Properties.Resources.GoProGray;
                    btnGoPro.Enabled = false;
                }
                if (listView_Add.Items[4].SubItems[3].Text == "0")
                {
                    btnTablet.BackgroundImage = Properties.Resources.TabletGray;
                    btnTablet.Enabled = false;
                }
                if (listView_Add.Items[5].SubItems[3].Text == "0")
                {
                    btnLaptop.BackgroundImage = Properties.Resources.LaptopGray;
                    btnLaptop.Enabled = false;
                }

            }
        }
        public void ResetCart() // clears the cart and sets the total to zero
        {
            listView_Cart.Items.Clear();
            Total = 0.00;
            lbTotal.Text = "€" + Total.ToString();
        }

        public double GetNewBalance() // get the balance after calculation of the pricing on checkout
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);


            databaseConnection.Open();
            string sqlBalance = "SELECT (balance - " + Total + ") FROM visitor WHERE visitor_id = " + visitorID;
            MySqlCommand commandBalance = new MySqlCommand(sqlBalance, databaseConnection);
            double updatedBalance = Convert.ToDouble(commandBalance.ExecuteScalar());
            databaseConnection.Close();
            return updatedBalance;
        }
        public bool EnoughToPay()
        {
            double UpdatedBalance = GetNewBalance();

            if (UpdatedBalance < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool EnoughInStock()
        {
            int stock = 0;
            int amount;
            string productName = "";
            int productID;
            string stockStatus = "F";
            for (int i = 0; i < listView_Cart.Items.Count; i++)
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                productName = listView_Cart.Items[i].SubItems[0].Text;
                databaseConnection.Open();
                string sqlPID = "SELECT product_id FROM product WHERE product_name = '" + productName + "'";
                MySqlCommand commandPID = new MySqlCommand(sqlPID, databaseConnection);
                productID = Convert.ToInt32(commandPID.ExecuteScalar());
                databaseConnection.Close();

                amount = Convert.ToInt32(listView_Cart.Items[i].SubItems[2].Text);
                string sqlStock = "SELECT amount FROM shop_inventory WHERE shop_id = " + shopID + " AND product_id = " + productID;
                databaseConnection.Open();
                MySqlCommand commandStock = new MySqlCommand(sqlStock, databaseConnection);
                stock = Convert.ToInt32(commandStock.ExecuteScalar());
                databaseConnection.Close();

                if (stock - amount < 0)
                {
                    stockStatus = "F";
                    i = listView_Cart.Items.Count;
                }
                else
                {
                    stockStatus = "S";
                }

                // get the amount needed to be removed and product id
            }
            if (stockStatus == "F")
                return false;
            else
            {
                return true;
            }


        }
        public void Checkout()
        {
            int amount;
            int productID;
            string productName = "";

            if (listView_Cart.Items.Count != 0)
            {

                if (EnoughToPay() && EnoughInStock())
                {
                    for (int i = 0; i < listView_Cart.Items.Count; i++)
                    {
                        MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                        productName = listView_Cart.Items[i].SubItems[0].Text;
                        databaseConnection.Open();
                        string sqlPID = "SELECT product_id FROM product WHERE product_name = '" + productName + "'";
                        MySqlCommand commandPID = new MySqlCommand(sqlPID, databaseConnection);
                        productID = Convert.ToInt32(commandPID.ExecuteScalar());
                        databaseConnection.Close();

                        amount = Convert.ToInt32(listView_Cart.Items[i].SubItems[2].Text);
                        // get the amount needed to be removed and product id

                        string sqlStockUpdate = "UPDATE shop_inventory SET amount = (amount - " + amount + ") WHERE shop_id = " + shopID + " AND product_id = " + productID;

                        MySqlCommand commandUpdateStock;
                        commandUpdateStock = new MySqlCommand(sqlStockUpdate, databaseConnection);

                        databaseConnection.Open();
                        commandUpdateStock.ExecuteNonQuery();
                        databaseConnection.Close();



                    }
                    UpdateBalance();
                    InsertOrder();
                    string receipt = "\tReceipt for " + DateTime.Now.ToString() + "\n\t======Order Details======\n";
                    for (int i = 0; i < listView_Cart.Items.Count; i++)
                    {
                        MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                        int odAmount = Convert.ToInt32(listView_Cart.Items[i].SubItems[2].Text);
                        int odPID;


                        productName = listView_Cart.Items[i].SubItems[0].Text;
                        databaseConnection.Open();
                        string sqlPID = "SELECT product_id FROM product WHERE product_name = '" + productName + "'";
                        MySqlCommand commandPID = new MySqlCommand(sqlPID, databaseConnection);
                        odPID = Convert.ToInt32(commandPID.ExecuteScalar());
                        databaseConnection.Close();

                        databaseConnection.Open();
                        string query = "INSERT INTO order_detail (order_nr, product_id, amount, type) VALUES " +
                                       " ((SELECT o.order_nr FROM orders o, visitor v WHERE o.visitor_id = v.visitor_id ORDER BY o.order_nr desc LIMIT 1), " + odPID + ", " + odAmount + ", 'rent')";
                        MySqlCommand command = new MySqlCommand(query, databaseConnection);
                        command.ExecuteNonQuery();
                        databaseConnection.Close();

                        databaseConnection.Open();
                        string queryRent = "INSERT INTO rented_products (visitor_id, product_id, amount, days_rented) VALUES (" + visitorID + "," + odPID + ", " + odAmount + ", 1)";
                        MySqlCommand commandRent = new MySqlCommand(queryRent, databaseConnection);
                        commandRent.ExecuteNonQuery();
                        databaseConnection.Close();

                        //give receipt
                        receipt += "\n\t" + odAmount.ToString() + "x " + productName + "\t€" + listView_Cart.Items[i].SubItems[3].Text;
                    }
                    receipt += "\n\t-----------------\n\tTotal: \t€" + Total.ToString();
                    receipt += "\n\n\tThank you for your order";
                    MessageBox.Show(receipt);
                }
                else
                {
                    if (EnoughToPay() && !EnoughInStock()) // There's not enough in stock
                    {
                        MessageBox.Show("Not enough in stock!");
                    }
                    else
                    {
                        MessageBox.Show("Insufficient funds!");
                    }

                }
                DisplayListInfo();
                ResetCart();
                ResetColors();
                proAmount = 0;
                productID = 0;

                lbSwipe.Visible = false;
                pnlSwipe.Visible = false;
                lblAmount.Text = proAmount.ToString();
            }
            else
            {
                MessageBox.Show("Please add something to the cart");
            }
        }
        public void UpdateBalance()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            for (int i = 0; i < listView_Cart.Items.Count; i++)
            {
                databaseConnection.Open();
                subTotal = Convert.ToDouble(listView_Cart.Items[i].SubItems[3].Text);
                string sqlBalance = "UPDATE visitor SET balance = (balance - " + subTotal + ") WHERE visitor_id = " + visitorID;
                MySqlCommand command = new MySqlCommand(sqlBalance, databaseConnection);
                command.ExecuteNonQuery();
                databaseConnection.Close();
            }
        }
        public void InsertOrder()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            databaseConnection.Open();
            string query = "INSERT INTO orders VALUES (DEFAULT," + visitorID + "," + shopID + ")";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }


        private void button_GoBack_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            UserRFID.close();
            this.Hide();
            Form1.ShowDialog();
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (productID != 0)
            {

                string sql = "SELECT product_name, deposit FROM product WHERE product_id = " + productID;

                string sqlSubTotal = "SELECT (deposit * " + proAmount + ") FROM product " +
                                     "WHERE product_id = " + productID;


                double subTotal = 0.00;



                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandList = new MySqlCommand(sql, databaseConnection);
                MySqlCommand commandST = new MySqlCommand(sqlSubTotal, databaseConnection);
                if (proAmount > 0)
                {
                    try // subtotal calculation
                    {
                        databaseConnection.Open();
                        double stQuery = Convert.ToDouble(commandST.ExecuteScalar());

                        subTotal = stQuery;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        databaseConnection.Close();

                    }

                    try // add to cart
                    {
                        databaseConnection.Open();
                        MySqlDataReader reader = commandList.ExecuteReader();


                        while (reader.Read())

                        {



                            ListViewItem item = new ListViewItem(reader[0].ToString());
                            item.SubItems.Add(reader[1].ToString());
                            item.SubItems.Add(proAmount.ToString());
                            item.SubItems.Add(subTotal.ToString());

                            listView_Cart.Items.Add(item);





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

                    Total += subTotal;
                    lbTotal.Text = "€" + Total.ToString();
                }
                else
                {
                    MessageBox.Show("Please input a valid amount");
                    proAmount = 0;
                    productID = 0;
                    lblAmount.Text = proAmount.ToString();
                }
                proAmount = 0;
                productID = 0;
                lblAmount.Text = proAmount.ToString();
                ResetColors();
                pnlSwipe.Visible = true;
                lbSwipe.Visible = true;
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listView_Cart.Items.Count != 0)
            {
                string sqlRemove = "SELECT (deposit * " + Convert.ToInt32(listView_Cart.SelectedItems[0].SubItems[2].Text) +
                               " ) FROM product WHERE product_name = '" + listView_Cart.SelectedItems[0].SubItems[0].Text + "'";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                try
                {
                    databaseConnection.Open();
                    MySqlCommand commandRemove = new MySqlCommand(sqlRemove, databaseConnection);
                    double stRemove = Convert.ToDouble(commandRemove.ExecuteScalar());

                    Total -= stRemove;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();

                }


                lbTotal.Text = "€" + Total.ToString();
                listView_Cart.SelectedItems[0].Remove();

                if (listView_Cart.Items.Count == 0)
                {
                    lbSwipe.Visible = false;
                    pnlSwipe.Visible = false;
                }
            }
        }

        private void button_Checkout_Click(object sender, EventArgs e)
        {
           
        }
        public void ResetButtons()
        {
            
            btnCharger.Enabled = true;

            btnGoPro.BackgroundImage = Properties.Resources.GoPro;
            btnGoPro.Enabled = true;
                        
            btnHeadphone.Enabled = true;

            btnLaptop.BackgroundImage = Properties.Resources.laptopFixed;
            btnLaptop.Enabled = true;

            btnTablet.BackgroundImage = Properties.Resources.Tablet;
            btnTablet.Enabled = true;

            btnUsb.Enabled = true;
        
        }
        public void ResetColors()
        {
            btnGoPro.BackColor = Color.Transparent;
            btnTablet.BackColor = Color.Transparent;
            btnHeadphone.BackColor = Color.Transparent;
            btnCharger.BackColor = Color.Transparent;
            btnUsb.BackColor = Color.Transparent;
            btnCharger.BackColor = Color.Transparent;
        }
        private void cbShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbShop.SelectedItem.ToString())
            {
                case "TechRent":
                    shopID = 2;
                    break;

                case "CoolGreen":
                    shopID = 5;
                    break;


                default:
                    break;
            }
            //GetProductID();
            ResetButtons();
            DisplayListInfo();
            ResetCart();

            ResetColors();
            proAmount = 0;
            lblAmount.Text = proAmount.ToString();


        }

        private void btnGoPro_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnGoPro.BackColor = SystemColors.GradientActiveCaption;
                
                proAmount = 1;
                productID = 9;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnTablet_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();

                btnTablet.BackColor = SystemColors.GradientActiveCaption;
               

                proAmount = 1;
                productID = 10;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnHeadphone_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnHeadphone.BackColor = SystemColors.GradientActiveCaption;
               

                proAmount = 1;
                productID = 5;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnCharger.BackColor = SystemColors.GradientActiveCaption;
               

                proAmount = 1;
                productID = 6;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnUsb_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnUsb.BackColor = SystemColors.GradientActiveCaption;

                proAmount = 1;
                productID = 3;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void Form_Loans_Load(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (proAmount > 0 && cbShop.SelectedIndex != -1)
            {
                proAmount--;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1 && productID != 0)
            {
                proAmount++;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnLaptop.BackColor = SystemColors.GradientActiveCaption;

                proAmount = 1;
                productID = 15;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
