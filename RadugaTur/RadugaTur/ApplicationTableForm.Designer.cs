namespace RadugaTur
{
    partial class ApplicationTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radugaDBDataSet5 = new RadugaTur.RadugaDBDataSet5();
            this.radugaDBDataSet7 = new RadugaTur.RadugaDBDataSet7();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNumChildrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNumOldPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNumPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNumNightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNumDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appEndTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appStartTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appWayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNameOrgOrPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNumContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.applicationTableAdapter1 = new RadugaTur.RadugaDBDataSet7TableAdapters.ApplicationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // radugaDBDataSet5
            // 
            this.radugaDBDataSet5.DataSetName = "RadugaDBDataSet5";
            this.radugaDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radugaDBDataSet7
            // 
            this.radugaDBDataSet7.DataSetName = "RadugaDBDataSet7";
            this.radugaDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appDateDataGridViewTextBoxColumn,
            this.appNumContractDataGridViewTextBoxColumn,
            this.appFullNameDataGridViewTextBoxColumn,
            this.appNameOrgOrPFDataGridViewTextBoxColumn,
            this.appCountryDataGridViewTextBoxColumn,
            this.appWayDataGridViewTextBoxColumn,
            this.appStartTourDataGridViewTextBoxColumn,
            this.appEndTourDataGridViewTextBoxColumn,
            this.appNumDaysDataGridViewTextBoxColumn,
            this.appNumNightsDataGridViewTextBoxColumn,
            this.appNumPeopleDataGridViewTextBoxColumn,
            this.appNumOldPeopleDataGridViewTextBoxColumn,
            this.appNumChildrenDataGridViewTextBoxColumn,
            this.appCategoryDataGridViewTextBoxColumn,
            this.appPhoneDataGridViewTextBoxColumn,
            this.appNotesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.applicationBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1353, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // appNotesDataGridViewTextBoxColumn
            // 
            this.appNotesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appNotesDataGridViewTextBoxColumn.DataPropertyName = "AppNotes";
            this.appNotesDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.appNotesDataGridViewTextBoxColumn.Name = "appNotesDataGridViewTextBoxColumn";
            this.appNotesDataGridViewTextBoxColumn.Width = 95;
            // 
            // appPhoneDataGridViewTextBoxColumn
            // 
            this.appPhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appPhoneDataGridViewTextBoxColumn.DataPropertyName = "AppPhone";
            this.appPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.appPhoneDataGridViewTextBoxColumn.Name = "appPhoneDataGridViewTextBoxColumn";
            this.appPhoneDataGridViewTextBoxColumn.Width = 77;
            // 
            // appCategoryDataGridViewTextBoxColumn
            // 
            this.appCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appCategoryDataGridViewTextBoxColumn.DataPropertyName = "AppCategory";
            this.appCategoryDataGridViewTextBoxColumn.HeaderText = "Номер/Категория";
            this.appCategoryDataGridViewTextBoxColumn.Name = "appCategoryDataGridViewTextBoxColumn";
            this.appCategoryDataGridViewTextBoxColumn.Width = 124;
            // 
            // appNumChildrenDataGridViewTextBoxColumn
            // 
            this.appNumChildrenDataGridViewTextBoxColumn.DataPropertyName = "AppNumChildren";
            this.appNumChildrenDataGridViewTextBoxColumn.HeaderText = "Дети";
            this.appNumChildrenDataGridViewTextBoxColumn.Name = "appNumChildrenDataGridViewTextBoxColumn";
            this.appNumChildrenDataGridViewTextBoxColumn.Width = 50;
            // 
            // appNumOldPeopleDataGridViewTextBoxColumn
            // 
            this.appNumOldPeopleDataGridViewTextBoxColumn.DataPropertyName = "AppNumOldPeople";
            this.appNumOldPeopleDataGridViewTextBoxColumn.HeaderText = "Взрослые";
            this.appNumOldPeopleDataGridViewTextBoxColumn.Name = "appNumOldPeopleDataGridViewTextBoxColumn";
            this.appNumOldPeopleDataGridViewTextBoxColumn.Width = 50;
            // 
            // appNumPeopleDataGridViewTextBoxColumn
            // 
            this.appNumPeopleDataGridViewTextBoxColumn.DataPropertyName = "AppNumPeople";
            this.appNumPeopleDataGridViewTextBoxColumn.HeaderText = "Количество человек";
            this.appNumPeopleDataGridViewTextBoxColumn.Name = "appNumPeopleDataGridViewTextBoxColumn";
            this.appNumPeopleDataGridViewTextBoxColumn.Width = 60;
            // 
            // appNumNightsDataGridViewTextBoxColumn
            // 
            this.appNumNightsDataGridViewTextBoxColumn.DataPropertyName = "AppNumNights";
            this.appNumNightsDataGridViewTextBoxColumn.HeaderText = "Количество ночей";
            this.appNumNightsDataGridViewTextBoxColumn.Name = "appNumNightsDataGridViewTextBoxColumn";
            this.appNumNightsDataGridViewTextBoxColumn.Width = 80;
            // 
            // appNumDaysDataGridViewTextBoxColumn
            // 
            this.appNumDaysDataGridViewTextBoxColumn.DataPropertyName = "AppNumDays";
            this.appNumDaysDataGridViewTextBoxColumn.HeaderText = "Количество дней";
            this.appNumDaysDataGridViewTextBoxColumn.Name = "appNumDaysDataGridViewTextBoxColumn";
            this.appNumDaysDataGridViewTextBoxColumn.Width = 80;
            // 
            // appEndTourDataGridViewTextBoxColumn
            // 
            this.appEndTourDataGridViewTextBoxColumn.DataPropertyName = "AppEndTour";
            this.appEndTourDataGridViewTextBoxColumn.HeaderText = "Окончание тура";
            this.appEndTourDataGridViewTextBoxColumn.Name = "appEndTourDataGridViewTextBoxColumn";
            this.appEndTourDataGridViewTextBoxColumn.Width = 80;
            // 
            // appStartTourDataGridViewTextBoxColumn
            // 
            this.appStartTourDataGridViewTextBoxColumn.DataPropertyName = "AppStartTour";
            this.appStartTourDataGridViewTextBoxColumn.HeaderText = "Начало тура";
            this.appStartTourDataGridViewTextBoxColumn.Name = "appStartTourDataGridViewTextBoxColumn";
            this.appStartTourDataGridViewTextBoxColumn.Width = 80;
            // 
            // appWayDataGridViewTextBoxColumn
            // 
            this.appWayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appWayDataGridViewTextBoxColumn.DataPropertyName = "AppWay";
            this.appWayDataGridViewTextBoxColumn.HeaderText = "Направление";
            this.appWayDataGridViewTextBoxColumn.Name = "appWayDataGridViewTextBoxColumn";
            // 
            // appCountryDataGridViewTextBoxColumn
            // 
            this.appCountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appCountryDataGridViewTextBoxColumn.DataPropertyName = "AppCountry";
            this.appCountryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.appCountryDataGridViewTextBoxColumn.Name = "appCountryDataGridViewTextBoxColumn";
            this.appCountryDataGridViewTextBoxColumn.Width = 68;
            // 
            // appNameOrgOrPFDataGridViewTextBoxColumn
            // 
            this.appNameOrgOrPFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appNameOrgOrPFDataGridViewTextBoxColumn.DataPropertyName = "AppNameOrgOrPF";
            this.appNameOrgOrPFDataGridViewTextBoxColumn.HeaderText = "Организ/Частн.лицо";
            this.appNameOrgOrPFDataGridViewTextBoxColumn.Name = "appNameOrgOrPFDataGridViewTextBoxColumn";
            this.appNameOrgOrPFDataGridViewTextBoxColumn.Width = 138;
            // 
            // appFullNameDataGridViewTextBoxColumn
            // 
            this.appFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appFullNameDataGridViewTextBoxColumn.DataPropertyName = "AppFullName";
            this.appFullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.appFullNameDataGridViewTextBoxColumn.Name = "appFullNameDataGridViewTextBoxColumn";
            this.appFullNameDataGridViewTextBoxColumn.Width = 59;
            // 
            // appNumContractDataGridViewTextBoxColumn
            // 
            this.appNumContractDataGridViewTextBoxColumn.DataPropertyName = "AppNumContract";
            this.appNumContractDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.appNumContractDataGridViewTextBoxColumn.Name = "appNumContractDataGridViewTextBoxColumn";
            this.appNumContractDataGridViewTextBoxColumn.Width = 80;
            // 
            // appDateDataGridViewTextBoxColumn
            // 
            this.appDateDataGridViewTextBoxColumn.DataPropertyName = "AppDate";
            this.appDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.appDateDataGridViewTextBoxColumn.Name = "appDateDataGridViewTextBoxColumn";
            this.appDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // applicationBindingSource1
            // 
            this.applicationBindingSource1.DataMember = "Application";
            this.applicationBindingSource1.DataSource = this.radugaDBDataSet7;
            // 
            // applicationTableAdapter1
            // 
            this.applicationTableAdapter1.ClearBeforeFill = true;
            // 
            // ApplicationTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 195);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ApplicationTableForm";
            this.Text = "ApplicationTableForm";
            this.Load += new System.EventHandler(this.ApplicationTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadugaDBDataSet5 radugaDBDataSet5;
        private RadugaDBDataSet7 radugaDBDataSet7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNumContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNameOrgOrPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appWayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appStartTourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appEndTourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNumDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNumNightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNumPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNumOldPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNumChildrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource applicationBindingSource1;
        private RadugaDBDataSet7TableAdapters.ApplicationTableAdapter applicationTableAdapter1;
    }
}