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
            this.JFId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jFNameOrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jFFullNameOrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jFFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jFPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jFCargoCarrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juridicalFaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radugaDBDataSet3 = new RadugaTur.RadugaDBDataSet3();
            this.juridicalFaceTableAdapter = new RadugaTur.RadugaDBDataSet3TableAdapters.JuridicalFaceTableAdapter();
            this.addJFButton = new System.Windows.Forms.Button();
            this.changeJFButton = new System.Windows.Forms.Button();
            this.cancelJFButton = new System.Windows.Forms.Button();
            this._1gb_rrrrrDataSet1 = new RadugaTur._1gb_rrrrrDataSet1();
            this.juridicalFaceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.juridicalFaceTableAdapter1 = new RadugaTur._1gb_rrrrrDataSet1TableAdapters.JuridicalFaceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juridicalFaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1gb_rrrrrDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juridicalFaceBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.JFId,
            this.jFNameOrgDataGridViewTextBoxColumn,
            this.jFFullNameOrgDataGridViewTextBoxColumn,
            this.jFFullNameDataGridViewTextBoxColumn,
            this.jFPhoneDataGridViewTextBoxColumn,
            this.jFCargoCarrierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.juridicalFaceBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // JFId
            // 
            this.JFId.DataPropertyName = "JFId";
            this.JFId.HeaderText = "JFId";
            this.JFId.Name = "JFId";
            this.JFId.ReadOnly = true;
            this.JFId.Visible = false;
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
            // juridicalFaceBindingSource
            // 
            this.juridicalFaceBindingSource.DataMember = "JuridicalFace";
            this.juridicalFaceBindingSource.DataSource = this.radugaDBDataSet3;
            // 
            // radugaDBDataSet3
            // 
            this.radugaDBDataSet3.DataSetName = "RadugaDBDataSet3";
            this.radugaDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // juridicalFaceTableAdapter
            // 
            this.juridicalFaceTableAdapter.ClearBeforeFill = true;
            // 
            // addJFButton
            // 
            this.addJFButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addJFButton.Location = new System.Drawing.Point(337, 251);
            this.addJFButton.Name = "addJFButton";
            this.addJFButton.Size = new System.Drawing.Size(119, 23);
            this.addJFButton.TabIndex = 1;
            this.addJFButton.Text = "Добавить";
            this.addJFButton.UseVisualStyleBackColor = true;
            this.addJFButton.Click += new System.EventHandler(this.addJFButton_Click);
            // 
            // changeJFButton
            // 
            this.changeJFButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.changeJFButton.Location = new System.Drawing.Point(486, 251);
            this.changeJFButton.Name = "changeJFButton";
            this.changeJFButton.Size = new System.Drawing.Size(119, 23);
            this.changeJFButton.TabIndex = 2;
            this.changeJFButton.Text = "Изменить";
            this.changeJFButton.UseVisualStyleBackColor = true;
            this.changeJFButton.Click += new System.EventHandler(this.changeJFButton_Click);
            // 
            // cancelJFButton
            // 
            this.cancelJFButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelJFButton.Location = new System.Drawing.Point(635, 251);
            this.cancelJFButton.Name = "cancelJFButton";
            this.cancelJFButton.Size = new System.Drawing.Size(119, 23);
            this.cancelJFButton.TabIndex = 3;
            this.cancelJFButton.Text = "Отменить";
            this.cancelJFButton.UseVisualStyleBackColor = true;
            this.cancelJFButton.Click += new System.EventHandler(this.cancelJFButton_Click);
            // 
            // _1gb_rrrrrDataSet1
            // 
            this._1gb_rrrrrDataSet1.DataSetName = "_1gb_rrrrrDataSet1";
            this._1gb_rrrrrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // juridicalFaceBindingSource1
            // 
            this.juridicalFaceBindingSource1.DataMember = "JuridicalFace";
            this.juridicalFaceBindingSource1.DataSource = this._1gb_rrrrrDataSet1;
            // 
            // juridicalFaceTableAdapter1
            // 
            this.juridicalFaceTableAdapter1.ClearBeforeFill = true;
            // 
            // JFTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 280);
            this.Controls.Add(this.cancelJFButton);
            this.Controls.Add(this.changeJFButton);
            this.Controls.Add(this.addJFButton);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(1200, 300);
            this.Name = "JFTableForm";
            this.Text = "Юридические лица";
            this.Load += new System.EventHandler(this.JFTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juridicalFaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1gb_rrrrrDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juridicalFaceBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RadugaDBDataSet3 radugaDBDataSet3;
        private System.Windows.Forms.BindingSource juridicalFaceBindingSource;
        private RadugaDBDataSet3TableAdapters.JuridicalFaceTableAdapter juridicalFaceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn JFId;
        private System.Windows.Forms.DataGridViewTextBoxColumn jFNameOrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jFFullNameOrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jFFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jFPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jFCargoCarrierDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addJFButton;
        private System.Windows.Forms.Button changeJFButton;
        private System.Windows.Forms.Button cancelJFButton;
        private _1gb_rrrrrDataSet1 _1gb_rrrrrDataSet1;
        private System.Windows.Forms.BindingSource juridicalFaceBindingSource1;
        private _1gb_rrrrrDataSet1TableAdapters.JuridicalFaceTableAdapter juridicalFaceTableAdapter1;
    }
}