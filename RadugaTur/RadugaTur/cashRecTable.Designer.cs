namespace RadugaTur
{
    partial class cashRecTable
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
            this.radugaDBDataSet17 = new RadugaTur.RadugaDBDataSet17();
            this.cashReceiptesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashReceiptesTableAdapter = new RadugaTur.RadugaDBDataSet17TableAdapters.CashReceiptesTableAdapter();
            this.cashNumberDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashReceiptesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cashNumberDocDataGridViewTextBoxColumn,
            this.cashDataDataGridViewTextBoxColumn,
            this.cashSumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cashReceiptesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // radugaDBDataSet17
            // 
            this.radugaDBDataSet17.DataSetName = "RadugaDBDataSet17";
            this.radugaDBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashReceiptesBindingSource
            // 
            this.cashReceiptesBindingSource.DataMember = "CashReceiptes";
            this.cashReceiptesBindingSource.DataSource = this.radugaDBDataSet17;
            // 
            // cashReceiptesTableAdapter
            // 
            this.cashReceiptesTableAdapter.ClearBeforeFill = true;
            // 
            // cashNumberDocDataGridViewTextBoxColumn
            // 
            this.cashNumberDocDataGridViewTextBoxColumn.DataPropertyName = "cashNumberDoc";
            this.cashNumberDocDataGridViewTextBoxColumn.HeaderText = "Номер документа";
            this.cashNumberDocDataGridViewTextBoxColumn.Name = "cashNumberDocDataGridViewTextBoxColumn";
            // 
            // cashDataDataGridViewTextBoxColumn
            // 
            this.cashDataDataGridViewTextBoxColumn.DataPropertyName = "cashData";
            this.cashDataDataGridViewTextBoxColumn.HeaderText = "Дата документа";
            this.cashDataDataGridViewTextBoxColumn.Name = "cashDataDataGridViewTextBoxColumn";
            // 
            // cashSumDataGridViewTextBoxColumn
            // 
            this.cashSumDataGridViewTextBoxColumn.DataPropertyName = "cashSum";
            this.cashSumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.cashSumDataGridViewTextBoxColumn.Name = "cashSumDataGridViewTextBoxColumn";
            // 
            // cashRecTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 202);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cashRecTable";
            this.Text = "Приходный кассовый ордер";
            this.Load += new System.EventHandler(this.cashRecTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashReceiptesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RadugaDBDataSet17 radugaDBDataSet17;
        private System.Windows.Forms.BindingSource cashReceiptesBindingSource;
        private RadugaDBDataSet17TableAdapters.CashReceiptesTableAdapter cashReceiptesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashNumberDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashSumDataGridViewTextBoxColumn;
    }
}