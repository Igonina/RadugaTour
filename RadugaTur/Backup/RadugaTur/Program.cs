using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace RadugaTur
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ApplicationJunkClass());
            //Connect();
        }
        /*static void Connect() {
            string CommandText = "Подключение к MySql";
            string Connect = "Database = radugatour; Data Source=127.0.0.1; User Id=root";
            MySqlConnection myConnection = new MySqlConnection(Connect);
            MySqlCommand myCommand = new MySqlCommand(CommandText, myConnection);
            myConnection.Open();
            myConnection.Close();

        }
          */
    }
}
