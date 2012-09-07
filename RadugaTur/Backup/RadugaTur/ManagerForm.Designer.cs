namespace RadugaTur
{
    partial class ManagerForm
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
            this.Сохранить = new System.Windows.Forms.Button();
            this.inputFullNameMeneger = new System.Windows.Forms.TextBox();
            this.inputPositionMeneger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Должность";
            // 
            // Сохранить
            // 
            this.Сохранить.Location = new System.Drawing.Point(244, 97);
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.Size = new System.Drawing.Size(75, 23);
            this.Сохранить.TabIndex = 2;
            this.Сохранить.Text = "button1";
            this.Сохранить.UseVisualStyleBackColor = true;
            // 
            // inputFullNameMeneger
            // 
            this.inputFullNameMeneger.Location = new System.Drawing.Point(128, 20);
            this.inputFullNameMeneger.Name = "inputFullNameMeneger";
            this.inputFullNameMeneger.Size = new System.Drawing.Size(349, 20);
            this.inputFullNameMeneger.TabIndex = 3;
            // 
            // inputPositionMeneger
            // 
            this.inputPositionMeneger.Location = new System.Drawing.Point(128, 53);
            this.inputPositionMeneger.Name = "inputPositionMeneger";
            this.inputPositionMeneger.Size = new System.Drawing.Size(349, 20);
            this.inputPositionMeneger.TabIndex = 4;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 132);
            this.Controls.Add(this.inputPositionMeneger);
            this.Controls.Add(this.inputFullNameMeneger);
            this.Controls.Add(this.Сохранить);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagerForm";
            this.Text = "Добавить менеджера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Сохранить;
        private System.Windows.Forms.TextBox inputFullNameMeneger;
        private System.Windows.Forms.TextBox inputPositionMeneger;
    }
}