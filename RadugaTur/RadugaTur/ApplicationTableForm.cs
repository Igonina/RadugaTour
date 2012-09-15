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
    public partial class ApplicationTableForm : Form
    {
        public ApplicationTableForm()
        {
            InitializeComponent();
        }

        private void ApplicationTableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaDBDataSet7.Application' table. You can move, or remove it, as needed.
            this.applicationTableAdapter1.Fill(this.radugaDBDataSet7.Application);

        }
    }
}
