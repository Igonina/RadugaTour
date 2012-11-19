namespace RadugaTur
{
    partial class PFTableForm
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
            this.PhisicalFaceView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFFullRussNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFFullEngNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFBirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFNumAndSerRussPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFDateGetRussPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFOrgGetRussPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFNumAndSerForeignPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFDateGetForeignPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFDateEndForeignPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFOrgGetForeignPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFBirthPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phisicalFaceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.radugaDBDataSet22 = new RadugaTur.RadugaDBDataSet22();
            this.phisicalFaceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radugaDBDataSet20 = new RadugaTur.RadugaDBDataSet20();
            this.phisicalFaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radugaDBDataSet4 = new RadugaTur.RadugaDBDataSet4();
            this.phisicalFaceTableAdapter = new RadugaTur.RadugaDBDataSet4TableAdapters.PhisicalFaceTableAdapter();
            this.phisicalFaceTableAdapter1 = new RadugaTur.RadugaDBDataSet20TableAdapters.PhisicalFaceTableAdapter();
            this.addPFbutton = new System.Windows.Forms.Button();
            this.changePFbutton = new System.Windows.Forms.Button();
            this.cancelPFbutton = new System.Windows.Forms.Button();
            this.phisicalFaceTableAdapter2 = new RadugaTur.RadugaDBDataSet22TableAdapters.PhisicalFaceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PhisicalFaceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalFaceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalFaceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalFaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // PhisicalFaceView
            // 
            this.PhisicalFaceView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PhisicalFaceView.AutoGenerateColumns = false;
            this.PhisicalFaceView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PhisicalFaceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhisicalFaceView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.pFFullRussNameDataGridViewTextBoxColumn,
            this.pFFullEngNameDataGridViewTextBoxColumn,
            this.pFBirthdayDataGridViewTextBoxColumn,
            this.pFNumAndSerRussPassportDataGridViewTextBoxColumn,
            this.pFDateGetRussPassportDataGridViewTextBoxColumn,
            this.pFOrgGetRussPassportDataGridViewTextBoxColumn,
            this.pFNumAndSerForeignPassportDataGridViewTextBoxColumn,
            this.pFDateGetForeignPassportDataGridViewTextBoxColumn,
            this.pFDateEndForeignPassportDataGridViewTextBoxColumn,
            this.pFOrgGetForeignPassportDataGridViewTextBoxColumn,
            this.pFBirthPlaceDataGridViewTextBoxColumn,
            this.pFPhoneDataGridViewTextBoxColumn});
            this.PhisicalFaceView.DataSource = this.phisicalFaceBindingSource2;
            this.PhisicalFaceView.Location = new System.Drawing.Point(2, 1);
            this.PhisicalFaceView.Name = "PhisicalFaceView";
            this.PhisicalFaceView.RowHeadersVisible = false;
            this.PhisicalFaceView.Size = new System.Drawing.Size(1339, 231);
            this.PhisicalFaceView.TabIndex = 0;
            this.PhisicalFaceView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PhisicalFaceView_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PFId";
            this.Column1.HeaderText = "Номер";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // pFFullRussNameDataGridViewTextBoxColumn
            // 
            this.pFFullRussNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pFFullRussNameDataGridViewTextBoxColumn.DataPropertyName = "PFFullRussName";
            this.pFFullRussNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.pFFullRussNameDataGridViewTextBoxColumn.Name = "pFFullRussNameDataGridViewTextBoxColumn";
            this.pFFullRussNameDataGridViewTextBoxColumn.Width = 59;
            // 
            // pFFullEngNameDataGridViewTextBoxColumn
            // 
            this.pFFullEngNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pFFullEngNameDataGridViewTextBoxColumn.DataPropertyName = "PFFullEngName";
            this.pFFullEngNameDataGridViewTextBoxColumn.HeaderText = "ФИО(Eng)";
            this.pFFullEngNameDataGridViewTextBoxColumn.Name = "pFFullEngNameDataGridViewTextBoxColumn";
            this.pFFullEngNameDataGridViewTextBoxColumn.Width = 84;
            // 
            // pFBirthdayDataGridViewTextBoxColumn
            // 
            this.pFBirthdayDataGridViewTextBoxColumn.DataPropertyName = "PFBirthday";
            this.pFBirthdayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.pFBirthdayDataGridViewTextBoxColumn.Name = "pFBirthdayDataGridViewTextBoxColumn";
            this.pFBirthdayDataGridViewTextBoxColumn.Width = 80;
            // 
            // pFNumAndSerRussPassportDataGridViewTextBoxColumn
            // 
            this.pFNumAndSerRussPassportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pFNumAndSerRussPassportDataGridViewTextBoxColumn.DataPropertyName = "PFNumAndSerRussPassport";
            this.pFNumAndSerRussPassportDataGridViewTextBoxColumn.HeaderText = "Номер и серия русского паспорта";
            this.pFNumAndSerRussPassportDataGridViewTextBoxColumn.Name = "pFNumAndSerRussPassportDataGridViewTextBoxColumn";
            this.pFNumAndSerRussPassportDataGridViewTextBoxColumn.Width = 146;
            // 
            // pFDateGetRussPassportDataGridViewTextBoxColumn
            // 
            this.pFDateGetRussPassportDataGridViewTextBoxColumn.DataPropertyName = "PFDateGetRussPassport";
            this.pFDateGetRussPassportDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.pFDateGetRussPassportDataGridViewTextBoxColumn.Name = "pFDateGetRussPassportDataGridViewTextBoxColumn";
            this.pFDateGetRussPassportDataGridViewTextBoxColumn.Width = 80;
            // 
            // pFOrgGetRussPassportDataGridViewTextBoxColumn
            // 
            this.pFOrgGetRussPassportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pFOrgGetRussPassportDataGridViewTextBoxColumn.DataPropertyName = "PFOrgGetRussPassport";
            this.pFOrgGetRussPassportDataGridViewTextBoxColumn.HeaderText = "Орган выдавший паспорт";
            this.pFOrgGetRussPassportDataGridViewTextBoxColumn.Name = "pFOrgGetRussPassportDataGridViewTextBoxColumn";
            this.pFOrgGetRussPassportDataGridViewTextBoxColumn.Width = 148;
            // 
            // pFNumAndSerForeignPassportDataGridViewTextBoxColumn
            // 
            this.pFNumAndSerForeignPassportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pFNumAndSerForeignPassportDataGridViewTextBoxColumn.DataPropertyName = "PFNumAndSerForeignPassport";
            this.pFNumAndSerForeignPassportDataGridViewTextBoxColumn.HeaderText = "Номер и серия зарубежного паспорта";
            this.pFNumAndSerForeignPassportDataGridViewTextBoxColumn.Name = "pFNumAndSerForeignPassportDataGridViewTextBoxColumn";
            this.pFNumAndSerForeignPassportDataGridViewTextBoxColumn.Width = 164;
            // 
            // pFDateGetForeignPassportDataGridViewTextBoxColumn
            // 
            this.pFDateGetForeignPassportDataGridViewTextBoxColumn.DataPropertyName = "PFDateGetForeignPassport";
            this.pFDateGetForeignPassportDataGridViewTextBoxColumn.HeaderText = "Дата выдачи ";
            this.pFDateGetForeignPassportDataGridViewTextBoxColumn.Name = "pFDateGetForeignPassportDataGridViewTextBoxColumn";
            this.pFDateGetForeignPassportDataGridViewTextBoxColumn.Width = 80;
            // 
            // pFDateEndForeignPassportDataGridViewTextBoxColumn
            // 
            this.pFDateEndForeignPassportDataGridViewTextBoxColumn.DataPropertyName = "PFDateEndForeignPassport";
            this.pFDateEndForeignPassportDataGridViewTextBoxColumn.HeaderText = "Дата окончания ";
            this.pFDateEndForeignPassportDataGridViewTextBoxColumn.Name = "pFDateEndForeignPassportDataGridViewTextBoxColumn";
            this.pFDateEndForeignPassportDataGridViewTextBoxColumn.Width = 80;
            // 
            // pFOrgGetForeignPassportDataGridViewTextBoxColumn
            // 
            this.pFOrgGetForeignPassportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pFOrgGetForeignPassportDataGridViewTextBoxColumn.DataPropertyName = "PFOrgGetForeignPassport";
            this.pFOrgGetForeignPassportDataGridViewTextBoxColumn.HeaderText = "Орган выдавший паспорт";
            this.pFOrgGetForeignPassportDataGridViewTextBoxColumn.Name = "pFOrgGetForeignPassportDataGridViewTextBoxColumn";
            this.pFOrgGetForeignPassportDataGridViewTextBoxColumn.Width = 148;
            // 
            // pFBirthPlaceDataGridViewTextBoxColumn
            // 
            this.pFBirthPlaceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pFBirthPlaceDataGridViewTextBoxColumn.DataPropertyName = "PFBirthPlace";
            this.pFBirthPlaceDataGridViewTextBoxColumn.HeaderText = "Место рождения";
            this.pFBirthPlaceDataGridViewTextBoxColumn.Name = "pFBirthPlaceDataGridViewTextBoxColumn";
            this.pFBirthPlaceDataGridViewTextBoxColumn.Width = 107;
            // 
            // pFPhoneDataGridViewTextBoxColumn
            // 
            this.pFPhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pFPhoneDataGridViewTextBoxColumn.DataPropertyName = "PFPhone";
            this.pFPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.pFPhoneDataGridViewTextBoxColumn.Name = "pFPhoneDataGridViewTextBoxColumn";
            this.pFPhoneDataGridViewTextBoxColumn.Width = 77;
            // 
            // phisicalFaceBindingSource2
            // 
            this.phisicalFaceBindingSource2.DataMember = "PhisicalFace";
            this.phisicalFaceBindingSource2.DataSource = this.radugaDBDataSet22;
            // 
            // radugaDBDataSet22
            // 
            this.radugaDBDataSet22.DataSetName = "RadugaDBDataSet22";
            this.radugaDBDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phisicalFaceBindingSource1
            // 
            this.phisicalFaceBindingSource1.DataMember = "PhisicalFace";
            this.phisicalFaceBindingSource1.DataSource = this.radugaDBDataSet20;
            // 
            // radugaDBDataSet20
            // 
            this.radugaDBDataSet20.DataSetName = "RadugaDBDataSet20";
            this.radugaDBDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phisicalFaceBindingSource
            // 
            this.phisicalFaceBindingSource.DataMember = "PhisicalFace";
            this.phisicalFaceBindingSource.DataSource = this.radugaDBDataSet4;
            // 
            // radugaDBDataSet4
            // 
            this.radugaDBDataSet4.DataSetName = "RadugaDBDataSet4";
            this.radugaDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phisicalFaceTableAdapter
            // 
            this.phisicalFaceTableAdapter.ClearBeforeFill = true;
            // 
            // phisicalFaceTableAdapter1
            // 
            this.phisicalFaceTableAdapter1.ClearBeforeFill = true;
            // 
            // addPFbutton
            // 
            this.addPFbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addPFbutton.Location = new System.Drawing.Point(407, 239);
            this.addPFbutton.Name = "addPFbutton";
            this.addPFbutton.Size = new System.Drawing.Size(135, 23);
            this.addPFbutton.TabIndex = 1;
            this.addPFbutton.Text = "Добавить";
            this.addPFbutton.UseVisualStyleBackColor = true;
            this.addPFbutton.Click += new System.EventHandler(this.addPFbutton_Click);
            // 
            // changePFbutton
            // 
            this.changePFbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.changePFbutton.Location = new System.Drawing.Point(548, 239);
            this.changePFbutton.Name = "changePFbutton";
            this.changePFbutton.Size = new System.Drawing.Size(135, 23);
            this.changePFbutton.TabIndex = 2;
            this.changePFbutton.Text = "Изменить";
            this.changePFbutton.UseVisualStyleBackColor = true;
            this.changePFbutton.Click += new System.EventHandler(this.changePFbutton_Click);
            // 
            // cancelPFbutton
            // 
            this.cancelPFbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelPFbutton.Location = new System.Drawing.Point(689, 239);
            this.cancelPFbutton.Name = "cancelPFbutton";
            this.cancelPFbutton.Size = new System.Drawing.Size(135, 23);
            this.cancelPFbutton.TabIndex = 3;
            this.cancelPFbutton.Text = "Отменить";
            this.cancelPFbutton.UseVisualStyleBackColor = true;
            this.cancelPFbutton.Click += new System.EventHandler(this.cancelPFbutton_Click);
            // 
            // phisicalFaceTableAdapter2
            // 
            this.phisicalFaceTableAdapter2.ClearBeforeFill = true;
            // 
            // PFTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 268);
            this.Controls.Add(this.cancelPFbutton);
            this.Controls.Add(this.changePFbutton);
            this.Controls.Add(this.addPFbutton);
            this.Controls.Add(this.PhisicalFaceView);
            this.MinimumSize = new System.Drawing.Size(1200, 300);
            this.Name = "PFTableForm";
            this.Text = "Физические лица";
            this.Load += new System.EventHandler(this.PFTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhisicalFaceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalFaceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalFaceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalFaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PhisicalFaceView;
        private RadugaDBDataSet4 radugaDBDataSet4;
        private System.Windows.Forms.BindingSource phisicalFaceBindingSource;
        private RadugaDBDataSet4TableAdapters.PhisicalFaceTableAdapter phisicalFaceTableAdapter;
        private RadugaDBDataSet20 radugaDBDataSet20;
        private System.Windows.Forms.BindingSource phisicalFaceBindingSource1;
        private RadugaDBDataSet20TableAdapters.PhisicalFaceTableAdapter phisicalFaceTableAdapter1;
        private System.Windows.Forms.Button addPFbutton;
        private System.Windows.Forms.Button changePFbutton;
        private System.Windows.Forms.Button cancelPFbutton;
        private RadugaDBDataSet22 radugaDBDataSet22;
        private System.Windows.Forms.BindingSource phisicalFaceBindingSource2;
        private RadugaDBDataSet22TableAdapters.PhisicalFaceTableAdapter phisicalFaceTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFFullRussNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFFullEngNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFBirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFNumAndSerRussPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFDateGetRussPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFOrgGetRussPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFNumAndSerForeignPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFDateGetForeignPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFDateEndForeignPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFOrgGetForeignPassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFBirthPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFPhoneDataGridViewTextBoxColumn;
    }
}