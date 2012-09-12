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
    public partial class JFTableForm : Form
    {
        public JFTableForm()
        {
            InitializeComponent();
        }

        private void JFTableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaDBDataSet3.JuridicalFace' table. You can move, or remove it, as needed.
            this.juridicalFaceTableAdapter.Fill(this.radugaDBDataSet3.JuridicalFace);

        }
    }
}
