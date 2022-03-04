
namespace OOP_KR
{
    partial class Form1
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
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.ButtonCreateBranche = new System.Windows.Forms.Button();
            this.AddElement = new System.Windows.Forms.Button();
            this.RedactElementButton = new System.Windows.Forms.Button();
            this.OnOffButton = new System.Windows.Forms.Button();
            this.DeleteElement = new System.Windows.Forms.Button();
            this.DeleteElectricalCircuitButton = new System.Windows.Forms.Button();
            this.CerializationButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteBranchButton = new System.Windows.Forms.Button();
            this.CoutInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoTextBox.Location = new System.Drawing.Point(280, 22);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoTextBox.Size = new System.Drawing.Size(1124, 596);
            this.InfoTextBox.TabIndex = 0;
            // 
            // ButtonCreateBranche
            // 
            this.ButtonCreateBranche.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreateBranche.Location = new System.Drawing.Point(12, 22);
            this.ButtonCreateBranche.Name = "ButtonCreateBranche";
            this.ButtonCreateBranche.Size = new System.Drawing.Size(262, 40);
            this.ButtonCreateBranche.TabIndex = 1;
            this.ButtonCreateBranche.Text = "Добавить новую ветку";
            this.ButtonCreateBranche.UseVisualStyleBackColor = true;
            this.ButtonCreateBranche.Click += new System.EventHandler(this.ButtonCreateBranche_Click);
            // 
            // AddElement
            // 
            this.AddElement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElement.Location = new System.Drawing.Point(12, 68);
            this.AddElement.Name = "AddElement";
            this.AddElement.Size = new System.Drawing.Size(262, 40);
            this.AddElement.TabIndex = 2;
            this.AddElement.Text = "Добавить элемент в цепь";
            this.AddElement.UseVisualStyleBackColor = true;
            this.AddElement.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // RedactElementButton
            // 
            this.RedactElementButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedactElementButton.Location = new System.Drawing.Point(12, 114);
            this.RedactElementButton.Name = "RedactElementButton";
            this.RedactElementButton.Size = new System.Drawing.Size(262, 40);
            this.RedactElementButton.TabIndex = 3;
            this.RedactElementButton.Text = "Редактировать элемент";
            this.RedactElementButton.UseVisualStyleBackColor = true;
            this.RedactElementButton.Click += new System.EventHandler(this.RedactElementButton_Click);
            // 
            // OnOffButton
            // 
            this.OnOffButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OnOffButton.Location = new System.Drawing.Point(12, 344);
            this.OnOffButton.Name = "OnOffButton";
            this.OnOffButton.Size = new System.Drawing.Size(262, 40);
            this.OnOffButton.TabIndex = 5;
            this.OnOffButton.Text = "ВКЛ/ВЫКЛ цепь";
            this.OnOffButton.UseVisualStyleBackColor = true;
            this.OnOffButton.Click += new System.EventHandler(this.OnOffButton_Click);
            // 
            // DeleteElement
            // 
            this.DeleteElement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteElement.Location = new System.Drawing.Point(12, 160);
            this.DeleteElement.Name = "DeleteElement";
            this.DeleteElement.Size = new System.Drawing.Size(262, 40);
            this.DeleteElement.TabIndex = 6;
            this.DeleteElement.Text = "Удалить элемент";
            this.DeleteElement.UseVisualStyleBackColor = true;
            this.DeleteElement.Click += new System.EventHandler(this.DeleteElement_Click);
            // 
            // DeleteElectricalCircuitButton
            // 
            this.DeleteElectricalCircuitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteElectricalCircuitButton.Location = new System.Drawing.Point(12, 252);
            this.DeleteElectricalCircuitButton.Name = "DeleteElectricalCircuitButton";
            this.DeleteElectricalCircuitButton.Size = new System.Drawing.Size(262, 40);
            this.DeleteElectricalCircuitButton.TabIndex = 7;
            this.DeleteElectricalCircuitButton.Text = "Удалить цепь";
            this.DeleteElectricalCircuitButton.UseVisualStyleBackColor = true;
            this.DeleteElectricalCircuitButton.Click += new System.EventHandler(this.DeleteElectricalCircuitButton_Click);
            // 
            // CerializationButton
            // 
            this.CerializationButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CerializationButton.Location = new System.Drawing.Point(12, 532);
            this.CerializationButton.Name = "CerializationButton";
            this.CerializationButton.Size = new System.Drawing.Size(262, 40);
            this.CerializationButton.TabIndex = 8;
            this.CerializationButton.Text = "Сохранить цепь в файл";
            this.CerializationButton.UseVisualStyleBackColor = true;
            this.CerializationButton.Click += new System.EventHandler(this.CerializationButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Загрузить цепь из файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteBranchButton
            // 
            this.DeleteBranchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBranchButton.Location = new System.Drawing.Point(12, 206);
            this.DeleteBranchButton.Name = "DeleteBranchButton";
            this.DeleteBranchButton.Size = new System.Drawing.Size(262, 40);
            this.DeleteBranchButton.TabIndex = 10;
            this.DeleteBranchButton.Text = "Удалить ветку";
            this.DeleteBranchButton.UseVisualStyleBackColor = true;
            this.DeleteBranchButton.Click += new System.EventHandler(this.DeleteBranchButton_Click);
            // 
            // CoutInfoButton
            // 
            this.CoutInfoButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoutInfoButton.Location = new System.Drawing.Point(12, 298);
            this.CoutInfoButton.Name = "CoutInfoButton";
            this.CoutInfoButton.Size = new System.Drawing.Size(262, 40);
            this.CoutInfoButton.TabIndex = 11;
            this.CoutInfoButton.Text = "Вывести информацию";
            this.CoutInfoButton.UseVisualStyleBackColor = true;
            this.CoutInfoButton.Click += new System.EventHandler(this.CoutInfoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 630);
            this.Controls.Add(this.CoutInfoButton);
            this.Controls.Add(this.DeleteBranchButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CerializationButton);
            this.Controls.Add(this.DeleteElectricalCircuitButton);
            this.Controls.Add(this.DeleteElement);
            this.Controls.Add(this.OnOffButton);
            this.Controls.Add(this.RedactElementButton);
            this.Controls.Add(this.AddElement);
            this.Controls.Add(this.ButtonCreateBranche);
            this.Controls.Add(this.InfoTextBox);
            this.Name = "Form1";
            this.Text = "Разчет электрических цепей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Button ButtonCreateBranche;
        private System.Windows.Forms.Button AddElement;
        private System.Windows.Forms.Button RedactElementButton;
        private System.Windows.Forms.Button OnOffButton;
        private System.Windows.Forms.Button DeleteElement;
        private System.Windows.Forms.Button DeleteElectricalCircuitButton;
        private System.Windows.Forms.Button CerializationButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteBranchButton;
        private System.Windows.Forms.Button CoutInfoButton;
    }
}