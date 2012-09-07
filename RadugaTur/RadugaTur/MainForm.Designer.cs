namespace RadugaTur
{
    partial class ApplicationJunkClass
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
            this.Lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateApplication = new System.Windows.Forms.Button();
            this.ShowPhisFace = new System.Windows.Forms.Button();
            this.ShowJuriFace = new System.Windows.Forms.Button();
            this.AddPhisFace = new System.Windows.Forms.Button();
            this.AddJuriFace = new System.Windows.Forms.Button();
            this.LookAtApplications = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.outputProfile = new System.Windows.Forms.Label();
            this.outputLogin = new System.Windows.Forms.Label();
            this.outputDateTime = new System.Windows.Forms.Label();
            this.AddManagerButton = new System.Windows.Forms.Button();
            this.radugaTourDatabaseDataSet1 = new RadugaTur.RadugaTourDatabaseDataSet1();
            this.managerTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTable1TableAdapter = new RadugaTur.RadugaTourDatabaseDataSet1TableAdapters.ManagerTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(21, 9);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(53, 13);
            this.Lable1.TabIndex = 0;
            this.Lable1.Text = "Профиль";
            this.Lable1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вход выполнен";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Действия";
            // 
            // CreateApplication
            // 
            this.CreateApplication.Location = new System.Drawing.Point(24, 197);
            this.CreateApplication.Name = "CreateApplication";
            this.CreateApplication.Size = new System.Drawing.Size(172, 23);
            this.CreateApplication.TabIndex = 7;
            this.CreateApplication.Text = "Создать заявку";
            this.CreateApplication.UseVisualStyleBackColor = true;
            this.CreateApplication.Click += new System.EventHandler(this.CreateApplication_Click);
            // 
            // ShowPhisFace
            // 
            this.ShowPhisFace.Location = new System.Drawing.Point(24, 339);
            this.ShowPhisFace.Name = "ShowPhisFace";
            this.ShowPhisFace.Size = new System.Drawing.Size(172, 23);
            this.ShowPhisFace.TabIndex = 8;
            this.ShowPhisFace.Text = "Показать физические лица";
            this.ShowPhisFace.UseVisualStyleBackColor = true;
            // 
            // ShowJuriFace
            // 
            this.ShowJuriFace.Location = new System.Drawing.Point(24, 310);
            this.ShowJuriFace.Name = "ShowJuriFace";
            this.ShowJuriFace.Size = new System.Drawing.Size(172, 23);
            this.ShowJuriFace.TabIndex = 9;
            this.ShowJuriFace.Text = "Показать юридические лица";
            this.ShowJuriFace.UseVisualStyleBackColor = true;
            // 
            // AddPhisFace
            // 
            this.AddPhisFace.Location = new System.Drawing.Point(24, 281);
            this.AddPhisFace.Name = "AddPhisFace";
            this.AddPhisFace.Size = new System.Drawing.Size(172, 23);
            this.AddPhisFace.TabIndex = 10;
            this.AddPhisFace.Text = "Добавить физическое лицо";
            this.AddPhisFace.UseVisualStyleBackColor = true;
            this.AddPhisFace.Click += new System.EventHandler(this.AddPhisFace_Click);
            // 
            // AddJuriFace
            // 
            this.AddJuriFace.Location = new System.Drawing.Point(24, 252);
            this.AddJuriFace.Name = "AddJuriFace";
            this.AddJuriFace.Size = new System.Drawing.Size(172, 23);
            this.AddJuriFace.TabIndex = 11;
            this.AddJuriFace.Text = "Добавить юридическое лицо";
            this.AddJuriFace.UseVisualStyleBackColor = true;
            this.AddJuriFace.Click += new System.EventHandler(this.AddJuriFace_Click);
            // 
            // LookAtApplications
            // 
            this.LookAtApplications.Location = new System.Drawing.Point(24, 223);
            this.LookAtApplications.Name = "LookAtApplications";
            this.LookAtApplications.Size = new System.Drawing.Size(172, 23);
            this.LookAtApplications.TabIndex = 12;
            this.LookAtApplications.Text = "Просмотреть заявки";
            this.LookAtApplications.UseVisualStyleBackColor = true;
            this.LookAtApplications.Click += new System.EventHandler(this.LookAtApplications_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RadugaTur.Properties.Resources.Главная_картинка;
            this.pictureBox1.Location = new System.Drawing.Point(440, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // outputProfile
            // 
            this.outputProfile.AutoSize = true;
            this.outputProfile.Location = new System.Drawing.Point(24, 37);
            this.outputProfile.Name = "outputProfile";
            this.outputProfile.Size = new System.Drawing.Size(35, 13);
            this.outputProfile.TabIndex = 14;
            this.outputProfile.Text = "label4";
            // 
            // outputLogin
            // 
            this.outputLogin.AutoSize = true;
            this.outputLogin.Location = new System.Drawing.Point(89, 70);
            this.outputLogin.Name = "outputLogin";
            this.outputLogin.Size = new System.Drawing.Size(35, 13);
            this.outputLogin.TabIndex = 15;
            this.outputLogin.Text = "label5";
            // 
            // outputDateTime
            // 
            this.outputDateTime.AutoSize = true;
            this.outputDateTime.Location = new System.Drawing.Point(127, 97);
            this.outputDateTime.Name = "outputDateTime";
            this.outputDateTime.Size = new System.Drawing.Size(35, 13);
            this.outputDateTime.TabIndex = 16;
            this.outputDateTime.Text = "label6";
            // 
            // AddManagerButton
            // 
            this.AddManagerButton.Location = new System.Drawing.Point(24, 368);
            this.AddManagerButton.Name = "AddManagerButton";
            this.AddManagerButton.Size = new System.Drawing.Size(172, 23);
            this.AddManagerButton.TabIndex = 17;
            this.AddManagerButton.Text = "Добавить менеджера";
            this.AddManagerButton.UseVisualStyleBackColor = true;
            this.AddManagerButton.Click += new System.EventHandler(this.AddManagerButton_Click);
            // 
            // radugaTourDatabaseDataSet1
            // 
            this.radugaTourDatabaseDataSet1.DataSetName = "RadugaTourDatabaseDataSet1";
            this.radugaTourDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerTable1BindingSource
            // 
            this.managerTable1BindingSource.DataMember = "ManagerTable1";
            this.managerTable1BindingSource.DataSource = this.radugaTourDatabaseDataSet1;
            // 
            // managerTable1TableAdapter
            // 
            this.managerTable1TableAdapter.ClearBeforeFill = true;
            // 
            // ApplicationJunkClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 420);
            this.Controls.Add(this.AddManagerButton);
            this.Controls.Add(this.outputDateTime);
            this.Controls.Add(this.outputLogin);
            this.Controls.Add(this.outputProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LookAtApplications);
            this.Controls.Add(this.AddJuriFace);
            this.Controls.Add(this.AddPhisFace);
            this.Controls.Add(this.ShowJuriFace);
            this.Controls.Add(this.ShowPhisFace);
            this.Controls.Add(this.CreateApplication);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lable1);
            this.Name = "ApplicationJunkClass";
            this.Text = "Домашняя страница";
            this.Load += new System.EventHandler(this.ApplicationJunkClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateApplication;
        private System.Windows.Forms.Button ShowPhisFace;
        private System.Windows.Forms.Button ShowJuriFace;
        private System.Windows.Forms.Button AddPhisFace;
        private System.Windows.Forms.Button AddJuriFace;
        private System.Windows.Forms.Button LookAtApplications;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label outputProfile;
        private System.Windows.Forms.Label outputLogin;
        private System.Windows.Forms.Label outputDateTime;
        private System.Windows.Forms.Button AddManagerButton;
        private RadugaTourDatabaseDataSet1 radugaTourDatabaseDataSet1;
        private System.Windows.Forms.BindingSource managerTable1BindingSource;
        private RadugaTourDatabaseDataSet1TableAdapters.ManagerTable1TableAdapter managerTable1TableAdapter;

    }
}

