namespace RadugaTur
{
    partial class AccountSanTable
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
            this.radugaDBDataSet14 = new RadugaTur.RadugaDBDataSet14();
            this.accountSanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountSanTableAdapter = new RadugaTur.RadugaDBDataSet14TableAdapters.AccountSanTableAdapter();
            this.accAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountSanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accAccountDataGridViewTextBoxColumn,
            this.accDateDataGridViewTextBoxColumn,
            this.accSumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountSanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 98);
            this.dataGridView1.TabIndex = 0;
           
            // 
            // radugaDBDataSet14
            // 
            this.radugaDBDataSet14.DataSetName = "RadugaDBDataSet14";
            this.radugaDBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountSanBindingSource
            // 
            this.accountSanBindingSource.DataMember = "AccountSan";
            this.accountSanBindingSource.DataSource = this.radugaDBDataSet14;
            // 
            // accountSanTableAdapter
            // 
            this.accountSanTableAdapter.ClearBeforeFill = true;
            // 
            // accAccountDataGridViewTextBoxColumn
            // 
            this.accAccountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accAccountDataGridViewTextBoxColumn.DataPropertyName = "accAccount";
            this.accAccountDataGridViewTextBoxColumn.HeaderText = "Номер счёта";
            this.accAccountDataGridViewTextBoxColumn.Name = "accAccountDataGridViewTextBoxColumn";
            this.accAccountDataGridViewTextBoxColumn.Width = 97;
            // 
            // accDateDataGridViewTextBoxColumn
            // 
            this.accDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accDateDataGridViewTextBoxColumn.DataPropertyName = "accDate";
            this.accDateDataGridViewTextBoxColumn.HeaderText = "Дата счёта";
            this.accDateDataGridViewTextBoxColumn.Name = "accDateDataGridViewTextBoxColumn";
            this.accDateDataGridViewTextBoxColumn.Width = 89;
            // 
            // accSumDataGridViewTextBoxColumn
            // 
            this.accSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accSumDataGridViewTextBoxColumn.DataPropertyName = "accSum";
            this.accSumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.accSumDataGridViewTextBoxColumn.Name = "accSumDataGridViewTextBoxColumn";
            this.accSumDataGridViewTextBoxColumn.Width = 66;
            // 
            // AccountSanTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 108);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AccountSanTable";
            this.Text = "Счёт санатория";
            this.Load += new System.EventHandler(this.AccountSanTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountSanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RadugaDBDataSet14 radugaDBDataSet14;
        private System.Windows.Forms.BindingSource accountSanBindingSource;
        private RadugaDBDataSet14TableAdapters.AccountSanTableAdapter accountSanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accSumDataGridViewTextBoxColumn;
    }
}