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
            this.radugaTourDatabaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hashNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._1gb_rrrrrDataSet2 = new RadugaTur._1gb_rrrrrDataSet2();
            this.hashingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hashingTableAdapter1 = new RadugaTur._1gb_rrrrrDataSet2TableAdapters.HashingTableAdapter();
            this._1gb_rrrrrDataSet8 = new RadugaTur._1gb_rrrrrDataSet8();
            this.hashingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hashingTableAdapter2 = new RadugaTur._1gb_rrrrrDataSet8TableAdapters.HashingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.managerTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1gb_rrrrrDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1gb_rrrrrDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashingBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // managerTable1BindingSource
            // 
            this.managerTable1BindingSource.DataMember = "ManagerTable1";

            this.radugaTourDatabaseDataSet2BindingSource.Position = 0;
        
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
            this.dataGridView1.DataSource = this.hashingBindingSource2;
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

            // 
            // managerTableBindingSource
            // 
            this.managerTableBindingSource.DataMember = "ManagerTable";
 
            // 
            // managerTable1BindingSource1
            // 
            this.managerTable1BindingSource1.DataMember = "ManagerTable1";
   
            // 
            // _1gb_rrrrrDataSet2
            // 
            this._1gb_rrrrrDataSet2.DataSetName = "_1gb_rrrrrDataSet2";
            this._1gb_rrrrrDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hashingBindingSource1
            // 
            this.hashingBindingSource1.DataMember = "Hashing";
            this.hashingBindingSource1.DataSource = this._1gb_rrrrrDataSet2;
            // 
            // hashingTableAdapter1
            // 
            this.hashingTableAdapter1.ClearBeforeFill = true;
            // 
            // _1gb_rrrrrDataSet8
            // 
            this._1gb_rrrrrDataSet8.DataSetName = "_1gb_rrrrrDataSet8";
            this._1gb_rrrrrDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hashingBindingSource2
            // 
            this.hashingBindingSource2.DataMember = "Hashing";
            this.hashingBindingSource2.DataSource = this._1gb_rrrrrDataSet8;
            // 
            // hashingTableAdapter2
            // 
            this.hashingTableAdapter2.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1gb_rrrrrDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1gb_rrrrrDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hashingBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.BindingSource radugaTourDatabaseDataSet2BindingSource;
        private System.Windows.Forms.BindingSource managerTable1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource managerTable1BindingSource1;
        private System.Windows.Forms.BindingSource managerTableBindingSource;
        private System.Windows.Forms.BindingSource hashingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashPositionDataGridViewTextBoxColumn;
        private _1gb_rrrrrDataSet2 _1gb_rrrrrDataSet2;
        private System.Windows.Forms.BindingSource hashingBindingSource1;
        private _1gb_rrrrrDataSet2TableAdapters.HashingTableAdapter hashingTableAdapter1;
        private _1gb_rrrrrDataSet8 _1gb_rrrrrDataSet8;
        private System.Windows.Forms.BindingSource hashingBindingSource2;
        private _1gb_rrrrrDataSet8TableAdapters.HashingTableAdapter hashingTableAdapter2;
    }
}