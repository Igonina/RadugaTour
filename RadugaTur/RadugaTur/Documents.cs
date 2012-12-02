using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Word;
//using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.IO;

namespace RadugaTur
{
    public partial class Documents : Form
    {
        

        public Documents(System.Windows.Forms.TextBox inputAppDate, 
            System.Windows.Forms.TextBox inputNumContract, 
            System.Windows.Forms.TextBox inputAppFullName, 
            System.Windows.Forms.TextBox inputAppNameOrgOrPF, 
            System.Windows.Forms.TextBox inputAppCountry, 
            System.Windows.Forms.TextBox inputAppWay, 
            System.Windows.Forms.TextBox inputAppStartTour, 
            System.Windows.Forms.TextBox inputNumDays, 
            System.Windows.Forms.TextBox inputNumNights, 
            System.Windows.Forms.TextBox inputAppNumPeople, 
            System.Windows.Forms.TextBox inputAppOldPeople, 
            System.Windows.Forms.TextBox inputAppNumChildren, 
            System.Windows.Forms.TextBox inputAppChildAge, 
            System.Windows.Forms.TextBox inputAppNumberAndCategory, 
            System.Windows.Forms.TextBox inputAppNotes, 
            System.Windows.Forms.TextBox inputNumDaysHealth, 
            System.Windows.Forms.TextBox inputFood, 
            System.Windows.Forms.TextBox inputArBase, 
            System.Windows.Forms.TextBox inputAppCost,  
            System.Windows.Forms.TextBox inputAppCostWithoutProcent,
            System.Windows.Forms.TextBox inputAppSumPay, 
            System.Windows.Forms.TextBox inputAppDateSumPay, 
            System.Windows.Forms.TextBox inputAppDebt, 
            System.Windows.Forms.TextBox inputAppOtherMoney,
            System.Windows.Forms.TextBox inputAppPhone,
            System.Windows.Forms.TextBox inputRoute,
            System.Windows.Forms.ComboBox inputTransfer,
            System.Windows.Forms.ComboBox inputTourProgram,
            System.Windows.Forms.ComboBox inputVisa,
            System.Windows.Forms.ComboBox inputTick,
            System.Windows.Forms.ComboBox inputIns,
            System.Windows.Forms.ComboBox inputTipeApp,
            System.Windows.Forms.TextBox inputAgentsProcent,
            System.Windows.Forms.TextBox dateAcc,
            System.Windows.Forms.TextBox sumAcc,
            System.Windows.Forms.TextBox payAcc,
            System.Windows.Forms.TextBox orderAcc,
            System.Windows.Forms.TextBox dateRec,
            System.Windows.Forms.TextBox sumRec,
            System.Windows.Forms.TextBox payRec,
            System.Windows.Forms.TextBox orderRec,
            System.Windows.Forms.TextBox DateDeb,
            System.Windows.Forms. TextBox sumDeb,
            System.Windows.Forms.TextBox payDeb,
            System.Windows.Forms.TextBox orderDeb,
            System.Windows.Forms.TextBox jurTick,
            System.Windows.Forms.TextBox dateTick,
            System.Windows.Forms.TextBox sumTick,
            System.Windows.Forms.TextBox payTick,
            System.Windows.Forms.TextBox orderTick,
            System.Windows.Forms.TextBox jurWay,
            System.Windows.Forms.TextBox dateWay,
            System.Windows.Forms.TextBox sumWay,
            System.Windows.Forms.TextBox payWay,
            System.Windows.Forms.TextBox orderWay,
            System.Windows.Forms.TextBox jurIns,
            System.Windows.Forms.TextBox dateIns,
            System.Windows.Forms.TextBox sumIns,
            System.Windows.Forms.TextBox payIns,
            System.Windows.Forms.TextBox orderIns)
        {
            InitializeComponent();
            this.inputAppDate = inputAppDate;
            this.inputNumContract = inputNumContract;
            this.inputAppFullName = inputAppFullName;
            this.inputAppNameOrgOrPF = inputAppNameOrgOrPF;
            this.inputAppCountry = inputAppCountry;
            this.inputAppWay = inputAppWay;
            this.inputAppStartTour = inputAppStartTour;
            this.inputNumDays = inputNumDays;
            this.inputNumNights = inputNumNights;
            this.inputAppNumPeople = inputAppNumPeople;
            this.inputAppOldPeople = inputAppOldPeople;
            this.inputAppNumChildren = inputAppNumChildren;
            this.inputAppChildAge = inputAppChildAge;
            this.inputAppNumberAndCategory = inputAppNumberAndCategory;
            this.inputAppNotes = inputAppNotes;
            this.inputNumDaysHealth = inputNumDaysHealth;
            this.inputFood = inputFood;
            this.inputArBase = inputArBase;
            this.inputAppCost = inputAppCost;
            this.inputAppCostWithoutProcent = inputAppCostWithoutProcent;
            this.inputAppSumPay = inputAppSumPay;
            this.inputAppDateSumPay = inputAppDateSumPay;
            this.inputAppDebt = inputAppDebt;
            this.inputAppOtherMoney = inputAppOtherMoney;
            this.inputAppPhone = inputAppPhone;
            this.inputRoute = inputRoute;
            this.inputTransfer = inputTransfer;
            this.inputTourProgram = inputTourProgram;
            this.inputVisa = inputVisa;
            this.inputTick = inputTick;
            this.inputIns = inputIns;
            this.inputTipeApp = inputTipeApp;
            this.inputAgentsProcent = inputAgentsProcent;
            this.dateAcc = dateAcc;
            this.sumAcc = sumAcc;
            this.payAcc = payAcc;
            this.orderAcc = orderAcc;
            this.dateRec = dateRec;
            this.sumRec = sumRec;
            this.payRec = payRec;
            this.orderRec = orderRec;
            this.DateDeb = DateDeb;
            this.sumDeb = sumDeb;
            this.payDeb = payDeb;
            this.orderDeb = orderDeb;
            this.jurTick = jurTick;
            this.dateTick = dateTick;
            this.sumTick = sumTick;
            this.payTick = payTick;
            this.orderTick = orderTick;
            this.jurWay = jurWay;
            this.dateWay = dateWay;
            this.sumWay = sumWay;
            this.payWay = payWay;
            this.orderWay = orderWay;
            this.jurIns = jurIns;
            this.dateIns = dateIns;
            this.sumIns = sumIns;
            this.payIns = payIns;
            this.orderIns = orderIns;
        }

        TextBox inputAppDate;
        TextBox inputNumContract;
        TextBox inputAppFullName;
        TextBox inputAppNameOrgOrPF;
        TextBox inputAppCountry;
        TextBox inputAppWay;
        TextBox inputAppStartTour;
        TextBox inputNumDays;
        TextBox inputNumNights;
        TextBox inputAppNumPeople;
        TextBox inputAppOldPeople;
        TextBox inputAppNumChildren;
        TextBox inputAppChildAge;
        TextBox inputAppNumberAndCategory;
        TextBox inputAppNotes;
        TextBox inputNumDaysHealth;
        TextBox inputFood;
        TextBox inputArBase;
        TextBox inputAppCost;
        TextBox inputAppCostWithoutProcent;
        TextBox inputAppSumPay;
        TextBox inputAppDateSumPay;
        TextBox inputAppDebt;
        TextBox inputAppOtherMoney; 
        TextBox inputAppPhone;
        TextBox inputRoute;
        ComboBox inputTransfer;
        ComboBox inputTourProgram;
        ComboBox inputVisa;
        ComboBox inputTick;
        ComboBox inputIns;
        ComboBox inputTipeApp;
        TextBox inputAgentsProcent;
        TextBox dateAcc;
        TextBox sumAcc;
        TextBox payAcc;
        TextBox orderAcc;
        TextBox dateRec;
        TextBox sumRec;
        TextBox payRec;
        TextBox orderRec;
        TextBox DateDeb;
        TextBox sumDeb;
        TextBox payDeb;
        TextBox orderDeb;
        TextBox jurTick;
        TextBox dateTick;
        TextBox sumTick;
        TextBox payTick;
        TextBox orderTick;
        TextBox jurWay;
        TextBox dateWay;
        TextBox sumWay;
        TextBox payWay;
        TextBox orderWay;
        TextBox jurIns;
        TextBox dateIns;
        TextBox sumIns;
        TextBox payIns;
        TextBox orderIns;

        internal void fillDocument2(string PFFullEngName, string PFBirthday, string PFNumAndSerRussPassport, string PFDateGetRussPassport,  string PFOrgGetRussPassport, string PFNumAndSerForeignPassport, string PFDateGetForeignPassport, string PFDateEndForeignPassport, string PFOrgGetForeignPassport, string PFBirthPlace, string PFPhone) {
            this.PFFullEngName = PFFullEngName.ToString();
            this.PFBirthday = PFBirthday.ToString();
            this.PFNumAndSerRussPassport = PFNumAndSerRussPassport.ToString();
            this.PFDateGetRussPassport = PFDateGetRussPassport.ToString();
            this.PFOrgGetRussPassport = PFOrgGetRussPassport.ToString();
            this.PFNumAndSerForeignPassport = PFNumAndSerForeignPassport.ToString();
            this.PFDateGetForeignPassport = PFDateGetForeignPassport.ToString();
            this.PFDateEndForeignPassport = PFDateEndForeignPassport.ToString();
            this.PFOrgGetForeignPassport = PFOrgGetForeignPassport.ToString();
            this.PFBirthPlace = PFBirthPlace.ToString();
            this.PFPhone = PFPhone.ToString();

        }
        string PFFullEngName;
        string PFBirthday;
        string PFNumAndSerRussPassport;
        string PFDateGetRussPassport;
        string PFOrgGetRussPassport;
        string PFNumAndSerForeignPassport;
        string PFDateGetForeignPassport;
        string PFDateEndForeignPassport;
        string PFOrgGetForeignPassport;
        string PFBirthPlace;
        string PFPhone;

        internal void fillDocumentH(string PFFullEngName, string PFBirthday, string PFNumAndSerForeignPassport, string PFDateEndForeignPassport) {
            this.PFFullEngName = PFFEN;
            this.PFBirthday =  PFB;
            this.PFNumAndSerForeignPassport = PFNASFP;
            this.PFDateEndForeignPassport =  PFDEFP;
        }
        string PFFEN;
        string PFB;
        string PFNASFP;
        string PFDEFP;

        internal void fillDocumentF(string PFFullEngName, string PFBirthday, string PFNumAndSerForeignPassport, string PFDateEndForeignPassport)
        {
            this.PFFullEngName = PFFEN2;
            this.PFBirthday = PFB2;
            this.PFNumAndSerForeignPassport = PFNASFP2;
            this.PFDateEndForeignPassport = PFDEFP2;
        }
        string PFFEN2;
        string PFB2;
        string PFNASFP2;
        string PFDEFP2;

        internal void fillDocumentK(string PFFullEngName, string PFBirthday, string PFNumAndSerForeignPassport, string PFDateEndForeignPassport)
        {
            this.PFFullEngName = PFFEN3;
            this.PFBirthday = PFB3;
            this.PFNumAndSerForeignPassport = PFNASFP3;
            this.PFDateEndForeignPassport = PFDEFP3;
        }
        string PFFEN3;
        string PFB3;
        string PFNASFP3;
        string PFDEFP3;


        internal void fillDocument3(string JFNameOrg, string JFCargoCarrier) {
            this.JFNameOrg = JFNameOrg;
            this.JFCargoCarrier = JFCargoCarrier;
        }
       
        string JFNameOrg;
        string JFCargoCarrier;


       
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


        struct ReplacePattern
        {
            // Что заменяем
            public string replaced;
            // Чем заменяем
            public string replacing;
            // Как заменяем
            public int how;
        };

        private void fillDocument(string _filename, List<ReplacePattern> replacePatterns)
        {
            // Генерируем случайную строку из символов латиницы, например
            string templateFileName = _filename;
            string randomFilePathName = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            _filename = Path.Combine(randomFilePathName, Path.GetFileName(_filename));
            if (!Directory.Exists(randomFilePathName))
            {
                Directory.CreateDirectory(randomFilePathName);
            }
            File.Copy(templateFileName, _filename);
            

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

            string[] text = inputAppFullName.Text.Split(';');
            string d = text[0]; 

            Microsoft.Office.Interop.Excel.Application appExcel = new Microsoft.Office.Interop.Excel.Application();
            // Microsoft.Office.Interop.Excel.Workbook bookExcel = new Microsoft.Office.Interop.Excel.Workbook();
            Microsoft.Office.Interop.Excel.Worksheet worksheetExcel = new Microsoft.Office.Interop.Excel.Worksheet();
            Microsoft.Office.Interop.Excel.Sheets sheetsExcel;
            Microsoft.Office.Interop.Excel.Range rangeExcel;
            appExcel.Visible = true;

            //Работа с документом - Договор
            appExcel.Workbooks.Open(_filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            sheetsExcel = appExcel.Worksheets;
            worksheetExcel = (Microsoft.Office.Interop.Excel.Worksheet)sheetsExcel.get_Item(1);

            rangeExcel = worksheetExcel.get_Range("A2", "AE2");
            rangeExcel.Merge(Type.Missing);
            rangeExcel.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            rangeExcel.VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            rangeExcel.Value2 = "№" + inputNumContract.Text + "   от" + "                         2012г.";

            rangeExcel = worksheetExcel.get_Range("F5", "AH5");
            rangeExcel.Merge(Type.Missing);
            rangeExcel.Value2 = inputAppNameOrgOrPF.Text;

            rangeExcel = worksheetExcel.get_Range("D9", "G9");
            rangeExcel.Merge(Type.Missing);
            rangeExcel.Value2 = "Путёвка в санаторий    " + " \" " + inputAppWay.Text + " \" " + inputNumDays.Text + "дн.," + " \" " + inputAppNumberAndCategory.Text + " \" " + ", с  " + inputAppStartTour.Text + "   " + d;

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
            rangeExcel.Value2 = "Всего оказана услуг 1, на сумму" + "  " + inputAppCost.Text + "  " + "рублей";

        }

        private void fillDocumentExcel1(string _filename)
        {
            Object wMissing = System.Reflection.Missing.Value;
            Object wTrue = true;
            Object wFalse = false;

            string[] text = inputAppFullName.Text.Split(';');
            string d = text[0];
           
           

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
            rangeExcel1.Value2 = "Счёт №  " + inputNumContract.Text + "   от  " + dateAcc.Text;

            rangeExcel1 = worksheetExcel1.get_Range("A14", "I14");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = "Плательщик:  " + inputAppNameOrgOrPF.Text;

            rangeExcel1 = worksheetExcel1.get_Range("A15:A16", "I15:I16");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = "Грузополучатель:    " + JFCargoCarrier;

            rangeExcel1 = worksheetExcel1.get_Range("B19", "E19");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = "Путёвка в санаторий " + inputAppWay.Text + ",  " + inputNumDays.Text + "дн.,  \" " + inputAppNumberAndCategory.Text + " \" c  " + inputAppStartTour.Text + " , " + d;

            rangeExcel1 = worksheetExcel1.get_Range("H19", Type.Missing);
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = sumAcc.Text;

            rangeExcel1 = worksheetExcel1.get_Range("I19", Type.Missing);
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = sumAcc.Text;

            rangeExcel1 = worksheetExcel1.get_Range("I26", Type.Missing);
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = sumAcc.Text;

            rangeExcel1 = worksheetExcel1.get_Range("E27", "I27");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = sumAcc.Text;
        }

        private void fillDocumentExcel2(string _filename)
        {
            Object wMissing = System.Reflection.Missing.Value;
            Object wTrue = true;
            Object wFalse = false;

            string[] text = inputAppFullName.Text.Split(';');
            string d = text[0]; 

            Microsoft.Office.Interop.Excel.Application appExcel1 = new Microsoft.Office.Interop.Excel.Application();
            // Microsoft.Office.Interop.Excel.Workbook bookExcel = new Microsoft.Office.Interop.Excel.Workbook();
            Microsoft.Office.Interop.Excel.Worksheet worksheetExcel1 = new Microsoft.Office.Interop.Excel.Worksheet();
            Microsoft.Office.Interop.Excel.Sheets sheetsExcel1;
            Microsoft.Office.Interop.Excel.Range rangeExcel1;
            appExcel1.Visible = true;

            //Работа с документом - Приходный ордер
            appExcel1.Workbooks.Open(_filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            sheetsExcel1 = appExcel1.Worksheets;
            worksheetExcel1 = (Microsoft.Office.Interop.Excel.Worksheet)sheetsExcel1.get_Item(1);

            rangeExcel1 = worksheetExcel1.get_Range("I17", "K17");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = inputNumContract.Text;

            rangeExcel1 = worksheetExcel1.get_Range("L17", "N17");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = dateRec.Text;

            rangeExcel1 = worksheetExcel1.get_Range("G27:G28", "J27:J28");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = sumRec.Text + "руб. 00 коп.";

            rangeExcel1 = worksheetExcel1.get_Range("C29:C30", "N29:N30");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = "через " + d;

            rangeExcel1 = worksheetExcel1.get_Range("C31:C34", "N31:N34");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = inputArBase.Text;

            rangeExcel1 = worksheetExcel1.get_Range("C36", "N36");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = inputAppCost.Text;

            rangeExcel1 = worksheetExcel1.get_Range("S8:S9", "Y8:Y9");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = "через" + d;

            rangeExcel1 = worksheetExcel1.get_Range("S13:S14", "Y13:Y14");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = inputArBase.Text;

            rangeExcel1 = worksheetExcel1.get_Range("S18:S19", "Y18:Y19");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = sumRec.Text;

            rangeExcel1 = worksheetExcel1.get_Range("S31:S32", "Y31:Y32");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = dateRec.Text;

            
        }

        private void fillDocumentExcel3(string _filename)
        {
            Object wMissing = System.Reflection.Missing.Value;
            Object wTrue = true;
            Object wFalse = false;

            string[] text = inputAppFullName.Text.Split(';');
            string d = text[0]; 

            Microsoft.Office.Interop.Excel.Application appExcel1 = new Microsoft.Office.Interop.Excel.Application();
            // Microsoft.Office.Interop.Excel.Workbook bookExcel = new Microsoft.Office.Interop.Excel.Workbook();
            Microsoft.Office.Interop.Excel.Worksheet worksheetExcel1 = new Microsoft.Office.Interop.Excel.Worksheet();
            Microsoft.Office.Interop.Excel.Sheets sheetsExcel1;
            Microsoft.Office.Interop.Excel.Range rangeExcel1;
            appExcel1.Visible = true;

            //Работа с документом - Приходный ордер
            appExcel1.Workbooks.Open(_filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            sheetsExcel1 = appExcel1.Worksheets;
            worksheetExcel1 = (Microsoft.Office.Interop.Excel.Worksheet)sheetsExcel1.get_Item(1);

            rangeExcel1 = worksheetExcel1.get_Range("N10", "P10");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = inputNumContract.Text;

            rangeExcel1 = worksheetExcel1.get_Range("Q10", "S10");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = DateDeb.Text;

            rangeExcel1 = worksheetExcel1.get_Range("M18:M19", "P18:P19");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = sumDeb.Text + "руб. 00 коп.";

            rangeExcel1 = worksheetExcel1.get_Range("D21", "S21");
            rangeExcel1.Merge(Type.Missing);
            rangeExcel1.Value2 = d;

           


        }

       

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

        public void ConvertStringDecimal(string stringVal) {
            decimal decimalVal = 0;
            stringVal = System.Convert.ToString(decimalVal);
        }
                  
        
        private void button1_Click(object sender, EventArgs e)
        {
            int i = inputAppFullName.Lines.Length;
            string[] text = inputAppFullName.Text.Split(';');
            if (text[0] != null)
            {
                string s = text[0];


                string query6 = "select  PFFullEngName, PFBirthday, PFNumAndSerRussPassport, PFDateGetRussPassport,  PFOrgGetRussPassport, PFNumAndSerForeignPassport, PFDateGetForeignPassport, PFDateEndForeignPassport,PFOrgGetForeignPassport, PFBirthPlace, PFPhone from PhisicalFace where (PFFullRussName = \'" + s + "\')";

                SqlDataReader data3 = Database.executeQuery(query6);
                object[] fields3 = new object[11];
                data3.Read();
                data3.GetValues(fields3);
                data3.Close();

                string PFFullEngName = fields3[0].ToString(), PFBirthday = fields3[1].ToString(), PFNumAndSerRussPassport = fields3[2].ToString();
                string PFDateGetRussPassport = fields3[3].ToString(), PFOrgGetRussPassport = fields3[4].ToString(), PFNumAndSerForeignPassport = fields3[5].ToString();
                string PFDateGetForeignPassport = fields3[6].ToString(), PFDateEndForeignPassport = fields3[7].ToString();
                string PFOrgGetForeignPassport = fields3[8].ToString(), PFBirthPlace = fields3[9].ToString(), PFPhone = fields3[10].ToString();

                fillDocument2(PFFullEngName, PFBirthday, PFNumAndSerRussPassport, PFDateGetRussPassport, PFOrgGetRussPassport, PFNumAndSerForeignPassport, PFDateGetForeignPassport, PFDateEndForeignPassport, PFOrgGetForeignPassport, PFBirthPlace, PFPhone);
            }
                   

            


            string query5 = "select JFNameOrg, JFCargoCarrier from JuridicalFace where (JFFullNameOrg =\'" + inputAppNameOrgOrPF.Text + "\')";
            SqlDataReader data5 = Database.executeQuery(query5);
            object[] fields5 = new object[2];
            data5.Read();
            data5.GetValues(fields5);
            data5.Close();

            string JFNameOrg = fields5[0].ToString(), JFCargoCarrier = fields5[1].ToString();

            fillDocument3(JFNameOrg, JFCargoCarrier);

            /*if (text[1] != null)
           {
               string h = text[1];
               string query1 = "select  PFFullEngName, PFBirthday, PFNumAndSerForeignPassport, PFDateEndForeignPassport from PhisicalFace where (PFFullRussName = \'" + h + "\')";

               SqlDataReader data1 = Database.executeQuery(query1);
               object[] fields1 = new object[4];
               data1.Read();
               data1.GetValues(fields1);
               data1.Close();

               string PFFullEngName = fields1[0].ToString(), PFBirthday = fields1[1].ToString(),  PFNumAndSerForeignPassport = fields1[2].ToString();
               string PFDateEndForeignPassport = fields1[3].ToString();                

               fillDocumentH(PFFullEngName, PFBirthday,  PFNumAndSerForeignPassport, PFDateEndForeignPassport);
           }
           if (text[2] != null)
           {
               string f = text[2];
               string query2 = "select  PFFullEngName, PFBirthday, PFNumAndSerForeignPassport, PFDateEndForeignPassport from PhisicalFace where (PFFullRussName = \'" + f + "\')";

               SqlDataReader data2 = Database.executeQuery(query2);
               object[] fields2 = new object[4];
               data2.Read();
               data2.GetValues(fields2);
               data2.Close();

               string PFFullEngName = fields2[0].ToString(), PFBirthday = fields2[1].ToString(), PFNumAndSerForeignPassport = fields2[2].ToString();
               string PFDateEndForeignPassport = fields2[3].ToString();

               fillDocumentF(PFFullEngName, PFBirthday, PFNumAndSerForeignPassport, PFDateEndForeignPassport);
           }
           if (text[3] != null)
           {
               string k = text[3];
               string query4 = "select  PFFullEngName, PFBirthday, PFNumAndSerForeignPassport, PFDateEndForeignPassport from PhisicalFace where (PFFullRussName = \'" + k + "\')";

               SqlDataReader data4 = Database.executeQuery(query4);
               object[] fields4 = new object[4];
               data4.Read();
               data4.GetValues(fields4);
               data4.Close();

               string PFFullEngName = fields4[0].ToString(), PFBirthday = fields4[1].ToString(), PFNumAndSerForeignPassport = fields4[2].ToString();
               string PFDateEndForeignPassport = fields4[3].ToString();

               fillDocumentK(PFFullEngName, PFBirthday, PFNumAndSerForeignPassport, PFDateEndForeignPassport);
           }*/

           
            
            
            if (actCheckBox.Checked) {
                fillDocumentExcel(@"c:\АСУ-Тур\Акт реализации.xls");
            }
            if (appCheckBox.Checked) {
                List<ReplacePattern> replacePatterns = new List<ReplacePattern>();
                ReplacePattern pattern;
                pattern = new ReplacePattern(); pattern.replaced = "Sanat"; pattern.replacing = inputAppWay.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "name"; pattern.replacing = text[0]; pattern.how = 1; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "category"; pattern.replacing = inputAppNumberAndCategory.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "arrived"; pattern.replacing = inputAppStartTour.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "num"; pattern.replacing = inputNumDays.Text; pattern.how = 0; replacePatterns.Add(pattern);

                fillDocument(@"c:\АСУ-Тур\Заявка на бронирование1.dot", replacePatterns);
            }
            if (contractCheckBox.Checked) {
                List<ReplacePattern> replacePatterns = new List<ReplacePattern>();
                ReplacePattern pattern;
                pattern = new ReplacePattern(); pattern.replaced = "contract"; pattern.replacing = inputNumContract.Text; pattern.how = 1; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "way"; pattern.replacing = "Санаторий  " + inputAppWay.Text; pattern.how = 1; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "starttour"; pattern.replacing = inputAppStartTour.Text; pattern.how = 1; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "category"; pattern.replacing = inputAppNumberAndCategory.Text; pattern.how = 1; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "fullname"; pattern.replacing = text[0]; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "food"; pattern.replacing = inputFood.Text; pattern.how = 1; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "numdays"; pattern.replacing = inputNumDays.Text; pattern.how = 1; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "cost"; pattern.replacing = inputAppCost.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "rec"; pattern.replacing = sumRec.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "health"; pattern.replacing = inputNumDaysHealth.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "passport"; pattern.replacing = PFNumAndSerRussPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "get"; pattern.replacing = PFOrgGetRussPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "date"; pattern.replacing = PFDateGetRussPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "fullAllName"; pattern.replacing = inputAppFullName.Text; pattern.how = 0; replacePatterns.Add(pattern);

                fillDocument(@"c:\АСУ-Тур\Договор.dot", replacePatterns);
            }
            if (acceptCheckBox.Checked) {
                List<ReplacePattern> replacePatterns = new List<ReplacePattern>();
                ReplacePattern pattern;

             
                pattern = new ReplacePattern(); pattern.replaced = "fullname"; pattern.replacing = text[0]; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "birthday"; pattern.replacing = PFBirthday; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "passport"; pattern.replacing = PFNumAndSerRussPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "get"; pattern.replacing = PFOrgGetRussPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "date"; pattern.replacing = PFDateGetRussPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "birthplace"; pattern.replacing = PFBirthPlace; pattern.how = 0; replacePatterns.Add(pattern);
                

                fillDocument(@"c:\АСУ-Тур\Письменное согласие.dot", replacePatterns);
            }
            if (orderCheckBox.Checked) {
                fillDocumentExcel1(@"c:\АСУ-ТУР\Платёжное поручение.xls");
            }
            if (tourCheckBox.Checked) {
                List<ReplacePattern> replacePatterns = new List<ReplacePattern>();
                ReplacePattern pattern;
                pattern = new ReplacePattern(); pattern.replaced = "contract"; pattern.replacing = inputNumContract.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "sanat"; pattern.replacing = inputAppWay.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "name"; pattern.replacing = text[0]; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "Org"; pattern.replacing = inputAppNameOrgOrPF.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "arrived"; pattern.replacing = inputAppStartTour.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "days"; pattern.replacing = inputNumDays.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "food"; pattern.replacing = inputFood.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "category"; pattern.replacing = inputAppNumberAndCategory.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "cost"; pattern.replacing = inputAppCost.Text; pattern.how = 0; replacePatterns.Add(pattern);

                fillDocument(@"c:\АСУ-Тур\Путёвка.dot", replacePatterns);
            }
            if (contractTourProductCheckBox1.Checked) {
                List<ReplacePattern> replacePatterns = new List<ReplacePattern>();
                ReplacePattern pattern;
                pattern = new ReplacePattern(); pattern.replaced = "fullname"; pattern.replacing = text[0]; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "route"; pattern.replacing = inputRoute.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "starttour"; pattern.replacing = inputAppStartTour.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "category"; pattern.replacing = inputAppNumberAndCategory.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "food"; pattern.replacing = inputFood.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "transfer"; pattern.replacing = inputTransfer.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "ticket"; pattern.replacing = inputTick.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "insurance"; pattern.replacing = inputIns.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "cost"; pattern.replacing = inputAppCost.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "sernumpassport"; pattern.replacing = PFNumAndSerRussPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "organddategetpassport"; pattern.replacing = PFOrgGetRussPassport + "  от  " + PFDateGetRussPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "birthplace"; pattern.replacing = PFBirthPlace; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "birthday"; pattern.replacing = PFBirthday; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "fullAllName"; pattern.replacing = inputAppFullName.Text; pattern.how = 0; replacePatterns.Add(pattern);
                

                fillDocument(@"c:\АСУ-Тур\Договор зарубежный.dot", replacePatterns);
            }
            if (contractPersonalDatacheckBox1.Checked) {
                List<ReplacePattern> replacePatterns = new List<ReplacePattern>();
                ReplacePattern pattern;

                pattern = new ReplacePattern(); pattern.replaced = "fullname"; pattern.replacing = text[0]; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "country"; pattern.replacing = inputAppCountry.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "starttour"; pattern.replacing = inputAppStartTour.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "category"; pattern.replacing = inputAppNumberAndCategory.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "food"; pattern.replacing = inputFood.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "transfer"; pattern.replacing = inputTransfer.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "ticket"; pattern.replacing = inputTick.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "insurance"; pattern.replacing = inputIns.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "cost"; pattern.replacing = inputAppCost.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "way"; pattern.replacing = inputAppWay.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "numnights"; pattern.replacing = inputNumNights.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "tourprogram"; pattern.replacing = inputTourProgram.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "visa"; pattern.replacing = inputVisa.Text; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "birthday"; pattern.replacing = PFBirthday; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "fullengname"; pattern.replacing = PFFullEngName; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "sernumengpassport"; pattern.replacing = PFNumAndSerForeignPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "dateendpassport"; pattern.replacing = PFDateEndForeignPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "sernumrusspassport"; pattern.replacing = PFNumAndSerRussPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "place"; pattern.replacing = PFBirthPlace; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "phone"; pattern.replacing = PFPhone; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "orggetrusspassport"; pattern.replacing = PFNumAndSerRussPassport; pattern.how = 0; replacePatterns.Add(pattern);
                pattern = new ReplacePattern(); pattern.replaced = "dategetrusspassport"; pattern.replacing = PFBirthPlace; pattern.how = 0; replacePatterns.Add(pattern);
                

                fillDocument(@"c:\АСУ-Тур\Договор реализации.dot", replacePatterns);
                
            }
            if (cashOrderCheckBox1.Checked) {
                fillDocumentExcel2(@"c:\АСУ-Тур\Приходный ордер.xls");
            }
            if (DebOrderCheckBox1.Checked) {
                fillDocumentExcel3(@"c:\АСУ-Тур\Расходный ордер.xls");
            }
        }
       
    }
}
