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
            this.SaveManagerFormButton = new System.Windows.Forms.Button();
            this.inputFullNameManager = new System.Windows.Forms.TextBox();
            this.inputPositionManager = new System.Windows.Forms.TextBox();
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
            // SaveManagerFormButton
            // 
            this.SaveManagerFormButton.Location = new System.Drawing.Point(185, 97);
            this.SaveManagerFormButton.Name = "SaveManagerFormButton";
            this.SaveManagerFormButton.Size = new System.Drawing.Size(75, 23);
            this.SaveManagerFormButton.TabIndex = 2;
            this.SaveManagerFormButton.Text = "Сохранить";
            this.SaveManagerFormButton.UseVisualStyleBackColor = true;
            this.SaveManagerFormButton.Click += new System.EventHandler(this.SaveManagerFormButton_Click);
            // 
            // inputFullNameManager
            // 
            this.inputFullNameManager.Location = new System.Drawing.Point(108, 20);
            this.inputFullNameManager.Name = "inputFullNameManager";
            this.inputFullNameManager.Size = new System.Drawing.Size(349, 20);
            this.inputFullNameManager.TabIndex = 3;
            // 
            // inputPositionManager
            // 
            this.inputPositionManager.Location = new System.Drawing.Point(108, 53);
            this.inputPositionManager.Name = "inputPositionManager";
            this.inputPositionManager.Size = new System.Drawing.Size(349, 20);
            this.inputPositionManager.TabIndex = 4;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 132);
            this.Controls.Add(this.inputPositionManager);
            this.Controls.Add(this.inputFullNameManager);
            this.Controls.Add(this.SaveManagerFormButton);
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
        private System.Windows.Forms.Button SaveManagerFormButton;
        private System.Windows.Forms.TextBox inputFullNameManager;
        private System.Windows.Forms.TextBox inputPositionManager;
    }
}