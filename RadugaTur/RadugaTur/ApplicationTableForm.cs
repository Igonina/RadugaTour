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
    public partial class ApplicationTableForm : Form
    {
        public ApplicationTableForm()
        {
            InitializeComponent();
        }

        private void ApplicationTableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'radugaDBDataSet13.FullApplication' table. You can move, or remove it, as needed.
            this.fullApplicationTableAdapter1.Fill(this.radugaDBDataSet13.FullApplication);
            // TODO: This line of code loads data into the 'radugaDBDataSet12.FullApplication' table. You can move, or remove it, as needed.
           


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ApplicationForm appForm = new ApplicationForm();
            appForm.Show();

            //("select * from FullApplication where AppId = 2");
            //.;
            int i = ApplicationTabledataGridView.SelectedCells[0].RowIndex;
            int id = int.Parse(ApplicationTabledataGridView.Rows[i].Cells[0].Value.ToString());
            string query = "select AppId, AppDate, AppNumContract, AppFullName, AppNameOrgOrPF, AppCountry, AppWay, AppStartTour, AppNumDays, AppNumNights, AppNumPeople, AppNumOldPeople, AppNumChildren, AppChildrensAge, AppCategory, AppNotes, ArNumDaysHealth, ArFood, ArBase, ArMoreTourists, ArCost, ArCostWithoutProcent, ArAccountNumberSan, ArAccountNumberRad, ArMoneyOrg, ArDateMoneyOrg, ArPaySanRad, ArDatePaySanRad, ArDebt, ArOtherMoney, ArSumPay, ArDateSunPay, ArPhone from FullApplication where (AppId = " + id + ")";
            SqlDataReader data = Database.executeQuery(query);
            object[] fields = new object[33];
            data.Read();
            data.GetValues(fields);
            data.Close();

            int AppId = int.Parse(fields[0].ToString());
            string AppDate = fields[1].ToString(), AppNumContact = fields[2].ToString(), AppFullName = fields[3].ToString(), AppNameOrgOrPF = fields[4].ToString(), AppCountry = fields[5].ToString(), AppWay = fields[6].ToString(), AppStartTour = fields[7].ToString(), AppNumDays = fields[8].ToString(), AppNumNights = fields[9].ToString();
            int AppNumPeople = int.Parse(fields[10].ToString()), AppNumOldPeople = int.Parse(fields[11].ToString()), AppNumChildren = int.Parse(fields[12].ToString());
            string AppChildrensAge = fields[13].ToString(), AppCategory = fields[14].ToString(), AppNotes = fields[15].ToString();
            int ArNumDaysHealth = int.Parse(fields[16].ToString());
            string ArFood = fields[17].ToString(), ArBase = fields[18].ToString(), ArMoreTourists = fields[19].ToString();
            //money?
            string ArCost = fields[20].ToString(), ArCostWithoutProcent = fields[21].ToString();
            string ArAccountNumberSan = fields[22].ToString(), ArAccountNumberRad = fields[23].ToString(), ArMoneyOrg = fields[24].ToString(), ArDateMoneyOrg = fields[25].ToString(), ArPaySanRad = fields[26].ToString(), ArDatePaySanRad = fields[27].ToString(), ArDebt = fields[28].ToString(), ArOtherMoney = fields[29].ToString(), ArSumPay = fields[30].ToString(), ArDateSunPay = fields[31].ToString(), ArPhone = fields[32].ToString();
            appForm.fillData(AppId, AppDate, AppNumContact, AppFullName, AppNameOrgOrPF, AppCountry, AppWay, AppStartTour, AppNumDays, AppNumNights, AppNumPeople, AppNumOldPeople, AppNumChildren, AppChildrensAge, AppCategory, AppNotes, ArNumDaysHealth, ArFood, ArBase, ArMoreTourists, ArCost, ArCostWithoutProcent, ArAccountNumberSan, ArAccountNumberRad, ArMoneyOrg, ArDateMoneyOrg, ArPaySanRad, ArDatePaySanRad, ArDebt, ArOtherMoney, ArSumPay, ArDateSunPay, ArPhone);
        }

       

        
    }
}
