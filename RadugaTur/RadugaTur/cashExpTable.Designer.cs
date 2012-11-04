namespace RadugaTur
{
    partial class cashExpTable
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
            this.radugaDBDataSet18 = new RadugaTur.RadugaDBDataSet18();
            this.expendableOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expendableOrderTableAdapter = new RadugaTur.RadugaDBDataSet18TableAdapters.ExpendableOrderTableAdapter();
            this.useNumDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expendableOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useNumDocDataGridViewTextBoxColumn,
            this.useDateDataGridViewTextBoxColumn,
            this.useSumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expendableOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // radugaDBDataSet18
            // 
            this.radugaDBDataSet18.DataSetName = "RadugaDBDataSet18";
            this.radugaDBDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expendableOrderBindingSource
            // 
            this.expendableOrderBindingSource.DataMember = "ExpendableOrder";
            this.expendableOrderBindingSource.DataSource = this.radugaDBDataSet18;
            // 
            // expendableOrderTableAdapter
            // 
            this.expendableOrderTableAdapter.ClearBeforeFill = true;
            // 
            // useNumDocDataGridViewTextBoxColumn
            // 
            this.useNumDocDataGridViewTextBoxColumn.DataPropertyName = "useNumDoc";
            this.useNumDocDataGridViewTextBoxColumn.HeaderText = "Номер документа";
            this.useNumDocDataGridViewTextBoxColumn.Name = "useNumDocDataGridViewTextBoxColumn";
            // 
            // useDateDataGridViewTextBoxColumn
            // 
            this.useDateDataGridViewTextBoxColumn.DataPropertyName = "useDate";
            this.useDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.useDateDataGridViewTextBoxColumn.Name = "useDateDataGridViewTextBoxColumn";
            // 
            // useSumDataGridViewTextBoxColumn
            // 
            this.useSumDataGridViewTextBoxColumn.DataPropertyName = "useSum";
            this.useSumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.useSumDataGridViewTextBoxColumn.Name = "useSumDataGridViewTextBoxColumn";
            // 
            // cashExpTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 188);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cashExpTable";
            this.Text = "Расходный кассовый ордер";
            this.Load += new System.EventHandler(this.cashExpTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expendableOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RadugaDBDataSet18 radugaDBDataSet18;
        private System.Windows.Forms.BindingSource expendableOrderBindingSource;
        private RadugaDBDataSet18TableAdapters.ExpendableOrderTableAdapter expendableOrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useNumDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useSumDataGridViewTextBoxColumn;
    }
}