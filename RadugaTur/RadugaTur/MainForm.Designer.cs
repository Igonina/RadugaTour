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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationJunkClass));
            this.Lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateApplication = new System.Windows.Forms.Button();
            this.ShowPhisFace = new System.Windows.Forms.Button();
            this.ShowJuriFace = new System.Windows.Forms.Button();
            this.AddPhisFace = new System.Windows.Forms.Button();
            this.AddJuriFace = new System.Windows.Forms.Button();
            this.LookAtApplications = new System.Windows.Forms.Button();
            this.outputProfile = new System.Windows.Forms.Label();
            this.outputLogin = new System.Windows.Forms.Label();
            this.radugaTourDatabaseDataSet1 = new RadugaTur.RadugaTourDatabaseDataSet1();
            this.managerTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTable1TableAdapter = new RadugaTur.RadugaTourDatabaseDataSet1TableAdapters.ManagerTable1TableAdapter();
            this.LookAtManagersbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.BackColor = System.Drawing.Color.LightSalmon;
            this.Lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lable1.Location = new System.Drawing.Point(615, 167);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(89, 20);
            this.Lable1.TabIndex = 0;
            this.Lable1.Text = "Профиль";
            this.Lable1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1060, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // CreateApplication
            // 
            this.CreateApplication.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateApplication.BackgroundImage")));
            this.CreateApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CreateApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateApplication.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CreateApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateApplication.Location = new System.Drawing.Point(83, 210);
            this.CreateApplication.Name = "CreateApplication";
            this.CreateApplication.Size = new System.Drawing.Size(139, 36);
            this.CreateApplication.TabIndex = 7;
            this.CreateApplication.Text = "Создать заявку";
            this.CreateApplication.UseVisualStyleBackColor = false;
            this.CreateApplication.Click += new System.EventHandler(this.CreateApplication_Click);
            // 
            // ShowPhisFace
            // 
            this.ShowPhisFace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowPhisFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPhisFace.BackgroundImage")));
            this.ShowPhisFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShowPhisFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPhisFace.Location = new System.Drawing.Point(518, 210);
            this.ShowPhisFace.Name = "ShowPhisFace";
            this.ShowPhisFace.Size = new System.Drawing.Size(139, 36);
            this.ShowPhisFace.TabIndex = 8;
            this.ShowPhisFace.Text = "Показать физические лица";
            this.ShowPhisFace.UseVisualStyleBackColor = false;
            this.ShowPhisFace.Click += new System.EventHandler(this.ShowPhisFace_Click);
            // 
            // ShowJuriFace
            // 
            this.ShowJuriFace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowJuriFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowJuriFace.BackgroundImage")));
            this.ShowJuriFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShowJuriFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowJuriFace.Location = new System.Drawing.Point(808, 210);
            this.ShowJuriFace.Name = "ShowJuriFace";
            this.ShowJuriFace.Size = new System.Drawing.Size(139, 36);
            this.ShowJuriFace.TabIndex = 9;
            this.ShowJuriFace.Text = "Показать юридические лица";
            this.ShowJuriFace.UseVisualStyleBackColor = false;
            this.ShowJuriFace.Click += new System.EventHandler(this.ShowJuriFace_Click);
            // 
            // AddPhisFace
            // 
            this.AddPhisFace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPhisFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPhisFace.BackgroundImage")));
            this.AddPhisFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddPhisFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPhisFace.Location = new System.Drawing.Point(373, 210);
            this.AddPhisFace.Name = "AddPhisFace";
            this.AddPhisFace.Size = new System.Drawing.Size(139, 36);
            this.AddPhisFace.TabIndex = 10;
            this.AddPhisFace.Text = "Добавить физическое лицо";
            this.AddPhisFace.UseVisualStyleBackColor = false;
            this.AddPhisFace.Click += new System.EventHandler(this.AddPhisFace_Click);
            // 
            // AddJuriFace
            // 
            this.AddJuriFace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddJuriFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddJuriFace.BackgroundImage")));
            this.AddJuriFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddJuriFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddJuriFace.Location = new System.Drawing.Point(663, 210);
            this.AddJuriFace.Name = "AddJuriFace";
            this.AddJuriFace.Size = new System.Drawing.Size(139, 36);
            this.AddJuriFace.TabIndex = 11;
            this.AddJuriFace.Text = "Добавить юридическое лицо";
            this.AddJuriFace.UseVisualStyleBackColor = false;
            this.AddJuriFace.Click += new System.EventHandler(this.AddJuriFace_Click);
            // 
            // LookAtApplications
            // 
            this.LookAtApplications.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LookAtApplications.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LookAtApplications.BackgroundImage")));
            this.LookAtApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LookAtApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LookAtApplications.Location = new System.Drawing.Point(228, 210);
            this.LookAtApplications.Name = "LookAtApplications";
            this.LookAtApplications.Size = new System.Drawing.Size(139, 36);
            this.LookAtApplications.TabIndex = 12;
            this.LookAtApplications.Text = "Просмотреть заявки";
            this.LookAtApplications.UseVisualStyleBackColor = false;
            this.LookAtApplications.Click += new System.EventHandler(this.LookAtApplications_Click);
            // 
            // outputProfile
            // 
            this.outputProfile.AutoSize = true;
            this.outputProfile.BackColor = System.Drawing.Color.LightSalmon;
            this.outputProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputProfile.Location = new System.Drawing.Point(710, 167);
            this.outputProfile.Name = "outputProfile";
            this.outputProfile.Size = new System.Drawing.Size(306, 20);
            this.outputProfile.TabIndex = 14;
            this.outputProfile.Text = "Светлякова Анастачия Владимировна";
            this.outputProfile.Click += new System.EventHandler(this.outputProfile_Click);
            // 
            // outputLogin
            // 
            this.outputLogin.AutoSize = true;
            this.outputLogin.BackColor = System.Drawing.Color.LightSalmon;
            this.outputLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLogin.Location = new System.Drawing.Point(1126, 167);
            this.outputLogin.Name = "outputLogin";
            this.outputLogin.Size = new System.Drawing.Size(94, 20);
            this.outputLogin.TabIndex = 15;
            this.outputLogin.Text = "Svetlyachok";
            this.outputLogin.Click += new System.EventHandler(this.outputLogin_Click);
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
            // LookAtManagersbutton
            // 
            this.LookAtManagersbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LookAtManagersbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LookAtManagersbutton.BackgroundImage")));
            this.LookAtManagersbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LookAtManagersbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LookAtManagersbutton.Location = new System.Drawing.Point(1098, 208);
            this.LookAtManagersbutton.Name = "LookAtManagersbutton";
            this.LookAtManagersbutton.Size = new System.Drawing.Size(139, 37);
            this.LookAtManagersbutton.TabIndex = 18;
            this.LookAtManagersbutton.Text = "Показать менеджеров";
            this.LookAtManagersbutton.UseVisualStyleBackColor = false;
            this.LookAtManagersbutton.Click += new System.EventHandler(this.LookAtManagersbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(953, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Назначить права доступа";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApplicationJunkClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LookAtManagersbutton);
            this.Controls.Add(this.outputLogin);
            this.Controls.Add(this.outputProfile);
            this.Controls.Add(this.LookAtApplications);
            this.Controls.Add(this.AddJuriFace);
            this.Controls.Add(this.AddPhisFace);
            this.Controls.Add(this.ShowJuriFace);
            this.Controls.Add(this.ShowPhisFace);
            this.Controls.Add(this.CreateApplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lable1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ApplicationJunkClass";
            this.Text = "Домашняя страница";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ApplicationJunkClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radugaTourDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateApplication;
        private System.Windows.Forms.Button ShowPhisFace;
        private System.Windows.Forms.Button ShowJuriFace;
        private System.Windows.Forms.Button AddPhisFace;
        private System.Windows.Forms.Button AddJuriFace;
        private System.Windows.Forms.Button LookAtApplications;
        private System.Windows.Forms.Label outputProfile;
        private System.Windows.Forms.Label outputLogin;
        private RadugaTourDatabaseDataSet1 radugaTourDatabaseDataSet1;
        private System.Windows.Forms.BindingSource managerTable1BindingSource;
        private RadugaTourDatabaseDataSet1TableAdapters.ManagerTable1TableAdapter managerTable1TableAdapter;
        private System.Windows.Forms.Button LookAtManagersbutton;
        private System.Windows.Forms.Button button1;

    }
}

