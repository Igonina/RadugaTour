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
            this.ApplicationTabledataGridView = new System.Windows.Forms.DataGridView();
            this.fullApplicationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radugaDBDataSet13 = new RadugaTur.RadugaDBDataSet13();
            this.fullApplicationTableAdapter = new RadugaTur.RadugaDBDataSet12TableAdapters.FullApplicationTableAdapter();
            this.fullApplicationTableAdapter1 = new RadugaTur.RadugaDBDataSet13TableAdapters.FullApplicationTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNumContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNameOrgOrPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appWayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appStartTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNumDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNumNightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appNumPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationTabledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullApplicationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicationTabledataGridView
            // 
            this.ApplicationTabledataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationTabledataGridView.AutoGenerateColumns = false;
            this.ApplicationTabledataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ApplicationTabledataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ApplicationTabledataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ApplicationTabledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicationTabledataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.appNumContractDataGridViewTextBoxColumn,
            this.appFullNameDataGridViewTextBoxColumn,
            this.appNameOrgOrPFDataGridViewTextBoxColumn,
            this.appCountryDataGridViewTextBoxColumn,
            this.appWayDataGridViewTextBoxColumn,
            this.appStartTourDataGridViewTextBoxColumn,
            this.appNumDaysDataGridViewTextBoxColumn,
            this.appNumNightsDataGridViewTextBoxColumn,
            this.appNumPeopleDataGridViewTextBoxColumn,
            this.appCategoryDataGridViewTextBoxColumn});
            this.ApplicationTabledataGridView.DataSource = this.fullApplicationBindingSource1;
            this.ApplicationTabledataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ApplicationTabledataGridView.Location = new System.Drawing.Point(13, 13);
            this.ApplicationTabledataGridView.Name = "ApplicationTabledataGridView";
            this.ApplicationTabledataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApplicationTabledataGridView.Size = new System.Drawing.Size(1286, 352);
            this.ApplicationTabledataGridView.TabIndex = 0;
            this.ApplicationTabledataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // fullApplicationBindingSource1
            // 
            this.fullApplicationBindingSource1.DataMember = "FullApplication";
            this.fullApplicationBindingSource1.DataSource = this.radugaDBDataSet13;
            // 
            // radugaDBDataSet13
            // 
            this.radugaDBDataSet13.DataSetName = "RadugaDBDataSet13";
            this.radugaDBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fullApplicationTableAdapter
            // 
            this.fullApplicationTableAdapter.ClearBeforeFill = true;
            // 
            // fullApplicationTableAdapter1
            // 
            this.fullApplicationTableAdapter1.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "AppId";
            this.Column1.HeaderText = "Номер";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 66;
            // 
            // appNumContractDataGridViewTextBoxColumn
            // 
            this.appNumContractDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appNumContractDataGridViewTextBoxColumn.DataPropertyName = "AppNumContract";
            this.appNumContractDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.appNumContractDataGridViewTextBoxColumn.Name = "appNumContractDataGridViewTextBoxColumn";
            this.appNumContractDataGridViewTextBoxColumn.Width = 106;
            // 
            // appFullNameDataGridViewTextBoxColumn
            // 
            this.appFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appFullNameDataGridViewTextBoxColumn.DataPropertyName = "AppFullName";
            this.appFullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.appFullNameDataGridViewTextBoxColumn.Name = "appFullNameDataGridViewTextBoxColumn";
            this.appFullNameDataGridViewTextBoxColumn.Width = 59;
            // 
            // appNameOrgOrPFDataGridViewTextBoxColumn
            // 
            this.appNameOrgOrPFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appNameOrgOrPFDataGridViewTextBoxColumn.DataPropertyName = "AppNameOrgOrPF";
            this.appNameOrgOrPFDataGridViewTextBoxColumn.HeaderText = "Организация/Частное лицо";
            this.appNameOrgOrPFDataGridViewTextBoxColumn.Name = "appNameOrgOrPFDataGridViewTextBoxColumn";
            this.appNameOrgOrPFDataGridViewTextBoxColumn.Width = 159;
            // 
            // appCountryDataGridViewTextBoxColumn
            // 
            this.appCountryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appCountryDataGridViewTextBoxColumn.DataPropertyName = "AppCountry";
            this.appCountryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.appCountryDataGridViewTextBoxColumn.Name = "appCountryDataGridViewTextBoxColumn";
            this.appCountryDataGridViewTextBoxColumn.Width = 68;
            // 
            // appWayDataGridViewTextBoxColumn
            // 
            this.appWayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appWayDataGridViewTextBoxColumn.DataPropertyName = "AppWay";
            this.appWayDataGridViewTextBoxColumn.HeaderText = "Направление";
            this.appWayDataGridViewTextBoxColumn.Name = "appWayDataGridViewTextBoxColumn";
            // 
            // appStartTourDataGridViewTextBoxColumn
            // 
            this.appStartTourDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appStartTourDataGridViewTextBoxColumn.DataPropertyName = "AppStartTour";
            this.appStartTourDataGridViewTextBoxColumn.HeaderText = "Начало тура";
            this.appStartTourDataGridViewTextBoxColumn.Name = "appStartTourDataGridViewTextBoxColumn";
            this.appStartTourDataGridViewTextBoxColumn.Width = 87;
            // 
            // appNumDaysDataGridViewTextBoxColumn
            // 
            this.appNumDaysDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appNumDaysDataGridViewTextBoxColumn.DataPropertyName = "AppNumDays";
            this.appNumDaysDataGridViewTextBoxColumn.HeaderText = "Количество дней";
            this.appNumDaysDataGridViewTextBoxColumn.Name = "appNumDaysDataGridViewTextBoxColumn";
            this.appNumDaysDataGridViewTextBoxColumn.Width = 108;
            // 
            // appNumNightsDataGridViewTextBoxColumn
            // 
            this.appNumNightsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appNumNightsDataGridViewTextBoxColumn.DataPropertyName = "AppNumNights";
            this.appNumNightsDataGridViewTextBoxColumn.HeaderText = "Количество ночей";
            this.appNumNightsDataGridViewTextBoxColumn.Name = "appNumNightsDataGridViewTextBoxColumn";
            this.appNumNightsDataGridViewTextBoxColumn.Width = 113;
            // 
            // appNumPeopleDataGridViewTextBoxColumn
            // 
            this.appNumPeopleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appNumPeopleDataGridViewTextBoxColumn.DataPropertyName = "AppNumPeople";
            this.appNumPeopleDataGridViewTextBoxColumn.HeaderText = "Количество человек";
            this.appNumPeopleDataGridViewTextBoxColumn.Name = "appNumPeopleDataGridViewTextBoxColumn";
            this.appNumPeopleDataGridViewTextBoxColumn.Width = 124;
            // 
            // appCategoryDataGridViewTextBoxColumn
            // 
            this.appCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appCategoryDataGridViewTextBoxColumn.DataPropertyName = "AppCategory";
            this.appCategoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.appCategoryDataGridViewTextBoxColumn.Name = "appCategoryDataGridViewTextBoxColumn";
            this.appCategoryDataGridViewTextBoxColumn.Width = 85;
            // 
            // ApplicationTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1331, 360);
            this.Controls.Add(this.ApplicationTabledataGridView);
            this.Name = "ApplicationTableForm";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.ApplicationTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationTabledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullApplicationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ApplicationTabledataGridView;
        private RadugaDBDataSet12TableAdapters.FullApplicationTableAdapter fullApplicationTableAdapter;
        private RadugaDBDataSet13 radugaDBDataSet13;
        private System.Windows.Forms.BindingSource fullApplicationBindingSource1;
        private RadugaDBDataSet13TableAdapters.FullApplicationTableAdapter fullApplicationTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNumContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNameOrgOrPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appWayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appStartTourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNumDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNumNightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNumPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appCategoryDataGridViewTextBoxColumn;

    }
}