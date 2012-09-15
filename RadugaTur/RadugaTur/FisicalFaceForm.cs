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
    public partial class FisicalFaceForm : Form
    {
        public FisicalFaceForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PHDateGetForPassButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputPHDateGetForPassport);
            monthCal.Show();
        }

        private void PFDateEndEngPassportButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputPHDateEndForPassport);
            monthCal.Show();
        }

        private void PFDateGetRussPassportButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputPFDateGetRussPassport);
            monthCal.Show();
        }

        private void PFBirthdayButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputPFBirthday);
            monthCal.Show();
        }

        private void SaveFisicalFaceFormButton_Click(object sender, EventArgs e)
        {
            string query = "insert into PhisicalFace(PFFullRussName, PFFullEngName, PFBirthday, PFNumAndSerRussPassport, PFDateGetRussPassport,  PFOrgGetRussPassport, PFNumAndSerForeignPassport, PFDateGetForeignPassport, PFDateEndForeignPassport,PFOrgGetForeignPassport, PFBirthPlace, PFPhone ) values (\'" +
                inputPFFullRussName.Text + "\', \'" +
                inputPFFullEngName.Text + "\', \'" +
                inputPFBirthday.Text + "\',\'" +
                inputPFSerialAndNumberRussPassport.Text + "\',\'"
                + inputPFDateGetRussPassport.Text + "\',\'" +
                inputPFOrgGetRussPassport.Text + "\',\'" +
                inputNumSerForeignPassport.Text + "\',\'" +
                inputPHDateGetForPassport.Text + "\',\'" +
                inputPHDateEndForPassport.Text + "\',\'" +
                inputPFOrgGetEngPassport.Text + "\',\'" +
                inputPFBirthPlace.Text + "\',\'" +
                inputPFPhone.Text + "\')";
            Database.executeQuery(query);
            PFTableForm pfTable = new PFTableForm();
            pfTable.Show();
            this.Close();
           
        }
    }
}
