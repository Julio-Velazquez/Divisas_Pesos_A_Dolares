using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divisas_Pesos_A_Dolares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TextBoxDolares.Enabled = false;
        }

        private void TextBoxPesos_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxDolares_TextChanged(object sender, EventArgs e)
        {

        }

        private void Conversor_Click(object sender, EventArgs e)
        {
            float pesos;
            float dolares;

            if (string.IsNullOrEmpty(TextBoxPesos.Text))
            {
                MessageBox.Show("Error! Debes ingresar un numero");
                return;
            }

            pesos = Convert.ToInt32(TextBoxPesos.Text);
            dolares = pesos / 20;

            TextBoxDolares.Text = (dolares.ToString());



        }

        private void Clean_Click(object sender, EventArgs e)
        {
            TextBoxPesos.Text = "";
            TextBoxDolares.Text = "";
        }
    }
}
