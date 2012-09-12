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
    public partial class JuridicalFaceAddForm : Form
    {
        public JuridicalFaceAddForm()
        {
            InitializeComponent();
        }

        private void SaveJuridicalFaceFormButton_Click(object sender, EventArgs e)
        {
            string query = "insert into JuridicalFace (JuridicalFaceNameOrganization, JuridicalFaceFullNameOrganization, JuridicalFaceFullName, JuridicalFacePhoneNumber, JuridicalFaceCargoCarrier) values (\'" + inputNameOrganizationJuriFace.Text + "\', \'" + inputFullNameOrganizationJuriFace.Text + "\', \'" + inputFullNameJuriFace.Text + "\', \'" + inputPhoneNumberJuriFace.Text + "\', \'" + inputCargoCarrierJuriFace.Text + "\')";
            Database.executeQuery(query);
            JuridicalFaceTableForm juriFaceTable = new JuridicalFaceTableForm(); 
            juriFaceTable.Show();
            this.Close();
        }
    }
}
