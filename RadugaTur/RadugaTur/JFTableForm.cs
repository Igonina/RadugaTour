using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

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
            // TODO: This line of code loads data into the '_1gb_rrrrrDataSet7.JuridicalFace' table. You can move, or remove it, as needed.
            this.juridicalFaceTableAdapter3.Fill(this._1gb_rrrrrDataSet7.JuridicalFace);
            // TODO: This line of code loads data into the '_1gb_rrrrrDataSet4.JuridicalFace' table. You can move, or remove it, as needed.
            this.juridicalFaceTableAdapter2.Fill(this._1gb_rrrrrDataSet4.JuridicalFace);
            // TODO: This line of code loads data into the '_1gb_rrrrrDataSet1.JuridicalFace' table. You can move, or remove it, as needed.
            this.juridicalFaceTableAdapter1.Fill(this._1gb_rrrrrDataSet1.JuridicalFace);
            /*string MyString = "Data Source=mysql56.1gb.ru;Database=db_radugatour;Uid=db_radugatour;Pwd=82f6b51c345;";
            SqlConnection connection = new SqlConnection(MyString);
            connection.Open();
            try
            {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select JFId, JFNameOrg, JFFullNameOrg, JFFullName, JFPhone, JFCargoCarrier from JuridicalFace";
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }*/

          

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
                  this.Close();
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
            JFForm.ShowDialog();

            this.Close();
           

        }

        private void cancelJFButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
