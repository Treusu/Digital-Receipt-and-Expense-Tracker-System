using MySql.Data.MySqlClient;

using System;
using System.Windows.Forms;

namespace Digital_Receipt_and_Expense_Tracker_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}


