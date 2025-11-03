using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Digital_Receipt_and_Expense_Tracker_System
{
    internal class DBConnection
    {
        private static string connectionString = "server=localhost;database=receipt_tracker_db;uid=root;pwd=;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }
            return conn;
        }
    }
}
