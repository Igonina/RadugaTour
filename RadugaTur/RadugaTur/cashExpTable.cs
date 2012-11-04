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
    public partial class cashExpTable : Form
    {
        public cashExpTable(System.Windows.Forms.TextBox input)
        {
            InitializeComponent();
            this.input = input;
        }

        private void cashExpTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaDBDataSet18.ExpendableOrder' table. You can move, or remove it, as needed.
            this.expendableOrderTableAdapter.Fill(this.radugaDBDataSet18.ExpendableOrder);

        }
        TextBox input;
    }
}
