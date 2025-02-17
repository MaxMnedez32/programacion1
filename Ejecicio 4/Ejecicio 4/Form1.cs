namespace Ejecicio_4
{
    public partial class Form1 : Form
    {
        decimal Resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTexto1_Click(object sender, EventArgs e)
        {

        }

        private void lblTexto2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir1_Click(object sender, EventArgs e)
        {
            Resultado = Convert.ToDecimal(textTexto1.Text) * 9 / 5 + 32;//Hace la conversion
            lblResultado1.Text = Resultado.ToString( ) + "°F";

        }

        private void btnConvertir2_Click(object sender, EventArgs e)
        {
            Resultado = (Convert.ToDecimal(textTexto2.Text) - 32) * 5 / 9;//Hace la convercion para dar los resultados
            lblResultado2.Text = Resultado.ToString( ) + "℃";


        }
    }
}
