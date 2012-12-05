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
    public partial class ManagerFormTable : Form
    {
        public ManagerFormTable()
        {
            InitializeComponent();
        }

        private void ManagerTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_1gb_rrrrrDataSet8.Hashing' table. You can move, or remove it, as needed.
            this.hashingTableAdapter2.Fill(this._1gb_rrrrrDataSet8.Hashing);
            // TODO: This line of code loads data into the '_1gb_rrrrrDataSet2.Hashing' table. You can move, or remove it, as needed.
            this.hashingTableAdapter1.Fill(this._1gb_rrrrrDataSet2.Hashing);
            /*string MyString = "Database=db_radugatour;Data Source=mysql56.1gb.ru;Database=db_radugatour;User id=db_radugatour;Password=82f6b51c345;";
            SqlConnection connection = new SqlConnection(MyString);
            connection.Open();
            try
            {

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select hashId, hashName, hashLogin, hash, hashName2, hashPosition from Hashing";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
