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
            this.fullApplicationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.radugaDBDataSet24 = new RadugaTur.RadugaDBDataSet24();
            this.fullApplicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radugaDBDataSet23 = new RadugaTur.RadugaDBDataSet23();
            this.fullApplicationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radugaDBDataSet13 = new RadugaTur.RadugaDBDataSet13();
            this.fullApplicationTableAdapter = new RadugaTur.RadugaDBDataSet12TableAdapters.FullApplicationTableAdapter();
            this.fullApplicationTableAdapter1 = new RadugaTur.RadugaDBDataSet13TableAdapters.FullApplicationTableAdapter();
            this.fullApplicationTableAdapter2 = new RadugaTur.RadugaDBDataSet23TableAdapters.FullApplicationTableAdapter();
            this.addApplicationButton = new System.Windows.Forms.Button();
            this.changeApplicationButton = new System.Windows.Forms.Button();
            this.cancelApplicationButton = new System.Windows.Forms.Button();
            this.fullApplicationTableAdapter3 = new RadugaTur.RadugaDBDataSet24TableAdapters.FullApplicationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationTabledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullApplicationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullApplicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet23)).BeginInit();
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
            this.ApplicationTabledataGridView.DataSource = this.fullApplicationBindingSource2;
            this.ApplicationTabledataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ApplicationTabledataGridView.Location = new System.Drawing.Point(13, 13);
            this.ApplicationTabledataGridView.Name = "ApplicationTabledataGridView";
            this.ApplicationTabledataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApplicationTabledataGridView.RowHeadersVisible = false;
            this.ApplicationTabledataGridView.Size = new System.Drawing.Size(1286, 311);
            this.ApplicationTabledataGridView.TabIndex = 0;
            
            this.ApplicationTabledataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // fullApplicationBindingSource2
            // 
            this.fullApplicationBindingSource2.DataMember = "FullApplication";
            this.fullApplicationBindingSource2.DataSource = this.radugaDBDataSet24;
            // 
            // radugaDBDataSet24
            // 
            this.radugaDBDataSet24.DataSetName = "RadugaDBDataSet24";
            this.radugaDBDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fullApplicationBindingSource
            // 
            this.fullApplicationBindingSource.DataMember = "FullApplication";
            this.fullApplicationBindingSource.DataSource = this.radugaDBDataSet23;
            // 
            // radugaDBDataSet23
            // 
            this.radugaDBDataSet23.DataSetName = "RadugaDBDataSet23";
            this.radugaDBDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // fullApplicationTableAdapter2
            // 
            this.fullApplicationTableAdapter2.ClearBeforeFill = true;
            // 
            // addApplicationButton
            // 
            this.addApplicationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addApplicationButton.Location = new System.Drawing.Point(371, 330);
            this.addApplicationButton.Name = "addApplicationButton";
            this.addApplicationButton.Size = new System.Drawing.Size(116, 23);
            this.addApplicationButton.TabIndex = 1;
            this.addApplicationButton.Text = "Добавить";
            this.addApplicationButton.UseVisualStyleBackColor = true;
            this.addApplicationButton.Click += new System.EventHandler(this.addApplicationButton_Click);
            // 
            // changeApplicationButton
            // 
            this.changeApplicationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.changeApplicationButton.Location = new System.Drawing.Point(538, 330);
            this.changeApplicationButton.Name = "changeApplicationButton";
            this.changeApplicationButton.Size = new System.Drawing.Size(116, 23);
            this.changeApplicationButton.TabIndex = 2;
            this.changeApplicationButton.Text = "Изменить";
            this.changeApplicationButton.UseVisualStyleBackColor = true;
            this.changeApplicationButton.Click += new System.EventHandler(this.changeApplicationButton_Click);
            // 
            // cancelApplicationButton
            // 
            this.cancelApplicationButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelApplicationButton.Location = new System.Drawing.Point(710, 330);
            this.cancelApplicationButton.Name = "cancelApplicationButton";
            this.cancelApplicationButton.Size = new System.Drawing.Size(116, 23);
            this.cancelApplicationButton.TabIndex = 3;
            this.cancelApplicationButton.Text = "Отменить";
            this.cancelApplicationButton.UseVisualStyleBackColor = true;
            this.cancelApplicationButton.Click += new System.EventHandler(this.cancelApplicationButton_Click);
            // 
            // fullApplicationTableAdapter3
            // 
            this.fullApplicationTableAdapter3.ClearBeforeFill = true;
            // 
            // ApplicationTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1331, 360);
            this.Controls.Add(this.cancelApplicationButton);
            this.Controls.Add(this.changeApplicationButton);
            this.Controls.Add(this.addApplicationButton);
            this.Controls.Add(this.ApplicationTabledataGridView);
            this.MinimumSize = new System.Drawing.Size(1200, 300);
            this.Name = "ApplicationTableForm";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.ApplicationTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationTabledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullApplicationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullApplicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet23)).EndInit();
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
        private RadugaDBDataSet23 radugaDBDataSet23;
        private System.Windows.Forms.BindingSource fullApplicationBindingSource;
        private RadugaDBDataSet23TableAdapters.FullApplicationTableAdapter fullApplicationTableAdapter2;
        private System.Windows.Forms.Button addApplicationButton;
        private System.Windows.Forms.Button changeApplicationButton;
        private System.Windows.Forms.Button cancelApplicationButton;
        private RadugaDBDataSet24 radugaDBDataSet24;
        private System.Windows.Forms.BindingSource fullApplicationBindingSource2;
        private RadugaDBDataSet24TableAdapters.FullApplicationTableAdapter fullApplicationTableAdapter3;

    }
}