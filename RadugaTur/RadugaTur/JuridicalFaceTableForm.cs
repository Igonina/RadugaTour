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
    public partial class JuridicalFaceTableForm : Form
    {
        public JuridicalFaceTableForm()
        {
            InitializeComponent();
        }

        private void JuridicalFaceFormTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaDBDataSet5.JuridicalFace' table. You can move, or remove it, as needed.
            this.juridicalFaceTableAdapter.Fill(this.radugaDBDataSet5.JuridicalFace);
            // TODO: This line of code loads data into the 'radugaDBDataSet4.JuridicalFaceTable' table. You can move, or remove it, as needed.
            this.juridicalFaceTableTableAdapter3.Fill(this.radugaDBDataSet4.JuridicalFaceTable);
            // TODO: This line of code loads data into the 'radugaDBDataSet3.JuridicalFaceTable' table. You can move, or remove it, as needed.
            this.juridicalFaceTableTableAdapter2.Fill(this.radugaDBDataSet3.JuridicalFaceTable);
            // TODO: This line of code loads data into the 'radugaDBDataSet2.JuridicalFaceTable' table. You can move, or remove it, as needed.
            this.juridicalFaceTableTableAdapter1.Fill(this.radugaDBDataSet2.JuridicalFaceTable);
            // TODO: This line of code loads data into the 'radugaDBDataSet1.JuridicalFaceTable' table. You can move, or remove it, as needed.
            this.juridicalFaceTableTableAdapter.Fill(this.radugaDBDataSet1.JuridicalFaceTable);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.juridicalFaceTableTableAdapter3.FillBy(this.radugaDBDataSet4.JuridicalFaceTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
