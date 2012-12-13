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
            //this.AppId = AppId;
        }
        //int AppId;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PHDateGetForPassButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputPHDateGetForPassport);
            monthCal.ShowDialog();
        }

        private void PFDateEndEngPassportButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputPHDateEndForPassport);
            monthCal.ShowDialog();
        }

        private void PFDateGetRussPassportButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputPFDateGetRussPassport);
            monthCal.ShowDialog();
        }

        private void PFBirthdayButton_Click(object sender, EventArgs e)
        {
            MonthCalendar1 monthCal = new MonthCalendar1(inputPFBirthday);
            monthCal.ShowDialog();
        }

        bool isUpdateModeEnabled = false;
        int updatePFId;
        internal void fillData( int PFId, string PFFullRussName, string PFFullEngName, string PFBirthday, string PFNumAndSerRussPassport, string PFDateGetRussPassport, string PFOrgGetRussPassport, string PFNumAndSerForeignPassport, string PFDateGetForeignPassport, string PFDateEndForeignPassport, string PFOrgGetForeignPassport, string PFBirthPlace, string PFPhone, string PFMail) {
             inputPFFullRussName.Text = PFFullRussName.ToString();
             inputPFFullEngName.Text =  PFFullEngName.ToString();
             inputPFBirthday.Text =  PFBirthday.ToString();
             inputPFSerialAndNumberRussPassport.Text =  PFNumAndSerRussPassport.ToString();
             inputPFDateGetRussPassport.Text = PFDateGetRussPassport.ToString();
             inputPFOrgGetRussPassport.Text = PFOrgGetRussPassport.ToString();
             inputNumSerForeignPassport.Text = PFNumAndSerForeignPassport.ToString();
             inputPHDateGetForPassport.Text = PFDateGetForeignPassport.ToString();
             inputPHDateEndForPassport.Text = PFDateEndForeignPassport.ToString();
             inputPFOrgGetEngPassport.Text = PFOrgGetForeignPassport.ToString();
             inputPFBirthPlace.Text = PFBirthPlace.ToString();
             inputPFPhone.Text = PFPhone.ToString();
             inputPFMail.Text = PFMail.ToString();
                
             isUpdateModeEnabled = true;
             updatePFId = PFId; 
        }

        internal void insert() {
            if (updatePFId == 0)
            {
                string query = "insert into PhisicalFace(PFFullRussName, PFFullEngName, PFBirthday, PFNumAndSerRussPassport, PFDateGetRussPassport,  PFOrgGetRussPassport, PFNumAndSerForeignPassport, PFDateGetForeignPassport, PFDateEndForeignPassport,PFOrgGetForeignPassport, PFBirthPlace, PFPhone, PFMail  ) values (\'" +
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
                    inputPFPhone.Text + "\',\'" +
                    inputPFMail.Text + "\')";
                Database.executeQuery(query).Close();
            }
            else
            {
                string query2 = "update PhisicalFace set PFFullRussName = \'" + inputPFFullRussName.Text + "\', PFFullEngName = \'" + inputPFFullEngName.Text + "\', PFBirthday = \'" + inputPFBirthday.Text + "\', PFNumAndSerRussPassport= \'" + inputPFSerialAndNumberRussPassport.Text + "\', PFDateGetRussPassport= \'" + inputPFDateGetRussPassport.Text + "\', PFOrgGetRussPassport= \'" + inputPFOrgGetRussPassport.Text + "\', PFNumAndSerForeignPassport= \'" + inputNumSerForeignPassport.Text + "\', PFDateGetForeignPassport= \'" + inputPHDateGetForPassport.Text + "\', PFDateEndForeignPassport= \'" + inputPHDateEndForPassport.Text + "\', PFOrgGetForeignPassport= \'" + inputPFOrgGetEngPassport.Text + "\', PFBirthPlace = \'" + inputPFBirthPlace.Text + "\', PFPhone= \'" + inputPFPhone.Text + "\', PFMail = \'" + inputPFMail.Text + "\'  where (PFId = " + updatePFId + ")";
                Database.executeQuery(query2).Close();
            }

            this.Close();
        }

        private void SaveFisicalFaceFormButton_Click(object sender, EventArgs e)
        {
            insert();
        }

       
        private void inputPFFullRussName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Нажата клавиша Enter, перенос карретки (carriage Return), '\r' == 13
            if (e.KeyChar == '\r')
            {
                insert();
            }
        }

       

        
    }
}
