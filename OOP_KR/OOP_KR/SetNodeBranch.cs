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
    public partial class SetNodeBranch : Form
    {
        private Branche br;
        private ElectricalСircuit elcir;
        public delegate void RedactBranche(Branche br, ElectricalСircuit elcir);
        public event RedactBranche RedactBrancheEvent;
        public SetNodeBranch(Branche brnc, ElectricalСircuit elcr)
        {
            elcir = elcr;
            br = brnc;
            InitializeComponent();
        }

        private void SetNodeBranch_Load(object sender, EventArgs e)
        { 
            RedactBrancheEvent+= ShowRedactBranchForm;
            this.ControlBox = false;
        }
        private void ShowRedactBranchForm(Branche sender)
        {
            AddBranchForm form = new AddBranchForm(sender, elcir);
            form.Show();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            string s = textBox1.Text;
            if (s.Length == 1)
            {
                if (a == 8)
                {

                }
                else
                    e.Handled = true;
            }
            else
            {
                if ((a<49||a>51)&& a != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            string s = textBox2.Text;
            if (s.Length == 1)
            {
                if (a == 8)
                {

                }
                else
                    e.Handled = true;
            }
            else
            { 
                if ((a < 49 || a > 51) && a != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show(this, "Узлы должны быть разными.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(this, "Не все поля заполнены.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (textBox1.Text)
            {
                case ("1"):
                    br.IncumingNode = elcir.FNode;
                    break;
                case ("2"):
                    br.IncumingNode = elcir.SNode;
                    break;
                case ("3"):
                    br.IncumingNode = elcir.TNode;
                    break;
            }
            switch (textBox2.Text)
            {
                case ("1"):
                    br.OutcummingNode = elcir.FNode;
                    break;
                case ("2"):
                    br.OutcummingNode = elcir.SNode;
                    break;
                case ("3"):
                    br.OutcummingNode = elcir.TNode;
                    break;
            }
            MessageBox.Show(this, "Ветвь подключена.", "Сообщение.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RedactBrancheEvent(br, elcir);
            this.Close();
        }
        public void ShowRedactBranchForm(Branche br, ElectricalСircuit elcir)
        {
            AddBranchForm form = new AddBranchForm(br, elcir);
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
