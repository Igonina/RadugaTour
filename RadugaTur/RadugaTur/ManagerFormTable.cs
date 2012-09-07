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
    public partial class ManagerFormTable : Form
    {
        public ManagerFormTable()
        {
            InitializeComponent();
        }

        private void ManagerTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaDBDataSet.ManagerTable' table. You can move, or remove it, as needed.
            this.managerTableTableAdapter.Fill(this.radugaDBDataSet.ManagerTable);
            // TODO: This line of code loads data into the 'radugaTourDatabaseDataSet3.ManagerTable1' table. You can move, or remove it, as needed.
            this.managerTable1TableAdapter1.Fill(this.radugaTourDatabaseDataSet3.ManagerTable1);
            // TODO: This line of code loads data into the 'radugaTourDatabaseDataSet1.ManagerTable1' table. You can move, or remove it, as needed.
            this.managerTable1TableAdapter.Fill(this.radugaTourDatabaseDataSet1.ManagerTable1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
