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
    public partial class AccountRadForm : Form
    {
        public AccountRadForm(System.Windows.Forms.TextBox numContract)
        {
            InitializeComponent();
            this.numContract = numContract;
        }

        private void AddAccRadButton_Click(object sender, EventArgs e)
        {
            string query = "insert into AccountRad(AccRadAccount, AccRadDate, AccRadSum, AccRadAccountSan, AccRadNumContract) values (\'" +
               inputAccountRad.Text + "\', \'" +
               inputDateAccountRad.Text + "\', \'" +
               inputSumAccountRad.Text + "\', \'" +
               inputAccountSan2.Text + "\', \'" +
               numContract.Text + "\')";
            Database.executeQuery(query).Close();
            this.Close();

        }
        TextBox numContract;

        private void DateAccountRadButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputDateAccountRad);
            monthCal.Show();
        }
    }
}
