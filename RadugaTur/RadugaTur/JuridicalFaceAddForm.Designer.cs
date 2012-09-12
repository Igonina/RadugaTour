namespace RadugaTur
{
    partial class JuridicalFaceAddForm
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
            this.inputNameOrganizationJuriFace = new System.Windows.Forms.TextBox();
            this.inputFullNameJuriFace = new System.Windows.Forms.TextBox();
            this.inputPhoneNumberJuriFace = new System.Windows.Forms.TextBox();
            this.SaveJuridicalFaceFormButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inputFullNameOrganizationJuriFace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputCargoCarrierJuriFace = new System.Windows.Forms.TextBox();
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
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // inputNameOrganizationJuriFace
            // 
            this.inputNameOrganizationJuriFace.Location = new System.Drawing.Point(187, 19);
            this.inputNameOrganizationJuriFace.Name = "inputNameOrganizationJuriFace";
            this.inputNameOrganizationJuriFace.Size = new System.Drawing.Size(426, 20);
            this.inputNameOrganizationJuriFace.TabIndex = 3;
            // 
            // inputFullNameJuriFace
            // 
            this.inputFullNameJuriFace.Location = new System.Drawing.Point(187, 72);
            this.inputFullNameJuriFace.Name = "inputFullNameJuriFace";
            this.inputFullNameJuriFace.Size = new System.Drawing.Size(426, 20);
            this.inputFullNameJuriFace.TabIndex = 4;
            // 
            // inputPhoneNumberJuriFace
            // 
            this.inputPhoneNumberJuriFace.Location = new System.Drawing.Point(187, 99);
            this.inputPhoneNumberJuriFace.Name = "inputPhoneNumberJuriFace";
            this.inputPhoneNumberJuriFace.Size = new System.Drawing.Size(426, 20);
            this.inputPhoneNumberJuriFace.TabIndex = 5;
            // 
            // SaveJuridicalFaceFormButton
            // 
            this.SaveJuridicalFaceFormButton.Location = new System.Drawing.Point(269, 160);
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
            // inputFullNameOrganizationJuriFace
            // 
            this.inputFullNameOrganizationJuriFace.Location = new System.Drawing.Point(187, 46);
            this.inputFullNameOrganizationJuriFace.Name = "inputFullNameOrganizationJuriFace";
            this.inputFullNameOrganizationJuriFace.Size = new System.Drawing.Size(426, 20);
            this.inputFullNameOrganizationJuriFace.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Грузоперевозчик";
            // 
            // inputCargoCarrierJuriFace
            // 
            this.inputCargoCarrierJuriFace.Location = new System.Drawing.Point(187, 125);
            this.inputCargoCarrierJuriFace.Name = "inputCargoCarrierJuriFace";
            this.inputCargoCarrierJuriFace.Size = new System.Drawing.Size(426, 20);
            this.inputCargoCarrierJuriFace.TabIndex = 10;
            // 
            // JuridicalFaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 194);
            this.Controls.Add(this.inputCargoCarrierJuriFace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputFullNameOrganizationJuriFace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveJuridicalFaceFormButton);
            this.Controls.Add(this.inputPhoneNumberJuriFace);
            this.Controls.Add(this.inputFullNameJuriFace);
            this.Controls.Add(this.inputNameOrganizationJuriFace);
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
        private System.Windows.Forms.TextBox inputNameOrganizationJuriFace;
        private System.Windows.Forms.TextBox inputFullNameJuriFace;
        private System.Windows.Forms.TextBox inputPhoneNumberJuriFace;
        private System.Windows.Forms.Button SaveJuridicalFaceFormButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputFullNameOrganizationJuriFace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputCargoCarrierJuriFace;
    }
}