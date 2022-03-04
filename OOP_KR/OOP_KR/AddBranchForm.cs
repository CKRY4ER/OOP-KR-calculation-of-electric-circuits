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
    public partial class AddBranchForm : Form
    {
        private Branche branche;
        private ElectricalСircuit collectionBr;
        public AddBranchForm(Branche br, ElectricalСircuit elcr)
        {
            collectionBr = elcr;
            branche = br;
            InitializeComponent();
        }

        private void AddBranchForm_Load(object sender, EventArgs e)
        {
        
            this.ControlBox = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ResistanceTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void VoltageKeyPressed_TextBox(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void IncumingNodeKeyPressed_TextBox(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void TypeElementKeyPressed_TextBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SostKey_TextBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void OutcummingNodeKeyPressed_TextBox(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        public void InicializeABButton()
        {
            NameDanElementLabel.Visible = true;
            NameDanElementTextBox.Visible = true;
            OtmenaDoPosleAddButton.Visible = true;


        }
        public void HideABButton()
        {
            AddElementAfter.BackColor = System.Drawing.SystemColors.ControlLight;
            AddElementBefore.BackColor = System.Drawing.SystemColors.ControlLight;
            NameDanElementLabel.Visible = false;
            NameDanElementTextBox.Visible = false;
            OtmenaDoPosleAddButton.Visible = false;
            NameDanElementTextBox.Text = "";
        }
        private void TextChangedTypeElement_TextBox(object sender, EventArgs e)
        {
            ResistanceTextBox.Text = "";
            textBox1.Text = "";
            IncumingNodeTextBox.Text = "";
            OutComingNodeTextBox.Text = "";
            comboBox1.Text = "";
            NameElementTextBox.Text = "";
            if (TypeElementComboBox.Text != "" && TypeElementComboBox.Text != "Лампа")
            {
                if (TypeElementComboBox.Text == "Резистор")
                {
                    ResisterBox.Enabled = true;
                    EDSBOX.Enabled = false;
                    KeyBox.Enabled = false;

                }
                if(TypeElementComboBox.Text== "ЭДС источник")
                {
                    foreach(Elements el in branche.elements)
                    {
                        if (el is CCS)
                        {
                            MessageBox.Show(this, "В ветке может быть только один ЭДС источник.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TypeElementComboBox.Text = "";
                            return;
                        }
                    }
                    ResisterBox.Enabled = false;
                    EDSBOX.Enabled = true;
                    KeyBox.Enabled = false;
                }
                if (TypeElementComboBox.Text == "Ключ")
                {
                    foreach(Elements el in branche.elements)
                    {
                        if(el is Key)
                        {
                            MessageBox.Show(this, "В ветке может быть только один ключ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TypeElementComboBox.Text = "";
                            return;
                        }
                    }
                    ResisterBox.Enabled = false;
                    EDSBOX.Enabled = false;
                    KeyBox.Enabled = true;
                }
            }
            else
            {
                ResisterBox.Enabled = false;
                EDSBOX.Enabled = false;
                KeyBox.Enabled = false;
            }
        }

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            if (TypeElementComboBox.Text == "")
            {
                MessageBox.Show(this, "Не выбран элемент для добавления.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (Branche br in collectionBr.branches)
            {
                foreach (Elements el in br.elements)
                {
                    if (el.Name == NameElementTextBox.Text)
                    {
                        MessageBox.Show(this, "Элемент с таким именем уже етсь в списке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NameElementTextBox.Text = "";
                        return;
                    }
                }
            }
            switch (TypeElementComboBox.Text)
            {
                case ("Резистор"):
                    if(NameElementTextBox.Text!="" && ResistanceTextBox.Text != "")
                    {
                        Resister resister = new Resister(NameElementTextBox.Text, double.Parse(ResistanceTextBox.Text));
                        if(AddElementAfter.BackColor == System.Drawing.SystemColors.ActiveBorder)
                        {
                            if (NameDanElementTextBox.Text != "")
                            {
                                foreach (Elements el in branche.elements)
                                {
                                    if (el.Name == NameDanElementTextBox.Text)
                                    {
                                        branche.elements.AddElementAfter(el, resister);
                                        NameDanElementTextBox.Text = "";
                                        
                                        HideABButton();
                                        NameElementTextBox.Text = "";
                                        TypeElementComboBox.Text = "";
                                        ResistanceTextBox.Text = "";
                                        return;
                                    }
                                }
                                MessageBox.Show(this, "Заданного элемента нет в ветке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                NameDanElementTextBox.Text = "";
                                return;
                            }
                            MessageBox.Show(this, "Не заполнено поле заданного элемента. Заполните его или отключите.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (AddElementBefore.BackColor == System.Drawing.SystemColors.ActiveBorder)
                        {
                            if (NameDanElementTextBox.Text != "")
                            {
                                foreach (Elements el in branche.elements)
                                {
                                    if (el.Name == NameDanElementTextBox.Text)
                                    {
                                        branche.elements.AddElementBefore(el, resister);
                                      
                                        NameDanElementTextBox.Text = "";
                                        HideABButton();
                                        NameElementTextBox.Text = "";
                                        TypeElementComboBox.Text = "";
                                        ResistanceTextBox.Text = "";
                                        return;
                                    }
                                }
                                MessageBox.Show(this, "Заданного элемента нет в ветке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                NameDanElementTextBox.Text = "";
                                return;
                            }
                            MessageBox.Show(this, "Не заполнено поле заданного элемента. Заполните его или отключите.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        branche.elements.AddElementLast(resister);
                     
                        NameElementTextBox.Text = "";
                        TypeElementComboBox.Text = "";
                        ResistanceTextBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(this, "Не возможно добавить элемент. Не все поля для добавления заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NameElementTextBox.Text = "";
                    }
                    break;
                case ("ЭДС источник"):
                    if (NameElementTextBox.Text != "" && textBox1.Text != "" && IncumingNodeTextBox.Text != "" && OutComingNodeTextBox.Text != "")
                    {
                        CCS ccs = new CCS(NameElementTextBox.Text, double.Parse(textBox1.Text));
                        if (IncumingNodeTextBox.Text == OutComingNodeTextBox.Text)
                        {
                            MessageBox.Show(this, "Входящий и выходящий узлы должны быть разными.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if ((IncumingNodeTextBox.Text == branche.IncumingNode.Name || IncumingNodeTextBox.Text == branche.OutcummingNode.Name) && (OutComingNodeTextBox.Text == branche.IncumingNode.Name || OutComingNodeTextBox.Text == branche.OutcummingNode.Name))
                        { }
                        else
                        {
                            MessageBox.Show(this, "ЭДС источник указывает на узылы, которых нет в ветке. Измените узлы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        switch (IncumingNodeTextBox.Text)
                        {
                            case ("1"):
                                ccs.IncumingNode = collectionBr.FNode;
                                break;
                            case ("2"):
                                ccs.IncumingNode=collectionBr.SNode;
                                break;
                            case ("3"):
                                ccs.IncumingNode=collectionBr.TNode;
                                break;
                            default:
                                MessageBox.Show(this, "Ошибка в номере входящего узла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                IncumingNodeTextBox.Text = "";
                                return;    
                        }
                        switch (OutComingNodeTextBox.Text)
                        {
                            case ("1"):
                                ccs.OutcummingNode=collectionBr.FNode;
                                break;
                            case ("2"):
                                ccs.OutcummingNode = collectionBr.SNode;
                                break;
                            case ("3"):
                                ccs.OutcummingNode = collectionBr.TNode;
                                break;
                            default:
                                MessageBox.Show(this, "Ошибка в номере выходящего узла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                OutComingNodeTextBox.Text = "";
                                return;
                        }
                        if (AddElementAfter.BackColor == System.Drawing.SystemColors.ActiveBorder)
                        {
                            if (NameDanElementTextBox.Text != "")
                            {
                                foreach (Elements el in branche.elements)
                                {
                                    if (el.Name == NameDanElementTextBox.Text)
                                    {
                                        branche.elements.AddElementAfter(el, ccs);
                                       
                                        NameDanElementTextBox.Text = "";
                                        HideABButton();
                                        NameElementTextBox.Text = "";
                                        TypeElementComboBox.Text = "";
                                        ResistanceTextBox.Text = "";
                                        return;
                                    }
                                }
                                MessageBox.Show(this, "Заданного элемента нет в ветке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                NameDanElementTextBox.Text = "";
                                return;
                            }
                            MessageBox.Show(this, "Не заполнено поле заданного элемента. Заполните его или отключите.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (AddElementBefore.BackColor == System.Drawing.SystemColors.ActiveBorder)
                        {
                            if (NameDanElementTextBox.Text != "")
                            {
                                foreach (Elements el in branche.elements)
                                {
                                    if (el.Name == NameDanElementTextBox.Text)
                                    {
                                        branche.elements.AddElementBefore(el, ccs);
                                   
                                        NameDanElementTextBox.Text = "";
                                        HideABButton();
                                        NameElementTextBox.Text = "";
                                        TypeElementComboBox.Text = "";
                                        ResistanceTextBox.Text = "";
                                        return;
                                    }
                                }
                                MessageBox.Show(this, "Заданного элемента нет в ветке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                NameDanElementTextBox.Text = "";
                                return;
                            }
                            MessageBox.Show(this, "Не заполнено поле заданного элемента. Заполните его или отключите.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        branche.elements.AddElementLast(ccs);
                
                        TypeElementComboBox.Text = "";
                        NameElementTextBox.Text = "";
                        textBox1.Text = "";
                        IncumingNodeTextBox.Text = "";
                        OutComingNodeTextBox.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show(this, "Не возможно добавить элемент. Не все поля для добавления заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NameElementTextBox.Text = "";
                    }
                    break;
                case ("Ключ"):
                    foreach(Elements el in branche.elements)
                    {
                        if (el is Key)
                        {
                            MessageBox.Show(this, "В ветке не может быть более одного ключа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NameElementTextBox.Text = "";
                            comboBox1.Text = "";
                            return;
                        }
                    }
                    if (NameElementTextBox.Text == ""||comboBox1.Text=="")
                    {
                        MessageBox.Show(this, "Не все поля для добавления элемента заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    Key key = new Key(NameElementTextBox.Text);
                    if (comboBox1.Text == "Опущен")
                    {
                        key.active = true;
                    }
                    else
                    {
                        key.active = false;
                    }
                    if (AddElementAfter.BackColor == System.Drawing.SystemColors.ActiveBorder)
                    {
                        if (NameDanElementTextBox.Text != "")
                        {
                            foreach (Elements el in branche.elements)
                            {
                                if (el.Name == NameDanElementTextBox.Text)
                                {
                                    branche.elements.AddElementAfter(el, key);
                                   
                                    NameDanElementTextBox.Text = "";
                                    HideABButton();
                                    NameElementTextBox.Text = "";
                                    TypeElementComboBox.Text = "";
                                    ResistanceTextBox.Text = "";
                                    return;
                                }
                            }
                            MessageBox.Show(this, "Заданного элемента нет в ветке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NameDanElementTextBox.Text = "";
                            return;
                        }
                        MessageBox.Show(this, "Не заполнено поле заданного элемента. Заполните его или отключите.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (AddElementBefore.BackColor == System.Drawing.SystemColors.ActiveBorder)
                    {
                        if (NameDanElementTextBox.Text != "")
                        {
                            foreach (Elements el in branche.elements)
                            {
                                if (el.Name == NameDanElementTextBox.Text)
                                {
                                    branche.elements.AddElementBefore(el, key);
                                
                                    NameDanElementTextBox.Text = "";
                                    HideABButton();
                                    NameElementTextBox.Text = "";
                                    TypeElementComboBox.Text = "";
                                    ResistanceTextBox.Text = "";
                                    return;
                                }
                            }
                            MessageBox.Show(this, "Заданного элемента нет в ветке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NameDanElementTextBox.Text = "";
                            return;
                        }
                        MessageBox.Show(this, "Не заполнено поле заданного элемента. Заполните его или отключите.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    branche.elements.AddElementLast(key);
              
                    TypeElementComboBox.Text = "";
                    comboBox1.Text = "";
                    break;
                case ("Лампа"):
                    foreach (Elements el in branche.elements)
                    {
                        if (el is Lamp)
                        {
                            MessageBox.Show(this, "В ветке не может быть более одной лампы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NameElementTextBox.Text = "";
                            comboBox1.Text = "";
                            return;
                        }
                    }
                    Lamp l = new Lamp(NameElementTextBox.Text);
                    if (AddElementAfter.BackColor == System.Drawing.SystemColors.ActiveBorder)
                    {
                        if (NameDanElementTextBox.Text != "")
                        {
                            foreach (Elements el in branche.elements)
                            {
                                if (el.Name == NameDanElementTextBox.Text)
                                {
                                    branche.elements.AddElementAfter(el, l);
                                  
                                    NameDanElementTextBox.Text = "";
                                    HideABButton();
                                    NameElementTextBox.Text = "";
                                    TypeElementComboBox.Text = "";
                                    ResistanceTextBox.Text = "";
                                    return;
                                }
                            }
                            MessageBox.Show(this, "Заданного элемента нет в ветке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NameDanElementTextBox.Text = "";
                            return;
                        }
                        MessageBox.Show(this, "Не заполнено поле заданного элемента. Заполните его или отключите.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (AddElementBefore.BackColor == System.Drawing.SystemColors.ActiveBorder)
                    {
                        if (NameDanElementTextBox.Text != "")
                        {
                            foreach (Elements el in branche.elements)
                            {
                                if (el.Name == NameDanElementTextBox.Text)
                                {
                                    branche.elements.AddElementBefore(el, l);
                                   
                                    NameDanElementTextBox.Text = "";
                                    HideABButton();
                                    NameElementTextBox.Text = "";
                                    TypeElementComboBox.Text = "";
                                    ResistanceTextBox.Text = "";
                                    return;
                                }
                            }
                            MessageBox.Show(this, "Заданного элемента нет в ветке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NameDanElementTextBox.Text = "";
                            return;
                        }
                        MessageBox.Show(this, "Не заполнено поле заданного элемента. Заполните его или отключите.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    branche.elements.AddElementLast(l);
                   
                    TypeElementComboBox.Text = "";
                    comboBox1.Text = "";
                    break;

                default:
                    break;
            }
            HideABButton();
        }

        private void EndAddElement_Click(object sender, EventArgs e)
        {
            if (branche.elements.Count() == 0)
            {
                MessageBox.Show(this, "Ветка пуста, не возможно добавить. Добавте элементы в ветку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (Elements el in branche.elements)
            {
                if (el is Resister)
                {
                    this.Close();
                    return;
                }

            }
            MessageBox.Show(this, "В цепи нет нагрузки. Добавте минимум один резистор.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        private void AddElementAfter_Click(object sender, EventArgs e)
        {
            AddElementAfter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            AddElementBefore.BackColor = System.Drawing.SystemColors.ControlLight;
            InicializeABButton();
        }

        private void AddElementBefore_Click(object sender, EventArgs e)
        {
            AddElementAfter.BackColor = System.Drawing.SystemColors.ControlLight;
            AddElementBefore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            InicializeABButton();
        }

        private void OtmenaDoPosleAddButton_Click(object sender, EventArgs e)
        {
            HideABButton();
        }

        private void TypeElementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
