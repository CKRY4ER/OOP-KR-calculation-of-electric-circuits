
namespace OOP_KR
{
    partial class AddBranchForm
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
            this.TypeElementLabel = new System.Windows.Forms.Label();
            this.TypeElementComboBox = new System.Windows.Forms.ComboBox();
            this.ResistanceLabel = new System.Windows.Forms.Label();
            this.ResistanceTextBox = new System.Windows.Forms.TextBox();
            this.NameElementTextBox = new System.Windows.Forms.TextBox();
            this.NameElementLabel = new System.Windows.Forms.Label();
            this.VoltageEDSLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ResisterBox = new System.Windows.Forms.GroupBox();
            this.EDSBOX = new System.Windows.Forms.GroupBox();
            this.OutComingNodeTextBox = new System.Windows.Forms.TextBox();
            this.IncumingNodeTextBox = new System.Windows.Forms.TextBox();
            this.OutCummingNodeLabel = new System.Windows.Forms.Label();
            this.IncumingNodeLabel = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.KeySostLabel = new System.Windows.Forms.Label();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.AddElementAfter = new System.Windows.Forms.Button();
            this.EndAddElement = new System.Windows.Forms.Button();
            this.AddElementBefore = new System.Windows.Forms.Button();
            this.NameDanElementLabel = new System.Windows.Forms.Label();
            this.NameDanElementTextBox = new System.Windows.Forms.TextBox();
            this.OtmenaDoPosleAddButton = new System.Windows.Forms.Button();
            this.ResisterBox.SuspendLayout();
            this.EDSBOX.SuspendLayout();
            this.KeyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeElementLabel
            // 
            this.TypeElementLabel.AutoSize = true;
            this.TypeElementLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeElementLabel.Location = new System.Drawing.Point(12, 32);
            this.TypeElementLabel.Name = "TypeElementLabel";
            this.TypeElementLabel.Size = new System.Drawing.Size(220, 22);
            this.TypeElementLabel.TabIndex = 0;
            this.TypeElementLabel.Text = "Выберите тип элемента:";
            // 
            // TypeElementComboBox
            // 
            this.TypeElementComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeElementComboBox.FormattingEnabled = true;
            this.TypeElementComboBox.Items.AddRange(new object[] {
            "Резистор",
            "ЭДС источник",
            "Ключ",
            "Лампа"});
            this.TypeElementComboBox.Location = new System.Drawing.Point(240, 29);
            this.TypeElementComboBox.Name = "TypeElementComboBox";
            this.TypeElementComboBox.Size = new System.Drawing.Size(283, 30);
            this.TypeElementComboBox.TabIndex = 1;
            this.TypeElementComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeElementComboBox_SelectedIndexChanged);
            this.TypeElementComboBox.TextUpdate += new System.EventHandler(this.TextChangedTypeElement_TextBox);
            this.TypeElementComboBox.TextChanged += new System.EventHandler(this.TextChangedTypeElement_TextBox);
            this.TypeElementComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeElementKeyPressed_TextBox);
            // 
            // ResistanceLabel
            // 
            this.ResistanceLabel.AutoSize = true;
            this.ResistanceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResistanceLabel.Location = new System.Drawing.Point(6, 38);
            this.ResistanceLabel.Name = "ResistanceLabel";
            this.ResistanceLabel.Size = new System.Drawing.Size(285, 22);
            this.ResistanceLabel.TabIndex = 2;
            this.ResistanceLabel.Text = "Сопротивление резистора (Ом):";
            // 
            // ResistanceTextBox
            // 
            this.ResistanceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResistanceTextBox.Location = new System.Drawing.Point(329, 35);
            this.ResistanceTextBox.Name = "ResistanceTextBox";
            this.ResistanceTextBox.Size = new System.Drawing.Size(182, 30);
            this.ResistanceTextBox.TabIndex = 3;
            this.ResistanceTextBox.TextChanged += new System.EventHandler(this.ResistanceTextBox_TextChanged);
            this.ResistanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // NameElementTextBox
            // 
            this.NameElementTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameElementTextBox.Location = new System.Drawing.Point(154, 65);
            this.NameElementTextBox.Name = "NameElementTextBox";
            this.NameElementTextBox.Size = new System.Drawing.Size(369, 30);
            this.NameElementTextBox.TabIndex = 5;
            // 
            // NameElementLabel
            // 
            this.NameElementLabel.AutoSize = true;
            this.NameElementLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NameElementLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameElementLabel.Location = new System.Drawing.Point(12, 68);
            this.NameElementLabel.Name = "NameElementLabel";
            this.NameElementLabel.Size = new System.Drawing.Size(136, 22);
            this.NameElementLabel.TabIndex = 4;
            this.NameElementLabel.Text = "Имя элемента:";
            // 
            // VoltageEDSLabel
            // 
            this.VoltageEDSLabel.AutoSize = true;
            this.VoltageEDSLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VoltageEDSLabel.Location = new System.Drawing.Point(4, 37);
            this.VoltageEDSLabel.Name = "VoltageEDSLabel";
            this.VoltageEDSLabel.Size = new System.Drawing.Size(292, 22);
            this.VoltageEDSLabel.TabIndex = 6;
            this.VoltageEDSLabel.Text = "Напряжение ЭДС источника (В):";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(329, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 30);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VoltageKeyPressed_TextBox);
            // 
            // ResisterBox
            // 
            this.ResisterBox.Controls.Add(this.ResistanceLabel);
            this.ResisterBox.Controls.Add(this.ResistanceTextBox);
            this.ResisterBox.Enabled = false;
            this.ResisterBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResisterBox.Location = new System.Drawing.Point(12, 101);
            this.ResisterBox.Name = "ResisterBox";
            this.ResisterBox.Size = new System.Drawing.Size(515, 79);
            this.ResisterBox.TabIndex = 8;
            this.ResisterBox.TabStop = false;
            this.ResisterBox.Text = "Резистор";
            this.ResisterBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EDSBOX
            // 
            this.EDSBOX.Controls.Add(this.OutComingNodeTextBox);
            this.EDSBOX.Controls.Add(this.IncumingNodeTextBox);
            this.EDSBOX.Controls.Add(this.OutCummingNodeLabel);
            this.EDSBOX.Controls.Add(this.IncumingNodeLabel);
            this.EDSBOX.Controls.Add(this.VoltageEDSLabel);
            this.EDSBOX.Controls.Add(this.textBox1);
            this.EDSBOX.Enabled = false;
            this.EDSBOX.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EDSBOX.Location = new System.Drawing.Point(12, 186);
            this.EDSBOX.Name = "EDSBOX";
            this.EDSBOX.Size = new System.Drawing.Size(515, 142);
            this.EDSBOX.TabIndex = 9;
            this.EDSBOX.TabStop = false;
            this.EDSBOX.Text = "ЭДС источник";
            // 
            // OutComingNodeTextBox
            // 
            this.OutComingNodeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutComingNodeTextBox.Location = new System.Drawing.Point(218, 106);
            this.OutComingNodeTextBox.Name = "OutComingNodeTextBox";
            this.OutComingNodeTextBox.Size = new System.Drawing.Size(293, 30);
            this.OutComingNodeTextBox.TabIndex = 11;
            this.OutComingNodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutcummingNodeKeyPressed_TextBox);
            // 
            // IncumingNodeTextBox
            // 
            this.IncumingNodeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncumingNodeTextBox.Location = new System.Drawing.Point(205, 70);
            this.IncumingNodeTextBox.Name = "IncumingNodeTextBox";
            this.IncumingNodeTextBox.Size = new System.Drawing.Size(306, 30);
            this.IncumingNodeTextBox.TabIndex = 10;
            this.IncumingNodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IncumingNodeKeyPressed_TextBox);
            // 
            // OutCummingNodeLabel
            // 
            this.OutCummingNodeLabel.AutoSize = true;
            this.OutCummingNodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutCummingNodeLabel.Location = new System.Drawing.Point(6, 109);
            this.OutCummingNodeLabel.Name = "OutCummingNodeLabel";
            this.OutCummingNodeLabel.Size = new System.Drawing.Size(206, 22);
            this.OutCummingNodeLabel.TabIndex = 9;
            this.OutCummingNodeLabel.Text = "Номер выходного узла:";
            // 
            // IncumingNodeLabel
            // 
            this.IncumingNodeLabel.AutoSize = true;
            this.IncumingNodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncumingNodeLabel.Location = new System.Drawing.Point(6, 73);
            this.IncumingNodeLabel.Name = "IncumingNodeLabel";
            this.IncumingNodeLabel.Size = new System.Drawing.Size(193, 22);
            this.IncumingNodeLabel.TabIndex = 8;
            this.IncumingNodeLabel.Text = "Номер входного узла:";
            // 
            // KeyBox
            // 
            this.KeyBox.Controls.Add(this.comboBox1);
            this.KeyBox.Controls.Add(this.KeySostLabel);
            this.KeyBox.Enabled = false;
            this.KeyBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyBox.Location = new System.Drawing.Point(12, 334);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(515, 80);
            this.KeyBox.TabIndex = 10;
            this.KeyBox.TabStop = false;
            this.KeyBox.Text = "Ключ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Опущен",
            "Поднят"});
            this.comboBox1.Location = new System.Drawing.Point(175, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 30);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SostKey_TextBox);
            // 
            // KeySostLabel
            // 
            this.KeySostLabel.AutoSize = true;
            this.KeySostLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeySostLabel.Location = new System.Drawing.Point(4, 33);
            this.KeySostLabel.Name = "KeySostLabel";
            this.KeySostLabel.Size = new System.Drawing.Size(165, 22);
            this.KeySostLabel.TabIndex = 3;
            this.KeySostLabel.Text = "Состояние ключа:";
            // 
            // AddElementButton
            // 
            this.AddElementButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElementButton.Location = new System.Drawing.Point(12, 420);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(231, 33);
            this.AddElementButton.TabIndex = 11;
            this.AddElementButton.Text = "Добавить элемент";
            this.AddElementButton.UseVisualStyleBackColor = true;
            this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
            // 
            // AddElementAfter
            // 
            this.AddElementAfter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddElementAfter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElementAfter.Location = new System.Drawing.Point(12, 459);
            this.AddElementAfter.Name = "AddElementAfter";
            this.AddElementAfter.Size = new System.Drawing.Size(515, 33);
            this.AddElementAfter.TabIndex = 12;
            this.AddElementAfter.Text = "Добавить элемент после заданного";
            this.AddElementAfter.UseVisualStyleBackColor = false;
            this.AddElementAfter.Click += new System.EventHandler(this.AddElementAfter_Click);
            // 
            // EndAddElement
            // 
            this.EndAddElement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndAddElement.Location = new System.Drawing.Point(249, 420);
            this.EndAddElement.Name = "EndAddElement";
            this.EndAddElement.Size = new System.Drawing.Size(278, 33);
            this.EndAddElement.TabIndex = 13;
            this.EndAddElement.Text = "Закончить";
            this.EndAddElement.UseVisualStyleBackColor = true;
            this.EndAddElement.Click += new System.EventHandler(this.EndAddElement_Click);
            // 
            // AddElementBefore
            // 
            this.AddElementBefore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElementBefore.Location = new System.Drawing.Point(12, 498);
            this.AddElementBefore.Name = "AddElementBefore";
            this.AddElementBefore.Size = new System.Drawing.Size(515, 33);
            this.AddElementBefore.TabIndex = 14;
            this.AddElementBefore.Text = "Добавить элемент до заданного";
            this.AddElementBefore.UseVisualStyleBackColor = true;
            this.AddElementBefore.Click += new System.EventHandler(this.AddElementBefore_Click);
            // 
            // NameDanElementLabel
            // 
            this.NameDanElementLabel.AutoSize = true;
            this.NameDanElementLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDanElementLabel.Location = new System.Drawing.Point(16, 550);
            this.NameDanElementLabel.Name = "NameDanElementLabel";
            this.NameDanElementLabel.Size = new System.Drawing.Size(227, 22);
            this.NameDanElementLabel.TabIndex = 15;
            this.NameDanElementLabel.Text = "Имя заданного элемента:";
            this.NameDanElementLabel.Visible = false;
            // 
            // NameDanElementTextBox
            // 
            this.NameDanElementTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDanElementTextBox.Location = new System.Drawing.Point(249, 547);
            this.NameDanElementTextBox.Name = "NameDanElementTextBox";
            this.NameDanElementTextBox.Size = new System.Drawing.Size(274, 30);
            this.NameDanElementTextBox.TabIndex = 16;
            this.NameDanElementTextBox.Visible = false;
            // 
            // OtmenaDoPosleAddButton
            // 
            this.OtmenaDoPosleAddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtmenaDoPosleAddButton.Location = new System.Drawing.Point(12, 583);
            this.OtmenaDoPosleAddButton.Name = "OtmenaDoPosleAddButton";
            this.OtmenaDoPosleAddButton.Size = new System.Drawing.Size(515, 33);
            this.OtmenaDoPosleAddButton.TabIndex = 17;
            this.OtmenaDoPosleAddButton.Text = "Отменить добавление до/после заданного";
            this.OtmenaDoPosleAddButton.UseVisualStyleBackColor = true;
            this.OtmenaDoPosleAddButton.Visible = false;
            this.OtmenaDoPosleAddButton.Click += new System.EventHandler(this.OtmenaDoPosleAddButton_Click);
            // 
            // AddBranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 640);
            this.ControlBox = false;
            this.Controls.Add(this.OtmenaDoPosleAddButton);
            this.Controls.Add(this.NameDanElementTextBox);
            this.Controls.Add(this.NameDanElementLabel);
            this.Controls.Add(this.AddElementBefore);
            this.Controls.Add(this.EndAddElement);
            this.Controls.Add(this.AddElementAfter);
            this.Controls.Add(this.AddElementButton);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.EDSBOX);
            this.Controls.Add(this.ResisterBox);
            this.Controls.Add(this.NameElementTextBox);
            this.Controls.Add(this.NameElementLabel);
            this.Controls.Add(this.TypeElementComboBox);
            this.Controls.Add(this.TypeElementLabel);
            this.Name = "AddBranchForm";
            this.Text = "Добавление элементов в ветку";
            this.Load += new System.EventHandler(this.AddBranchForm_Load);
            this.ResisterBox.ResumeLayout(false);
            this.ResisterBox.PerformLayout();
            this.EDSBOX.ResumeLayout(false);
            this.EDSBOX.PerformLayout();
            this.KeyBox.ResumeLayout(false);
            this.KeyBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeElementLabel;
        private System.Windows.Forms.ComboBox TypeElementComboBox;
        private System.Windows.Forms.Label ResistanceLabel;
        private System.Windows.Forms.TextBox ResistanceTextBox;
        private System.Windows.Forms.TextBox NameElementTextBox;
        private System.Windows.Forms.Label NameElementLabel;
        private System.Windows.Forms.Label VoltageEDSLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox ResisterBox;
        private System.Windows.Forms.GroupBox EDSBOX;
        private System.Windows.Forms.Label IncumingNodeLabel;
        private System.Windows.Forms.TextBox OutComingNodeTextBox;
        private System.Windows.Forms.TextBox IncumingNodeTextBox;
        private System.Windows.Forms.Label OutCummingNodeLabel;
        private System.Windows.Forms.GroupBox KeyBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label KeySostLabel;
        private System.Windows.Forms.Button AddElementButton;
        private System.Windows.Forms.Button AddElementAfter;
        private System.Windows.Forms.Button EndAddElement;
        private System.Windows.Forms.Button AddElementBefore;
        private System.Windows.Forms.Label NameDanElementLabel;
        private System.Windows.Forms.TextBox NameDanElementTextBox;
        private System.Windows.Forms.Button OtmenaDoPosleAddButton;
    }
}