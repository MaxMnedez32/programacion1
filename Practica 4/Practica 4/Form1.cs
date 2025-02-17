using System;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTexto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular1_Click(object sender, EventArgs e)
        {
            int radio = int.Parse(txtTexto1.Text);
            int area = (int)(Math.PI * radio * radio);//Hace el 
            lblResultado1.Text = "Área: 6" + area;
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            int radio = int.Parse(txtTexto1.Text);
            int perimetro = (int)(2 * Math.PI * radio);
            lblResultado2.Text = "Perímetro: " + perimetro;
        }

        private void lblResultado1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado2_Click(object sender, EventArgs e)
        {

        }
    }
} 