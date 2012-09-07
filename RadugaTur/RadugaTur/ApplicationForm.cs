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
            //SqlQuery query = new SqlQuery("update hfjfjh");
            //    query.exec();
            /* using (SqlConnection connection = new SqlConnection("server=localhost;Database=RadugaTourDatabase;Integrated Security=true")
             {
              
                 SqlCommand command = new SqlCommand("insert ApplicationTable set inputDateApp= ", connection);
                 command.Connection.Open();
                 command.ExecuteNonQuery();
             }*/
        }

        private void inputApplicationBeginTour_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.DateTimePicker dateTimePickerAppBeginTour = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerApplicationDateContract.Location = new System.Drawing.Point(369, 92);
            this.dateTimePickerApplicationDateContract.Name = "dateTimePickerApplicationStartTour";
            this.dateTimePickerApplicationDateContract.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerApplicationDateContract.TabIndex = 105;
            dateTimePickerAppBeginTour.Show();
        }

    } 
   }
