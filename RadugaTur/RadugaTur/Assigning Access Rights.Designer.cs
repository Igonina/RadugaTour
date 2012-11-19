namespace RadugaTur
{
    partial class AssigningAccessRights
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.inputHashLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputHashName = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputHashName2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(74, 140);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(158, 23);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Добавить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // inputHashLogin
            // 
            this.inputHashLogin.Location = new System.Drawing.Point(74, 63);
            this.inputHashLogin.Name = "inputHashLogin";
            this.inputHashLogin.Size = new System.Drawing.Size(158, 20);
            this.inputHashLogin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ФИО";
            // 
            // inputHashName
            // 
            this.inputHashName.Location = new System.Drawing.Point(74, 12);
            this.inputHashName.Name = "inputHashName";
            this.inputHashName.Size = new System.Drawing.Size(158, 20);
            this.inputHashName.TabIndex = 13;
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(74, 89);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(158, 20);
            this.inputPassword.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пароль";
            // 
            // inputHashName2
            // 
            this.inputHashName2.Location = new System.Drawing.Point(74, 37);
            this.inputHashName2.Name = "inputHashName2";
            this.inputHashName2.Size = new System.Drawing.Size(158, 20);
            this.inputHashName2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "ФИО\r\n(краткое)";
            // 
            // inputPosition
            // 
            this.inputPosition.Location = new System.Drawing.Point(74, 114);
            this.inputPosition.Name = "inputPosition";
            this.inputPosition.Size = new System.Drawing.Size(158, 20);
            this.inputPosition.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Должность";
            // 
            // AssigningAccessRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputHashName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputHashName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.inputHashLogin);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(300, 213);
            this.Name = "AssigningAccessRights";
            this.Text = "Назначение прав доступа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox inputHashLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputHashName;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputHashName2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputPosition;
        private System.Windows.Forms.Label label5;
    }
}