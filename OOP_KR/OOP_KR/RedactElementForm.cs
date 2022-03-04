using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KR
{
    public partial class RedactElementForm : Form
    {
        Resister res;
        CCS c;
        Key k;
        Branche branche;
        public RedactElementForm()
        {
            InitializeComponent();
        }
        public void ShowRedactElement()
        {
            NameElementRedactButton.Enabled = false;
            NameelementRedactTextBox.Enabled = false;
            NewNameElementTextBox.Enabled = true;
            ChoseNewElementButton.Enabled = true;
            insertButton.Enabled = true;
            NewNameButton.Enabled = true;
        }
        public void HideRedacntElement()
        {
            NameElementRedactButton.Enabled = true;
            NameelementRedactTextBox.Enabled = true;
          
            InfoElementTextBox.Text = "";
            NewNameElementTextBox.Text = "";
            NewNameElementTextBox.Enabled = false;
            NewNameButton.Enabled = false;
            ResisterGroupBox.Enabled = false;
            ResisterTextBox.Text = "";
            CCSGroupBox.Enabled = false;
            VoltageTextBox.Text = "";
            IncumingNodeTextBox.Text = "";
            OutCumingNodeTextBox.Text = "";
            comboBox1.Text = "";
            KeyBox.Enabled = false;
        }
        private void ResisterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResisterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void VoltageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void IncumingNodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void OutCumingNodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void NameElementRedactButton_Click(object sender, EventArgs e)
        {
            if (NameelementRedactTextBox.Text == "")

                return;
            foreach (Branche br in Form1.electricalСircuit.branches)
            {
                foreach(Elements el in br.elements)
                {
                    if (el.Name== NameelementRedactTextBox.Text)
                    {
                        branche = br;
                        if (el is Resister)
                        {
                            res = (Resister)el;
                            InfoElementTextBox.Text = res.ToString();
                            ShowRedactElement();
                            ResisterGroupBox.Enabled = true;
                            CCSGroupBox.Enabled = false;
                            KeyBox.Enabled = false;
                            return;
                        }
                        if (el is CCS)
                        {
                            c = (CCS)el;
                            InfoElementTextBox.Text = c.ToString();
                            ShowRedactElement();
                            ResisterGroupBox.Enabled = false;
                            CCSGroupBox.Enabled = true;
                            KeyBox.Enabled = false;
                            return;
                        }
                        if(el is Key)
                        {
                            k = (Key)el;
                            InfoElementTextBox.Text = k.ToString();
                            ShowRedactElement();
                            ResisterGroupBox.Enabled = false;
                            CCSGroupBox.Enabled = false;
                            KeyBox.Enabled = true;
                            return;
                        }
                        if (el is Lamp)
                        {
                            MessageBox.Show(this, "В лампе нечего менять.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NameelementRedactTextBox.Text = "";
                            return;
                        }
                        
                    }
                }
            }
            MessageBox.Show(this, "Элемент не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            NameelementRedactTextBox.Text = "";
            return;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (ResisterGroupBox.Enabled)
            {
                if (ResisterTextBox.Text == "")
                    return;
                res.Resistance = double.Parse(ResisterTextBox.Text);
                InfoElementTextBox.Text = res.ToString();
                ResisterTextBox.Text = "";
                return;
            }
            if (CCSGroupBox.Enabled)
            {
                if(VoltageTextBox.Text==""|| IncumingNodeTextBox.Text=="" || OutCumingNodeTextBox.Text == "")
                {
                    MessageBox.Show(this, "Не все поля для редактирования заполнены. Если вы не хотите менять входящие и вывходящие узлы, то введите в поля номера данныйх узлов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((IncumingNodeTextBox.Text == branche.IncumingNode.Name || IncumingNodeTextBox.Text == branche.OutcummingNode.Name) && (OutCumingNodeTextBox.Text == branche.IncumingNode.Name || OutCumingNodeTextBox.Text == branche.OutcummingNode.Name))
                {
                    switch (IncumingNodeTextBox.Text)
                    {
                        case ("1"):
                            c.IncumingNode = Form1.electricalСircuit.FNode;
                            break;
                        case ("2"):
                            c.IncumingNode = Form1.electricalСircuit.SNode;
                            break;
                        case ("3"):
                            c.IncumingNode = Form1.electricalСircuit.TNode;
                            break;
                        default:
                            MessageBox.Show(this, "В поле \"Входящий узел\" указан номер не существующего узла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            IncumingNodeTextBox.Text = "";
                            return;
                    }
                    switch (OutCumingNodeTextBox.Text)
                    {
                        case ("1"):
                            c.OutcummingNode = Form1.electricalСircuit.FNode;
                            break;
                        case ("2"):
                            c.OutcummingNode = Form1.electricalСircuit.SNode;
                            break;
                        case ("3"):
                            break;
                        default:
                            MessageBox.Show(this, "В поле \"Выходящий узел\" указан номер не существующего узла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            OutCumingNodeTextBox.Text = "";
                            return;
                    }
                    c.Voltage = double.Parse(VoltageTextBox.Text);
                    VoltageTextBox.Text = "";
                    IncumingNodeTextBox.Text = "";
                    OutCumingNodeTextBox.Text = "";
                    InfoElementTextBox.Text = c.ToString();
                }
                else
                {

                }
            }
            if (KeyBox.Enabled)
            {
                if (comboBox1.Text == "")
                    return;
                if (comboBox1.Text == "Опущен")
                    k.active = true;
                else
                    k.active = false;
                comboBox1.Text = "";
                InfoElementTextBox.Text = k.ToString();
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NewNameButton_Click(object sender, EventArgs e)
        {
            if (NewNameElementTextBox.Text == "")
                return;
            foreach(Branche br in Form1.electricalСircuit.branches)
            {
                foreach(Elements el in br.elements)
                {
                    if(el.Name==NewNameElementTextBox.Text)
                    {
                        MessageBox.Show(this, "Данное имя уже занято.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NewNameElementTextBox.Text = "";
                        return;
                    }
                }
            }
            if (ResisterGroupBox.Enabled)
            {
                res.Name = NewNameElementTextBox.Text;
                InfoElementTextBox.Text = res.ToString();
               
            }
            if (CCSGroupBox.Enabled)
            {
                c.Name = NewNameElementTextBox.Text;
                InfoElementTextBox.Text = c.ToString();
               
            }
            if (KeyBox.Enabled)
            {
                k.Name = NewNameElementTextBox.Text;
                InfoElementTextBox.Text = k.ToString();
                
            }
            NameelementRedactTextBox.Text = NewNameElementTextBox.Text;
            NewNameElementTextBox.Text = "";
        }

        private void EndRedactButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChoseNewElementButton_Click(object sender, EventArgs e)
        {
            HideRedacntElement();
        }
    }
}
