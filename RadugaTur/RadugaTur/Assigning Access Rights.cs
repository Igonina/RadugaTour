using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadugaTur
{
    public partial class AssigningAccessRights : Form
    {
        public AssigningAccessRights()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string query = "insert into Hashing(hashName, hashName2, hashLogin, hash, hashPosition) values (\'" +
                inputHashName.Text + "\', \'" +
                inputHashName2.Text + "\', \'" +
                inputHashLogin.Text + "\', \'" +
                inputPassword.Text + "\', \'" +
                inputPosition.Text + "\')";
            Database.executeQuery(query);
            this.Close();
        }
    }
}
