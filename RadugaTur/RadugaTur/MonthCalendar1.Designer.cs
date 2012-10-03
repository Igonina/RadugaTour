namespace RadugaTur
{
    partial class MonthCalendar1
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
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.MonthCalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(11, 18);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 0;
            // 
            // MonthCalButton
            // 
            this.MonthCalButton.Location = new System.Drawing.Point(47, 192);
            this.MonthCalButton.Name = "MonthCalButton";
            this.MonthCalButton.Size = new System.Drawing.Size(75, 23);
            this.MonthCalButton.TabIndex = 1;
            this.MonthCalButton.Text = "Ок";
            this.MonthCalButton.UseVisualStyleBackColor = true;
            this.MonthCalButton.Click += new System.EventHandler(this.MonthCalButton_Click);
            // 
            // MonthCalendar1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 223);
            this.Controls.Add(this.MonthCalButton);
            this.Controls.Add(this.monthCalendar2);
            this.Name = "MonthCalendar1";
            this.Text = "MonthCalendar1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button MonthCalButton;
    }
}