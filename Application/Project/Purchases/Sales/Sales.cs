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
        int shopID = 0;
        int visitorID = 1;
        int proAmount = 0;
        int productID = 0;

        double Total = 0.00;
        double subTotal = 0.00;

        public Sales()
        {
            InitializeComponent();
            //btnCola.BackgroundImage = Properties.Resources.ColaGray;
            //DisplayShopID();
           

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
            //shopID = Convert.ToInt32(cbShop.SelectedItem);

            string sql = "SELECT p.product_id, p.product_name, p.price, si.amount " +
                         "FROM product p , shop_inventory si " +
                         "WHERE p.product_id = si.product_id " +
                         "AND si.shop_id = " + shopID;




            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandList = new MySqlCommand(sql, databaseConnection);

            //foreach (var item in collection)
            //{
            //    Button ProductButton = new Button();
            //    ProductButton

            //    dynamicbutton.Click += new System.EventHandler(menuItem_Click);
            //    dynamicbutton.Text = menu.ReadLine();
            //    dynamicbutton.Visible = true;
            //    dynamicbutton.Location = new Point(4 + repetition * 307, 4);
            //    dynamicbutton.Height = 44;
            //    dynamicbutton.Width = 203;
            //    dynamicbutton.BackColor = Color.FromArgb(40, 40, 40);
            //    dynamicbutton.ForeColor = Color.White;
            //    dynamicbutton.Font = new Font("Lucida Console", 16);
            //    dynamicbutton.Show();
            //    menuPanel.Controls.Add(dynamicbutton);
            //}
            //panelItems.Controls.Add


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
                    btnCola.BackgroundImage = Properties.Resources.ColaGray;
                    btnCola.Enabled = false;
                }
                if (listView_Add.Items[1].SubItems[3].Text == "0")
                {
                    btnHeiniken.BackgroundImage = Properties.Resources.HeinikenGray;
                    btnHeiniken.Enabled = false;
                }
                if (listView_Add.Items[2].SubItems[3].Text == "0")
                {
                    btnCroquette.BackgroundImage = Properties.Resources.CroquetteGray;
                    btnCroquette.Enabled = false;
                }
                if (listView_Add.Items[3].SubItems[3].Text == "0")
                {
                    btnDoner.BackgroundImage = Properties.Resources.DonerGray;
                    btnDoner.Enabled = false;
                }
                if (listView_Add.Items[4].SubItems[3].Text == "0")
                {
                    btnFries.BackgroundImage = Properties.Resources.FriesGray;
                    btnFries.Enabled = false;
                }
                if (listView_Add.Items[5].SubItems[3].Text == "0")
                {
                    btnCoffee.BackgroundImage = Properties.Resources.coffeeGray;
                    btnCoffee.Enabled = false;
                }
                if (listView_Add.Items[6].SubItems[3].Text == "0")
                {
                    btnBavaria.BackgroundImage = Properties.Resources.bavariaGray;
                    btnBavaria.Enabled = false;
                }
                if (listView_Add.Items[7].SubItems[3].Text == "0")
                {
                    btnHotdog.BackgroundImage = Properties.Resources.hotdoggray;
                    btnHotdog.Enabled = false;
                }
                if (listView_Add.Items[8].SubItems[3].Text == "0")
                {
                    btnAmstel.BackgroundImage = Properties.Resources.amstelGray;
                    btnAmstel.Enabled = false;
                }
            }
        }

        //public void GetProductID()
        //{
        //    cbProducts.Items.Clear();
        //    shopID = Convert.ToInt32(cbShop.SelectedItem);
        //    string sql = "SELECT product_id FROM shop_inventory WHERE shop_id = " + shopID;

        //    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        //    MySqlCommand commandCombo = new MySqlCommand(sql, databaseConnection);

        //    try
        //    {
        //        databaseConnection.Open();
        //        MySqlDataReader reader = commandCombo.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            cbProducts.Items.Add(reader[0].ToString());
        //        }
        //        reader.Close();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        databaseConnection.Close();

        //    }
        //}
        public void ResetCart() // clears the cart and sets the total to zero
        {
            listView_Cart.Items.Clear();
            Total = 0.00;
            lbTotal.Text = "€" + Total.ToString();
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

        public void IsInStock()
        {

        }
        // input a shop id
        private void cbShop_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            switch (cbShop.SelectedItem.ToString())
            {
                case "Bob's Bar":
                    shopID = 1;
                    break;

                case "The Ceiling":
                    shopID = 3;
                    break;

                case "De Krokante Friet":
                    shopID = 4;
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

        private void button_Add_Click(object sender, EventArgs e)
        {

            if (productID != 0)
            {

                string sql = "SELECT product_name, price FROM product WHERE product_id = " +
                              /*listView_Add.SelectedItems[0].SubItems[0].Text;*/ productID;

                string sqlSubTotal = "SELECT (price * " + proAmount + ") FROM product " +
                                     "WHERE product_id = " + /*listView_Add.SelectedItems[0].SubItems[0].Text;*/ productID;


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

        private void listView_Add_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listView_Cart.Items.Count != 0)
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


                lbTotal.Text = "€" + Total.ToString();
                listView_Cart.SelectedItems[0].Remove();
                if (listView_Cart.Items.Count == 0)
                {
                    lbSwipe.Visible = false;
                    pnlSwipe.Visible = false;
                }
            }
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

         //   Checkout();

        }

        public void ResetButtons()
        {
            btnDoner.BackgroundImage = Properties.Resources.Doner_kebab1;
            btnDoner.Enabled = true;

            btnCola.BackgroundImage = Properties.Resources.ColaFixed;
            btnCola.Enabled = true;

            btnFries.BackgroundImage = Properties.Resources.French_fries1;
            btnFries.Enabled = true;

            btnHeiniken.BackgroundImage = Properties.Resources.HeinikenFIxed;
            btnHeiniken.Enabled = true;

            btnCroquette.BackgroundImage = Properties.Resources.Croquette1;
            btnCroquette.Enabled = true;

            btnHotdog.BackgroundImage = Properties.Resources.hotdogFixed;
            btnHotdog.Enabled = true;

            btnCoffee.BackgroundImage = Properties.Resources.coffeeFixed;
            btnCoffee.Enabled = true;

            btnBavaria.BackgroundImage = Properties.Resources.bavariaFixed;
            btnBavaria.Enabled = true;

            btnAmstel.BackgroundImage = Properties.Resources.amstelFixed;
            btnAmstel.Enabled = true;
        }
        public void ResetColors()
        {
            btnDoner.BackColor = Color.Transparent;   
                
            btnCola.BackColor = Color.Transparent;           

            btnFries.BackColor = Color.Transparent;           

            btnHeiniken.BackColor = Color.Transparent;            

            btnCroquette.BackColor = Color.Transparent;            

            btnHotdog.BackColor = Color.Transparent;           

            btnCoffee.BackColor = Color.Transparent;           

            btnBavaria.BackColor = Color.Transparent;          

            btnAmstel.BackColor = Color.Transparent;
           
        }
        private void btnDoner_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnDoner.BackColor = SystemColors.GradientActiveCaption;

                

                proAmount = 1;
                productID = 7;
                lblAmount.Text = proAmount.ToString();
            }
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
            if (cbShop.SelectedIndex != -1 && productID!=0)
            {
                proAmount++;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnFries.BackColor = SystemColors.GradientActiveCaption;

                

                proAmount = 1;
                productID = 8;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnCroquette_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnCroquette.BackColor = SystemColors.GradientActiveCaption;

                proAmount = 1;
                productID = 4;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnHeiniken_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnHeiniken.BackColor = SystemColors.GradientActiveCaption;
                

                proAmount = 1;
                productID = 2;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnCola.BackColor = SystemColors.GradientActiveCaption;
                

                proAmount = 1;
                productID = 1;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnHotdog_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnHotdog.BackColor = SystemColors.GradientActiveCaption;


                proAmount = 1;
                productID = 13;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnCoffee.BackColor = SystemColors.GradientActiveCaption;


                proAmount = 1;
                productID = 11;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnBavaria_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnBavaria.BackColor = SystemColors.GradientActiveCaption;


                proAmount = 1;
                productID = 12;
                lblAmount.Text = proAmount.ToString();
            }
        }

        private void btnAmstel_Click(object sender, EventArgs e)
        {
            if (cbShop.SelectedIndex != -1)
            {
                ResetColors();
                btnAmstel.BackColor = SystemColors.GradientActiveCaption;


                proAmount = 1;
                productID = 14;
                lblAmount.Text = proAmount.ToString();
            }
        }
    }
    //Above about tag
}

