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
            string query = "insert into FullApplication(AppDate, AppNumContract, AppFullName, AppNameOrgOrPF, AppCountry, AppWay, AppStartTour, AppNumDays, AppNumNights, AppNumPeople, AppNumOldPeople, AppNumChildren, AppChildrensAge, AppCategory, AppNotes,ArNumDaysHealth, ArFood, ArBase, ArMoreTourists, ArCost, ArCostWithoutProcent, ArAccountNumberSan, ArDateAccNumSan, ArAccountNumberRad, ArDateAccNumRad, ArMoneyOrg, ArDateMoneyOrg, ArPaySanRad, ArDatePaySanRad, ArDebt, ArOtherMoney, ArSumPay, ArDateSunPay,  ArPhone) values (\'" +
                inputAppDate.Text + "\', \'" +
                inputNumContract.Text + "\', \'" +
                inputAppFullName.Text + "\',\'" +
                inputAppNameOrgOrPF.Text + "\',\'"
                + inputAppCountry.Text + "\',\'" +
                inputAppWay.Text + "\',\'" +
                inputAppStartTour.Text + "\',\'" +
                inputNumDays.Text + "\',\'" +
                inputNumNights.Text + "\',\'" +
                inputAppNumPeople.Text + "\',\'" +
                inputAppNumChildren.Text + "\',\'" +
                inputAppChildAge.Text+ "\',\'" +
                checkBox1.Text+ "\', \'"+
                inputAppNumberAndCategory.Text + "\',\'" +
                inputAppNotes.Text + "\',\'"+
                inputNumDaysHealth.Text + "\', \'" +
                inputFood.Text + "\',\'" +
                inputArBase.Text + "\',\'" +
                inputAppTourists.Text + "\',\'" +
                inputAppCost.Text + "\',\'" +
                inputAppCostWithoutProcent.Text + "\',\'" +
                inputAppAcountNumber.Text +"\',\'"+
                inputAppDateAccountNumber.Text + "\',\'" +
                inputAppAccNumRaduga.Text + "\',\'" +
                inputAppDateAcountNumRad.Text + "\',\'" +
                inputAppMoneyOrg.Text +"\',\'"+
                inputAppDateMoneyOrg.Text + "\',\'" +
                inputAppPaySanRad.Text+ "\',\'" +
                inputAppDatePaySanRad.Text + "\',\'" +
                inputAppDebt.Text + "\',\'" +
                inputAppOtherMoney.Text + "\',\'" +
                inputAppSumPay.Text+ "\' , \'"+
                inputAppDateSumPay.Text + "\',\'" +
                inputAppPhone.Text +"\')";
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

        private void AppDateButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppDate);
            monthCal.Show();
        }





        bool isUpdateModeEnabled = false;
        int updateAppId;
        internal void fillData(int AppId, string AppDate, string AppNumContract, string AppFullName, string AppNameOrgOrPF, string AppCountry, string AppWay, string AppStartTour, string AppNumDays, string AppNumNights, int AppNumPeople, int AppNumOldPeople, int AppNumChildren, string AppChildrensAge,  string AppCategory, string AppNotes, int ArNumDaysHealth, string ArFood, string ArBase, string ArMoreTourists, string ArCost, string ArCostWithoutProcent, string ArAccountNumberSan, string ArAccountNumberRad, string ArMoneyOrg, string ArDateMoneyOrg, string ArPaySanRad, string ArDatePaySanRad, string ArDebt, string ArOtherMoney, string ArSumPay, string ArDateSunPay, string ArPhone)
        {
            this.inputAppDate.Text = AppDate;
            
            this.inputNumContract.Text = AppNumContract;
            this.inputAppFullName.Text = AppFullName;
            this.inputAppNameOrgOrPF.Text = AppNameOrgOrPF;
            this.inputAppCountry.Text = AppCountry;
            this.inputAppWay.Text = AppWay;
            this.inputAppStartTour.Text = AppStartTour;
            this.inputNumDays.Text = AppNumDays;
            this.inputNumNights.Text = AppNumNights;
            this.inputAppNumPeople.Text = AppNumPeople.ToString();
            this.inputAppOldPeople.Text = AppNumOldPeople.ToString();
            this.inputAppNumChildren.Text = AppNumChildren.ToString();
            this.inputAppChildAge.Text = AppChildrensAge;
            this.inputAppNumberAndCategory.Text = AppCategory;
            this.inputAppNotes.Text = AppNotes;
            this.inputNumDaysHealth.Text = ArNumDaysHealth.ToString();
            this.inputFood.Text = ArFood;
            this.inputArBase.Text = ArBase;
            this.inputAppTourists.Text = ArMoreTourists;
            this.inputAppCost.Text = ArCost;
            this.inputAppCostWithoutProcent.Text = ArCostWithoutProcent;
            this.inputAppAcountNumber.Text = ArAccountNumberSan;
            this.inputAppAccNumRaduga.Text = ArAccountNumberRad;
            this.inputAppMoneyOrg.Text = ArMoneyOrg;
            this.inputAppDateMoneyOrg.Text = ArDateMoneyOrg;
            this.inputAppPaySanRad.Text = ArPaySanRad;
            this.inputAppDatePaySanRad.Text = ArDatePaySanRad;
            this.inputAppDebt.Text = ArDebt;
            this.inputAppOtherMoney.Text = ArOtherMoney;
            this.inputAppSumPay.Text = ArSumPay;
            this.inputAppDateSumPay.Text = ArDateSunPay;
            this.inputAppPhone.Text = ArPhone;


            updateAppId = AppId;
            isUpdateModeEnabled = true;
        }
    } 
   }
