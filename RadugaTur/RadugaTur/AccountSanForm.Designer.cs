namespace RadugaTur
{
    partial class AccountSanForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.inputAccountSan = new System.Windows.Forms.TextBox();
            this.inputDateAccountSan = new System.Windows.Forms.TextBox();
            this.inputSumAccountSan = new System.Windows.Forms.TextBox();
            this.AddAccSanButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер счёта \r\nсанатория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата счёта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сумма";
            // 
            // inputAccountSan
            // 
            this.inputAccountSan.Location = new System.Drawing.Point(106, 19);
            this.inputAccountSan.Name = "inputAccountSan";
            this.inputAccountSan.Size = new System.Drawing.Size(146, 20);
            this.inputAccountSan.TabIndex = 3;
            // 
            // inputDateAccountSan
            // 
            this.inputDateAccountSan.Location = new System.Drawing.Point(106, 45);
            this.inputDateAccountSan.Name = "inputDateAccountSan";
            this.inputDateAccountSan.Size = new System.Drawing.Size(146, 20);
            this.inputDateAccountSan.TabIndex = 4;
            // 
            // inputSumAccountSan
            // 
            this.inputSumAccountSan.Location = new System.Drawing.Point(106, 71);
            this.inputSumAccountSan.Name = "inputSumAccountSan";
            this.inputSumAccountSan.Size = new System.Drawing.Size(146, 20);
            this.inputSumAccountSan.TabIndex = 5;
            // 
            // AddAccSanButton
            // 
            this.AddAccSanButton.Location = new System.Drawing.Point(139, 97);
            this.AddAccSanButton.Name = "AddAccSanButton";
            this.AddAccSanButton.Size = new System.Drawing.Size(75, 23);
            this.AddAccSanButton.TabIndex = 6;
            this.AddAccSanButton.Text = "Добавить";
            this.AddAccSanButton.UseVisualStyleBackColor = true;
            this.AddAccSanButton.Click += new System.EventHandler(this.AddAccSanButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 25);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountSanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 130);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddAccSanButton);
            this.Controls.Add(this.inputSumAccountSan);
            this.Controls.Add(this.inputDateAccountSan);
            this.Controls.Add(this.inputAccountSan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountSanForm";
            this.Text = "Добавить счёт санатория";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputAccountSan;
        private System.Windows.Forms.TextBox inputDateAccountSan;
        private System.Windows.Forms.TextBox inputSumAccountSan;
        private System.Windows.Forms.Button AddAccSanButton;
        private System.Windows.Forms.Button button1;
    }
}