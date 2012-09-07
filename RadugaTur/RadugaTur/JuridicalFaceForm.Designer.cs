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
            this.inputNameOrganizationJuriFace = new System.Windows.Forms.TextBox();
            this.inputFullNameJuriFace = new System.Windows.Forms.TextBox();
            this.inputFoneNumberJuriFace = new System.Windows.Forms.TextBox();
            this.SaveJuridicalFaceFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название организации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // inputNameOrganizationJuriFace
            // 
            this.inputNameOrganizationJuriFace.Location = new System.Drawing.Point(144, 19);
            this.inputNameOrganizationJuriFace.Name = "inputNameOrganizationJuriFace";
            this.inputNameOrganizationJuriFace.Size = new System.Drawing.Size(469, 20);
            this.inputNameOrganizationJuriFace.TabIndex = 3;
            // 
            // inputFullNameJuriFace
            // 
            this.inputFullNameJuriFace.Location = new System.Drawing.Point(144, 51);
            this.inputFullNameJuriFace.Name = "inputFullNameJuriFace";
            this.inputFullNameJuriFace.Size = new System.Drawing.Size(402, 20);
            this.inputFullNameJuriFace.TabIndex = 4;
            // 
            // inputFoneNumberJuriFace
            // 
            this.inputFoneNumberJuriFace.Location = new System.Drawing.Point(144, 81);
            this.inputFoneNumberJuriFace.Name = "inputFoneNumberJuriFace";
            this.inputFoneNumberJuriFace.Size = new System.Drawing.Size(268, 20);
            this.inputFoneNumberJuriFace.TabIndex = 5;
            // 
            // SaveJuridicalFaceFormButton
            // 
            this.SaveJuridicalFaceFormButton.Location = new System.Drawing.Point(276, 131);
            this.SaveJuridicalFaceFormButton.Name = "SaveJuridicalFaceFormButton";
            this.SaveJuridicalFaceFormButton.Size = new System.Drawing.Size(75, 23);
            this.SaveJuridicalFaceFormButton.TabIndex = 6;
            this.SaveJuridicalFaceFormButton.Text = "Сохранить";
            this.SaveJuridicalFaceFormButton.UseVisualStyleBackColor = true;
            // 
            // JuridicalFaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 176);
            this.Controls.Add(this.SaveJuridicalFaceFormButton);
            this.Controls.Add(this.inputFoneNumberJuriFace);
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
        private System.Windows.Forms.TextBox inputFoneNumberJuriFace;
        private System.Windows.Forms.Button SaveJuridicalFaceFormButton;
    }
}