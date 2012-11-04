namespace RadugaTur
{
    partial class AccountRadForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.inputAccountRad = new System.Windows.Forms.TextBox();
            this.inputDateAccountRad = new System.Windows.Forms.TextBox();
            this.inputSumAccountRad = new System.Windows.Forms.TextBox();
            this.inputAccountSan2 = new System.Windows.Forms.TextBox();
            this.AddAccRadButton = new System.Windows.Forms.Button();
            this.DateAccountRadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер платёжного \r\nпоручения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата платёжного \r\nпоручения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сумма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер счёта \r\nсанатория";
            // 
            // inputAccountRad
            // 
            this.inputAccountRad.Location = new System.Drawing.Point(127, 28);
            this.inputAccountRad.Name = "inputAccountRad";
            this.inputAccountRad.Size = new System.Drawing.Size(145, 20);
            this.inputAccountRad.TabIndex = 4;
            // 
            // inputDateAccountRad
            // 
            this.inputDateAccountRad.Location = new System.Drawing.Point(127, 65);
            this.inputDateAccountRad.Name = "inputDateAccountRad";
            this.inputDateAccountRad.Size = new System.Drawing.Size(145, 20);
            this.inputDateAccountRad.TabIndex = 5;
            // 
            // inputSumAccountRad
            // 
            this.inputSumAccountRad.Location = new System.Drawing.Point(127, 94);
            this.inputSumAccountRad.Name = "inputSumAccountRad";
            this.inputSumAccountRad.Size = new System.Drawing.Size(145, 20);
            this.inputSumAccountRad.TabIndex = 6;
            // 
            // inputAccountSan2
            // 
            this.inputAccountSan2.Location = new System.Drawing.Point(127, 131);
            this.inputAccountSan2.Name = "inputAccountSan2";
            this.inputAccountSan2.Size = new System.Drawing.Size(145, 20);
            this.inputAccountSan2.TabIndex = 7;
            // 
            // AddAccRadButton
            // 
            this.AddAccRadButton.Location = new System.Drawing.Point(160, 158);
            this.AddAccRadButton.Name = "AddAccRadButton";
            this.AddAccRadButton.Size = new System.Drawing.Size(75, 23);
            this.AddAccRadButton.TabIndex = 8;
            this.AddAccRadButton.Text = "Добавить";
            this.AddAccRadButton.UseVisualStyleBackColor = true;
            this.AddAccRadButton.Click += new System.EventHandler(this.AddAccRadButton_Click);
            // 
            // DateAccountRadButton
            // 
            this.DateAccountRadButton.Location = new System.Drawing.Point(278, 65);
            this.DateAccountRadButton.Name = "DateAccountRadButton";
            this.DateAccountRadButton.Size = new System.Drawing.Size(19, 23);
            this.DateAccountRadButton.TabIndex = 9;
            this.DateAccountRadButton.UseVisualStyleBackColor = true;
            this.DateAccountRadButton.Click += new System.EventHandler(this.DateAccountRadButton_Click);
            // 
            // AccountRadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 193);
            this.Controls.Add(this.DateAccountRadButton);
            this.Controls.Add(this.AddAccRadButton);
            this.Controls.Add(this.inputAccountSan2);
            this.Controls.Add(this.inputSumAccountRad);
            this.Controls.Add(this.inputDateAccountRad);
            this.Controls.Add(this.inputAccountRad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountRadForm";
            this.Text = "Добавить платёжное поручение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputAccountRad;
        private System.Windows.Forms.TextBox inputDateAccountRad;
        private System.Windows.Forms.TextBox inputSumAccountRad;
        private System.Windows.Forms.TextBox inputAccountSan2;
        private System.Windows.Forms.Button AddAccRadButton;
        private System.Windows.Forms.Button DateAccountRadButton;
    }
}