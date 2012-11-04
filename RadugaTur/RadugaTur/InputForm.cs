using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RadugaTur
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ApplicationJunkClass mainForm = new ApplicationJunkClass();
            mainForm.Show();
            string query = "select hashName, hashLogin from Hashing where hashLogin = \'" + inputLogin.Text + "\' and hash = \'" +inputPassword2.Text+ "\'";
            
            SqlDataReader data = Database.executeQuery(query);
            object[] fields = new object[3];
            data.Read();
            data.GetValues(fields);
            data.Close();

            string hashName = fields[0].ToString(), hashLogin = fields[1].ToString();
            mainForm.fillData(hashName, hashLogin);

            Database.executeQuery(query);
            //this.Close();
        }

       
    }
}
