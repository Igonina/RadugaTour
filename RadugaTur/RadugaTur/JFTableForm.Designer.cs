namespace RadugaTur
{
    partial class JFTableForm
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
            this.radugaDBDataSet3 = new RadugaTur.RadugaDBDataSet3();
            this.juridicalFaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juridicalFaceTableAdapter = new RadugaTur.RadugaDBDataSet3TableAdapters.JuridicalFaceTableAdapter();
            this.jFNameOrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jFFullNameOrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jFFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jFPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jFCargoCarrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juridicalFaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jFNameOrgDataGridViewTextBoxColumn,
            this.jFFullNameOrgDataGridViewTextBoxColumn,
            this.jFFullNameDataGridViewTextBoxColumn,
            this.jFPhoneDataGridViewTextBoxColumn,
            this.jFCargoCarrierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.juridicalFaceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1296, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // radugaDBDataSet3
            // 
            this.radugaDBDataSet3.DataSetName = "RadugaDBDataSet3";
            this.radugaDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // juridicalFaceBindingSource
            // 
            this.juridicalFaceBindingSource.DataMember = "JuridicalFace";
            this.juridicalFaceBindingSource.DataSource = this.radugaDBDataSet3;
            // 
            // juridicalFaceTableAdapter
            // 
            this.juridicalFaceTableAdapter.ClearBeforeFill = true;
            // 
            // jFNameOrgDataGridViewTextBoxColumn
            // 
            this.jFNameOrgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jFNameOrgDataGridViewTextBoxColumn.DataPropertyName = "JFNameOrg";
            this.jFNameOrgDataGridViewTextBoxColumn.HeaderText = " Краткое название организации";
            this.jFNameOrgDataGridViewTextBoxColumn.Name = "jFNameOrgDataGridViewTextBoxColumn";
            this.jFNameOrgDataGridViewTextBoxColumn.Width = 178;
            // 
            // jFFullNameOrgDataGridViewTextBoxColumn
            // 
            this.jFFullNameOrgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jFFullNameOrgDataGridViewTextBoxColumn.DataPropertyName = "JFFullNameOrg";
            this.jFFullNameOrgDataGridViewTextBoxColumn.HeaderText = "Полное название организации";
            this.jFFullNameOrgDataGridViewTextBoxColumn.Name = "jFFullNameOrgDataGridViewTextBoxColumn";
            this.jFFullNameOrgDataGridViewTextBoxColumn.Width = 172;
            // 
            // jFFullNameDataGridViewTextBoxColumn
            // 
            this.jFFullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jFFullNameDataGridViewTextBoxColumn.DataPropertyName = "JFFullName";
            this.jFFullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.jFFullNameDataGridViewTextBoxColumn.Name = "jFFullNameDataGridViewTextBoxColumn";
            this.jFFullNameDataGridViewTextBoxColumn.Width = 59;
            // 
            // jFPhoneDataGridViewTextBoxColumn
            // 
            this.jFPhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jFPhoneDataGridViewTextBoxColumn.DataPropertyName = "JFPhone";
            this.jFPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.jFPhoneDataGridViewTextBoxColumn.Name = "jFPhoneDataGridViewTextBoxColumn";
            this.jFPhoneDataGridViewTextBoxColumn.Width = 77;
            // 
            // jFCargoCarrierDataGridViewTextBoxColumn
            // 
            this.jFCargoCarrierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jFCargoCarrierDataGridViewTextBoxColumn.DataPropertyName = "JFCargoCarrier";
            this.jFCargoCarrierDataGridViewTextBoxColumn.HeaderText = "Грузоперевозчик";
            this.jFCargoCarrierDataGridViewTextBoxColumn.Name = "jFCargoCarrierDataGridViewTextBoxColumn";
            this.jFCargoCarrierDataGridViewTextBoxColumn.Width = 120;
            // 
            // JFTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JFTableForm";
            this.Text = "Юридические лица";
            this.Load += new System.EventHandler(this.JFTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juridicalFaceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RadugaDBDataSet3 radugaDBDataSet3;
        private System.Windows.Forms.BindingSource juridicalFaceBindingSource;
        private RadugaDBDataSet3TableAdapters.JuridicalFaceTableAdapter juridicalFaceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jFNameOrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jFFullNameOrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jFFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jFPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jFCargoCarrierDataGridViewTextBoxColumn;
    }
}