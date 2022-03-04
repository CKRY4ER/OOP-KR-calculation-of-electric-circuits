
namespace OOP_KR
{
    partial class AddElementsForm
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
            this.BranchInfoTextBox = new System.Windows.Forms.TextBox();
            this.BranchInfoLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NameElementLabel = new System.Windows.Forms.Label();
            this.NameElementTextBox = new System.Windows.Forms.TextBox();
            this.TypeElementLabel = new System.Windows.Forms.Label();
            this.TypeElementComboBox = new System.Windows.Forms.ComboBox();
            this.ResisterGroupBox = new System.Windows.Forms.GroupBox();
            this.ResisterTextBox = new System.Windows.Forms.TextBox();
            this.ResisterLabel = new System.Windows.Forms.Label();
            this.NameElementAddLabel = new System.Windows.Forms.Label();
            this.NameNewElementTextBox = new System.Windows.Forms.TextBox();
            this.CCSGroupBox = new System.Windows.Forms.GroupBox();
            this.OutCumingNodeTextBox = new System.Windows.Forms.TextBox();
            this.OutcummingNodeLabel = new System.Windows.Forms.Label();
            this.IncumingNodeTextBox = new System.Windows.Forms.TextBox();
            this.IncumingNodeLabel = new System.Windows.Forms.Label();
            this.VoltageTextBox = new System.Windows.Forms.TextBox();
            this.VoltageLabel = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.KeySostLabel = new System.Windows.Forms.Label();
            this.AddElementButton = new System.Windows.Forms.Button();
            this.EndAddElement = new System.Windows.Forms.Button();
            this.AddElementAfter = new System.Windows.Forms.Button();
            this.AddElementBefore = new System.Windows.Forms.Button();
            this.OtmenaDoPosleAddButton = new System.Windows.Forms.Button();
            this.NameDanElementTextBox = new System.Windows.Forms.TextBox();
            this.NameDanElementLabel = new System.Windows.Forms.Label();
            this.ResisterGroupBox.SuspendLayout();
            this.CCSGroupBox.SuspendLayout();
            this.KeyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BranchInfoTextBox
            // 
            this.BranchInfoTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BranchInfoTextBox.Location = new System.Drawing.Point(12, 34);
            this.BranchInfoTextBox.Multiline = true;
            this.BranchInfoTextBox.Name = "BranchInfoTextBox";
            this.BranchInfoTextBox.ReadOnly = true;
            this.BranchInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BranchInfoTextBox.Size = new System.Drawing.Size(518, 201);
            this.BranchInfoTextBox.TabIndex = 0;
            // 
            // BranchInfoLabel
            // 
            this.BranchInfoLabel.AutoSize = true;
            this.BranchInfoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BranchInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.BranchInfoLabel.Name = "BranchInfoLabel";
            this.BranchInfoLabel.Size = new System.Drawing.Size(193, 22);
            this.BranchInfoLabel.TabIndex = 1;
            this.BranchInfoLabel.Text = "Информация о ветке:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(518, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать элемент";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameElementLabel
            // 
            this.NameElementLabel.AutoSize = true;
            this.NameElementLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameElementLabel.Location = new System.Drawing.Point(8, 254);
            this.NameElementLabel.Name = "NameElementLabel";
            this.NameElementLabel.Size = new System.Drawing.Size(136, 22);
            this.NameElementLabel.TabIndex = 3;
            this.NameElementLabel.Text = "Имя элемента:";
            // 
            // NameElementTextBox
            // 
            this.NameElementTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameElementTextBox.Location = new System.Drawing.Point(150, 251);
            this.NameElementTextBox.Name = "NameElementTextBox";
            this.NameElementTextBox.Size = new System.Drawing.Size(380, 30);
            this.NameElementTextBox.TabIndex = 4;
            // 
            // TypeElementLabel
            // 
            this.TypeElementLabel.AutoSize = true;
            this.TypeElementLabel.Enabled = false;
            this.TypeElementLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeElementLabel.Location = new System.Drawing.Point(12, 330);
            this.TypeElementLabel.Name = "TypeElementLabel";
            this.TypeElementLabel.Size = new System.Drawing.Size(134, 22);
            this.TypeElementLabel.TabIndex = 5;
            this.TypeElementLabel.Text = "Тип элемента:";
            // 
            // TypeElementComboBox
            // 
            this.TypeElementComboBox.Enabled = false;
            this.TypeElementComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeElementComboBox.FormattingEnabled = true;
            this.TypeElementComboBox.Items.AddRange(new object[] {
            "Резистор",
            "ЭДС источник",
            "Ключ",
            "Лампа"});
            this.TypeElementComboBox.Location = new System.Drawing.Point(150, 327);
            this.TypeElementComboBox.Name = "TypeElementComboBox";
            this.TypeElementComboBox.Size = new System.Drawing.Size(380, 30);
            this.TypeElementComboBox.TabIndex = 6;
            this.TypeElementComboBox.TextChanged += new System.EventHandler(this.TypeElementComboBox_TextChanged);
            this.TypeElementComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeElementComboBox_KeyPress);
            // 
            // ResisterGroupBox
            // 
            this.ResisterGroupBox.Controls.Add(this.ResisterTextBox);
            this.ResisterGroupBox.Controls.Add(this.ResisterLabel);
            this.ResisterGroupBox.Enabled = false;
            this.ResisterGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResisterGroupBox.Location = new System.Drawing.Point(12, 399);
            this.ResisterGroupBox.Name = "ResisterGroupBox";
            this.ResisterGroupBox.Size = new System.Drawing.Size(518, 84);
            this.ResisterGroupBox.TabIndex = 7;
            this.ResisterGroupBox.TabStop = false;
            this.ResisterGroupBox.Text = "Резистор";
            // 
            // ResisterTextBox
            // 
            this.ResisterTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResisterTextBox.Location = new System.Drawing.Point(297, 36);
            this.ResisterTextBox.Name = "ResisterTextBox";
            this.ResisterTextBox.Size = new System.Drawing.Size(215, 30);
            this.ResisterTextBox.TabIndex = 7;
            this.ResisterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResisterTextBox_KeyPress);
            // 
            // ResisterLabel
            // 
            this.ResisterLabel.AutoSize = true;
            this.ResisterLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResisterLabel.Location = new System.Drawing.Point(6, 39);
            this.ResisterLabel.Name = "ResisterLabel";
            this.ResisterLabel.Size = new System.Drawing.Size(285, 22);
            this.ResisterLabel.TabIndex = 6;
            this.ResisterLabel.Text = "Сопротивление резистора (Ом):";
            // 
            // NameElementAddLabel
            // 
            this.NameElementAddLabel.AutoSize = true;
            this.NameElementAddLabel.Enabled = false;
            this.NameElementAddLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameElementAddLabel.Location = new System.Drawing.Point(12, 366);
            this.NameElementAddLabel.Name = "NameElementAddLabel";
            this.NameElementAddLabel.Size = new System.Drawing.Size(199, 22);
            this.NameElementAddLabel.TabIndex = 8;
            this.NameElementAddLabel.Text = "Имя нового элемента:";
            // 
            // NameNewElementTextBox
            // 
            this.NameNewElementTextBox.Enabled = false;
            this.NameNewElementTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameNewElementTextBox.Location = new System.Drawing.Point(217, 363);
            this.NameNewElementTextBox.Name = "NameNewElementTextBox";
            this.NameNewElementTextBox.Size = new System.Drawing.Size(313, 30);
            this.NameNewElementTextBox.TabIndex = 9;
            // 
            // CCSGroupBox
            // 
            this.CCSGroupBox.Controls.Add(this.OutCumingNodeTextBox);
            this.CCSGroupBox.Controls.Add(this.OutcummingNodeLabel);
            this.CCSGroupBox.Controls.Add(this.IncumingNodeTextBox);
            this.CCSGroupBox.Controls.Add(this.IncumingNodeLabel);
            this.CCSGroupBox.Controls.Add(this.VoltageTextBox);
            this.CCSGroupBox.Controls.Add(this.VoltageLabel);
            this.CCSGroupBox.Enabled = false;
            this.CCSGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CCSGroupBox.Location = new System.Drawing.Point(12, 489);
            this.CCSGroupBox.Name = "CCSGroupBox";
            this.CCSGroupBox.Size = new System.Drawing.Size(518, 155);
            this.CCSGroupBox.TabIndex = 10;
            this.CCSGroupBox.TabStop = false;
            this.CCSGroupBox.Text = "ЭДС источник";
            this.CCSGroupBox.Enter += new System.EventHandler(this.CCSGroupBox_Enter);
            // 
            // OutCumingNodeTextBox
            // 
            this.OutCumingNodeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutCumingNodeTextBox.Location = new System.Drawing.Point(218, 108);
            this.OutCumingNodeTextBox.Name = "OutCumingNodeTextBox";
            this.OutCumingNodeTextBox.Size = new System.Drawing.Size(294, 30);
            this.OutCumingNodeTextBox.TabIndex = 11;
            this.OutCumingNodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // OutcummingNodeLabel
            // 
            this.OutcummingNodeLabel.AutoSize = true;
            this.OutcummingNodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutcummingNodeLabel.Location = new System.Drawing.Point(6, 111);
            this.OutcummingNodeLabel.Name = "OutcummingNodeLabel";
            this.OutcummingNodeLabel.Size = new System.Drawing.Size(206, 22);
            this.OutcummingNodeLabel.TabIndex = 10;
            this.OutcummingNodeLabel.Text = "Номер выходного узла:";
            // 
            // IncumingNodeTextBox
            // 
            this.IncumingNodeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncumingNodeTextBox.Location = new System.Drawing.Point(205, 72);
            this.IncumingNodeTextBox.Name = "IncumingNodeTextBox";
            this.IncumingNodeTextBox.Size = new System.Drawing.Size(307, 30);
            this.IncumingNodeTextBox.TabIndex = 9;
            this.IncumingNodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IncumingNodeTextBox_KeyPress);
            // 
            // IncumingNodeLabel
            // 
            this.IncumingNodeLabel.AutoSize = true;
            this.IncumingNodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncumingNodeLabel.Location = new System.Drawing.Point(6, 75);
            this.IncumingNodeLabel.Name = "IncumingNodeLabel";
            this.IncumingNodeLabel.Size = new System.Drawing.Size(193, 22);
            this.IncumingNodeLabel.TabIndex = 8;
            this.IncumingNodeLabel.Text = "Номер входного узла:";
            // 
            // VoltageTextBox
            // 
            this.VoltageTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VoltageTextBox.Location = new System.Drawing.Point(304, 36);
            this.VoltageTextBox.Name = "VoltageTextBox";
            this.VoltageTextBox.Size = new System.Drawing.Size(208, 30);
            this.VoltageTextBox.TabIndex = 7;
            this.VoltageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VoltageTextBox_KeyPress);
            // 
            // VoltageLabel
            // 
            this.VoltageLabel.AutoSize = true;
            this.VoltageLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VoltageLabel.Location = new System.Drawing.Point(6, 39);
            this.VoltageLabel.Name = "VoltageLabel";
            this.VoltageLabel.Size = new System.Drawing.Size(292, 22);
            this.VoltageLabel.TabIndex = 6;
            this.VoltageLabel.Text = "Напряжение ЭДС источника (В):";
            // 
            // KeyBox
            // 
            this.KeyBox.Controls.Add(this.comboBox1);
            this.KeyBox.Controls.Add(this.KeySostLabel);
            this.KeyBox.Enabled = false;
            this.KeyBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyBox.Location = new System.Drawing.Point(12, 650);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(518, 80);
            this.KeyBox.TabIndex = 11;
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
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SostKeyComboBox_KeyPress);
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
            this.AddElementButton.Enabled = false;
            this.AddElementButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElementButton.Location = new System.Drawing.Point(12, 736);
            this.AddElementButton.Name = "AddElementButton";
            this.AddElementButton.Size = new System.Drawing.Size(234, 33);
            this.AddElementButton.TabIndex = 12;
            this.AddElementButton.Text = "Добавить элемент";
            this.AddElementButton.UseVisualStyleBackColor = true;
            this.AddElementButton.Click += new System.EventHandler(this.AddElementButton_Click);
            // 
            // EndAddElement
            // 
            this.EndAddElement.Enabled = false;
            this.EndAddElement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndAddElement.Location = new System.Drawing.Point(252, 736);
            this.EndAddElement.Name = "EndAddElement";
            this.EndAddElement.Size = new System.Drawing.Size(278, 33);
            this.EndAddElement.TabIndex = 14;
            this.EndAddElement.Text = "Закончить";
            this.EndAddElement.UseVisualStyleBackColor = true;
            this.EndAddElement.Click += new System.EventHandler(this.EndAddElement_Click);
            // 
            // AddElementAfter
            // 
            this.AddElementAfter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddElementAfter.Enabled = false;
            this.AddElementAfter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElementAfter.Location = new System.Drawing.Point(12, 775);
            this.AddElementAfter.Name = "AddElementAfter";
            this.AddElementAfter.Size = new System.Drawing.Size(518, 33);
            this.AddElementAfter.TabIndex = 15;
            this.AddElementAfter.Text = "Добавить элемент после заданного";
            this.AddElementAfter.UseVisualStyleBackColor = false;
            this.AddElementAfter.Click += new System.EventHandler(this.AddElementAfter_Click);
            // 
            // AddElementBefore
            // 
            this.AddElementBefore.Enabled = false;
            this.AddElementBefore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddElementBefore.Location = new System.Drawing.Point(12, 814);
            this.AddElementBefore.Name = "AddElementBefore";
            this.AddElementBefore.Size = new System.Drawing.Size(518, 33);
            this.AddElementBefore.TabIndex = 16;
            this.AddElementBefore.Text = "Добавить элемент до заданного";
            this.AddElementBefore.UseVisualStyleBackColor = true;
            this.AddElementBefore.Click += new System.EventHandler(this.AddElementBefore_Click);
            // 
            // OtmenaDoPosleAddButton
            // 
            this.OtmenaDoPosleAddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtmenaDoPosleAddButton.Location = new System.Drawing.Point(12, 889);
            this.OtmenaDoPosleAddButton.Name = "OtmenaDoPosleAddButton";
            this.OtmenaDoPosleAddButton.Size = new System.Drawing.Size(518, 33);
            this.OtmenaDoPosleAddButton.TabIndex = 20;
            this.OtmenaDoPosleAddButton.Text = "Отменить добавление до/после заданного";
            this.OtmenaDoPosleAddButton.UseVisualStyleBackColor = true;
            this.OtmenaDoPosleAddButton.Visible = false;
            this.OtmenaDoPosleAddButton.Click += new System.EventHandler(this.OtmenaDoPosleAddButton_Click);
            // 
            // NameDanElementTextBox
            // 
            this.NameDanElementTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDanElementTextBox.Location = new System.Drawing.Point(252, 853);
            this.NameDanElementTextBox.Name = "NameDanElementTextBox";
            this.NameDanElementTextBox.Size = new System.Drawing.Size(278, 30);
            this.NameDanElementTextBox.TabIndex = 19;
            this.NameDanElementTextBox.Visible = false;
            // 
            // NameDanElementLabel
            // 
            this.NameDanElementLabel.AutoSize = true;
            this.NameDanElementLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDanElementLabel.Location = new System.Drawing.Point(19, 856);
            this.NameDanElementLabel.Name = "NameDanElementLabel";
            this.NameDanElementLabel.Size = new System.Drawing.Size(227, 22);
            this.NameDanElementLabel.TabIndex = 18;
            this.NameDanElementLabel.Text = "Имя заданного элемента:";
            this.NameDanElementLabel.Visible = false;
            // 
            // AddElementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(573, 945);
            this.Controls.Add(this.OtmenaDoPosleAddButton);
            this.Controls.Add(this.NameDanElementTextBox);
            this.Controls.Add(this.NameDanElementLabel);
            this.Controls.Add(this.AddElementBefore);
            this.Controls.Add(this.AddElementAfter);
            this.Controls.Add(this.EndAddElement);
            this.Controls.Add(this.AddElementButton);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.CCSGroupBox);
            this.Controls.Add(this.NameNewElementTextBox);
            this.Controls.Add(this.NameElementAddLabel);
            this.Controls.Add(this.ResisterGroupBox);
            this.Controls.Add(this.TypeElementComboBox);
            this.Controls.Add(this.TypeElementLabel);
            this.Controls.Add(this.NameElementTextBox);
            this.Controls.Add(this.NameElementLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BranchInfoLabel);
            this.Controls.Add(this.BranchInfoTextBox);
            this.Name = "AddElementsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление элемента в цепь";
            this.Load += new System.EventHandler(this.AddElementsForm_Load);
            this.ResisterGroupBox.ResumeLayout(false);
            this.ResisterGroupBox.PerformLayout();
            this.CCSGroupBox.ResumeLayout(false);
            this.CCSGroupBox.PerformLayout();
            this.KeyBox.ResumeLayout(false);
            this.KeyBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BranchInfoTextBox;
        private System.Windows.Forms.Label BranchInfoLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameElementLabel;
        private System.Windows.Forms.TextBox NameElementTextBox;
        private System.Windows.Forms.Label TypeElementLabel;
        private System.Windows.Forms.ComboBox TypeElementComboBox;
        private System.Windows.Forms.GroupBox ResisterGroupBox;
        private System.Windows.Forms.TextBox ResisterTextBox;
        private System.Windows.Forms.Label ResisterLabel;
        private System.Windows.Forms.Label NameElementAddLabel;
        private System.Windows.Forms.TextBox NameNewElementTextBox;
        private System.Windows.Forms.GroupBox CCSGroupBox;
        private System.Windows.Forms.TextBox IncumingNodeTextBox;
        private System.Windows.Forms.Label IncumingNodeLabel;
        private System.Windows.Forms.TextBox VoltageTextBox;
        private System.Windows.Forms.Label VoltageLabel;
        private System.Windows.Forms.TextBox OutCumingNodeTextBox;
        private System.Windows.Forms.Label OutcummingNodeLabel;
        private System.Windows.Forms.GroupBox KeyBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label KeySostLabel;
        private System.Windows.Forms.Button AddElementButton;
        private System.Windows.Forms.Button EndAddElement;
        private System.Windows.Forms.Button AddElementAfter;
        private System.Windows.Forms.Button AddElementBefore;
        private System.Windows.Forms.Button OtmenaDoPosleAddButton;
        private System.Windows.Forms.TextBox NameDanElementTextBox;
        private System.Windows.Forms.Label NameDanElementLabel;
    }
}