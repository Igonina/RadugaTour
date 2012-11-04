namespace RadugaTur
{
    partial class AccountRadTable
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
            this.accountRadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radugaDBDataSet15 = new RadugaTur.RadugaDBDataSet15();
            this.accountRadTableAdapter = new RadugaTur.RadugaDBDataSet15TableAdapters.AccountRadTableAdapter();
            this.accRadAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accRadDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accRadSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accRadAccountSanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accRadAccountDataGridViewTextBoxColumn,
            this.accRadDateDataGridViewTextBoxColumn,
            this.accRadSumDataGridViewTextBoxColumn,
            this.accRadAccountSanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountRadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // accountRadBindingSource
            // 
            this.accountRadBindingSource.DataMember = "AccountRad";
            this.accountRadBindingSource.DataSource = this.radugaDBDataSet15;
            // 
            // radugaDBDataSet15
            // 
            this.radugaDBDataSet15.DataSetName = "RadugaDBDataSet15";
            this.radugaDBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountRadTableAdapter
            // 
            this.accountRadTableAdapter.ClearBeforeFill = true;
            // 
            // accRadAccountDataGridViewTextBoxColumn
            // 
            this.accRadAccountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accRadAccountDataGridViewTextBoxColumn.DataPropertyName = "AccRadAccount";
            this.accRadAccountDataGridViewTextBoxColumn.HeaderText = "Номер платёжного поручения";
            this.accRadAccountDataGridViewTextBoxColumn.Name = "accRadAccountDataGridViewTextBoxColumn";
            this.accRadAccountDataGridViewTextBoxColumn.Width = 168;
            // 
            // accRadDateDataGridViewTextBoxColumn
            // 
            this.accRadDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accRadDateDataGridViewTextBoxColumn.DataPropertyName = "AccRadDate";
            this.accRadDateDataGridViewTextBoxColumn.HeaderText = "Дата платёжного поручения";
            this.accRadDateDataGridViewTextBoxColumn.Name = "accRadDateDataGridViewTextBoxColumn";
            this.accRadDateDataGridViewTextBoxColumn.Width = 160;
            // 
            // accRadSumDataGridViewTextBoxColumn
            // 
            this.accRadSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accRadSumDataGridViewTextBoxColumn.DataPropertyName = "AccRadSum";
            this.accRadSumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.accRadSumDataGridViewTextBoxColumn.Name = "accRadSumDataGridViewTextBoxColumn";
            this.accRadSumDataGridViewTextBoxColumn.Width = 66;
            // 
            // accRadAccountSanDataGridViewTextBoxColumn
            // 
            this.accRadAccountSanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accRadAccountSanDataGridViewTextBoxColumn.DataPropertyName = "AccRadAccountSan";
            this.accRadAccountSanDataGridViewTextBoxColumn.HeaderText = "Счёт санатория";
            this.accRadAccountSanDataGridViewTextBoxColumn.Name = "accRadAccountSanDataGridViewTextBoxColumn";
            this.accRadAccountSanDataGridViewTextBoxColumn.Width = 102;
            // 
            // AccountRadTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 168);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AccountRadTable";
            this.Text = "Платёжное поручение";
            this.Load += new System.EventHandler(this.AccountRadTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RadugaDBDataSet15 radugaDBDataSet15;
        private System.Windows.Forms.BindingSource accountRadBindingSource;
        private RadugaDBDataSet15TableAdapters.AccountRadTableAdapter accountRadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accRadAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accRadDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accRadSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accRadAccountSanDataGridViewTextBoxColumn;
    }
}