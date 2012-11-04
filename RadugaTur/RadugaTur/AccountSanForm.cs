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
    public partial class AccountSanForm : Form
    {
        public AccountSanForm(System.Windows.Forms.TextBox numContract)
        {
            InitializeComponent();
            this.numContract = numContract;
        }

        private void AddAccSanButton_Click(object sender, EventArgs e)
        {
            //inputNumContract1.Text = numContract.Text;
            string query = "insert into AccountSan(AccAccount, AccDate, AccSum, AccNumContract) values (\'" +
                inputAccountSan.Text + "\', \'" +
                inputDateAccountSan.Text + "\', \'" +
                inputSumAccountSan.Text + "\', \'" +
                numContract.Text +"\')";
            Database.executeQuery(query).Close();
            this.Close();
            
        
        }
        TextBox numContract;

        private void button1_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputDateAccountSan);
            monthCal.Show();
        }
             
    }
}
