
namespace OOP_KR
{
    partial class RedactElementForm
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
            this.InfoElementLabel = new System.Windows.Forms.Label();
            this.InfoElementTextBox = new System.Windows.Forms.TextBox();
            this.NameelementRedactLabel = new System.Windows.Forms.Label();
            this.NameelementRedactTextBox = new System.Windows.Forms.TextBox();
            this.NameElementRedactButton = new System.Windows.Forms.Button();
            this.NewNameElementLabel = new System.Windows.Forms.Label();
            this.NewNameElementTextBox = new System.Windows.Forms.TextBox();
            this.ResisterGroupBox = new System.Windows.Forms.GroupBox();
            this.ResisterTextBox = new System.Windows.Forms.TextBox();
            this.ResisterLabel = new System.Windows.Forms.Label();
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
            this.insertButton = new System.Windows.Forms.Button();
            this.EndRedactButton = new System.Windows.Forms.Button();
            this.ChoseNewElementButton = new System.Windows.Forms.Button();
            this.NewNameButton = new System.Windows.Forms.Button();
            this.ResisterGroupBox.SuspendLayout();
            this.CCSGroupBox.SuspendLayout();
            this.KeyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoElementLabel
            // 
            this.InfoElementLabel.AutoSize = true;
            this.InfoElementLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoElementLabel.Location = new System.Drawing.Point(12, 9);
            this.InfoElementLabel.Name = "InfoElementLabel";
            this.InfoElementLabel.Size = new System.Drawing.Size(327, 22);
            this.InfoElementLabel.TabIndex = 0;
            this.InfoElementLabel.Text = "Информация о выбранном элементе:";
            // 
            // InfoElementTextBox
            // 
            this.InfoElementTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoElementTextBox.Location = new System.Drawing.Point(12, 34);
            this.InfoElementTextBox.Multiline = true;
            this.InfoElementTextBox.Name = "InfoElementTextBox";
            this.InfoElementTextBox.ReadOnly = true;
            this.InfoElementTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoElementTextBox.Size = new System.Drawing.Size(509, 137);
            this.InfoElementTextBox.TabIndex = 1;
            // 
            // NameelementRedactLabel
            // 
            this.NameelementRedactLabel.AutoSize = true;
            this.NameelementRedactLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameelementRedactLabel.Location = new System.Drawing.Point(12, 194);
            this.NameelementRedactLabel.Name = "NameelementRedactLabel";
            this.NameelementRedactLabel.Size = new System.Drawing.Size(312, 22);
            this.NameelementRedactLabel.TabIndex = 2;
            this.NameelementRedactLabel.Text = "Имя элемента для редактирования:";
            // 
            // NameelementRedactTextBox
            // 
            this.NameelementRedactTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameelementRedactTextBox.Location = new System.Drawing.Point(330, 191);
            this.NameelementRedactTextBox.Name = "NameelementRedactTextBox";
            this.NameelementRedactTextBox.Size = new System.Drawing.Size(185, 30);
            this.NameelementRedactTextBox.TabIndex = 3;
            // 
            // NameElementRedactButton
            // 
            this.NameElementRedactButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameElementRedactButton.Location = new System.Drawing.Point(12, 227);
            this.NameElementRedactButton.Name = "NameElementRedactButton";
            this.NameElementRedactButton.Size = new System.Drawing.Size(249, 33);
            this.NameElementRedactButton.TabIndex = 4;
            this.NameElementRedactButton.Text = "Выбрать элемент";
            this.NameElementRedactButton.UseVisualStyleBackColor = true;
            this.NameElementRedactButton.Click += new System.EventHandler(this.NameElementRedactButton_Click);
            // 
            // NewNameElementLabel
            // 
            this.NewNameElementLabel.AutoSize = true;
            this.NewNameElementLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewNameElementLabel.Location = new System.Drawing.Point(12, 269);
            this.NewNameElementLabel.Name = "NewNameElementLabel";
            this.NewNameElementLabel.Size = new System.Drawing.Size(190, 22);
            this.NewNameElementLabel.TabIndex = 5;
            this.NewNameElementLabel.Text = "Новое имя элемента:";
            // 
            // NewNameElementTextBox
            // 
            this.NewNameElementTextBox.Enabled = false;
            this.NewNameElementTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewNameElementTextBox.Location = new System.Drawing.Point(208, 266);
            this.NewNameElementTextBox.Name = "NewNameElementTextBox";
            this.NewNameElementTextBox.Size = new System.Drawing.Size(307, 30);
            this.NewNameElementTextBox.TabIndex = 6;
            // 
            // ResisterGroupBox
            // 
            this.ResisterGroupBox.Controls.Add(this.ResisterTextBox);
            this.ResisterGroupBox.Controls.Add(this.ResisterLabel);
            this.ResisterGroupBox.Enabled = false;
            this.ResisterGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResisterGroupBox.Location = new System.Drawing.Point(12, 341);
            this.ResisterGroupBox.Name = "ResisterGroupBox";
            this.ResisterGroupBox.Size = new System.Drawing.Size(509, 84);
            this.ResisterGroupBox.TabIndex = 8;
            this.ResisterGroupBox.TabStop = false;
            this.ResisterGroupBox.Text = "Резистор";
            // 
            // ResisterTextBox
            // 
            this.ResisterTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResisterTextBox.Location = new System.Drawing.Point(297, 36);
            this.ResisterTextBox.Name = "ResisterTextBox";
            this.ResisterTextBox.Size = new System.Drawing.Size(206, 30);
            this.ResisterTextBox.TabIndex = 7;
            this.ResisterTextBox.TextChanged += new System.EventHandler(this.ResisterTextBox_TextChanged);
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
            this.CCSGroupBox.Location = new System.Drawing.Point(12, 431);
            this.CCSGroupBox.Name = "CCSGroupBox";
            this.CCSGroupBox.Size = new System.Drawing.Size(509, 155);
            this.CCSGroupBox.TabIndex = 11;
            this.CCSGroupBox.TabStop = false;
            this.CCSGroupBox.Text = "ЭДС источник";
            // 
            // OutCumingNodeTextBox
            // 
            this.OutCumingNodeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutCumingNodeTextBox.Location = new System.Drawing.Point(218, 108);
            this.OutCumingNodeTextBox.Name = "OutCumingNodeTextBox";
            this.OutCumingNodeTextBox.Size = new System.Drawing.Size(285, 30);
            this.OutCumingNodeTextBox.TabIndex = 11;
            this.OutCumingNodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutCumingNodeTextBox_KeyPress);
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
            this.IncumingNodeTextBox.Size = new System.Drawing.Size(298, 30);
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
            this.VoltageTextBox.Size = new System.Drawing.Size(199, 30);
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
            this.KeyBox.Location = new System.Drawing.Point(12, 592);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(509, 80);
            this.KeyBox.TabIndex = 12;
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
            this.comboBox1.Size = new System.Drawing.Size(328, 30);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
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
            // insertButton
            // 
            this.insertButton.Enabled = false;
            this.insertButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertButton.Location = new System.Drawing.Point(12, 678);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(249, 33);
            this.insertButton.TabIndex = 13;
            this.insertButton.Text = "Внести изменения";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // EndRedactButton
            // 
            this.EndRedactButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndRedactButton.Location = new System.Drawing.Point(267, 678);
            this.EndRedactButton.Name = "EndRedactButton";
            this.EndRedactButton.Size = new System.Drawing.Size(254, 33);
            this.EndRedactButton.TabIndex = 14;
            this.EndRedactButton.Text = "Закончить";
            this.EndRedactButton.UseVisualStyleBackColor = true;
            this.EndRedactButton.Click += new System.EventHandler(this.EndRedactButton_Click);
            // 
            // ChoseNewElementButton
            // 
            this.ChoseNewElementButton.Enabled = false;
            this.ChoseNewElementButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoseNewElementButton.Location = new System.Drawing.Point(267, 227);
            this.ChoseNewElementButton.Name = "ChoseNewElementButton";
            this.ChoseNewElementButton.Size = new System.Drawing.Size(254, 33);
            this.ChoseNewElementButton.TabIndex = 15;
            this.ChoseNewElementButton.Text = "Выбрать другой элемент";
            this.ChoseNewElementButton.UseVisualStyleBackColor = true;
            this.ChoseNewElementButton.Click += new System.EventHandler(this.ChoseNewElementButton_Click);
            // 
            // NewNameButton
            // 
            this.NewNameButton.Enabled = false;
            this.NewNameButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewNameButton.Location = new System.Drawing.Point(267, 302);
            this.NewNameButton.Name = "NewNameButton";
            this.NewNameButton.Size = new System.Drawing.Size(254, 33);
            this.NewNameButton.TabIndex = 16;
            this.NewNameButton.Text = "Изменить имя элемента";
            this.NewNameButton.UseVisualStyleBackColor = true;
            this.NewNameButton.Click += new System.EventHandler(this.NewNameButton_Click);
            // 
            // RedactElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 721);
            this.Controls.Add(this.NewNameButton);
            this.Controls.Add(this.ChoseNewElementButton);
            this.Controls.Add(this.EndRedactButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.CCSGroupBox);
            this.Controls.Add(this.ResisterGroupBox);
            this.Controls.Add(this.NewNameElementTextBox);
            this.Controls.Add(this.NewNameElementLabel);
            this.Controls.Add(this.NameElementRedactButton);
            this.Controls.Add(this.NameelementRedactTextBox);
            this.Controls.Add(this.NameelementRedactLabel);
            this.Controls.Add(this.InfoElementTextBox);
            this.Controls.Add(this.InfoElementLabel);
            this.Name = "RedactElementForm";
            this.Text = "Редактирование элемента";
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

        private System.Windows.Forms.Label InfoElementLabel;
        private System.Windows.Forms.TextBox InfoElementTextBox;
        private System.Windows.Forms.Label NameelementRedactLabel;
        private System.Windows.Forms.TextBox NameelementRedactTextBox;
        private System.Windows.Forms.Button NameElementRedactButton;
        private System.Windows.Forms.Label NewNameElementLabel;
        private System.Windows.Forms.TextBox NewNameElementTextBox;
        private System.Windows.Forms.GroupBox ResisterGroupBox;
        private System.Windows.Forms.TextBox ResisterTextBox;
        private System.Windows.Forms.Label ResisterLabel;
        private System.Windows.Forms.GroupBox CCSGroupBox;
        private System.Windows.Forms.TextBox OutCumingNodeTextBox;
        private System.Windows.Forms.Label OutcummingNodeLabel;
        private System.Windows.Forms.TextBox IncumingNodeTextBox;
        private System.Windows.Forms.Label IncumingNodeLabel;
        private System.Windows.Forms.TextBox VoltageTextBox;
        private System.Windows.Forms.Label VoltageLabel;
        private System.Windows.Forms.GroupBox KeyBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label KeySostLabel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button EndRedactButton;
        private System.Windows.Forms.Button ChoseNewElementButton;
        private System.Windows.Forms.Button NewNameButton;
    }
}