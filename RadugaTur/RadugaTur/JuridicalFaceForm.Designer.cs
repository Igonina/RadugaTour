namespace RadugaTur
{
    partial class JuridicalFaceForm
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
            this.SaveJuridicalFaceFormButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputJFNameOrg = new System.Windows.Forms.TextBox();
            this.inputJFFullNameOrg = new System.Windows.Forms.TextBox();
            this.inputFullName = new System.Windows.Forms.TextBox();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.InputCargoCarrier = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Краткое название организации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // SaveJuridicalFaceFormButton
            // 
            this.SaveJuridicalFaceFormButton.Location = new System.Drawing.Point(270, 170);
            this.SaveJuridicalFaceFormButton.Name = "SaveJuridicalFaceFormButton";
            this.SaveJuridicalFaceFormButton.Size = new System.Drawing.Size(75, 23);
            this.SaveJuridicalFaceFormButton.TabIndex = 6;
            this.SaveJuridicalFaceFormButton.Text = "Сохранить";
            this.SaveJuridicalFaceFormButton.UseVisualStyleBackColor = true;
            this.SaveJuridicalFaceFormButton.Click += new System.EventHandler(this.SaveJuridicalFaceFormButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Полное название организации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Грузоперевозчик";
            // 
            // inputJFNameOrg
            // 
            this.inputJFNameOrg.Location = new System.Drawing.Point(207, 19);
            this.inputJFNameOrg.Name = "inputJFNameOrg";
            this.inputJFNameOrg.Size = new System.Drawing.Size(409, 20);
            this.inputJFNameOrg.TabIndex = 9;
            // 
            // inputJFFullNameOrg
            // 
            this.inputJFFullNameOrg.Location = new System.Drawing.Point(207, 46);
            this.inputJFFullNameOrg.Name = "inputJFFullNameOrg";
            this.inputJFFullNameOrg.Size = new System.Drawing.Size(409, 20);
            this.inputJFFullNameOrg.TabIndex = 10;
            // 
            // inputFullName
            // 
            this.inputFullName.Location = new System.Drawing.Point(207, 77);
            this.inputFullName.Name = "inputFullName";
            this.inputFullName.Size = new System.Drawing.Size(409, 20);
            this.inputFullName.TabIndex = 11;
            // 
            // inputPhone
            // 
            this.inputPhone.Location = new System.Drawing.Point(207, 103);
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Size = new System.Drawing.Size(409, 20);
            this.inputPhone.TabIndex = 12;
            // 
            // InputCargoCarrier
            // 
            this.InputCargoCarrier.Location = new System.Drawing.Point(207, 130);
            this.InputCargoCarrier.Name = "InputCargoCarrier";
            this.InputCargoCarrier.Size = new System.Drawing.Size(409, 20);
            this.InputCargoCarrier.TabIndex = 13;
            // 
            // JuridicalFaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 215);
            this.Controls.Add(this.InputCargoCarrier);
            this.Controls.Add(this.inputPhone);
            this.Controls.Add(this.inputFullName);
            this.Controls.Add(this.inputJFFullNameOrg);
            this.Controls.Add(this.inputJFNameOrg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveJuridicalFaceFormButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JuridicalFaceForm";
            this.Text = "Добавить юридическое лицо";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveJuridicalFaceFormButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputJFNameOrg;
        private System.Windows.Forms.TextBox inputJFFullNameOrg;
        private System.Windows.Forms.TextBox inputFullName;
        private System.Windows.Forms.TextBox inputPhone;
        private System.Windows.Forms.TextBox InputCargoCarrier;
    }
}