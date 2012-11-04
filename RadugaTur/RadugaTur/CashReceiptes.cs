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
    public partial class CashReceiptes : Form
    {
        public CashReceiptes(System.Windows.Forms.TextBox input)
        {
            InitializeComponent();
            this.input = input;
        }
        TextBox input;

        private void saveCashRecButton_Click(object sender, EventArgs e)
        {
            string query = "insert into CashReceiptes(cashNumberDoc, cashData, cashSum, cashNumApp) values (\'" +
                inputCashRecNumDoc.Text + "\', \'" +
                inputCashRecDate.Text + "\', \'" +
                inputCashRecSum.Text + "\', \'" +
                input.Text + "\')";
            Database.executeQuery(query).Close();
            this.Close();
        }

        private void DateCashExp_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputCashRecDate);
            monthCal.Show();
        }
    }
}
