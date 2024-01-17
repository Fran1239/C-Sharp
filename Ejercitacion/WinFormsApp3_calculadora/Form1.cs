namespace WinFormsApp3_calculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btRta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btRta.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btRta.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btRta.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btRta.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btRta.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btRta.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btRta.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btRta.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btRta.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            btRta.Text += button0.Text;
        }

        private void buttonMas_Click(object sender, EventArgs e)
        {
            btRta.Text += buttonMas.Text;
            string compMas = btRta.Text;
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            btRta.Text += buttonMenos.Text;
            string compMenos = btRta.Text;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            btRta.Text += buttonDivision.Text;
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            btRta.Text += buttonMultiplicacion.Text;
        }
    }
}