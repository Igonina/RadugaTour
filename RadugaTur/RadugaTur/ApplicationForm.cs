using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;




namespace RadugaTur
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }


        public void setFullName(string name)
        {
            inputAppFullName.Text = name;
        }

        public void setFullName2(string name2)
        {
            inputAppNameOrgOrPF.Text = name2;
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

        bool isUpdateModeEnabled = false;
        int updateAppId;
        internal void fillData(int AppId, string AppDate, int AppNumContract, string AppFullName, string AppNameOrgOrPF, string AppCountry, string AppWay, string AppStartTour, string AppNumDays, string AppNumNights, int AppNumPeople, int AppNumOldPeople, int AppNumChildren, string AppChildrensAge, string AppCategory, string AppNotes, int AppNumDaysHealth, string ArFood, string ArBase, string ArMoreTourists, string ArCost, string ArCostWithoutProcent, string ArSumPay, string ArDateSumPay, string ArDebt, string ArOtherMoney, string ArPhone, string ArRoute, string ArTransfer, string ArTourProgram, string ArVise, string ArTicket, string ArInsurance, string AppTipe, string AppAgentProcent)
        {
            this.inputAppDate.Text = AppDate;

            this.inputNumContract.Text = AppNumContract.ToString();
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
            this.inputNumDaysHealth.Text = AppNumDaysHealth.ToString();
            this.inputFood.Text = ArFood;
            this.inputArBase.Text = ArBase;
            this.inputAppTourists.Text = ArMoreTourists;
            this.inputAppCost.Text = ArCost;
            this.inputAppCostWithoutProcent.Text = ArCostWithoutProcent;
            this.inputAppSumPay.Text = ArSumPay;
            this.inputAppDateSumPay.Text = ArDateSumPay;
            this.inputAppDebt.Text = ArDebt;
            this.inputAppOtherMoney.Text = ArOtherMoney;
            this.inputAppPhone.Text = ArPhone;
            this.inputRoute.Text = ArRoute;
            this.inputTransfer.Text = ArTransfer;
            this.inputTourProgram.Text = ArTourProgram;
            this.inputVisa.Text = ArVise;
            this.inputTick.Text = ArTicket;
            this.inputIns.Text = ArInsurance;
            this.inputTipeApp.Text = AppTipe;
            this.inputAgentsProcent.Text = AppAgentProcent;



            updateAppId = AppId;
            isUpdateModeEnabled = true;
        }

         bool isUpdateModeEnabled2 = false;
        internal void fillData2(int tourId, int tourNumContract, string tourDateAcc, string tourSumAcc, string tourPayAcc, string tourOrderAcc, string tourDateRec, string tourSumRec, string tourPayRec, string tourOrderRec, string tourDateDebt, string tourSumDebt, string tourPayDebt, string tourOrderDebt, string forTourJurTick, string forTourDateTick, string forTourSumTick, string forTourPayTick, string forTourOrderTick, string forTourJurWay, string forTourDateWay, string forTourSumWay, string forTourPayWay, string forTourOrderWay, string forTourJurIns, string forTourDateIns, string forTourSumIns, string forTourPayIns, string forTourOrderIns) {
            this.dateAcc.Text = tourDateAcc.ToString();
            this.sumAcc.Text = tourSumAcc.ToString();
            this.payAcc.Text = tourPayAcc.ToString();
            this.orderAcc.Text = tourOrderAcc.ToString();
            this.dateRec.Text = tourDateRec.ToString();
            this.sumRec.Text = tourSumRec.ToString();
            this.payRec.Text = tourPayRec.ToString();
            this.orderRec.Text = tourOrderRec.ToString();
            this.DateDeb.Text = tourDateDebt.ToString();
            this.sumDeb.Text = tourSumDebt.ToString();
            this.payDeb.Text = tourPayDebt.ToString();
            this.orderDeb.Text = tourOrderDebt.ToString();
            this.jurTick.Text = forTourJurTick.ToString();
            this.dateTick.Text = forTourDateTick.ToString();
            this.sumTick.Text = forTourSumTick.ToString();
            this.payTick.Text = forTourPayTick.ToString();
            this.orderTick.Text = forTourOrderTick.ToString();
            this.jurWay.Text = forTourJurTick.ToString();
            this.dateWay.Text = forTourDateWay.ToString();
            this.sumWay.Text = forTourSumWay.ToString();
            this.payWay.Text = forTourPayWay.ToString();
            this.orderWay.Text = forTourOrderWay.ToString();
            this.jurIns.Text = forTourJurIns.ToString();
            this.dateIns.Text = forTourDateIns.ToString();
            this.sumIns.Text = forTourSumIns.ToString();
            this.payIns.Text = forTourPayIns.ToString();
            this.orderIns.Text = forTourOrderIns.ToString();

            
            isUpdateModeEnabled2 = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (updateAppId == 0)
            {
                string query = "insert into FullApplication(AppDate, AppNumContract, AppFullName, AppNameOrgOrPF, AppCountry, AppWay, AppStartTour, AppNumDays, AppNumNights, AppNumPeople,AppNumOldPeople, AppNumChildren, AppChildrensAge, AppCategory, AppNotes, AppNumDaysHealth, ArFood, ArBase, ArMoreTourists, ArCost, ArCostWithoutProcent, ArSumPay, ArDateSumPay, ArDebt, ArOtherMoney,  ArPhone, ArRoute, ArTransfer, ArTourProgram, ArVise, ArTicket, ArInsurance, AppTipe, AppAgentProcent) values (\'" +
                    inputAppDate.Text + "\', \'" +
                    inputNumContract.Text + "\', \'" +
                    inputAppFullName.Text + "\',\'" +
                    inputAppNameOrgOrPF.Text + "\',\'" +
                    inputAppCountry.Text + "\',\'" +
                    inputAppWay.Text + "\',\'" +
                    inputAppStartTour.Text + "\',\'" +
                    inputNumDays.Text + "\',\'" +
                    inputNumNights.Text + "\',\'" +
                    inputAppNumPeople.Text + "\',\'" +
                    inputAppOldPeople.Text + "\',\'" +
                    inputAppNumChildren.Text + "\',\'" +
                    inputAppChildAge.Text + "\',\'" +
                    inputAppNumberAndCategory.Text + "\',\'" +
                    inputAppNotes.Text + "\',\'" +
                    inputNumDaysHealth.Text + "\', \'" +
                    inputFood.Text + "\',\'" +
                    inputArBase.Text + "\',\'" +
                    inputAppTourists.Text + "\',\'" +
                    inputAppCost.Text + "\',\'" +
                    inputAppCostWithoutProcent.Text + "\',\'" +
                    inputAppSumPay.Text + "\' , \'" +
                    inputAppDateSumPay.Text + "\',\'" +
                    inputAppDebt.Text + "\',\'" +
                    inputAppOtherMoney.Text + "\',\'" +
                    inputAppPhone.Text + "\',\'" +
                    inputRoute.Text + "\',\'" +
                    inputTransfer.Text + "\',\'" +
                    inputTourProgram.Text + "\',\'" +
                    inputVisa.Text + "\',\'" +
                    inputTick.Text + "\',\'" +
                    inputIns.Text + "\',\'" +
                    inputTipeApp.Text + "\',\'" +
                    inputAgentsProcent.Text + "\')";
                string query2 = "insert into TouristsPayment(tourNumContract, tourDateAcc, tourSumAcc, tourPayAcc, tourOrderAcc, tourDateRec, tourSumRec, tourPayRec, tourOrderRec, tourDateDebt, tourSumDebt, tourPayDebt, tourOrderDebt, forTourJurTick, forTourDateTick, forTourSumTick, forTourPayTick, forTourOrderTick, forTourJurWay, forTourDateWay, forTourSumWay, forTourPayWay, forTourOrderWay, forTourJurIns, forTourDateIns, forTourSumIns, forTourPayIns, forTourOrderIns) values (\'" +
                inputNumContract.Text + "\', \'" +
                dateAcc.Text + "\', \'" +
                sumAcc.Text + "\', \'" +
                payAcc.Text + "\', \'" +
                orderAcc.Text + "\', \'" +
                dateRec.Text + "\', \'" +
                sumRec.Text + "\', \'" +
                payRec.Text + "\', \'" +
                orderRec.Text + "\', \'" +
                DateDeb.Text + "\', \'" +
                sumDeb.Text + "\', \'" +
                payDeb.Text + "\', \'" +
                orderDeb.Text + "\', \'" +
                jurTick.Text + "\', \'" +
                dateTick.Text + "\', \'" +
                sumTick.Text + "\', \'" +
                payTick.Text + "\', \'" +
                orderTick.Text + "\', \'" +
                jurWay.Text + "\', \'" +
                dateWay.Text + "\', \'" +
                sumWay.Text + "\', \'" +
                payWay.Text + "\', \'" +
                orderWay.Text + "\', \'" +
                jurIns.Text + "\', \'" +
                dateIns.Text + "\', \'" +
                sumIns.Text + "\', \'" +
                payIns.Text + "\', \'" +
                orderIns.Text + "\')";
                Database.executeQuery(query).Close();
                Database.executeQuery(query2).Close();
                ApplicationTableForm appTableForm = new ApplicationTableForm();
                appTableForm.Show();
                this.Close();
                this.Close();
            }
            else {
                string query3 = "update FullApplication set AppDate  = \'" + inputAppDate.Text + "\',  AppNumContract = \'" + inputNumContract.Text + "\',  AppFullName = \'" + inputAppFullName.Text + "\',  AppNameOrgOrPF = \'" + inputAppNameOrgOrPF.Text + "\',  AppCountry = \'" + inputAppCountry.Text + "\',  AppWay = \'" + inputAppWay.Text + "\',  AppStartTour = \'" + inputAppStartTour.Text + "\',  AppNumDays = \'" + inputNumDays.Text + "\',  AppNumNights = \'" + inputNumNights.Text + "\',  AppNumPeople = \'" + inputAppNumPeople.Text + "\',   AppNumOldPeople = \'" + inputAppOldPeople.Text + "\',  AppNumChildren = \'" + inputAppNumChildren.Text + "\',  AppChildrensAge = \'" + inputAppChildAge.Text + "\',  AppCategory = \'" + inputAppNumberAndCategory.Text + "\',  AppNotes = \'" + inputAppNotes.Text + "\',  AppNumDaysHealth = \'" + inputNumDaysHealth.Text + "\',  ArFood = \'" + inputFood.Text + "\',  ArBase = \'" + inputArBase.Text + "\',  ArMoreTourists = \'" + inputAppTourists.Text + "\',  ArCost = \'" + inputAppCost.Text + "\',  ArCostWithoutProcent = \'" + inputAppCostWithoutProcent.Text + "\',  ArSumPay =   \'" + inputAppSumPay.Text + "\',  ArDateSumPay = \'" + inputAppDateSumPay.Text + "\',  ArDebt  = \'" + inputAppDebt.Text + "\',  ArOtherMoney = \'" + inputAppOtherMoney.Text + "\',   ArPhone = \'" + inputAppPhone.Text + "\',  ArRoute = \'" + inputRoute.Text + "\',  ArTransfer = \'" + inputTransfer.Text + "\',  ArTourProgram = \'" + inputTourProgram.Text + "\',  ArVise = \'" + inputVisa.Text + "\',  ArTicket = \'" + inputTick.Text + "\',  ArInsurance = \'" + inputIns.Text + "\',  AppTipe = \'" + inputTipeApp.Text + "\',  AppAgentProcent = \'" + inputAgentsProcent.Text + "\' where (AppId = " + updateAppId + ")";
                string query4 = "update TouristsPayment set tourDateAcc = \'" + dateAcc.Text + "\', tourSumAcc = \'" + sumAcc.Text + "\', tourPayAcc = \'" + payAcc.Text + "\', tourOrderAcc = \'" + orderAcc.Text + "\', tourDateRec = \'" + dateRec.Text + "\', tourSumRec = \'" + sumRec.Text + "\', tourPayRec = \'" + payRec.Text + "\', tourOrderRec = \'" + orderRec.Text + "\', tourDateDebt = \'" + DateDeb.Text + "\', tourSumDebt = \'" + sumDeb.Text + "\', tourPayDebt = \'" + payDeb.Text + "\', tourOrderDebt = \'" + orderDeb.Text + "\', forTourJurTick = \'" + jurTick.Text + "\', forTourDateTick = \'" + dateTick.Text + "\', forTourSumTick = \'" + sumTick.Text + "\', forTourPayTick = \'" + payTick.Text + "\', forTourOrderTick = \'" + orderTick.Text + "\', forTourJurWay = \'" + jurWay.Text + "\', forTourDateWay = \'" + dateWay.Text + "\', forTourSumWay = \'" + sumWay.Text + "\', forTourPayWay = \'" + payWay.Text + "\', forTourOrderWay = \'" + orderWay.Text + "\', forTourJurIns = \'" + jurIns.Text + "\', forTourDateIns = \'" + dateIns.Text + "\', forTourSumIns = \'" + sumIns.Text + "\', forTourPayIns = \'" + payIns.Text + "\', forTourOrderIns = \'" + orderIns.Text + "\' where (tourNumContract = " + inputNumContract.Text + ")";
                Database.executeQuery(query3).Close();
                Database.executeQuery(query4).Close();
                this.Close();
            }

            
          
        }

                 
        private void AppStartTourButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppStartTour);
            monthCal.ShowDialog();
        }


        private void AppSumDatePay_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppDateSumPay);
            monthCal.ShowDialog();
        }

        

        private void AppDateButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppDate);
            monthCal.ShowDialog();
        }
       
        
       

        bool isUpdateModeEnabled3 = false;
        int updatePFId;
        internal void fillData3(int PFId, string PFFullRussName) {
            isUpdateModeEnabled3 = true;
            updatePFId = PFId;
        }

        bool isUpdateModeEnabled4 = false;
        int updateJFId;
        internal void fillData4(int JFId, string JFFullNameOrg)
        {
            this.inputAppNameOrgOrPF.Text = JFFullNameOrg.ToString();



            isUpdateModeEnabled4 = true;
            updateJFId = JFId;
        }

        
       
      

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Documents documents = new Documents(inputAppDate, inputNumContract, inputAppFullName, inputAppNameOrgOrPF, inputAppCountry, inputAppWay, inputAppStartTour, inputNumDays, inputNumNights, inputAppNumPeople,
                inputAppOldPeople, inputAppNumChildren, inputAppChildAge, inputAppNumberAndCategory, inputAppNotes, inputNumDaysHealth, inputFood, inputArBase, inputAppTourists, inputAppCost,
                inputAppCostWithoutProcent, inputAppSumPay, inputAppDateSumPay, inputAppDebt, inputAppOtherMoney, inputAppPhone, inputRoute, inputTransfer, inputTourProgram, inputVisa,
                inputTick, inputIns, inputTipeApp, inputAgentsProcent, dateAcc, sumAcc, payAcc, orderAcc, dateRec, sumRec, payRec, orderRec, DateDeb, sumDeb, payDeb, orderDeb, jurTick, dateTick, sumTick, payTick,
                orderTick, jurWay, dateWay, sumWay, payWay, orderWay, jurIns, dateIns, sumIns, payIns, orderIns);
            documents.ShowDialog();
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            PFTableForm pfTable = new PFTableForm(this);
            pfTable.ShowDialog();
        }

        private void addOrgbutton_Click(object sender, EventArgs e)
        {
            JFTableForm jfTable = new JFTableForm(this);
            jfTable.ShowDialog();
        }

        private void addTouristsbutton_Click(object sender, EventArgs e)
        {
            PFTableForm pfTable = new PFTableForm(this);
            pfTable.Show();
        }
        string Name;

        internal void addFullName(string name)
        {
            inputAppFullName.Text += (inputAppFullName.Text == "" ? "" : "; ") + name;
        }

        
    } 
}
