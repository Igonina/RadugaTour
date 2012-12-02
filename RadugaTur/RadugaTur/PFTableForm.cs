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
    public partial class PFTableForm : Form
    {
        public PFTableForm(Form parent)
        {
            InitializeComponent();
            if (parent.GetType() == typeof(ApplicationForm))
            {
                this.parent = parent as ApplicationForm;
            }
        }
        private ApplicationForm parent = null;
        private void PFTableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_1gb_rrrrrDataSet3.PhisicalFace' table. You can move, or remove it, as needed.
            this.phisicalFaceTableAdapter3.Fill(this._1gb_rrrrrDataSet3.PhisicalFace);
            /*string MyString = "Database=db_radugatour;Data Source=mysql56.1gb.ru;Database=db_radugatour;User id=db_radugatour;Password=82f6b51c345;";
            SqlConnection connection = new SqlConnection(MyString);
            connection.Open();
            try
            {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select PFId, PFFullRussName, PFFullEngName, PFBirthday, PFNumAndSerRussPassport, PFDateGetRussPassport, PFOrgGetRussPassport, PFNumAndSerForeignPassport, PFDateGetForeignPassport, PFDateEndForeignPassport, PFOrgGetForeignPassport, PFBirthPlace, PFPhone from PhisicalFace";
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                PhisicalFaceView.DataSource = ds.Tables[0].DefaultView;
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

            // TODO: This line of code loads data into the 'radugaDBDataSet22.PhisicalFace' table. You can move, or remove it, as needed.
            this.phisicalFaceTableAdapter2.Fill(this.radugaDBDataSet22.PhisicalFace);
            // TODO: This line of code loads data into the 'radugaDBDataSet20.PhisicalFace' table. You can move, or remove it, as needed.
            this.phisicalFaceTableAdapter1.Fill(this.radugaDBDataSet20.PhisicalFace);
            // TODO: This line of code loads data into the 'radugaDBDataSet4.PhisicalFace' table. You can move, or remove it, as needed.
            this.phisicalFaceTableAdapter.Fill(this.radugaDBDataSet4.PhisicalFace);
            
        }

        

        private void addPFbutton_Click(object sender, EventArgs e)
        {
            FisicalFaceForm fisFaceForm = new FisicalFaceForm();
            fisFaceForm.ShowDialog();
            this.Close();
        }

        private void cancelPFbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


          private void PhisicalFaceView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
          {
              if (parent != null)
              {

                  int i = PhisicalFaceView.SelectedCells[0].RowIndex;
                  int PFid = int.Parse(PhisicalFaceView.Rows[i].Cells[0].Value.ToString());
                  string query1 = "select PFId, PFFullRussName from PhisicalFace where (PFId = " + PFid + ")";

                  SqlDataReader data3 = Database.executeQuery(query1);
                  object[] fields3 = new object[2];
                  data3.Read();
                  data3.GetValues(fields3);
                  data3.Close();

                  int PFId = int.Parse(fields3[0].ToString());
                  string PFFullRussName = fields3[1].ToString();
                  //parent.setFullName(PFFullRussName);
                  parent.addFullName(PFFullRussName);
                  parent.fillData3(PFId, PFFullRussName);
              }

          }

          private void changePFbutton_Click(object sender, EventArgs e)
          {
              FisicalFaceForm PFForm = new FisicalFaceForm();
              
              int i = PhisicalFaceView.SelectedCells[0].RowIndex;
              int PFid = int.Parse(PhisicalFaceView.Rows[i].Cells[0].Value.ToString());
              string query = "select PFId, PFFullRussName, PFFullEngName, PFBirthday, PFNumAndSerRussPassport, PFDateGetRussPassport, PFOrgGetRussPassport, PFNumAndSerForeignPassport, PFDateGetForeignPassport, PFDateEndForeignPassport, PFOrgGetForeignPassport, PFBirthPlace, PFPhone from PhisicalFace where (PFId = " + PFid + ")";

              SqlDataReader data = Database.executeQuery(query);
              object[] fields = new object[13];
              data.Read();
              data.GetValues(fields);
              data.Close();
              this.Close();

              int PFId = int.Parse(fields[0].ToString());
              string PFFullRussName = fields[1].ToString(), PFFullEngName = fields[2].ToString(), PFBirthday = fields[3].ToString();
              string PFNumAndSerRussPassport = fields[4].ToString(), PFDateGetRussPassport = fields[5].ToString(), PFOrgGetRussPassport = fields[6].ToString();
              string PFNumAndSerForeignPassport = fields[7].ToString(), PFDateGetForeignPassport = fields[8].ToString(), PFDateEndForeignPassport = fields[9].ToString();
              string PFOrgGetForeignPassport = fields[10].ToString(), PFBirthPlace = fields[11].ToString(), PFPhone = fields[12].ToString();
              PFForm.fillData( PFId, PFFullRussName, PFFullEngName, PFBirthday, PFNumAndSerRussPassport, PFDateGetRussPassport, PFOrgGetRussPassport, PFNumAndSerForeignPassport, PFDateGetForeignPassport, PFDateEndForeignPassport, PFOrgGetForeignPassport, PFBirthPlace, PFPhone);
              PFForm.ShowDialog();
          }

         
         

       




    }
}
