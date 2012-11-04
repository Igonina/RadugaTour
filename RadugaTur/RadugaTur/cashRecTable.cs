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
    public partial class cashRecTable : Form
    {
        public cashRecTable(System.Windows.Forms.TextBox input)
        {
            InitializeComponent();
            this.input = input;
        }

        private void cashRecTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaDBDataSet17.CashReceiptes' table. You can move, or remove it, as needed.
            this.cashReceiptesTableAdapter.Fill(this.radugaDBDataSet17.CashReceiptes);

        }
        TextBox input;
    }
}
