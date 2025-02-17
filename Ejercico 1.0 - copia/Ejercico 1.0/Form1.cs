namespace Ejercico_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTexto.Text = txtTexto.Text;
            txtTexto.Text = "";//Borrar texto de textbox y que no tenga espacios
        }

        private void lbltexto_Click(object sender, EventArgs e)
        {

        }
    }
}