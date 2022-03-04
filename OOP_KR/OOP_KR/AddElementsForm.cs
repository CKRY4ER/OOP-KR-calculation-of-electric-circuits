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
    public partial class AddElementsForm : Form
    {
        private ElectricalСircuit electricalСircuit;
        Branche br;
        public AddElementsForm(ElectricalСircuit el)
        {
            electricalСircuit = el;
            InitializeComponent();
        }
        public void SetInfoBranch(Branche br)
        {
            BranchInfoTextBox.Text = $"Ветка подключена к {br.IncumingNode.Name} и {br.OutcummingNode.Name} узлам;\r\nОбщее кол-во элементов в ветке: {br.elements.Count()}\r\n";
            int i = 0;
            foreach(Elements e in br.elements)
            {
                if (e is Resister)
                    i++;
            }
            BranchInfoTextBox.Text += $"Кол-во резисторов в ветке: {i};\r\n";
            if (i != 0)
            {
                BranchInfoTextBox.Text += $"Информация по каждому резистору:";
                foreach(Elements e in br.elements)
                {
                    if(e is Resister)
                    {
                        Resister res = (Resister)e;
                        BranchInfoTextBox.Text += $"\r\n\tИмя резистора: {res.Name};\r\n\tСопротивление резистора: {res.Resistance};\r\n";
                    }
                }
            }
            i = 0;
            foreach(Elements e in br.elements)
            {
                if (e is CCS)
                    i++;
            }
            BranchInfoTextBox.Text += $"\r\nКол-во ЭДС источников: {i};\r\n";
            if (i != 0)
            {
                BranchInfoTextBox.Text += $"Информация по каждому ЭДС источнику:\r\n";
                foreach(Elements el in br.elements)
                {
                    if (el is CCS)
                    {
                        CCS ccs = (CCS)el;
                        BranchInfoTextBox.Text += $"\r\tИмя ЭДС источника: {ccs.Name};\r\n\tНапряжение источника: {ccs.Voltage};\r\n\t" +
                            $"Входной узел: {ccs.IncumingNode.Name};\r\n\tВыходной узел: {ccs.OutcummingNode.Name};\r\n";
                    }
                }
            }
            i = 0;
            foreach(Elements el in br.elements)
            {
                if (el is Key)
                    i++;
            }
            if (i == 0)
            {
                BranchInfoTextBox.Text += "Наличие кллюча в ветке: Нет;\r\n";
            }
            else
            {
                BranchInfoTextBox.Text += "Наличие кллюча в ветке: Да;\r\n";
            }
            i = 0;
            foreach (Elements el in br.elements)
            {
                if (el is Lamp)
                    i++;
            }
            if (i !=0)
            {
                BranchInfoTextBox.Text += "Наличие лымпы в ветке: Да;\r\n";
            }
            else
            {
                BranchInfoTextBox.Text += "Наличие лымпы в ветке: Нет;\r\n";
            }
        }
        private void AddElementsForm_Load(object sender, EventArgs e)
        {

        }
        public void InicializeComp()
        {
            TypeElementLabel.Enabled = true;
            TypeElementComboBox.Enabled = true;
            NameElementAddLabel.Enabled = true;
            NameNewElementTextBox.Enabled = true;
            AddElementButton.Enabled = true;
            EndAddElement.Enabled = true;
            AddElementAfter.Enabled = true;
            AddElementBefore.Enabled = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NameElementTextBox.Text == "")
                return;
            foreach(Branche br in electricalСircuit.branches)
            {
                foreach(Elements el in br.elements)
                {
                    if(el.Name == NameElementTextBox.Text)
                    {
                        SetInfoBranch(br);
                        this.br = br;
                        InicializeComp();
                        NameElementTextBox.Enabled = false;
                        button1.Enabled = false;
                        return;
                    }
                }
            }
            MessageBox.Show(this, "Не найдена ни одна ветка, хранящая элемент с введенным именем.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            NameElementTextBox.Text = "";
        }

        private void CCSGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SostKeyComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TypeElementComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            if (TypeElementComboBox.Text == "")
            {
                MessageBox.Show(this, "Не выбран элемент для добавления.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (Branche br in electricalСircuit.branches)
            {
                foreach (Elements el in br.elements)
                {
                    if (el.Name == NameNewElementTextBox.Text)
                    {
                        MessageBox.Show(this, "Элемент с таким именем уже етсь в списке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NameNewElementTextBox.Text = "";
                        return;
                    }
                }
            }
            switch (TypeElementComboBox.Text)
            {
                case ("Резистор"):
                    if (NameNewElementTextBox.Text != "" && ResisterTextBox.Text != "")
                    {
                        Resister resister = new Resister(NameNewElementTextBox.Text, double.Parse(ResisterTextBox.Text));
                        if (AddElementAfter.BackColor == System.Drawing.SystemColors.ActiveBorder)
                        {
                            if (NameDanElementTextBox.Text != "")
                            {
                                foreach (Elements el in br.elements)
                                {
                                    if (el.Name == NameDanElementTextBox.Text)
                                    {
                                        br.elements.AddElementAfter(el, resister);
                                       
                                        SetInfoBranch(br);
                                        NameDanElementTextBox.Text = "";
                                        HideABButton();
                                        NameNewElementTextBox.Text = "";
                                        TypeElementComboBox.Text = "";
                                        ResisterTextBox.Text = "";
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
                                foreach (Elements el in br.elements)
                                {
                                    if (el.Name == NameDanElementTextBox.Text)
                                    {
                                        br.elements.AddElementBefore(el, resister);
                                      
                                        SetInfoBranch(br);
                                        NameDanElementTextBox.Text = "";
                                        HideABButton();
                                        NameNewElementTextBox.Text = "";
                                        TypeElementComboBox.Text = "";
                                        ResisterTextBox.Text = "";
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
                        br.elements.AddElementLast(resister);
                      
                        SetInfoBranch(br);
                        NameNewElementTextBox.Text = "";
                        TypeElementComboBox.Text = "";
                        ResisterTextBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(this, "Не возможно добавить элемент. Не все поля для добавления заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NameNewElementTextBox.Text = "";
                    }
                    break;
                case ("ЭДС источник"):
                    if (NameNewElementTextBox.Text != "" && OutCumingNodeTextBox.Text != "" && IncumingNodeTextBox.Text != "" && OutCumingNodeTextBox.Text != "")
                    {
                        CCS ccs = new CCS(NameNewElementTextBox.Text, double.Parse(OutCumingNodeTextBox.Text));
                        if (IncumingNodeTextBox.Text == OutCumingNodeTextBox.Text)
                        {
                            MessageBox.Show(this, "Входящий и выходящий узлы должны быть разными.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if ((IncumingNodeTextBox.Text == br.IncumingNode.Name || IncumingNodeTextBox.Text == br.OutcummingNode.Name) && (OutCumingNodeTextBox.Text == br.IncumingNode.Name || OutCumingNodeTextBox.Text == br.OutcummingNode.Name))
                        { }
                        else
                        {
                            MessageBox.Show(this, "ЭДС источник указывает на узылы, которых нет в ветке. Измените узлы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (IncumingNodeTextBox.Text == br.IncumingNode.Name)
                            switch (IncumingNodeTextBox.Text)
                            {
                                case ("1"):
                                    ccs.IncumingNode = electricalСircuit.FNode;
                                    break;
                                case ("2"):
                                    ccs.IncumingNode = electricalСircuit.SNode;
                                    break;
                                case ("3"):
                                    ccs.IncumingNode = electricalСircuit.TNode;
                                    break;
                                default:
                                    MessageBox.Show(this, "Ошибка в номере входящего узла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    IncumingNodeTextBox.Text = "";
                                    return;
                            }
                        switch (OutCumingNodeTextBox.Text)
                        {
                            case ("1"):
                                ccs.OutcummingNode = electricalСircuit.FNode;
                                break;
                            case ("2"):
                                ccs.OutcummingNode = electricalСircuit.SNode;
                                break;
                            case ("3"):
                                ccs.OutcummingNode = electricalСircuit.TNode;
                                break;
                            default:
                                MessageBox.Show(this, "Ошибка в номере выходящего узла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                OutCumingNodeTextBox.Text = "";
                                return;
                        }
                        if (AddElementAfter.BackColor == System.Drawing.SystemColors.ActiveBorder)
                        {
                            if (NameDanElementTextBox.Text != "")
                            {
                                foreach (Elements el in br.elements)
                                {
                                    if (el.Name == NameDanElementTextBox.Text)
                                    {
                                        br.elements.AddElementAfter(el, ccs);
                                     
                                        SetInfoBranch(br);
                                        NameDanElementTextBox.Text = "";
                                        HideABButton();
                                        NameNewElementTextBox.Text = "";
                                        TypeElementComboBox.Text = "";
                                        ResisterTextBox.Text = "";
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
                                foreach (Elements el in br.elements)
                                {
                                    if (el.Name == NameDanElementTextBox.Text)
                                    {
                                        br.elements.AddElementBefore(el, ccs);
                                       
                                        SetInfoBranch(br);
                                        NameDanElementTextBox.Text = "";
                                        HideABButton();
                                        NameNewElementTextBox.Text = "";
                                        TypeElementComboBox.Text = "";
                                        ResisterTextBox.Text = "";
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
                        br.elements.AddElementLast(ccs);
                       
                        SetInfoBranch(br);
                        TypeElementComboBox.Text = "";
                        NameNewElementTextBox.Text = "";
                        OutCumingNodeTextBox.Text = "";
                        IncumingNodeTextBox.Text = "";
                        OutCumingNodeTextBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(this, "Не возможно добавить элемент. Не все поля для добавления заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NameNewElementTextBox.Text = "";
                    }
                    break;
                case ("Ключ"):
                    foreach (Elements el in br.elements)
                    {
                        if (el is Key)
                        {
                            MessageBox.Show(this, "В ветке не может быть более одного ключа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NameNewElementTextBox.Text = "";
                            comboBox1.Text = "";
                            return;
                        }
                    }
                    if (NameNewElementTextBox.Text == "" || comboBox1.Text == "")
                    {
                        MessageBox.Show(this, "Не все поля для добавления элемента заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    Key key = new Key(NameNewElementTextBox.Text);
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
                            foreach (Elements el in br.elements)
                            {
                                if (el.Name == NameDanElementTextBox.Text)
                                {
                                    br.elements.AddElementAfter(el, key);
                                   
                                    SetInfoBranch(br);
                                    NameDanElementTextBox.Text = "";
                                    HideABButton();
                                    NameNewElementTextBox.Text = "";
                                    TypeElementComboBox.Text = "";
                                    ResisterTextBox.Text = "";
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
                            foreach (Elements el in br.elements)
                            {
                                if (el.Name == NameDanElementTextBox.Text)
                                {
                                    br.elements.AddElementBefore(el, key);
                                   
                                    SetInfoBranch(br);
                                    NameDanElementTextBox.Text = "";
                                    HideABButton();
                                    NameNewElementTextBox.Text = "";
                                    TypeElementComboBox.Text = "";
                                    ResisterTextBox.Text = "";
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
                    br.elements.AddElementLast(key);
                   
                    SetInfoBranch(br);
                    TypeElementComboBox.Text = "";
                    comboBox1.Text = "";
                    break;
                case ("Лампа"):
                    foreach (Elements el in br.elements)
                    {
                        if (el is Lamp)
                        {
                            MessageBox.Show(this, "В ветке не может быть более одной лампы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NameNewElementTextBox.Text = "";
                            comboBox1.Text = "";
                            return;
                        }
                    }
                    Lamp l = new Lamp(NameElementTextBox.Text);
                    if (AddElementAfter.BackColor == System.Drawing.SystemColors.ActiveBorder)
                    {
                        if (NameDanElementTextBox.Text != "")
                        {
                            foreach (Elements el in br.elements)
                            {
                                if (el.Name == NameDanElementTextBox.Text)
                                {
                                    br.elements.AddElementAfter(el, l);
                                  
                                    SetInfoBranch(br);
                                    NameDanElementTextBox.Text = "";
                                    HideABButton();
                                    NameNewElementTextBox.Text = "";
                                    TypeElementComboBox.Text = "";
                                    ResisterTextBox.Text = "";
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
                            foreach (Elements el in br.elements)
                            {
                                if (el.Name == NameDanElementTextBox.Text)
                                {
                                    br.elements.AddElementBefore(el, l);
                                   
                                    SetInfoBranch(br);
                                    NameDanElementTextBox.Text = "";
                                    HideABButton();
                                    NameNewElementTextBox.Text = "";
                                    TypeElementComboBox.Text = "";
                                    ResisterTextBox.Text = "";
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
                    br.elements.AddElementLast(l);
                  
                    SetInfoBranch(br);
                    TypeElementComboBox.Text = "";
                    NameNewElementTextBox.Text = "";
                    comboBox1.Text = "";
                    break;
                default:
                    break;
            }
            HideABButton();
        }

        private void TypeElementComboBox_TextChanged(object sender, EventArgs e)
        {
            ResisterTextBox.Text = "";
            VoltageTextBox.Text = "";
            IncumingNodeTextBox.Text = "";
            OutCumingNodeTextBox.Text = "";
            comboBox1.Text = "";
            NameElementTextBox.Text = "";
            if (TypeElementComboBox.Text != ""&& TypeElementComboBox.Text !="Лампа")
            {
                if (TypeElementComboBox.Text == "Резистор")
                {
                    ResisterGroupBox.Enabled = true;
                    CCSGroupBox.Enabled = false;
                    KeyBox.Enabled = false;

                }
                if (TypeElementComboBox.Text == "ЭДС источник")
                {
                    foreach (Elements el in br.elements)
                    {
                        if (el is CCS)
                        {
                            MessageBox.Show(this, "В ветке может быть только один ЭДС источник.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TypeElementComboBox.Text = "";
                            return;
                        }
                    }
                    ResisterGroupBox.Enabled = false;
                    CCSGroupBox.Enabled = true;
                    KeyBox.Enabled = false;
                }
                if (TypeElementComboBox.Text == "Ключ")
                {
                    foreach (Elements el in br.elements)
                    {
                        if (el is Key)
                        {
                            MessageBox.Show(this, "В ветке может быть только один ключ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TypeElementComboBox.Text = "";
                            return;
                        }
                    }
                    ResisterGroupBox.Enabled = false;
                    CCSGroupBox.Enabled = false;
                    KeyBox.Enabled = true;
                }
                
            }
            else
            {
                ResisterGroupBox.Enabled = false;
                CCSGroupBox.Enabled = false;
                KeyBox.Enabled = false;
            }
        }

        private void OtmenaDoPosleAddButton_Click(object sender, EventArgs e)
        {
            HideABButton();
        }

        private void EndAddElement_Click(object sender, EventArgs e)
        {
            TypeElementLabel.Enabled = false;
            TypeElementComboBox.Enabled = false;
            NameElementAddLabel.Enabled = false;
            NameNewElementTextBox.Enabled = false;
            HideABButton();
            BranchInfoTextBox.Text = "";
            NameElementTextBox.Text = "";
            NameElementTextBox.Enabled = true;
            button1.Enabled = true;
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
    }
}
