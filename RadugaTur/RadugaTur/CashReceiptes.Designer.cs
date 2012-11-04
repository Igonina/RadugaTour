namespace RadugaTur
{
    partial class CashReceiptes
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
            this.inputCashRecNumDoc = new System.Windows.Forms.TextBox();
            this.inputCashRecDate = new System.Windows.Forms.TextBox();
            this.inputCashRecSum = new System.Windows.Forms.TextBox();
            this.saveCashRecButton = new System.Windows.Forms.Button();
            this.DateCashExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер документа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сумма";
            // 
            // inputCashRecNumDoc
            // 
            this.inputCashRecNumDoc.Location = new System.Drawing.Point(116, 18);
            this.inputCashRecNumDoc.Name = "inputCashRecNumDoc";
            this.inputCashRecNumDoc.Size = new System.Drawing.Size(158, 20);
            this.inputCashRecNumDoc.TabIndex = 3;
            // 
            // inputCashRecDate
            // 
            this.inputCashRecDate.Location = new System.Drawing.Point(116, 45);
            this.inputCashRecDate.Name = "inputCashRecDate";
            this.inputCashRecDate.Size = new System.Drawing.Size(158, 20);
            this.inputCashRecDate.TabIndex = 4;
            // 
            // inputCashRecSum
            // 
            this.inputCashRecSum.Location = new System.Drawing.Point(116, 73);
            this.inputCashRecSum.Name = "inputCashRecSum";
            this.inputCashRecSum.Size = new System.Drawing.Size(158, 20);
            this.inputCashRecSum.TabIndex = 5;
            // 
            // saveCashRecButton
            // 
            this.saveCashRecButton.Location = new System.Drawing.Point(116, 99);
            this.saveCashRecButton.Name = "saveCashRecButton";
            this.saveCashRecButton.Size = new System.Drawing.Size(158, 23);
            this.saveCashRecButton.TabIndex = 6;
            this.saveCashRecButton.Text = "Сохранить";
            this.saveCashRecButton.UseVisualStyleBackColor = true;
            this.saveCashRecButton.Click += new System.EventHandler(this.saveCashRecButton_Click);
            // 
            // DateCashExp
            // 
            this.DateCashExp.Location = new System.Drawing.Point(280, 43);
            this.DateCashExp.Name = "DateCashExp";
            this.DateCashExp.Size = new System.Drawing.Size(19, 23);
            this.DateCashExp.TabIndex = 15;
            this.DateCashExp.UseVisualStyleBackColor = true;
            this.DateCashExp.Click += new System.EventHandler(this.DateCashExp_Click);
            // 
            // CashReceiptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 134);
            this.Controls.Add(this.DateCashExp);
            this.Controls.Add(this.saveCashRecButton);
            this.Controls.Add(this.inputCashRecSum);
            this.Controls.Add(this.inputCashRecDate);
            this.Controls.Add(this.inputCashRecNumDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CashReceiptes";
            this.Text = "Приходный кассовый ордер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputCashRecNumDoc;
        private System.Windows.Forms.TextBox inputCashRecDate;
        private System.Windows.Forms.TextBox inputCashRecSum;
        private System.Windows.Forms.Button saveCashRecButton;
        private System.Windows.Forms.Button DateCashExp;
    }
}