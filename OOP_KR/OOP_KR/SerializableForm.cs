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
    public partial class SerializableForm : Form
    {
        ElectricalСircuit electricalСircuit;
        public SerializableForm(ElectricalСircuit el)
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
                MessageBox.Show(this, "Фаил с таким именем уже сужествует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NameFileTextBox.Text = "";
                return;
            }
            ElectricalСircuit.SaveDocuments(electricalСircuit, NameFileTextBox.Text);
            MessageBox.Show(this, "Фаил сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void SerializableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
