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
    public partial class JuridicalFaceForm : Form
    {
        public JuridicalFaceForm()
        {
            InitializeComponent();
        }

        private void SaveJuridicalFaceFormButton_Click(object sender, EventArgs e)
        {
            string query = "insert into JuridicalFace (JFNameOrg, JFFullNameOrg, JFFullName, JFPhone, JFCargoCarrier) values (\'"+inputJFNameOrg.Text+"\', \'"+inputJFFullNameOrg.Text+"\', \'"+inputFullName.Text+"\', \'"+inputPhone.Text+"\', \'"+InputCargoCarrier.Text+"\')";
            Database.executeQuery(query);
            JFTableForm JFTableForm = new JFTableForm();
            JFTableForm.Show();
            this.Close();
        }
    }
}
