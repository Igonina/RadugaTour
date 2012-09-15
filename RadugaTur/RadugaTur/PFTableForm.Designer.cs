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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radugaDBDataSet4 = new RadugaTur.RadugaDBDataSet4();
            this.phisicalFaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phisicalFaceTableAdapter = new RadugaTur.RadugaDBDataSet4TableAdapters.PhisicalFaceTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalFaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.phisicalFaceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1339, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // radugaDBDataSet4
            // 
            this.radugaDBDataSet4.DataSetName = "RadugaDBDataSet4";
            this.radugaDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phisicalFaceBindingSource
            // 
            this.phisicalFaceBindingSource.DataMember = "PhisicalFace";
            this.phisicalFaceBindingSource.DataSource = this.radugaDBDataSet4;
            // 
            // phisicalFaceTableAdapter
            // 
            this.phisicalFaceTableAdapter.ClearBeforeFill = true;
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
            // PFTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PFTableForm";
            this.Text = "Физические лица";
            this.Load += new System.EventHandler(this.PFTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phisicalFaceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RadugaDBDataSet4 radugaDBDataSet4;
        private System.Windows.Forms.BindingSource phisicalFaceBindingSource;
        private RadugaDBDataSet4TableAdapters.PhisicalFaceTableAdapter phisicalFaceTableAdapter;
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