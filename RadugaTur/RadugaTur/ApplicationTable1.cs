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
    public partial class ApplicationTable1 : Form
    {
        public ApplicationTable1()
        {
            InitializeComponent();
        }

        private void ApplicationTableGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void ApplicationTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaTourDatabaseDataSet4.ApplicationTable1' table. You can move, or remove it, as needed.
            this.applicationTable1TableAdapter1.Fill(this.radugaTourDatabaseDataSet4.ApplicationTable1);
            // TODO: This line of code loads data into the 'radugaTourDatabaseDataSet2.ApplicationTable1' table. You can move, or remove it, as needed.
            this.applicationTable1TableAdapter.Fill(this.radugaTourDatabaseDataSet2.ApplicationTable1);
            // TODO: This line of code loads data into the 'radugaTourDatabaseDataSet1.ApplicationTable' table. You can move, or remove it, as needed.
           // this.applicationTableTableAdapter.Fill(this.radugaTourDatabaseDataSet1.ApplicationTable);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
