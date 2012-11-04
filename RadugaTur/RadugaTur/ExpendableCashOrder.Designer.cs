namespace RadugaTur
{
    partial class ExpendableCashOrder
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
            this.saveCashExpButton = new System.Windows.Forms.Button();
            this.inputCashExpSum = new System.Windows.Forms.TextBox();
            this.inputCashExpDate = new System.Windows.Forms.TextBox();
            this.inputCashExpNumDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateCashExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveCashExpButton
            // 
            this.saveCashExpButton.Location = new System.Drawing.Point(104, 93);
            this.saveCashExpButton.Name = "saveCashExpButton";
            this.saveCashExpButton.Size = new System.Drawing.Size(158, 23);
            this.saveCashExpButton.TabIndex = 13;
            this.saveCashExpButton.Text = "Сохранить";
            this.saveCashExpButton.UseVisualStyleBackColor = true;
            this.saveCashExpButton.Click += new System.EventHandler(this.saveCashExpButton_Click);
            // 
            // inputCashExpSum
            // 
            this.inputCashExpSum.Location = new System.Drawing.Point(104, 67);
            this.inputCashExpSum.Name = "inputCashExpSum";
            this.inputCashExpSum.Size = new System.Drawing.Size(158, 20);
            this.inputCashExpSum.TabIndex = 12;
            // 
            // inputCashExpDate
            // 
            this.inputCashExpDate.Location = new System.Drawing.Point(104, 39);
            this.inputCashExpDate.Name = "inputCashExpDate";
            this.inputCashExpDate.Size = new System.Drawing.Size(158, 20);
            this.inputCashExpDate.TabIndex = 11;
            // 
            // inputCashExpNumDoc
            // 
            this.inputCashExpNumDoc.Location = new System.Drawing.Point(104, 12);
            this.inputCashExpNumDoc.Name = "inputCashExpNumDoc";
            this.inputCashExpNumDoc.Size = new System.Drawing.Size(158, 20);
            this.inputCashExpNumDoc.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сумма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер документа";
            // 
            // DateCashExp
            // 
            this.DateCashExp.Location = new System.Drawing.Point(268, 37);
            this.DateCashExp.Name = "DateCashExp";
            this.DateCashExp.Size = new System.Drawing.Size(19, 23);
            this.DateCashExp.TabIndex = 14;
            this.DateCashExp.UseVisualStyleBackColor = true;
            this.DateCashExp.Click += new System.EventHandler(this.DateCashExp_Click);
            // 
            // ExpendableCashOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 130);
            this.Controls.Add(this.DateCashExp);
            this.Controls.Add(this.saveCashExpButton);
            this.Controls.Add(this.inputCashExpSum);
            this.Controls.Add(this.inputCashExpDate);
            this.Controls.Add(this.inputCashExpNumDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExpendableCashOrder";
            this.Text = "Расходный кассовый ордер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveCashExpButton;
        private System.Windows.Forms.TextBox inputCashExpSum;
        private System.Windows.Forms.TextBox inputCashExpDate;
        private System.Windows.Forms.TextBox inputCashExpNumDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DateCashExp;
    }
}