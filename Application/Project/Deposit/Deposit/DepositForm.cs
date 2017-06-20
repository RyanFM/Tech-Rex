using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MySql.Data.MySqlClient;

namespace Deposit
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            
            string connectionString = "server=studmysql01.fhict.local;" + "Database=dbi350130;" + "Uid=dbi350130;" + "Pwd=Techrex;" + "connect timeout=30;";
           

          
            int NrOfDeposits = 0;
            int BankAccount = 0;
          
            string StartTime;
            string EndTime;
            FileStream fs = null;
            StreamReader sr = null;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            try
            {
               
                databaseConnection.Open();
                //fs = new FileStream(@"Resources\deposit.txt", FileMode.Open, FileAccess.Read);
                //sr = new StreamReader(fs);


                //while ((line = sr.ReadLine()) != null)
                //{
                string[] fields = File.ReadAllLines(@"Resources\deposit.txt");
                   
                   
                        BankAccount = Convert.ToInt32(fields[0]);
                        StartTime = fields[1];
                        EndTime = fields[2];
                        NrOfDeposits = Convert.ToInt32(fields[3]);
                     


                    for (int i = 0; i < NrOfDeposits; i++)
                    {
                        string query = "INSERT INTO deposit (bank_account, start_time, end_time, deposit_amount, deposit_detail) VALUES (" + BankAccount + ",'" + StartTime + "','" + EndTime + "'," + NrOfDeposits + ",'" + fields[4 + i].ToString() + "')";
                        MySqlCommand command = new MySqlCommand(query, databaseConnection);
                    command.ExecuteNonQuery();
                    }
                    
                //}
            }
            catch (IOException)
            {
                MessageBox.Show("Error reading file");

            }
            finally
            {
                databaseConnection.Close();
            }
            
        }
    }
}
