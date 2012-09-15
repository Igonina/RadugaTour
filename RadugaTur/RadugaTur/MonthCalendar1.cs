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
    public partial class MonthCalendar1 : Form
    {
        public MonthCalendar1(System.Windows.Forms.TextBox input)
        {
            InitializeComponent();
            this.input = input;
        }


        private void MonthCalButton_Click(object sender, EventArgs e)
        {
            
            DateTime dateTime   = this.monthCalendar2.SelectionStart;
            string date         = dateTime.Day.ToString() +"."+ dateTime.Month.ToString()+"." + dateTime.Year.ToString();
            input.Text          = date;           
        }
        TextBox input;
        

    }
}
