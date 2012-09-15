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
    public partial class PFTableForm : Form
    {
        public PFTableForm()
        {
            InitializeComponent();
        }

        private void PFTableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaDBDataSet4.PhisicalFace' table. You can move, or remove it, as needed.
            this.phisicalFaceTableAdapter.Fill(this.radugaDBDataSet4.PhisicalFace);

        }
    }
}
