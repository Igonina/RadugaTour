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
    public partial class JFTableForm : Form
    {
        public JFTableForm(Form parent)
        {
            InitializeComponent();
            if (parent.GetType() == typeof(ApplicationForm))
            {
                this.parent = parent as ApplicationForm;
            }
        }
        private ApplicationForm parent = null;
        

        private void JFTableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaDBDataSet3.JuridicalFace' table. You can move, or remove it, as needed.
            this.juridicalFaceTableAdapter.Fill(this.radugaDBDataSet3.JuridicalFace);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (parent != null)
              {

                  int i = dataGridView1.SelectedCells[0].RowIndex;
                  int JFid = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                  string query = "select JFId, JFFullNameOrg from JuridicalFace where (JFId = " + JFid + ")";

                  SqlDataReader data = Database.executeQuery(query);
                  object[] fields = new object[2];
                  data.Read();
                  data.GetValues(fields);
                  data.Close();

                  int JFId = int.Parse(fields[0].ToString());
                  string JFFullNameOrg = fields[1].ToString();
                  parent.setFullName2(JFFullNameOrg);
                  parent.fillData4(JFId, JFFullNameOrg);
              }

          
        }

        private void addJFButton_Click(object sender, EventArgs e)
        {
            JuridicalFaceForm JFForm = new JuridicalFaceForm();
            JFForm.ShowDialog();
            this.Close();
        }

        private void changeJFButton_Click(object sender, EventArgs e)
        {
            JuridicalFaceForm JFForm = new JuridicalFaceForm();
            JFForm.Show();
            int i = dataGridView1.SelectedCells[0].RowIndex;
            int JFid = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
            string query = "select JFId, JFNameOrg, JFFullNameOrg, JFFullName, JFPhone, JFCargoCarrier from JuridicalFace where (JFId = " + JFid + ")";

            SqlDataReader data2 = Database.executeQuery(query);
            object[] fields2 = new object[6];
            data2.Read();
            data2.GetValues(fields2);
            data2.Close();
            this.Close();

            int JFId = int.Parse(fields2[0].ToString());
            string JFNameOrg = fields2[1].ToString(), JFFullNameOrg = fields2[2].ToString(), JFFullName = fields2[3].ToString();
            string JFPhone = fields2[4].ToString(), JFCargoCarrier = fields2[5].ToString();

            JFForm.fillData(JFId, JFNameOrg, JFFullNameOrg, JFFullName, JFPhone, JFCargoCarrier);

            this.Close();
           

        }

        private void cancelJFButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
