namespace RadugaTur
{
    partial class ManagerFormTable
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
            this.managerTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radugaTourDatabaseDataSet1 = new RadugaTur.RadugaTourDatabaseDataSet1();
            this.radugaTourDatabaseDataSet2 = new RadugaTur.RadugaTourDatabaseDataSet2();
            this.radugaTourDatabaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTable1TableAdapter = new RadugaTur.RadugaTourDatabaseDataSet1TableAdapters.ManagerTable1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hashNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radugaDBDataSet16 = new RadugaTur.RadugaDBDataSet16();
            this.managerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radugaDBDataSet = new RadugaTur.RadugaDBDataSet();
            this.managerTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radugaTourDatabaseDataSet3 = new RadugaTur.RadugaTourDatabaseDataSet3();
            this.managerTable1TableAdapter1 = new RadugaTur.RadugaTourDatabaseDataSet3TableAdapters.ManagerTable1TableAdapter();
            this.managerTableTableAdapter = new RadugaTur.RadugaDBDataSetTableAdapters.ManagerTableTableAdapter();
            this.hashingTableAdapter = new RadugaTur.RadugaDBDataSet16TableAdapters.HashingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.managerTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // managerTable1BindingSource
            // 
            this.managerTable1BindingSource.DataMember = "ManagerTable1";
            this.managerTable1BindingSource.DataSource = this.radugaTourDatabaseDataSet1;
            // 
            // radugaTourDatabaseDataSet1
            // 
            this.radugaTourDatabaseDataSet1.DataSetName = "RadugaTourDatabaseDataSet1";
            this.radugaTourDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radugaTourDatabaseDataSet2
            // 
            this.radugaTourDatabaseDataSet2.DataSetName = "RadugaTourDatabaseDataSet2";
            this.radugaTourDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radugaTourDatabaseDataSet2BindingSource
            // 
            this.radugaTourDatabaseDataSet2BindingSource.DataSource = this.radugaTourDatabaseDataSet2;
            this.radugaTourDatabaseDataSet2BindingSource.Position = 0;
            // 
            // managerTable1TableAdapter
            // 
            this.managerTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hashNameDataGridViewTextBoxColumn,
            this.hashPositionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hashingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(556, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // hashNameDataGridViewTextBoxColumn
            // 
            this.hashNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hashNameDataGridViewTextBoxColumn.DataPropertyName = "hashName";
            this.hashNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.hashNameDataGridViewTextBoxColumn.Name = "hashNameDataGridViewTextBoxColumn";
            this.hashNameDataGridViewTextBoxColumn.Width = 59;
            // 
            // hashPositionDataGridViewTextBoxColumn
            // 
            this.hashPositionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hashPositionDataGridViewTextBoxColumn.DataPropertyName = "hashPosition";
            this.hashPositionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.hashPositionDataGridViewTextBoxColumn.Name = "hashPositionDataGridViewTextBoxColumn";
            this.hashPositionDataGridViewTextBoxColumn.Width = 90;
            // 
            // hashingBindingSource
            // 
            this.hashingBindingSource.DataMember = "Hashing";
            this.hashingBindingSource.DataSource = this.radugaDBDataSet16;
            // 
            // radugaDBDataSet16
            // 
            this.radugaDBDataSet16.DataSetName = "RadugaDBDataSet16";
            this.radugaDBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerTableBindingSource
            // 
            this.managerTableBindingSource.DataMember = "ManagerTable";
            this.managerTableBindingSource.DataSource = this.radugaDBDataSet;
            // 
            // radugaDBDataSet
            // 
            this.radugaDBDataSet.DataSetName = "RadugaDBDataSet";
            this.radugaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerTable1BindingSource1
            // 
            this.managerTable1BindingSource1.DataMember = "ManagerTable1";
            this.managerTable1BindingSource1.DataSource = this.radugaTourDatabaseDataSet3;
            // 
            // radugaTourDatabaseDataSet3
            // 
            this.radugaTourDatabaseDataSet3.DataSetName = "RadugaTourDatabaseDataSet3";
            this.radugaTourDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerTable1TableAdapter1
            // 
            this.managerTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // managerTableTableAdapter
            // 
            this.managerTableTableAdapter.ClearBeforeFill = true;
            // 
            // hashingTableAdapter
            // 
            this.hashingTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerFormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 199);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "ManagerFormTable";
            this.Text = "Менеджеры";
            this.Load += new System.EventHandler(this.ManagerTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadugaTourDatabaseDataSet2 radugaTourDatabaseDataSet2;
        private System.Windows.Forms.BindingSource radugaTourDatabaseDataSet2BindingSource;
        private RadugaTourDatabaseDataSet1 radugaTourDatabaseDataSet1;
        private System.Windows.Forms.BindingSource managerTable1BindingSource;
        private RadugaTourDatabaseDataSet1TableAdapters.ManagerTable1TableAdapter managerTable1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RadugaTourDatabaseDataSet3 radugaTourDatabaseDataSet3;
        private System.Windows.Forms.BindingSource managerTable1BindingSource1;
        private RadugaTourDatabaseDataSet3TableAdapters.ManagerTable1TableAdapter managerTable1TableAdapter1;
        private RadugaDBDataSet radugaDBDataSet;
        private System.Windows.Forms.BindingSource managerTableBindingSource;
        private RadugaDBDataSetTableAdapters.ManagerTableTableAdapter managerTableTableAdapter;
        private RadugaDBDataSet16 radugaDBDataSet16;
        private System.Windows.Forms.BindingSource hashingBindingSource;
        private RadugaDBDataSet16TableAdapters.HashingTableAdapter hashingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashPositionDataGridViewTextBoxColumn;
    }
}