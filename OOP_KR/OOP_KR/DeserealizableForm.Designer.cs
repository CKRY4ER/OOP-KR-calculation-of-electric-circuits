
namespace OOP_KR
{
    partial class DeserealizableForm
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
            this.NameFileLabel = new System.Windows.Forms.Label();
            this.NameFileTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
           // this.SuspendLayout();
            // 
            // NameFileLabel
            // 
            this.NameFileLabel.AutoSize = true;
            this.NameFileLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFileLabel.Location = new System.Drawing.Point(12, 25);
            this.NameFileLabel.Name = "NameFileLabel";
            this.NameFileLabel.Size = new System.Drawing.Size(392, 22);
            this.NameFileLabel.TabIndex = 1;
            this.NameFileLabel.Text = "Введите название файла с разширением .xml";
            // 
            // NameFileTextBox
            // 
            this.NameFileTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFileTextBox.Location = new System.Drawing.Point(410, 22);
            this.NameFileTextBox.Name = "NameFileTextBox";
            this.NameFileTextBox.Size = new System.Drawing.Size(378, 30);
            this.NameFileTextBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(277, 68);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(211, 30);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Загрузить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeserealizableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 120);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NameFileTextBox);
            this.Controls.Add(this.NameFileLabel);
            this.Name = "DeserealizableForm";
            this.Text = "Загрузить цепь из файла";
            this.Load += new System.EventHandler(this.DeserealizableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameFileLabel;
        private System.Windows.Forms.TextBox NameFileTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}