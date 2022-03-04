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

namespace OOP_KR
{
    public partial class DeserealizableForm : Form
    {
        ElectricalСircuit electricalСircuit;
        public DeserealizableForm(ElectricalСircuit el)
        {
            electricalСircuit = el;
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameFileTextBox.Text == "")
                return;
            if (File.Exists(NameFileTextBox.Text))
            {
                Form1.electricalСircuit = ElectricalСircuit.RestoreDocuments(NameFileTextBox.Text);
                MessageBox.Show(this, "Файл загружен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach(Branche br in Form1.electricalСircuit.branches)
                {
                    switch (br.IncumingNode.Name)
                    {
                        case ("1"):
                            br.IncumingNode = Form1.electricalСircuit.FNode;
                            break;
                        case ("2"):
                            br.IncumingNode = Form1.electricalСircuit.SNode;
                            break;
                        case ("3"):
                            br.IncumingNode = Form1.electricalСircuit.TNode;
                            break;
                    }
                    switch (br.OutcummingNode.Name)
                    {
                        case ("1"):
                            br.OutcummingNode = Form1.electricalСircuit.FNode;
                            break;
                        case ("2"):
                            br.OutcummingNode = Form1.electricalСircuit.SNode;
                            break;
                        case ("3"):
                            br.OutcummingNode = Form1.electricalСircuit.TNode;
                            break;
                    }
                    foreach(Elements el in br.elements)
                    {
                        if (el is CCS)
                        {
                            CCS c = (CCS)el;
                            switch (c.IncumingNode.Name)
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
                            }
                            switch (c.OutcummingNode.Name)
                            {
                                case ("1"):
                                    c.OutcummingNode = Form1.electricalСircuit.FNode;
                                    break;
                                case ("2"):
                                    c.OutcummingNode = Form1.electricalСircuit.SNode;
                                    break;
                                case ("3"):
                                    c.OutcummingNode = Form1.electricalСircuit.TNode;
                                    break;
                            }
                        }
                    }
                }
                this.Close();
                return;
            }
            MessageBox.Show(this, "Файла с таким именем не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;

        }

        private void DeserealizableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
