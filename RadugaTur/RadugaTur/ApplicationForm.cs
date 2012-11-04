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
            string query = "insert into FullApplication(AppDate, AppNumContract, AppFullName, AppNameOrgOrPF, AppCountry, AppWay, AppStartTour, AppNumDays, AppNumNights, AppNumPeople,AppNumOldPeople, AppNumChildren, AppChildrensAge, AppCategory, AppNotes,ArNumDaysHealth, ArFood, ArBase, ArMoreTourists, ArCost, ArCostWithoutProcent, ArDebt, ArOtherMoney, ArSumPay, ArDateSunPay,  ArPhone) values (\'" +
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
                inputAppOldPeople.Text + "\',\'"+
                inputAppNumChildren.Text + "\',\'" +
                inputAppChildAge.Text + "\',\'" +
                inputAppNumberAndCategory.Text + "\',\'" +
                inputAppNotes.Text + "\',\'"+
                inputNumDaysHealth.Text + "\', \'" +
                inputFood.Text + "\',\'" +
                inputArBase.Text + "\',\'" +
                inputAppTourists.Text + "\',\'" +
                inputAppCost.Text + "\',\'" +
                inputAppCostWithoutProcent.Text + "\',\'" +
                inputAppDebt.Text + "\',\'" +
                inputAppOtherMoney.Text + "\',\'" +
                inputAppSumPay.Text+ "\' , \'"+
                inputAppDateSumPay.Text + "\',\'" +
                inputAppPhone.Text +"\')";
            Database.executeQuery(query).Close();
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

        

        private void AppDateButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputAppDate);
            monthCal.Show();
        }





        bool isUpdateModeEnabled = false;
        int updateAppId;
        internal void fillData(int AppId, string AppDate, int AppNumContract, string AppFullName, string AppNameOrgOrPF, string AppCountry, string AppWay, string AppStartTour, string AppNumDays, string AppNumNights, int AppNumPeople, int AppNumOldPeople, int AppNumChildren, string AppChildrensAge,  string AppCategory, string AppNotes, int ArNumDaysHealth, string ArFood, string ArBase, string ArMoreTourists, string ArCost, string ArCostWithoutProcent, string ArDebt, string ArOtherMoney, string ArSumPay, string ArDateSunPay, string ArPhone)
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
            this.inputNumDaysHealth.Text = ArNumDaysHealth.ToString();
            this.inputFood.Text = ArFood;
            this.inputArBase.Text = ArBase;
            this.inputAppTourists.Text = ArMoreTourists;
            this.inputAppCost.Text = ArCost;
            this.inputAppCostWithoutProcent.Text = ArCostWithoutProcent;
            this.inputAppDebt.Text = ArDebt;
            this.inputAppOtherMoney.Text = ArOtherMoney;
            this.inputAppSumPay.Text = ArSumPay;
            this.inputAppDateSumPay.Text = ArDateSunPay;
            this.inputAppPhone.Text = ArPhone;


            updateAppId = AppId;
            isUpdateModeEnabled = true;
        }
        	// функция поиска и замены строк в документе ворд по заранее вписанным в него шаблонам
	public void wordSearchReplace(string search, string replace, ref Microsoft.Office.Interop.Word.Application wordApp, int how)
	{
	    // обьект диапазона, собственно какая-то часть документа
	    Microsoft.Office.Interop.Word.Range myRange;
	    // обьект пустого параметра
	    object wMissing = Type.Missing;
	 
	    // строка вида @@adress, которую будем искать в документе ворд
	    object textToFind = search;
	    // чем будем заменять строку шаблона
	    object replaceWith = replace;
	 
	    //типа поиска и замены
	    object replaceType;
	    if (how == 0)
	    // заменять все найденные вхождения
	        replaceType = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
	    else
	        // заменять только первое найденное вхождение
	        replaceType = Microsoft.Office.Interop.Word.WdReplace.wdReplaceOne;
	 
	    // обходим все разделы документа
	    for (int i = 1; i <= wordApp.ActiveDocument.Sections.Count; i++)
	    {
	        // берем всю секцию диапазоном
	        myRange = wordApp.ActiveDocument.Sections[i].Range;
	 
	        // выполняем метод поискаи  замены обьекта диапазона ворд
	        myRange.Find.Execute(ref textToFind, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref wMissing, ref replaceWith, ref replaceType, ref wMissing, ref wMissing, ref wMissing, ref wMissing);
	    }
	}


        struct  ReplacePattern {
            // Что заменяем
            public string replaced;
            // Чем заменяем
            public string replacing;
            // Как заменяем
            public int how;
        };

        private void fillDocument(string _filename, List<ReplacePattern> replacePatterns)
    {
        Object wMissing = System.Reflection.Missing.Value;
        Object wTrue = true;
        Object wFalse = false;

        Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
        Microsoft.Office.Interop.Word.Document wordDoc = new Microsoft.Office.Interop.Word.Document();
        //Работа с документом - Договор
        Object filename = _filename;
        Object confirmConversions = true;
        Object readOnly = false;
        Object addToRecentFiles = true;
        Object revert = false;
        Object passwordDocument = Type.Missing;
        Object passwordTemplate = Type.Missing;
        Object writePasswordDocument = Type.Missing;
        Object writePasswordTemplate = Type.Missing;
        Object format = Type.Missing;
        Object encoding = Type.Missing;
        Object visible = Type.Missing;
        Object openConflictDocument = Type.Missing;
        Object openAndRepair = Type.Missing;
        Object documentDirection = Type.Missing;
        Object noEncodingDialog = Type.Missing;
        wordApp.Documents.Open(ref filename, ref confirmConversions, ref readOnly, ref addToRecentFiles,
            ref passwordDocument, ref passwordTemplate, ref revert, ref writePasswordDocument, ref writePasswordTemplate,
            ref format, ref encoding, ref visible, ref openConflictDocument, ref openAndRepair, ref documentDirection, ref noEncodingDialog);

        wordApp.Visible = true;


        wordDoc = wordApp.Documents.Add(ref filename, ref wMissing, ref wTrue, ref wFalse);


        replacePatterns.ForEach(x => wordSearchReplace(x.replaced, x.replacing, ref wordApp, x.how));

        wordApp.Visible = true;
    
    }
      

        private void fillDocumentExcel(string _filename)
        {
            Object wMissing = System.Reflection.Missing.Value;
            Object wTrue = true;
            Object wFalse = false;

            Microsoft.Office.Interop.Excel.Application appExcel = new Microsoft.Office.Interop.Excel.Application();
           // Microsoft.Office.Interop.Excel.Workbook bookExcel = new Microsoft.Office.Interop.Excel.Workbook();
            Microsoft.Office.Interop.Excel.Worksheet worksheetExcel = new Microsoft.Office.Interop.Excel.Worksheet();
            Microsoft.Office.Interop.Excel.Sheets sheetsExcel;
            Microsoft.Office.Interop.Excel.Range rangeExcel;
            appExcel.Visible = true;
           
            //Работа с документом - Договор
            appExcel.Workbooks.Open(_filename,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing) ;

            sheetsExcel = appExcel.Worksheets;
            worksheetExcel = (Microsoft.Office.Interop.Excel.Worksheet) sheetsExcel.get_Item(1);
            
            rangeExcel =  worksheetExcel.get_Range("A2", "AE2");
            rangeExcel.Merge(Type.Missing);
            rangeExcel.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            rangeExcel.VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            rangeExcel.Value2 = "№" + inputNumContract.Text+ "   от" + "                         2012г.";
           
            rangeExcel = worksheetExcel.get_Range("F5", "AH5");
            rangeExcel.Merge(Type.Missing);
            rangeExcel.Value2 = inputAppNameOrgOrPF.Text;

            rangeExcel = worksheetExcel.get_Range("D9", "G9");
            rangeExcel.Merge(Type.Missing);
            rangeExcel.Value2 = "Путёвка в санаторий    " + " \" "+  inputAppWay.Text + " \" "+ inputNumDays.Text+ "дн.," +" \" "+  inputAppNumberAndCategory.Text + " \" "+  ", с  " + inputAppStartTour.Text+ "   " + inputAppFullName.Text ;
            
            rangeExcel = worksheetExcel.get_Range("Z9", "AA9");
            rangeExcel.Merge(Type.Missing);
            rangeExcel.Value2 = inputAppCost.Text;

            rangeExcel = worksheetExcel.get_Range("AD9", "AE9");
            rangeExcel.Merge(Type.Missing);
            rangeExcel.Value2 = inputAppCost.Text;

            rangeExcel = worksheetExcel.get_Range("AD11", "AE11");
            rangeExcel.Merge(Type.Missing);
            rangeExcel.Value2 = inputAppCost.Text;

            rangeExcel = worksheetExcel.get_Range("B14", "AE14");
            rangeExcel.Merge(Type.Missing);
            rangeExcel.Value2 = "Всего оказана услуг 1, на сумму" + "  " + inputAppCost.Text+ "  "+ "рублей";

        }

        private void fillDocumentExcel1(string _filename)
        {
            Object wMissing = System.Reflection.Missing.Value;
            Object wTrue = true;
            Object wFalse = false;

            Microsoft.Office.Interop.Excel.Application appExcel1 = new Microsoft.Office.Interop.Excel.Application();
            // Microsoft.Office.Interop.Excel.Workbook bookExcel = new Microsoft.Office.Interop.Excel.Workbook();
            Microsoft.Office.Interop.Excel.Worksheet worksheetExcel1 = new Microsoft.Office.Interop.Excel.Worksheet();
            Microsoft.Office.Interop.Excel.Sheets sheetsExcel1;
            Microsoft.Office.Interop.Excel.Range rangeExcel1;
            appExcel1.Visible = true;

            //Работа с документом - Договор
            appExcel1.Workbooks.Open(_filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            sheetsExcel1 = appExcel1.Worksheets;
            worksheetExcel1 = (Microsoft.Office.Interop.Excel.Worksheet)sheetsExcel1.get_Item(1);

            rangeExcel1 = worksheetExcel1.get_Range("A12", "I12");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            rangeExcel1.VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            rangeExcel1.Value2 = "Счёт №" + inputNumContract.Text + "   от" + "                         2012г.";

            rangeExcel1 = worksheetExcel1.get_Range("A14", "I14");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = "Плательщик:  " + inputAppNameOrgOrPF.Text;

            rangeExcel1 = worksheetExcel1.get_Range("A15", "I15");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = "Грузополучатель:    ";

            rangeExcel1 = worksheetExcel1.get_Range("B19", "E19");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = "Путёвка в санаторий " + inputAppWay.Text + ",  " + inputNumDays.Text + "дн.,  \" " + inputAppNumberAndCategory.Text + " \" c  " + inputAppStartTour.Text + " , " + inputAppFullName.Text;

            rangeExcel1 = worksheetExcel1.get_Range("H19", Type.Missing);
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = inputAppCost.Text;

            rangeExcel1 = worksheetExcel1.get_Range("I19", Type.Missing);
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = inputAppCost.Text;

            rangeExcel1 = worksheetExcel1.get_Range("I26", Type.Missing);
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = inputAppCost.Text;

            rangeExcel1 = worksheetExcel1.get_Range("E27", "I27");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = inputAppCost.Text;
        }
 
  
        private void PrintButton_Click(object sender, EventArgs e)
        {
            fillDocumentExcel(@"c:\АСУ-Тур\Акт реализации.xls");
            fillDocumentExcel1(@"c:\АСУ-ТУР\Платёжное поручение.xls");
             List<ReplacePattern> replacePatterns = new List<ReplacePattern>();
             ReplacePattern pattern;
            
             pattern = new ReplacePattern(); pattern.replaced = "94"; pattern.replacing = inputNumContract.Text; pattern.how = 1; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "Изумрудный"; pattern.replacing = inputAppWay.Text; pattern.how = 1; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "06.03.2012"; pattern.replacing = inputAppStartTour.Text; pattern.how = 1; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "Одноместный"; pattern.replacing = inputAppNumberAndCategory.Text; pattern.how = 1; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "3-х разовое"; pattern.replacing = inputFood.Text; pattern.how = 1; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "10"; pattern.replacing = inputNumDays.Text; pattern.how = 1; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "22 800"; pattern.replacing = inputAppCost.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "Белова Ирина Анатольевна"; pattern.replacing = inputAppFullName.Text; pattern.how = 0; replacePatterns.Add(pattern);

             fillDocument(@"c:\АСУ-Тур\Договор.dot", replacePatterns);
             //Работа с документом - Письменное согласие
             /*Object filename1 = @"c:\АСУ-Тур\Письменное согласие.dot";
             Object confirmConversions1 = true;
             Object readOnly1 = false;
             Object addToRecentFiles1 = true;
             Object revert1 = false;
             Object passwordDocument1 = Type.Missing;
             Object passwordTemplate1 = Type.Missing;
             Object writePasswordDocument1 = Type.Missing;
             Object writePasswordTemplate1 = Type.Missing;
             Object format1 = Type.Missing;
             Object encoding1 = Type.Missing;
             Object visible1 = Type.Missing;
             Object openConflictDocument1 = Type.Missing;
             Object openAndRepair1 = Type.Missing;
             Object documentDirection1 = Type.Missing;
             Object noEncodingDialog1 = Type.Missing;
             wordApp.Documents.Open(ref filename1, ref confirmConversions1, ref readOnly1, ref addToRecentFiles1,
                 ref passwordDocument1, ref passwordTemplate1, ref revert1, ref writePasswordDocument1, ref writePasswordTemplate1,
                 ref format1, ref encoding1, ref visible1, ref openConflictDocument1, ref openAndRepair1, ref documentDirection1, ref noEncodingDialog1);

             wordApp.Visible = true;


             wordDoc = wordApp.Documents.Add(ref filename1, ref wMissing, ref wTrue, ref wFalse);*/



             pattern = new ReplacePattern(); pattern.replaced = "Киселёва Татьяна Александровна"; pattern.replacing = inputAppFullName.Text; pattern.how = 0; replacePatterns.Add(pattern);
             //pattern = new ReplacePattern(); pattern.replaced = "Изумрудный"; pattern.replacing = inputAppWay.Text; pattern.how = 1; replacePatterns.Add(pattern);
             //pattern = new ReplacePattern(); pattern.replaced = "06.03.2012"; pattern.replacing = inputAppStartTour.Text; pattern.how = 1; replacePatterns.Add(pattern);
            // pattern = new ReplacePattern(); pattern.replaced = "Одноместный"; pattern.replacing = inputAppNumberAndCategory.Text; pattern.how = 1; replacePatterns.Add(pattern);
             //pattern = new ReplacePattern(); pattern.replaced = "3-х разовое"; pattern.replacing = inputFood.Text; pattern.how = 1; replacePatterns.Add(pattern);
            // pattern = new ReplacePattern(); pattern.replaced = "10"; pattern.replacing = inputNumDays.Text; pattern.how = 1; replacePatterns.Add(pattern);
             //pattern = new ReplacePattern(); pattern.replaced = "22 800"; pattern.replacing = inputAppCost.Text; pattern.how = 0; replacePatterns.Add(pattern);
            // pattern = new ReplacePattern(); pattern.replaced = "Белова Ирина Анатольевна"; pattern.replacing = inputAppFullName.Text; pattern.how = 0; replacePatterns.Add(pattern);

            
             pattern = new ReplacePattern(); pattern.replaced = "Киселева Татьяна Александровна"; pattern.replacing = inputAppFullName.Text; pattern.how = 0; replacePatterns.Add(pattern);

             fillDocument(@"c:\АСУ-Тур\Письменное согласие.dot", replacePatterns);

             pattern = new ReplacePattern(); pattern.replaced = "Sanat"; pattern.replacing = inputAppWay.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "name"; pattern.replacing = inputAppFullName.Text; pattern.how = 1; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "category"; pattern.replacing = inputAppNumberAndCategory.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "arrived"; pattern.replacing = inputAppStartTour.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "num"; pattern.replacing = inputNumDays.Text; pattern.how = 0; replacePatterns.Add(pattern);

             fillDocument(@"c:\АСУ-Тур\Заявка на бронирование1.dot", replacePatterns);

             pattern = new ReplacePattern(); pattern.replaced = "contract"; pattern.replacing = inputNumContract.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "sanat"; pattern.replacing = inputAppWay.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "name"; pattern.replacing = inputAppFullName.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "Org"; pattern.replacing = inputAppNameOrgOrPF.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "arrived"; pattern.replacing = inputAppStartTour.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "days"; pattern.replacing = inputNumDays.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "food"; pattern.replacing = inputFood.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "category"; pattern.replacing = inputAppNumberAndCategory.Text; pattern.how = 0; replacePatterns.Add(pattern);
             pattern = new ReplacePattern(); pattern.replaced = "cost"; pattern.replacing = inputAppCost.Text; pattern.how = 0; replacePatterns.Add(pattern);

             fillDocument(@"c:\АСУ-Тур\Путёвка.dot", replacePatterns);

        }

        private void AccountSanButton_Click(object sender, EventArgs e)
        {
         
            AccountSanForm accSanForm = new AccountSanForm(inputNumContract);
            accSanForm.Show();
        }

        private void AccountRadbutton_Click(object sender, EventArgs e)
        {
            AccountRadForm accRadForm = new AccountRadForm(inputNumContract);
            accRadForm.Show();
        }

        private void ViewAccountSanButton_Click(object sender, EventArgs e)
        {
            AccountSanTable accSanTable = new AccountSanTable(inputNumContract);
            string query = "select accAccount, accDate, accSum from AccountSan WHERE AccNumContract = \'" +inputNumContract.Text+"\'";
            Database.executeQuery(query).Close();           
            accSanTable.Show();
            this.Close();

        }

        private void ViewAccountRadButton_Click(object sender, EventArgs e)
        {
            AccountRadTable accRadTable = new AccountRadTable(inputNumContract);
            string query = "select AccRadAccount, AccRadDate, AccRadSum, AccRAdAccountSan from AccountRad WHERE AccRadNumContract = \'" + inputNumContract.Text + "\'";
            Database.executeQuery(query).Close();
            accRadTable.Show();
            this.Close();

        }

        private void addPettyCashReceiptes_Click(object sender, EventArgs e)
        {
            CashReceiptes cashRec = new CashReceiptes(inputNumContract);
            cashRec.Show();

        }

        private void addExpendableCash_Click(object sender, EventArgs e)
        {
            ExpendableCashOrder cashExp = new ExpendableCashOrder(inputNumContract);
            cashExp.Show();
        }

        private void viewCashReceiptesButton_Click(object sender, EventArgs e)
        {
            cashRecTable recTable = new cashRecTable(inputNumContract);
            string query = "select cashNumberDoc, cashData, cashSum from cashReceiptes WHERE cashNumApp = \'" + inputNumContract.Text + "\'";
            Database.executeQuery(query).Close();
            recTable.Show();
            this.Close();
        }

        private void viewCashButton_Click(object sender, EventArgs e)
        {
            cashExpTable expTable = new cashExpTable(inputNumContract);
            string query = "select useNumDoc, useDate, useSum from ExpendableOrder WHERE useNumApp = \'" + inputNumContract.Text + "\'";
            Database.executeQuery(query).Close();
            expTable.Show();
            this.Close();

        }

       

      

       
    } 
   }
