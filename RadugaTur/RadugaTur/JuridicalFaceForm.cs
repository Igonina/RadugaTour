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

        bool isUpdateModeEnabled = false;
        int updateJFId;
        internal void fillData(int JFId, string JFNameOrg, string JFFullNameOrg, string JFFullName, string JFPhone, string JFCargoCarrier)
        {
            inputJFNameOrg.Text = JFNameOrg.ToString();
            inputJFFullNameOrg.Text = JFFullNameOrg.ToString();
            inputFullName.Text = JFFullName.ToString();
            inputPhone.Text = JFPhone.ToString();
            InputCargoCarrier.Text = JFCargoCarrier.ToString();

            isUpdateModeEnabled = true;
            updateJFId = JFId;
           
        }
        internal void insert2() {
            if (updateJFId == 0)
            {
                string query = "insert into JuridicalFace (JFNameOrg, JFFullNameOrg, JFFullName, JFPhone, JFCargoCarrier) values (\'" + inputJFNameOrg.Text + "\', \'" + inputJFFullNameOrg.Text + "\', \'" + inputFullName.Text + "\', \'" + inputPhone.Text + "\', \'" + InputCargoCarrier.Text + "\')";
                Database.executeQuery(query).Close();
            }
            else
            {
                string query2 = "update JuridicalFace set JFNameOrg = \'" + inputJFNameOrg.Text + "\', JFFullNameOrg = \'" + inputJFFullNameOrg.Text + "\', JFFullName = \'" + inputFullName.Text + "\', JFPhone = \'" + inputPhone.Text + "\', JFCargoCarrier= \'" + InputCargoCarrier.Text + "\' where (JFId = " + updateJFId + ")";
                Database.executeQuery(query2).Close();
            }

            this.Close();
        }


        private void SaveJuridicalFaceFormButton_Click(object sender, EventArgs e)
        {
            insert2();
        }

        private void inputJFNameOrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                insert2();
            }
        }


       

        
    }
}
