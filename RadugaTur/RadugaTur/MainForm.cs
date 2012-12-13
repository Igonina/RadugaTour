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
    public partial class ApplicationJunkClass : Form
    {
        public ApplicationJunkClass()
        {
            InitializeComponent();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void CreateApplication_Click(object sender, EventArgs e)
        {
           
            ApplicationForm appForm = new ApplicationForm();
            appForm.Show();

        }
      

        private void AddManagerButton_Click(object sender, EventArgs e)
        {
            ManagerForm manForm = new ManagerForm();
            manForm.ShowDialog();
        }

        

        private void ShowJuriFace_Click(object sender, EventArgs e)
        {
            JFTableForm jfTableForm = new JFTableForm(this);
            jfTableForm.ShowDialog();
        }

        private void LookAtManagersbutton_Click(object sender, EventArgs e)
        {
            ManagerFormTable managerFormTable = new ManagerFormTable();
            managerFormTable.ShowDialog();
        }

        private void ShowPhisFace_Click(object sender, EventArgs e)
        {
            PFTableForm pfTableForm = new PFTableForm(this);
            pfTableForm.ShowDialog();
        }

        private void LookAtApplications_Click(object sender, EventArgs e)
        {
            ApplicationTableForm appTableForm = new ApplicationTableForm();
            appTableForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssigningAccessRights assAccessRights = new AssigningAccessRights();
            assAccessRights.ShowDialog();
        }

        private void outputDateTime_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void outputLogin_Click(object sender, EventArgs e)
        {

        }

        private void outputProfile_Click(object sender, EventArgs e)
        {

        }
        internal void fillData(string hashName, string hashLogin)
        {
            this.outputProfile.Text = hashName;
            this.outputLogin.Text = hashLogin;
        }
            
          
        
    }
}
