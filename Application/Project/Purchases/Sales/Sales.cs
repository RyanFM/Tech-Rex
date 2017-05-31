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
       
        private string rfidTag;
        RFID UserRFID;
        string connectionString = "server=studmysql01.fhict.local;" + "Database=dbi350130;" + "Uid=dbi350130;" + "Pwd=Techrex;" + "connect timeout=30;";
        int shopID;
        int visitorID = 1;

        double Total = 0.00;
        double subTotal = 0.00;

        public Sales()
        {
            InitializeComponent();
            DisplayShopID();
            lbtest2.Text = Total.ToString();

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
        public void DisplayShopID()
        {
            string sql = "SELECT shop_id FROM shop WHERE type = 'sale'";

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

        public void DisplayListInfo()
        {
            listView_Add.Items.Clear();
            shopID = Convert.ToInt32(cbShop.SelectedItem);

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
        }

        public void GetProductID()
        {
            cbProducts.Items.Clear();
            shopID = Convert.ToInt32(cbShop.SelectedItem);
            string sql = "SELECT product_id FROM shop_inventory WHERE shop_id = " + shopID;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandCombo = new MySqlCommand(sql, databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = commandCombo.ExecuteReader();

                while (reader.Read())
                {
                    cbProducts.Items.Add(reader[0].ToString());
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
        public void ResetCart() // clears the cart and sets the total to zero
        {
            listView_Cart.Items.Clear();
            Total = 0.00;
            lbTotal.Text = Total.ToString();
        }

        //public void GetSubTotal()
        //{
        //    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        //    double updatedBalance = 0.00;
        //    for (int i = 0; i < listView_Cart.Items.Count; i++)
        //    {
        //        databaseConnection.Open();
        //        subTotal = Convert.ToDouble(listView_Cart.Items[i].SubItems[3].Text);
        //        string sqlBalance = "SELECT (balance - " + subTotal + ") FROM visitor WHERE visitor_id = " + visitorID;
        //        MySqlCommand commandBalance = new MySqlCommand(sqlBalance, databaseConnection);
        //        updatedBalance = Convert.ToDouble(commandBalance.ExecuteScalar());
        //        databaseConnection.Close();
        //    }
           
        //}
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
                                   " ((SELECT o.order_nr FROM orders o, visitor v WHERE o.visitor_id = v.visitor_id ORDER BY o.order_nr desc LIMIT 1), " + odPID + ", " + odAmount + ", 'sale')";
                    MySqlCommand command = new MySqlCommand(query, databaseConnection);
                    command.ExecuteNonQuery();
                    databaseConnection.Close();

                    // Give receipt.
                    receipt += "\n\t" + odAmount.ToString() + "x " + productName + "\t€" + listView_Cart.Items[i].SubItems[3].Text;

                }
                receipt += "\n\t-----------------\n\tTotal: \t€" + Total.ToString();
                receipt += "\n\n\tThank you for your order";
                MessageBox.Show(receipt);
            }
            else
            {
                if (EnoughToPay() && !EnoughInStock())
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
            string query = "INSERT INTO orders VALUES (DEFAULT," + visitorID + "," + cbShop.Text + ")";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }
        //public void InsertOrderDetails()
        //{
        //    MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        //    databaseConnection.Open();
        //    string query = "INSERT INTO order_detail (order_nr, product_id, amount, type) VALUES " +
        //                   " ((SELECT o.order_nr FROM orders o, visitor v WHERE o.visitor_id = v.visitor_id ORDER BY o.order_nr desc LIMIT 1), " + "";
        //    MySqlCommand command = new MySqlCommand(query, databaseConnection);
        //    command.ExecuteNonQuery();
        //    databaseConnection.Close();
        //}

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

        // input a shop id
        private void cbShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayListInfo();
            GetProductID();
            ResetCart();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {



            string sql = "SELECT product_name, price FROM product WHERE product_id = " +
                          /*listView_Add.SelectedItems[0].SubItems[0].Text;*/ cbProducts.Text;

            string sqlSubTotal = "SELECT (price * " + Convert.ToInt32(textBox_Add.Text) + ") FROM product " +
                                 "WHERE product_id = " + /*listView_Add.SelectedItems[0].SubItems[0].Text;*/ cbProducts.Text;


            double subTotal = 0.00;



            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandList = new MySqlCommand(sql, databaseConnection);
            MySqlCommand commandST = new MySqlCommand(sqlSubTotal, databaseConnection);
            if (Convert.ToInt32(textBox_Add.Text) > 0)
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
                        item.SubItems.Add(textBox_Add.Text);
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
                lbTotal.Text = Total.ToString();
                lbtest2.Text = Total.ToString();
            }
            else
            {
                MessageBox.Show("Please input a valid amount");
                textBox_Add.Text = "0";
            }

        }

        private void listView_Add_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            string sqlRemove = "SELECT (price * " + Convert.ToInt32(listView_Cart.SelectedItems[0].SubItems[2].Text) +
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


            lbTotal.Text = Total.ToString();
            listView_Cart.SelectedItems[0].Remove();
            lbtest2.Text = Total.ToString();
        }

        private void button_Checkout_Click(object sender, EventArgs e) //update stock and create order/order_Detail
        {
            //int amount;
            //int productID;
            //string productName = "";

            //if (EnoughToPay() && EnoughInStock())
            //{
            //    for (int i = 0; i < listView_Cart.Items.Count; i++)
            //    {
            //        MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            //        productName = listView_Cart.Items[i].SubItems[0].Text;
            //        databaseConnection.Open();
            //        string sqlPID = "SELECT product_id FROM product WHERE product_name = '" + productName + "'";
            //        MySqlCommand commandPID = new MySqlCommand(sqlPID, databaseConnection);
            //        productID = Convert.ToInt32(commandPID.ExecuteScalar());
            //        databaseConnection.Close();

            //        amount = Convert.ToInt32(listView_Cart.Items[i].SubItems[2].Text);
            //        // get the amount needed to be removed and product id

            //        string sqlStockUpdate = "UPDATE shop_inventory SET amount = (amount - " + amount + ") WHERE shop_id = " + shopID + " AND product_id = " + productID;

            //        MySqlCommand commandUpdateStock;
            //        commandUpdateStock = new MySqlCommand(sqlStockUpdate, databaseConnection);

            //        databaseConnection.Open();
            //        commandUpdateStock.ExecuteNonQuery();
            //        databaseConnection.Close();
            //        UpdateBalance();


            //    }
            //    InsertOrder();
            //    string receipt = "\tReceipt for " + DateTime.Now.ToString() + "\n\t======Order Details======\n";
            //    for (int i = 0; i < listView_Cart.Items.Count; i++)
            //    {
            //        MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            //        int odAmount = Convert.ToInt32(listView_Cart.Items[i].SubItems[2].Text);
            //        int odPID;


            //        productName = listView_Cart.Items[i].SubItems[0].Text;
            //        databaseConnection.Open();
            //        string sqlPID = "SELECT product_id FROM product WHERE product_name = '" + productName + "'";
            //        MySqlCommand commandPID = new MySqlCommand(sqlPID, databaseConnection);
            //        odPID = Convert.ToInt32(commandPID.ExecuteScalar());
            //        databaseConnection.Close();

            //        databaseConnection.Open();
            //        string query = "INSERT INTO order_detail (order_nr, product_id, amount, type) VALUES " +
            //                       " ((SELECT o.order_nr FROM orders o, visitor v WHERE o.visitor_id = v.visitor_id ORDER BY o.order_nr desc LIMIT 1), " + odPID + ", " + odAmount + ", 'sale')";
            //        MySqlCommand command = new MySqlCommand(query, databaseConnection);
            //        command.ExecuteNonQuery();
            //        databaseConnection.Close();

            //        // Give receipt.
            //        receipt += "\n\t" + odAmount.ToString() + "x " + productName + "\t€" + listView_Cart.Items[i].SubItems[3].Text;

            //    }
            //    MessageBox.Show(receipt);
            //}
            //else
            //{ if (EnoughToPay() && !EnoughInStock())
            //    {
            //        MessageBox.Show("Not enough in stock!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Insufficient funds!");
            //    }
            //}


            //DisplayListInfo();
            //ResetCart();

            //Checkout();
           
        }
        //Above about tag
    }
}
