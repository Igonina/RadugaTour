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
            // TODO: This line of code loads data into the '_1gb_rrrrrDataSet.FullApplication' table. You can move, or remove it, as needed.
            this.fullApplicationTableAdapter5.Fill(this._1gb_rrrrrDataSet.FullApplication);
           /* string MyString = "Data Source=mysql56.1gb.ru;Database=db_radugatour;Uid=db_radugatour;Pwd=82f6b51c345;";
            SqlConnection connection = new SqlConnection(MyString);
            connection.Open();
            try
            {
                
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select AppId, AppDate, AppNumContract, AppFullName, AppNameOrgOrPF, AppCountry, AppWay, AppStartTour, AppNumDays, AppNumNights, AppNumPeople, AppNumOldPeople, AppNumChildren, AppChildrensAge, AppCategory, AppNotes, AppNumDaysHealth, ArFood, ArBase, ArCost, ArCostWithoutProcent, ArSumPay, ArDateSumPay, ArDebt, ArOtherMoney,  ArPhone, ArRoute, ArTransfer, ArTourProgram, ArVise, ArTicket, ArInsurance, AppTipe, AppAgentProcent from FullApplication";
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                ApplicationTabledataGridView.DataSource = ds.Tables[0].DefaultView;
            }
            catch
            {
                throw;
            }
            finally {
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                } 
            }*/

        
           


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            ApplicationForm appForm = new ApplicationForm();
            
            

            //("select * from FullApplication where AppId = 2");
            //.;
            int i = ApplicationTabledataGridView.SelectedCells[0].RowIndex;
            int id = int.Parse(ApplicationTabledataGridView.Rows[i].Cells[0].Value.ToString());
            string query = "select AppId, AppDate, AppNumContract, AppFullName, AppNameOrgOrPF, AppCountry, AppWay, AppStartTour, AppNumDays, AppNumNights, AppNumPeople, AppNumOldPeople, AppNumChildren, AppChildrensAge, AppCategory, AppNotes, AppNumDaysHealth, ArFood, ArBase, ArCost, ArCostWithoutProcent, ArSumPay, ArDateSumPay, ArDebt, ArOtherMoney,  ArPhone, ArRoute, ArTransfer, ArTourProgram, ArVise, ArTicket, ArInsurance, AppTipe, AppAgentProcent from FullApplication where (AppId = " + id + ")";
            SqlDataReader data = Database.executeQuery(query);
            object[] fields = new object[34];
            data.Read();
            data.GetValues(fields);
            data.Close();

            int AppId = int.Parse(fields[0].ToString());
            string AppDate = fields[1].ToString();
            int AppNumContact = int.Parse(fields[2].ToString());
            string AppFullName = fields[3].ToString(), AppNameOrgOrPF = fields[4].ToString(), AppCountry = fields[5].ToString(), AppWay = fields[6].ToString(), AppStartTour = fields[7].ToString(), AppNumDays = fields[8].ToString(), AppNumNights = fields[9].ToString();
            int AppNumPeople = int.Parse(fields[10].ToString()), AppNumOldPeople = int.Parse(fields[11].ToString()), AppNumChildren = int.Parse(fields[12].ToString());
            string AppChildrensAge = fields[13].ToString(), AppCategory = fields[14].ToString(), AppNotes = fields[15].ToString();
            string AppNumDaysHealth = fields[16].ToString();
            string ArFood = fields[17].ToString(), ArBase = fields[18].ToString();
            //money?
            string ArCost = fields[19].ToString(), ArCostWithoutProcent = fields[20].ToString();
            string ArSumPay = fields[21].ToString(), ArDateSumPay = fields[22].ToString();
            string ArDebt = fields[23].ToString(), ArOtherMoney = fields[24].ToString(), ArPhone = fields[25].ToString(), ArRoute = fields[26].ToString(), ArTransfer = fields[27].ToString();
            string ArTourProgram = fields[28].ToString(), ArVise = fields[29].ToString(), ArTicket = fields[30].ToString(), ArInsurance = fields[31].ToString(), AppTipe = fields[32].ToString();
            string AppAgentProcent = fields[33].ToString();
            appForm.fillData(AppId, AppDate, AppNumContact, AppFullName, AppNameOrgOrPF, AppCountry, AppWay, AppStartTour, AppNumDays, AppNumNights, AppNumPeople, AppNumOldPeople, AppNumChildren, AppChildrensAge, AppCategory, AppNotes, AppNumDaysHealth, ArFood, ArBase, ArCost, ArCostWithoutProcent, ArSumPay, ArDateSumPay, ArDebt, ArOtherMoney, ArPhone, ArRoute, ArTransfer, ArTourProgram, ArVise, ArTicket, ArInsurance, AppTipe, AppAgentProcent);

            string query2 = "select tourId, tourNumContract, tourDateAcc, tourSumAcc, tourPayAcc, tourOrderAcc, tourDateRec, tourSumRec, tourPayRec, tourOrderRec, tourDateDebt, tourSumDebt, tourPayDebt, tourOrderDebt, forTourJurTick, forTourDateTick, forTourSumTick, forTourPayTick, forTourOrderTick, forTourJurWay, forTourDateWay, forTourSumWay, forTourPayWay, forTourOrderWay, forTourJurIns, forTourDateIns, forTourSumIns, forTourPayIns, forTourOrderIns, forTourDocTick, forTourDocIns, forTourDocWay from TouristsPayment where(tourNumContract = " + AppNumContact + ")";
            SqlDataReader data2 = Database.executeQuery(query2);
            object[] fields2 = new object[32];
            data2.Read();
            data2.GetValues(fields2);
            data2.Close();

            int tourId = int.Parse(fields2[0].ToString()), tourNumContract = int.Parse(fields2[1].ToString());
            string tourDateAcc = fields2[2].ToString(), tourSumAcc = fields2[3].ToString(), tourPayAcc = fields2[4].ToString();
            string tourOrderAcc = fields2[5].ToString(), tourDateRec = fields2[6].ToString(), tourSumRec = fields2[7].ToString();
            string tourPayRec = fields2[8].ToString(), tourOrderRec = fields2[9].ToString(), tourDateDebt = fields2[10].ToString();
            string tourSumDebt = fields2[11].ToString(), tourPayDebt = fields2[12].ToString(), tourOrderDebt = fields2[13].ToString();
            string forTourJurTick = fields2[14].ToString(), forTourDateTick = fields2[15].ToString(), forTourSumTick = fields2[16].ToString();
            string forTourPayTick = fields2[17].ToString(), forTourOrderTick = fields2[18].ToString(), forTourJurWay = fields2[19].ToString();
            string forTourDateWay = fields2[20].ToString(), forTourSumWay = fields2[21].ToString(), forTourPayWay = fields2[22].ToString();
            string forTourOrderWay = fields2[23].ToString(), forTourJurIns = fields2[24].ToString(), forTourDateIns = fields2[25].ToString();
            string forTourSumIns = fields2[26].ToString(), forTourPayIns = fields2[27].ToString(), forTourOrderIns = fields2[28].ToString();
            string forTourDocTick = fields2[29].ToString(), forTourDocIns = fields2[30].ToString(), forTourDocWay = fields2[31].ToString();
            appForm.fillData2(tourId, tourNumContract, tourDateAcc, tourSumAcc, tourPayAcc, tourOrderAcc, tourDateRec, tourSumRec, tourPayRec, tourOrderRec, tourDateDebt, tourSumDebt, tourPayDebt, tourOrderDebt, forTourJurTick, forTourDateTick, forTourSumTick, forTourPayTick, forTourOrderTick, forTourJurWay, forTourDateWay, forTourSumWay, forTourPayWay, forTourOrderWay, forTourJurIns, forTourDateIns, forTourSumIns, forTourPayIns, forTourOrderIns, forTourDocTick, forTourDocIns, forTourDocWay);
            appForm.ShowDialog();
            this.Close();
        }

        private void addApplicationButton_Click(object sender, EventArgs e)
        {
            ApplicationForm appForm = new ApplicationForm();
            appForm.ShowDialog();
            this.Close();
        }

        private void changeApplicationButton_Click(object sender, EventArgs e)
        {
            ApplicationForm appForm = new ApplicationForm();
            


            //("select * from FullApplication where AppId = 2");
            //.;
            int i = ApplicationTabledataGridView.SelectedCells[0].RowIndex;
            int id = int.Parse(ApplicationTabledataGridView.Rows[i].Cells[0].Value.ToString());
            string query = "select AppId, AppDate, AppNumContract, AppFullName, AppNameOrgOrPF, AppCountry, AppWay, AppStartTour, AppNumDays, AppNumNights, AppNumPeople, AppNumOldPeople, AppNumChildren, AppChildrensAge, AppCategory, AppNotes, AppNumDaysHealth, ArFood, ArBase, ArCost, ArCostWithoutProcent, ArSumPay, ArDateSumPay, ArDebt, ArOtherMoney,  ArPhone, ArRoute, ArTransfer, ArTourProgram, ArVise, ArTicket, ArInsurance, AppTipe, AppAgentProcent from FullApplication where (AppId = " + id + ")";
            SqlDataReader data = Database.executeQuery(query);
            object[] fields = new object[34];
            data.Read();
            data.GetValues(fields);
            data.Close();

            int AppId = int.Parse(fields[0].ToString());
            string AppDate = fields[1].ToString();
            int AppNumContact = int.Parse(fields[2].ToString());
            string AppFullName = fields[3].ToString(), AppNameOrgOrPF = fields[4].ToString(), AppCountry = fields[5].ToString(), AppWay = fields[6].ToString(), AppStartTour = fields[7].ToString(), AppNumDays = fields[8].ToString(), AppNumNights = fields[9].ToString();
            int AppNumPeople = int.Parse(fields[10].ToString()), AppNumOldPeople = int.Parse(fields[11].ToString()), AppNumChildren = int.Parse(fields[12].ToString());
            string AppChildrensAge = fields[13].ToString(), AppCategory = fields[14].ToString(), AppNotes = fields[15].ToString();
            string AppNumDaysHealth = fields[16].ToString();
            string ArFood = fields[17].ToString(), ArBase = fields[18].ToString();
            //money?
            string ArCost = fields[19].ToString(), ArCostWithoutProcent = fields[20].ToString();
            string ArSumPay = fields[21].ToString(), ArDateSumPay = fields[22].ToString();
            string ArDebt = fields[23].ToString(), ArOtherMoney = fields[24].ToString(), ArPhone = fields[25].ToString(), ArRoute = fields[26].ToString(), ArTransfer = fields[27].ToString();
            string ArTourProgram = fields[28].ToString(), ArVise = fields[29].ToString(), ArTicket = fields[30].ToString(), ArInsurance = fields[31].ToString(), AppTipe = fields[32].ToString();
            string AppAgentProcent = fields[33].ToString();

            appForm.fillData(AppId, AppDate, AppNumContact, AppFullName, AppNameOrgOrPF, AppCountry, AppWay, AppStartTour, AppNumDays, AppNumNights, AppNumPeople, AppNumOldPeople, AppNumChildren, AppChildrensAge, AppCategory, AppNotes, AppNumDaysHealth, ArFood, ArBase, ArCost, ArCostWithoutProcent, ArSumPay, ArDateSumPay, ArDebt, ArOtherMoney, ArPhone, ArRoute, ArTransfer, ArTourProgram, ArVise, ArTicket, ArInsurance, AppTipe, AppAgentProcent);

            string query2 = "select tourId, tourNumContract, tourDateAcc, tourSumAcc, tourPayAcc, tourOrderAcc, tourDateRec, tourSumRec, tourPayRec, tourOrderRec, tourDateDebt, tourSumDebt, tourPayDebt, tourOrderDebt, forTourJurTick, forTourDateTick, forTourSumTick, forTourPayTick, forTourOrderTick, forTourJurWay, forTourDateWay, forTourSumWay, forTourPayWay, forTourOrderWay, forTourJurIns, forTourDateIns, forTourSumIns, forTourPayIns, forTourOrderIns, forTourDocTick, forTourDocIns, forTourDocWay from TouristsPayment where(tourNumContract = " + AppNumContact + ")";
            SqlDataReader data2 = Database.executeQuery(query2);
            object[] fields2 = new object[32];
            data2.Read();
            data2.GetValues(fields2);
            data2.Close();

            int tourId = int.Parse(fields2[0].ToString()), tourNumContract = int.Parse(fields2[1].ToString());
            string tourDateAcc = fields2[2].ToString(), tourSumAcc = fields2[3].ToString(), tourPayAcc = fields2[4].ToString();
            string tourOrderAcc = fields2[5].ToString(), tourDateRec = fields2[6].ToString(), tourSumRec = fields2[7].ToString();
            string tourPayRec = fields2[8].ToString(), tourOrderRec = fields2[9].ToString(), tourDateDebt = fields2[10].ToString();
            string tourSumDebt = fields2[11].ToString(), tourPayDebt = fields2[12].ToString(), tourOrderDebt = fields2[13].ToString();
            string forTourJurTick = fields2[14].ToString(), forTourDateTick = fields2[15].ToString(), forTourSumTick = fields2[16].ToString();
            string forTourPayTick = fields2[17].ToString(), forTourOrderTick = fields2[18].ToString(), forTourJurWay = fields2[19].ToString();
            string forTourDateWay = fields2[20].ToString(), forTourSumWay = fields2[21].ToString(), forTourPayWay = fields2[22].ToString();
            string forTourOrderWay = fields2[23].ToString(), forTourJurIns = fields2[24].ToString(), forTourDateIns = fields2[25].ToString();
            string forTourSumIns = fields2[26].ToString(), forTourPayIns = fields2[27].ToString(), forTourOrderIns = fields2[28].ToString();
            string forTourDocTick = fields2[29].ToString(), forTourDocIns = fields2[30].ToString(), forTourDocWay = fields2[31].ToString();
            appForm.fillData2(tourId, tourNumContract, tourDateAcc, tourSumAcc, tourPayAcc, tourOrderAcc, tourDateRec, tourSumRec, tourPayRec, tourOrderRec, tourDateDebt, tourSumDebt, tourPayDebt, tourOrderDebt, forTourJurTick, forTourDateTick, forTourSumTick, forTourPayTick, forTourOrderTick, forTourJurWay, forTourDateWay, forTourSumWay, forTourPayWay, forTourOrderWay, forTourJurIns, forTourDateIns, forTourSumIns, forTourPayIns, forTourOrderIns, forTourDocTick, forTourDocIns, forTourDocWay);
            appForm.ShowDialog();
            this.Close();

        }

        private void cancelApplicationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int i2 = ApplicationTabledataGridView.SelectedCells[0].RowIndex;
            int id2 = int.Parse(ApplicationTabledataGridView.Rows[i2].Cells[0].Value.ToString());
            ApplicationTabledataGridView.Rows[i2].DefaultCellStyle.BackColor = Color.Red;
            string query3 = "delete from FullApplication where (AppId = " + id2 + ")";
            Database.executeQuery(query3).Close();
        }

       


       

        

       

        
    }
}
