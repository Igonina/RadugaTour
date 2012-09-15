using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RadugaTur
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void inputCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void inputDataApp_TextChanged(object sender, EventArgs e)
        {
            MonthCalendar date = new MonthCalendar();
            date.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string query = "insert into Application(AppDate, AppNumContract, AppFullName, AppNameOrgOrPF, AppCountry, AppWay, AppStartTour, AppEndTour, AppNumDays, AppNumNights, AppNumPeople, AppNumOldPeople, AppNumChildren, AppCategory, AppPhone, AppNotes ) values (\'" +
                dateTimePickerApplicationDate.Text + "\', \'" +
                inputAppNumberContract.Text + "\', \'" +
                inputAppFullName.Text + "\',\'" +
                inputAppNameOrgOrPF.Text + "\',\'"
                + inputAppCountry.Text + "\',\'" +
                inputAppWay.Text + "\',\'" +
                inputAppStartTour.Text + "\',\'" +
                inputAppEndTour.Text + "\',\'" +
                inputNumDays.Text + "\',\'" +
                inputNumNights.Text + "\',\'" +
                inputAppNumPeople.Text + "\',\'" +
                inputAppOldPeople.Text + "\', \'"+
                inputAppNumChildren.Text + "\',\'" +
                inputAppNumberAndCategory.Text + "\',\'" +
                inputAppPhone.Text + "\',\'" +
                inputAppNotes.Text + "\')";
            Database.executeQuery(query);
            ApplicationTableForm appTableForm = new ApplicationTableForm();
            appTableForm.Show();
            this.Close();
        }

        private void AppStartTourButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppStartTour);
            monthCal.Show();
        }

        private void AppEndButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppEndTour);
            monthCal.Show();
        }

        private void AppDateContractButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppDateContract);
            monthCal.Show();
        }

        private void AppSumDatePay_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppDateSumPay);
            monthCal.Show();
        }

        private void AppDateAccountNumberButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppDateAccountNumber);
            monthCal.Show();
        }

        private void AppDateAccountNumRadButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppDateAcountNumRad);
            monthCal.Show();
        }

        private void AppMoneyOrgButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppDateMoneyOrg);
            monthCal.Show();
        }

        private void AppPaySanRadButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppDatePaySanRad);
            monthCal.Show();
        }

        

       
    } 
   }
