namespace RadugaTur
{
    partial class ArchiveTableForm
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
            this.radugaDBDataSet11 = new RadugaTur.RadugaDBDataSet11();
            this.archiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archiveTableAdapter = new RadugaTur.RadugaDBDataSet11TableAdapters.ArchiveTableAdapter();
            this.arDateContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDateArriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arNumDaysHealthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arCostWithoutProcentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arSumPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDateSumPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arAccountNumberSanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDateAccNumSanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arAccountNumberRadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDateAccNumRadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arMoneyOrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDateMoneyOrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arPaySanRadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDatePaySanRadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arDebtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arOtherMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.arDateContractDataGridViewTextBoxColumn,
            this.arDateArriveDataGridViewTextBoxColumn,
            this.arNumDaysHealthDataGridViewTextBoxColumn,
            this.arCostDataGridViewTextBoxColumn,
            this.arCostWithoutProcentDataGridViewTextBoxColumn,
            this.arSumPayDataGridViewTextBoxColumn,
            this.arDateSumPayDataGridViewTextBoxColumn,
            this.arAccountNumberSanDataGridViewTextBoxColumn,
            this.arDateAccNumSanDataGridViewTextBoxColumn,
            this.arAccountNumberRadDataGridViewTextBoxColumn,
            this.arDateAccNumRadDataGridViewTextBoxColumn,
            this.arMoneyOrgDataGridViewTextBoxColumn,
            this.arDateMoneyOrgDataGridViewTextBoxColumn,
            this.arPaySanRadDataGridViewTextBoxColumn,
            this.arDatePaySanRadDataGridViewTextBoxColumn,
            this.arDebtDataGridViewTextBoxColumn,
            this.arOtherMoneyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.archiveBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1357, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // radugaDBDataSet11
            // 
            this.radugaDBDataSet11.DataSetName = "RadugaDBDataSet11";
            this.radugaDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archiveBindingSource
            // 
            this.archiveBindingSource.DataMember = "Archive";
            this.archiveBindingSource.DataSource = this.radugaDBDataSet11;
            // 
            // archiveTableAdapter
            // 
            this.archiveTableAdapter.ClearBeforeFill = true;
            // 
            // arDateContractDataGridViewTextBoxColumn
            // 
            this.arDateContractDataGridViewTextBoxColumn.DataPropertyName = "ArDateContract";
            this.arDateContractDataGridViewTextBoxColumn.HeaderText = "Дата договора";
            this.arDateContractDataGridViewTextBoxColumn.Name = "arDateContractDataGridViewTextBoxColumn";
            this.arDateContractDataGridViewTextBoxColumn.Width = 80;
            // 
            // arDateArriveDataGridViewTextBoxColumn
            // 
            this.arDateArriveDataGridViewTextBoxColumn.DataPropertyName = "ArDateArrive";
            this.arDateArriveDataGridViewTextBoxColumn.HeaderText = "Дата заезда";
            this.arDateArriveDataGridViewTextBoxColumn.Name = "arDateArriveDataGridViewTextBoxColumn";
            this.arDateArriveDataGridViewTextBoxColumn.Width = 80;
            // 
            // arNumDaysHealthDataGridViewTextBoxColumn
            // 
            this.arNumDaysHealthDataGridViewTextBoxColumn.DataPropertyName = "ArNumDaysHealth";
            this.arNumDaysHealthDataGridViewTextBoxColumn.HeaderText = "Продолжительность лечения";
            this.arNumDaysHealthDataGridViewTextBoxColumn.Name = "arNumDaysHealthDataGridViewTextBoxColumn";
            this.arNumDaysHealthDataGridViewTextBoxColumn.Width = 50;
            // 
            // arCostDataGridViewTextBoxColumn
            // 
            this.arCostDataGridViewTextBoxColumn.DataPropertyName = "ArCost";
            this.arCostDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.arCostDataGridViewTextBoxColumn.Name = "arCostDataGridViewTextBoxColumn";
            this.arCostDataGridViewTextBoxColumn.Width = 80;
            // 
            // arCostWithoutProcentDataGridViewTextBoxColumn
            // 
            this.arCostWithoutProcentDataGridViewTextBoxColumn.DataPropertyName = "ArCostWithoutProcent";
            this.arCostWithoutProcentDataGridViewTextBoxColumn.HeaderText = "Стоимость без процентов";
            this.arCostWithoutProcentDataGridViewTextBoxColumn.Name = "arCostWithoutProcentDataGridViewTextBoxColumn";
            this.arCostWithoutProcentDataGridViewTextBoxColumn.Width = 80;
            // 
            // arSumPayDataGridViewTextBoxColumn
            // 
            this.arSumPayDataGridViewTextBoxColumn.DataPropertyName = "ArSumPay";
            this.arSumPayDataGridViewTextBoxColumn.HeaderText = "Сумма оплаты";
            this.arSumPayDataGridViewTextBoxColumn.Name = "arSumPayDataGridViewTextBoxColumn";
            this.arSumPayDataGridViewTextBoxColumn.Width = 80;
            // 
            // arDateSumPayDataGridViewTextBoxColumn
            // 
            this.arDateSumPayDataGridViewTextBoxColumn.DataPropertyName = "ArDateSumPay";
            this.arDateSumPayDataGridViewTextBoxColumn.HeaderText = "Дата оплаты";
            this.arDateSumPayDataGridViewTextBoxColumn.Name = "arDateSumPayDataGridViewTextBoxColumn";
            this.arDateSumPayDataGridViewTextBoxColumn.Width = 80;
            // 
            // arAccountNumberSanDataGridViewTextBoxColumn
            // 
            this.arAccountNumberSanDataGridViewTextBoxColumn.DataPropertyName = "ArAccountNumberSan";
            this.arAccountNumberSanDataGridViewTextBoxColumn.HeaderText = "Счёт санатория";
            this.arAccountNumberSanDataGridViewTextBoxColumn.Name = "arAccountNumberSanDataGridViewTextBoxColumn";
            this.arAccountNumberSanDataGridViewTextBoxColumn.Width = 80;
            // 
            // arDateAccNumSanDataGridViewTextBoxColumn
            // 
            this.arDateAccNumSanDataGridViewTextBoxColumn.DataPropertyName = "ArDateAccNumSan";
            this.arDateAccNumSanDataGridViewTextBoxColumn.HeaderText = "Дата счёта";
            this.arDateAccNumSanDataGridViewTextBoxColumn.Name = "arDateAccNumSanDataGridViewTextBoxColumn";
            this.arDateAccNumSanDataGridViewTextBoxColumn.Width = 80;
            // 
            // arAccountNumberRadDataGridViewTextBoxColumn
            // 
            this.arAccountNumberRadDataGridViewTextBoxColumn.DataPropertyName = "ArAccountNumberRad";
            this.arAccountNumberRadDataGridViewTextBoxColumn.HeaderText = "Счёт Радуги";
            this.arAccountNumberRadDataGridViewTextBoxColumn.Name = "arAccountNumberRadDataGridViewTextBoxColumn";
            this.arAccountNumberRadDataGridViewTextBoxColumn.Width = 80;
            // 
            // arDateAccNumRadDataGridViewTextBoxColumn
            // 
            this.arDateAccNumRadDataGridViewTextBoxColumn.DataPropertyName = "ArDateAccNumRad";
            this.arDateAccNumRadDataGridViewTextBoxColumn.HeaderText = "Дата счёта Радуги";
            this.arDateAccNumRadDataGridViewTextBoxColumn.Name = "arDateAccNumRadDataGridViewTextBoxColumn";
            this.arDateAccNumRadDataGridViewTextBoxColumn.Width = 80;
            // 
            // arMoneyOrgDataGridViewTextBoxColumn
            // 
            this.arMoneyOrgDataGridViewTextBoxColumn.DataPropertyName = "ArMoneyOrg";
            this.arMoneyOrgDataGridViewTextBoxColumn.HeaderText = "Поступление ден. средств от организации";
            this.arMoneyOrgDataGridViewTextBoxColumn.Name = "arMoneyOrgDataGridViewTextBoxColumn";
            this.arMoneyOrgDataGridViewTextBoxColumn.Width = 80;
            // 
            // arDateMoneyOrgDataGridViewTextBoxColumn
            // 
            this.arDateMoneyOrgDataGridViewTextBoxColumn.DataPropertyName = "ArDateMoneyOrg";
            this.arDateMoneyOrgDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.arDateMoneyOrgDataGridViewTextBoxColumn.Name = "arDateMoneyOrgDataGridViewTextBoxColumn";
            this.arDateMoneyOrgDataGridViewTextBoxColumn.Width = 80;
            // 
            // arPaySanRadDataGridViewTextBoxColumn
            // 
            this.arPaySanRadDataGridViewTextBoxColumn.DataPropertyName = "ArPaySanRad";
            this.arPaySanRadDataGridViewTextBoxColumn.HeaderText = "Оплата за санатория от Радуги";
            this.arPaySanRadDataGridViewTextBoxColumn.Name = "arPaySanRadDataGridViewTextBoxColumn";
            this.arPaySanRadDataGridViewTextBoxColumn.Width = 80;
            // 
            // arDatePaySanRadDataGridViewTextBoxColumn
            // 
            this.arDatePaySanRadDataGridViewTextBoxColumn.DataPropertyName = "ArDatePaySanRad";
            this.arDatePaySanRadDataGridViewTextBoxColumn.HeaderText = "Дата оплаты за санаторий";
            this.arDatePaySanRadDataGridViewTextBoxColumn.Name = "arDatePaySanRadDataGridViewTextBoxColumn";
            this.arDatePaySanRadDataGridViewTextBoxColumn.Width = 80;
            // 
            // arDebtDataGridViewTextBoxColumn
            // 
            this.arDebtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.arDebtDataGridViewTextBoxColumn.DataPropertyName = "ArDebt";
            this.arDebtDataGridViewTextBoxColumn.HeaderText = "Долг";
            this.arDebtDataGridViewTextBoxColumn.Name = "arDebtDataGridViewTextBoxColumn";
            this.arDebtDataGridViewTextBoxColumn.Width = 58;
            // 
            // arOtherMoneyDataGridViewTextBoxColumn
            // 
            this.arOtherMoneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.arOtherMoneyDataGridViewTextBoxColumn.DataPropertyName = "ArOtherMoney";
            this.arOtherMoneyDataGridViewTextBoxColumn.HeaderText = "Чужие";
            this.arOtherMoneyDataGridViewTextBoxColumn.Name = "arOtherMoneyDataGridViewTextBoxColumn";
            this.arOtherMoneyDataGridViewTextBoxColumn.Width = 65;
            // 
            // ArchiveTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 200);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ArchiveTableForm";
            this.Text = "Архив";
            this.Load += new System.EventHandler(this.ArchiveTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RadugaDBDataSet11 radugaDBDataSet11;
        private System.Windows.Forms.BindingSource archiveBindingSource;
        private RadugaDBDataSet11TableAdapters.ArchiveTableAdapter archiveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDateContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDateArriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arNumDaysHealthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arCostWithoutProcentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arSumPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDateSumPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arAccountNumberSanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDateAccNumSanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arAccountNumberRadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDateAccNumRadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arMoneyOrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDateMoneyOrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arPaySanRadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDatePaySanRadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arDebtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arOtherMoneyDataGridViewTextBoxColumn;


    }
}