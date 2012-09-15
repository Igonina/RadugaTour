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

        private void AddJuriFace_Click(object sender, EventArgs e)
        {
            JuridicalFaceForm juridicFaceForm = new JuridicalFaceForm();
            juridicFaceForm.Show();
        }

        private void AddPhisFace_Click(object sender, EventArgs e)
        {
            FisicalFaceForm fisicFaceForm = new FisicalFaceForm();
            fisicFaceForm.Show();
        }

        

        private void AddManagerButton_Click(object sender, EventArgs e)
        {
            ManagerForm manForm = new ManagerForm();
            manForm.Show();
        }

        private void ApplicationJunkClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaTourDatabaseDataSet1.ManagerTable1' table. You can move, or remove it, as needed.
            this.managerTable1TableAdapter.Fill(this.radugaTourDatabaseDataSet1.ManagerTable1);

        }

        private void ShowJuriFace_Click(object sender, EventArgs e)
        {
            JFTableForm jfTableForm = new JFTableForm();
            jfTableForm.Show();
        }

        private void LookAtManagersbutton_Click(object sender, EventArgs e)
        {
            ManagerFormTable managerFormTable = new ManagerFormTable();
            managerFormTable.Show();
        }

        private void ShowPhisFace_Click(object sender, EventArgs e)
        {
            PFTableForm pfTableForm = new PFTableForm();
            pfTableForm.Show();
        }

        private void LookAtApplications_Click(object sender, EventArgs e)
        {
            ApplicationTableForm appTableForm = new ApplicationTableForm();
            appTableForm.Show();
        }

        
    }
}
