using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RadugaTur
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }


        private void SaveManagerFormButton_Click(object sender, EventArgs e)
        {
            string query = "insert into ManagerTable (ManagerName, ManagerPosition) values (\'" + inputFullNameManager.Text + "\', \'" + inputPositionManager.Text + "\')";
            Database.executeQuery(query);
            ManagerFormTable managerTableForm = new ManagerFormTable();
            managerTableForm.Show();
            this.Close();
        }

        
    }
}
