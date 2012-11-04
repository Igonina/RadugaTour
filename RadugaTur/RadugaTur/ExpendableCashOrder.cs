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
    public partial class ExpendableCashOrder : Form
    {
        public ExpendableCashOrder(System.Windows.Forms.TextBox input)
        {
            InitializeComponent();
            this.input = input;
        }
        TextBox input;

        private void saveCashExpButton_Click(object sender, EventArgs e)
        {
            string query = "insert into ExpendableOrder(useNumDoc, useDate, useSum, useNumApp) values (\'" +
                inputCashExpNumDoc.Text + "\', \'" +
                inputCashExpDate.Text + "\', \'" +
                inputCashExpSum.Text + "\', \'" +
                input.Text + "\')";
            Database.executeQuery(query).Close();
            this.Close();
        }

        private void DateCashExp_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputCashExpDate);
            monthCal.Show();
        }

        
    }
}
