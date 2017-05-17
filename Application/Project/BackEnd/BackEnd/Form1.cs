using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BackEnd
{
    public partial class Form1 : Form
    {
        string connectionString = "server=studmysql01.fhict.local;" + "Database=dbi350130;" + "Uid=dbi350130;" + "Pwd=Techrex;" + "connect timeout=30;";
        public Form1()
        {
            InitializeComponent();
            DisplayVisitorInfo();
            DisplayListInfo();
            comboBox_Search.SelectedIndex = 0;
            
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            

            if (textBox_Search.Text != "") // If you begin to type into the search box
            {
                for (int i = listView_Details.Items.Count - 1; i >= 0; i--) 
                {
                   
                    if (listView_Details.Items[i].SubItems[comboBox_Search.SelectedIndex].Text.ToLower().Contains(textBox_Search.Text.ToLower()))// Looks if the row contained in the ListView column (determined by the combobox value) contains the search query
                    {
                        listView_Details.Items[i].BackColor = SystemColors.Highlight; // Highlights the search
                        listView_Details.Items[i].ForeColor = SystemColors.HighlightText;
                    }
                    else {
                        listView_Details.Items.Remove(listView_Details.Items[i]); // If the search didn't match, removes the rows
                    }
                }
                if (listView_Details.SelectedItems.Count == 1)
                {
                    listView_Details.Focus();
                }
            }
            else
            {
                 
                DisplayListInfo(); // Resets the listview when the search box is empty
            }
        }

        public void DisplayListInfo()
        {
            string sql = "SELECT visitor_id, last_name, status, balance, ifnull(camping_spot,0)" +
                        "FROM visitor";




            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandList = new MySqlCommand(sql, databaseConnection);




            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = commandList.ExecuteReader();


                while (reader.Read())

                {
                    string camping_spot = "";
                    if (reader[4].ToString() == "0")
                    {
                        camping_spot = "N";
                    }
                    else camping_spot = "Y";

                    ListViewItem item = new ListViewItem(reader["visitor_id"].ToString());
                    item.SubItems.Add(reader["last_name"].ToString());
                    item.SubItems.Add(reader["status"].ToString());
                    item.SubItems.Add(reader["balance"].ToString());
                    item.SubItems.Add(camping_spot);


                    listView_Details.Items.Add(item);

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

        public void EnableVisitorInfo()
        {
            lbCheckedOutTitle.Visible = true;
            lbCheckedOut.Visible = true;

            lbPending.Visible = true;
            lbPendingTitle.Visible = true;

            lbTickets.Visible = true;
            lbTicketsTitle.Visible = true;

            lbVisitors.Visible = true;
            lbVisitorsTitle.Visible = true;

            lbEarned.Visible = false;
            lbEarnedTitle.Visible = false;
        }


        public void DisplayVisitorInfo()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();
                string sqlTickets = "SELECT COUNT(*) FROM visitor"; // Total tickets sold
                MySqlCommand commandVisitors = new MySqlCommand(sqlTickets, databaseConnection);
                int amountTickets = Convert.ToInt32(commandVisitors.ExecuteScalar());
                lbTickets.Text = amountTickets.ToString();

                string sqlAttending = "SELECT COUNT(*) FROM visitor WHERE LOWER(status) IN('checked-in')"; // Total visitors attending
                MySqlCommand commandAttending = new MySqlCommand(sqlAttending, databaseConnection);
                int amountAttending = Convert.ToInt32(commandAttending.ExecuteScalar());
                lbVisitors.Text = amountAttending.ToString();

                string sqlPending = "SELECT COUNT(*) FROM visitor WHERE LOWER(status)IN('pending')"; // total visitors not yet checked in
                MySqlCommand commandPending = new MySqlCommand(sqlPending, databaseConnection);
                int amountPending = Convert.ToInt32(commandPending.ExecuteScalar());
                lbPending.Text = amountPending.ToString();

                string sqlCheckedOut = "SELECT COUNT(*) FROM visitor WHERE LOWER(status) IN('checked-out')"; // total visitors checked out
                MySqlCommand commandCheckedOut = new MySqlCommand(sqlCheckedOut, databaseConnection);
                int amountCheckedOut = Convert.ToInt32(commandCheckedOut.ExecuteScalar());
                lbCheckedOut.Text = amountCheckedOut.ToString();

                EnableVisitorInfo();
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

        public void EnableSalesInfo()
        {
            lbCheckedOutTitle.Visible = false;
            lbCheckedOut.Visible = false;

            lbPending.Visible = false;
            lbPendingTitle.Visible = false;

            lbTickets.Visible = false;
            lbTicketsTitle.Visible = false;

            lbVisitors.Visible = false;
            lbVisitorsTitle.Visible = false;

            lbEarned.Visible = true;
            lbEarnedTitle.Visible = true;
        }

        public void DisplaySalesInfo()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                databaseConnection.Open();
                string sqlEarned = "SELECT SUM(pro.price * od.amount) AS paid  FROM product pro " + 
                                    "JOIN order_detail od ON (pro.product_id = od.product_id) " + 
                                    "JOIN orders o ON (o.order_nr = od.order_nr) " +
                                    "JOIN visitor v ON (v.visitor_id = o.visitor_id)"; // Total money earned
                MySqlCommand commandVisitors = new MySqlCommand(sqlEarned, databaseConnection);
                double amountEarned = Convert.ToDouble(commandVisitors.ExecuteScalar());
                lbEarned.Text = "€" + amountEarned.ToString();

                

                EnableSalesInfo();
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

        private void button_Display_Click(object sender, EventArgs e)
        {
            DisplayListInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVisitorInfo_Click(object sender, EventArgs e)
        {
            DisplayVisitorInfo();
        }

        private void btnSalesInfo_Click(object sender, EventArgs e)
        {
            DisplaySalesInfo();
        }

        private void comboBox_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
