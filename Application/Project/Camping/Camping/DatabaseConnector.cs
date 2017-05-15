using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Entrance
{
    class DatabaseConnector
    {
        /********* instance varible ***********/
        private string connectionString;
        private MySqlConnection databaseConnection;

        /********* Construcor ***********/
        public DatabaseConnector()
        {
            connectionString = "server=studmysql01.fhict.local;" + "Database=dbi350130;" +"Uid=dbi350130;" + "Pwd=Techrex;" + "connect timeout=30;";

            databaseConnection = new MySqlConnection(connectionString);
        }

        //Open database
        public bool IsConnected()
        {
            bool connected = false;
            try
            {
                databaseConnection.Open();
                connected = !connected;
                return connected;
            }
            catch
            {
                databaseConnection.Close();
                return connected;
            }

        }
    }
}
