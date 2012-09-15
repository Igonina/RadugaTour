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
    public partial class ArchiveTableForm : Form
    {
        public ArchiveTableForm()
        {
            InitializeComponent();
        }

        private void ArchiveTableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaDBDataSet11.Archive' table. You can move, or remove it, as needed.
            this.archiveTableAdapter.Fill(this.radugaDBDataSet11.Archive);
          
           

        }
    }
}
