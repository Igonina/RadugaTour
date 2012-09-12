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
    public partial class ManagerAddForm : Form
    {
        public ManagerAddForm()
        {
            InitializeComponent();
        }


        private void SaveManagerFormButton_Click(object sender, EventArgs e)
        {
            string query = "insert into ManagerTable (ManagerName, ManagerPosition) values (\'" + inputFullNameManager.Text + "\', \'" + inputPositionManager.Text + "\')";
            Database.executeQuery(query);
            ManagerTableForm managerTableForm = new ManagerTableForm();
            managerTableForm.Show();
            this.Close();
        }

        
    }
}
