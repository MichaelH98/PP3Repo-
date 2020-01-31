using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Directives
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace HarrisMichael_FinalApp
{
    public static class DBUtils
    {
        // method to create the connection string
        public static string BuildConnectionString()
        {
            // strings to hold the connection data
            string serverIP = "";
            string port = "";

            // use a try...catch to very that the data can be retrieved
            try
            {
                // open the text file
                using (StreamReader sr = new StreamReader(@"C:\VFW\connect.txt"))
                {
                    // read the data for the IP and the port
                    serverIP = sr.ReadLine();
                    port = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            // return the connection string
            return "server=" + serverIP + ";userid=dbsAdmin;pwd=password;database=FilmNation;SslMode=none;port=" + port;
        }

        // method to connect to the database
        public static MySqlConnection Connect(string myConnectionString)
        {
            MySqlConnection conn = new MySqlConnection();

            // try..catch to check if the connection cannot be made
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                // DEBUG: Message to indicate the connection was made
                //MessageBox.Show("Connected!");
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 1042:
                        MessageBox.Show("Can't resolve the host address.\n" + myConnectionString);
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password.");
                        break;
                    default:
                        MessageBox.Show(e.ToString() + "\n" + myConnectionString);
                        break;
                }
            }
            return conn;
        }
    }
}
