using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOP_KR
{
    public partial class Form1 : Form
    {
        static public ElectricalСircuit electricalСircuit = new ElectricalСircuit();// { FNode = new Node("1"), SNode = new Node("2"), TNode = new Node("3") };
        private DeserealizableForm form = new DeserealizableForm(electricalСircuit);

        public Form1()
        {
          //  electricalСircuit = new ElectricalСircuit() { FNode = new Node("1"), SNode = new Node("2"), TNode = new Node("3") };
            //electricalСircuit.TNode.Potencial = 0;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        { 

        }
        private void ShowSetNodeForm(Branche branche)
        {
            SetNodeBranch form = new SetNodeBranch(branche, electricalСircuit);
            form.Show();
        }
        private void ButtonCreateBranche_Click(object sender, EventArgs e)
        {
            if (OnOffButton.BackColor == System.Drawing.SystemColors.ActiveBorder)
            {
                MessageBox.Show(this, "Не возможно редактировать цепь, пока она включена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Branche br = new Branche();
            electricalСircuit.branches.AddBranche(br);
            SetNodeBranch form = new SetNodeBranch(br, electricalСircuit);
            form.Show();
        }

        private void CerializationButton_Click(object sender, EventArgs e)
        {
            if(electricalСircuit.branches.Count()==0)
            {
                MessageBox.Show(this, "Цепь не создана. Нечего сохранять.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SerializableForm form = new SerializableForm(electricalСircuit);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeserealizableForm form = new DeserealizableForm(electricalСircuit);
            form.Show();
        }

        private void AddElement_Click(object sender, EventArgs e)
        {
            if (OnOffButton.BackColor == System.Drawing.SystemColors.ActiveBorder)
            {
                MessageBox.Show(this, "Не возможно редактировать цепь, пока она включена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (electricalСircuit.branches.Count() == 0)
            {
                MessageBox.Show(this, "Не созданно ни одной ветки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddElementsForm form = new AddElementsForm(electricalСircuit);
            form.Show();
        }
        private void CoutInfo()
        {
            if (electricalСircuit.branches.Count() == 0)
            {
                InfoTextBox.Text = "";
                return;
            }
            InfoTextBox.Text = $"Общее количество веток в цепи: {electricalСircuit.branches.Count()};";
            if (OnOffButton.BackColor == System.Drawing.SystemColors.ActiveBorder)
            {
                InfoTextBox.Text += $"\r\nПотенциал 1 узла: {electricalСircuit.FNode.Potencial};\r\nПотенциал 2 узла: {electricalСircuit.SNode.Potencial};";
                InfoTextBox.Text += $"\r\nОбщая проводимоcть 1 узла: {electricalСircuit.FNode.ConductivityNode};\r\nОбщая проводимость 2 узла: {electricalСircuit.SNode.ConductivityNode};\r\n";
            }
            InfoTextBox.Text += $"\r\nИнформация по каждой ветке:\r\n";
            foreach (Branche br in electricalСircuit.branches)
            {
                InfoTextBox.Text += $"\r\tВетка подключена к {br.IncumingNode.Name} и {br.OutcummingNode.Name} узлам;\r\n";
                if (OnOffButton.BackColor == System.Drawing.SystemColors.ActiveBorder)
                {
                    InfoTextBox.Text += $"\r\tОбщая проводимость ветки: {br.ConductivityBranch};\r\n";
                }
            

                if (OnOffButton.BackColor== System.Drawing.SystemColors.ActiveBorder)
                {
                   // InfoTextBox.Text += $"\r\n\n{br.OutcummingNode.Potencial}-{br.IncumingNode.Potencial}={br.OutcummingNode.Potencial - br.IncumingNode.Potencial}\r\n\n";
                    InfoTextBox.Text += $"\r\tСила тока в цепи: {Math.Abs(br.CurrentBranch)};\r\n";
                    if (br.CurrentBranch < 0)
                    {
                        InfoTextBox.Text += $"\r\tТок течет от узла {br.IncumingNode.Name} к узлу {br.OutcummingNode.Name};\r\n";
                    }
                    else
                    {
                        InfoTextBox.Text += $"\r\tТок течет от узла {br.OutcummingNode.Name} к узлу {br.IncumingNode.Name};\r\n";
                    }

                }
                InfoTextBox.Text += $"\r\tИнформация по каждому элементу в ветке:\r\n";
                foreach (Elements el in br.elements)
                {
                    if (el is Resister)
                    {
                        Resister res = (Resister)el;
                        InfoTextBox.Text += $"\r\n\t\tНазвание резистора: {el.Name};\r\n\t\tСопротивление резистора: {res.Resistance} Ом;\r\n\n";
                    }
                    if (el is CCS)
                    {
                        CCS ccs = (CCS)el;
                        InfoTextBox.Text += $"\r\n\t\tИмя ЭДС источника: {ccs.Name};\r\n\t\tНапряжение ЭДС источника: {ccs.Voltage} В;\r\n\t\tВходной узел: {ccs.IncumingNode.Name};" +
                            $"\r\n\t\tВыходной узел: {ccs.OutcummingNode.Name};\r\n\n";
                    }
                    if (el is Key)
                    {
                        Key k = (Key)el;
                        InfoTextBox.Text += $"\r\n\t\tИмя ключа: {k.Name};\r\n\t\tСостояние ключа: ";
                        if (k.active)
                        {
                            InfoTextBox.Text += $"Опущен;\r\n\n";
                        }
                        else
                        {
                            InfoTextBox.Text += $"Поднят;\r\n\n";
                        }
                    }
                    if (el is Lamp)
                    {
                        Lamp l = (Lamp)el;
                        InfoTextBox.Text += $"\r\n\t\tИмя лампы: {l.Name};\r\t\tСостояние лампы: ";
                        if (l.isOn)
                        {
                            InfoTextBox.Text = "Включенна\r\n\n";
                        }
                        else
                        {
                            InfoTextBox.Text = "Отключенна\r\n\n";
                        }

                    }
                }
            }
        }
        private void CoutInfoButton_Click(object sender, EventArgs e)
        {
            CoutInfo();
        }

        private void RedactElementButton_Click(object sender, EventArgs e)
        {
            if (OnOffButton.BackColor == System.Drawing.SystemColors.ActiveBorder)
            {
                MessageBox.Show(this, "Не возможно редактировать цепь, пока она включена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (electricalСircuit.branches.Count() == 0)
            {
                MessageBox.Show(this, "В цепи нет элементов для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RedactElementForm form = new RedactElementForm();
            form.Show();
        }

        private void DeleteElement_Click(object sender, EventArgs e)
        {
            if (OnOffButton.BackColor == System.Drawing.SystemColors.ActiveBorder)
            {
                MessageBox.Show(this, "Не возможно редактировать цепь, пока она включена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (electricalСircuit.branches.Count() == 0)
            {
                MessageBox.Show(this, "Цепь пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DeleteBranchElementForm form = new DeleteBranchElementForm("Удаление элемента", "Удалить элемент");
            form.Show();
        }

        private void DeleteBranchButton_Click(object sender, EventArgs e)
        {
            if (OnOffButton.BackColor == System.Drawing.SystemColors.ActiveBorder)
            {
                MessageBox.Show(this, "Не возможно редактировать цепь, пока она включена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (electricalСircuit.branches.Count() == 0)
            {
                MessageBox.Show(this, "Цепь пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DeleteBranchElementForm form = new DeleteBranchElementForm("Удаление ветки", "Удалить ветку");
            form.Show();
        }

        private void DeleteElectricalCircuitButton_Click(object sender, EventArgs e)
        {
            if (OnOffButton.BackColor == System.Drawing.SystemColors.ActiveBorder)
            {
                MessageBox.Show(this, "Не возможно редактировать цепь, пока она включена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (electricalСircuit.branches.Count() == 0)
            {
                MessageBox.Show(this, "Цепь и так пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            electricalСircuit.DeleteCircuit();
            InfoTextBox.Text = "";
        }
        private int CountCSS()
        {
            int i = 0;
            foreach (Branche br in electricalСircuit.branches)
            {
                foreach(Elements el in br.elements)
                {
                    if (el is CCS)
                        i++;
                }
            }
            return i;
        }
        private bool KeyOmitted(Branche br)
        {
            foreach (Elements el in br.elements)
            {
                if (el is Key)
                {
                    Key k = (Key)el;
                    return k.active;

                }
            }
            return true;
        }
        private double CountOpr(double[,] matrix)
        {
            double opr = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            double a = opr;
            opr = 0;
            return a;
        }
        public void coutMatrix(double[,] m)
        {
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    InfoTextBox.Text += m[i, j] + " ";
                }
                InfoTextBox.Text += "\r\n";
            }
            InfoTextBox.Text += "\r\n";
        }

        private void OnOffButton_Click(object sender, EventArgs e)
        {
            if (OnOffButton.BackColor == System.Drawing.SystemColors.ActiveBorder)
            {
                electricalСircuit.FNode.Potencial = 0;
                electricalСircuit.FNode.SumeEg = 0;
                electricalСircuit.FNode.ConductivityNode = 0;
                electricalСircuit.SNode.Potencial = 0;
                electricalСircuit.SNode.ConductivityNode = 0;
                electricalСircuit.SNode.SumeEg = 0;
                foreach (Branche br in electricalСircuit.branches)
                {
                    br.ConductivityBranch = 0;
                    br.CurrentBranch = 0;
                    foreach(Elements el in br.elements)
                    {
                        if (el is Lamp)
                        {
                            Lamp l = (Lamp)el;
                            if (l.isOn)
                                l.isOn = false;
                        }
                    }
                }
                InfoTextBox.Text = "";
                OnOffButton.BackColor = System.Drawing.SystemColors.ControlLight;
                return;
            }
            if (electricalСircuit.branches.Count() == 0)
            {
                MessageBox.Show(this, "Цепь не созданна..", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CountCSS() == 0)
            {
                MessageBox.Show(this, "В цепи нет ни одного ЭДС источника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int b12 = 0;
            int b23 = 0;
            int b31 = 0;
            foreach (Branche br in electricalСircuit.branches)
            {
                if (!KeyOmitted(br))
                {
                    continue;
                }
                if ((br.IncumingNode.Name == "1" || br.IncumingNode.Name == "2") && (br.OutcummingNode.Name == "1" || br.OutcummingNode.Name == "2"))
                {
                    b12++;
                    continue;
                }
                if ((br.OutcummingNode.Name == "2" || br.OutcummingNode.Name == "3") && (br.IncumingNode.Name == "2" || br.IncumingNode.Name == "3"))
                {
                    b23++;
                    continue;
                }
                if ((br.IncumingNode.Name == "3" || br.IncumingNode.Name == "1") && (br.OutcummingNode.Name == "3" || br.OutcummingNode.Name == "1"))
                {
                    b31++;
                    continue;
                }
            }
            if (b12 == 0 || b23 == 0 || b31 == 0)
            {
                MessageBox.Show(this, "Цепь не замкнута. Возможно где то разомкнут ключ, или не достаточно веток.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OnOffButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            foreach (Branche br in electricalСircuit.branches)
            {
                br.CalculateСonductivity(br);
            }
            electricalСircuit.FNode.CalculateConductivityNode(electricalСircuit);
            electricalСircuit.FNode.CalculateEg(electricalСircuit);
            electricalСircuit.SNode.CalculateConductivityNode(electricalСircuit);
            electricalСircuit.SNode.CalculateEg(electricalСircuit);
            //foreach (Branche br in electricalСircuit.branches)
            //{
            //    br.IncumingNode.CalculateConductivityNode(electricalСircuit);
            //    br.OutcummingNode.CalculateConductivityNode(electricalСircuit);
            //    br.IncumingNode.CalculateEg(electricalСircuit);
            //    br.OutcummingNode.CalculateEg(electricalСircuit);
            //}
            double[,] matrix = new double[2, 2];
            coutMatrix(matrix);
            double lambda = 0;
            double x1 = 0;
            double x2 = 0;
            matrix[0, 0] = electricalСircuit.FNode.ConductivityNode;
            matrix[1, 1] = electricalСircuit.SNode.ConductivityNode;
            foreach (Branche br in electricalСircuit.branches)
            {
                if ((br.IncumingNode.Name == "1" || br.IncumingNode.Name == "2") && (br.OutcummingNode.Name == "1" || br.OutcummingNode.Name == "2"))
                {
                    matrix[0, 1] -= br.ConductivityBranch;
                    matrix[1, 0] -= br.ConductivityBranch;
                }
            }
            coutMatrix(matrix);
            lambda = CountOpr(matrix);
            InfoTextBox.Text += "lambda " + lambda+"\r\n\n";
            matrix[0, 0] = electricalСircuit.FNode.SumeEg;
            matrix[1, 0] = electricalСircuit.SNode.SumeEg;
            coutMatrix(matrix);
            x1 = CountOpr(matrix);
            InfoTextBox.Text += "\r\nx1 " + x1+"\r\n\n";
            matrix[0, 0] = electricalСircuit.FNode.ConductivityNode;
            matrix[1, 0] = 0;
            foreach (Branche br in electricalСircuit.branches)
            {
                if ((br.IncumingNode.Name == "1" || br.IncumingNode.Name == "2") && (br.OutcummingNode.Name == "1" || br.OutcummingNode.Name == "2"))
                {
                    matrix[1, 0] -= br.ConductivityBranch;
                }
            }
            matrix[0, 1] = electricalСircuit.FNode.SumeEg;
            matrix[1, 1] = electricalСircuit.SNode.SumeEg;
            coutMatrix(matrix);
            x2 = CountOpr(matrix);
            InfoTextBox.Text += "\r\nx2 " + x2 + "\r\n\n";
            electricalСircuit.FNode.Potencial = x1 / lambda;
            electricalСircuit.SNode.Potencial = x2 / lambda;
            foreach (Branche br in electricalСircuit.branches)
            {
                br.CalculatecurrentBranch();
            }
            foreach (Branche br in electricalСircuit.branches)
            {
                InfoTextBox.Text += $"\r\n\n{br.IncumingNode.Potencial}    {br.IncumingNode.SumeEg}   {br.OutcummingNode.Potencial}   {br.OutcummingNode.SumeEg}\r\n\n";
            }
            matrix = new double[2, 2];
            lambda = 0;
            x1 = 0;
            x2 = 0;
            CoutInfo();
        }
    }
}
