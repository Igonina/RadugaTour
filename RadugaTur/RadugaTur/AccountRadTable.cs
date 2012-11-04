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
    public partial class AccountRadTable : Form
    {
        public AccountRadTable(System.Windows.Forms.TextBox numContract)
        {
            InitializeComponent();
            this.numContract = numContract;
        }

        private void AccountRadTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaDBDataSet15.AccountRad' table. You can move, or remove it, as needed.
            this.accountRadTableAdapter.Fill(this.radugaDBDataSet15.AccountRad);

        }
        TextBox numContract;
    }
}
