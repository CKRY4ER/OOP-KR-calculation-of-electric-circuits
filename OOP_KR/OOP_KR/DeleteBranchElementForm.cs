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
    public partial class DeleteBranchElementForm : Form
    {
        public DeleteBranchElementForm(string name, string textButton)
        {
            InitializeComponent();
            this.DeleteButton.Text = textButton;
            this.Text = name;
            if (textButton == "Удалить элемент")
                linkLabel1.Visible = false;
            else
                linkLabel1.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (NameElementTextBox.Text == "")
                return;
            
                //MessageBox.Show(this, "В цепи нет элемента с данным именем.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            
            if(DeleteButton.Text== "Удалить элемент")
            {
                foreach (Branche br in Form1.electricalСircuit.branches)
                {
                    foreach(Elements el in br.elements)
                    {
                        if (el.Name == NameElementTextBox.Text)
                        {
                            if (el is Resister && br.elements.CountResistor() == 1)
                            {
                                NameElementTextBox.Text = "";
                                MessageBox.Show(this, "Данный резистор невозможно удалить из цепи, тк. ветка, в которой он находится, останется без нагрузки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (br.elements.Count() == 1)
                            {
                                NameElementTextBox.Text = "";
                                MessageBox.Show(this, "Не возможно удалить последний элемент в ветке. Если нужно удалить ведку то воспользуйтесь кнопкой \"Удалить ветку\".", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            NameElementTextBox.Text = "";
                            br.elements.DeleteElement(el);
                            return;
                        }
                    }
                }
                MessageBox.Show(this, "В цепи нет элемента с данным именем.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DeleteButton.Text== "Удалить ветку")
            {
                foreach(Branche br in Form1.electricalСircuit.branches)
                {
                    foreach(Elements el in br.elements)
                    {
                        if (el.Name == NameElementTextBox.Text)
                        {
                            Form1.electricalСircuit.branches.DeleteBranche(br);
                            NameElementTextBox.Text = "";
                            return;
                        }
                    }
                }
                MessageBox.Show(this, "В цепи нет элемента с данным именем.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(this, "В данное поле необходимо ввести имя любого элемента, находящегося в ветке, которую вы хотите удалить.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}
