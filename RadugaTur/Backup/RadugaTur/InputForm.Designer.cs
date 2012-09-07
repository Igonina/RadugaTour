namespace RadugaTur
{
    partial class InputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.checkMemory = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(100, 61);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(100, 20);
            this.inputLogin.TabIndex = 2;
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(100, 98);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(100, 20);
            this.inputPassword.TabIndex = 3;
            // 
            // checkMemory
            // 
            this.checkMemory.AutoSize = true;
            this.checkMemory.Location = new System.Drawing.Point(31, 141);
            this.checkMemory.Name = "checkMemory";
            this.checkMemory.Size = new System.Drawing.Size(111, 17);
            this.checkMemory.TabIndex = 4;
            this.checkMemory.Text = "Запомнить меня";
            this.checkMemory.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(148, 137);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(52, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Вход";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkMemory);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.CheckBox checkMemory;
        private System.Windows.Forms.Button buttonStart;
    }
}