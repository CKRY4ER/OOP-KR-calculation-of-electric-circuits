
namespace OOP_KR
{
    partial class DeleteBranchElementForm
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
            this.NameElementLabel = new System.Windows.Forms.Label();
            this.NameElementTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // NameElementLabel
            // 
            this.NameElementLabel.AutoSize = true;
            this.NameElementLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameElementLabel.Location = new System.Drawing.Point(12, 15);
            this.NameElementLabel.Name = "NameElementLabel";
            this.NameElementLabel.Size = new System.Drawing.Size(252, 22);
            this.NameElementLabel.TabIndex = 0;
            this.NameElementLabel.Text = "Имя элемента для удаления:";
            // 
            // NameElementTextBox
            // 
            this.NameElementTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameElementTextBox.Location = new System.Drawing.Point(270, 12);
            this.NameElementTextBox.Name = "NameElementTextBox";
            this.NameElementTextBox.Size = new System.Drawing.Size(173, 30);
            this.NameElementTextBox.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(238, 48);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(205, 31);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить ветку";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(449, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(16, 17);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DeleteBranchElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 95);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NameElementTextBox);
            this.Controls.Add(this.NameElementLabel);
            this.Name = "DeleteBranchElementForm";
            this.Text = "Удаление ветки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameElementLabel;
        private System.Windows.Forms.TextBox NameElementTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}