using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_base_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rb_cuadrilatero_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cuadrilatero.Checked == true)
            {
                this.BackgroundImage = Properties.Resources.cuadrado;
            }
        }

        private void rb_triangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_triangulo.Checked == true)
            {
                this.BackgroundImage = Properties.Resources.triangulo;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_triangulo.Checked == true)
            {
                decimal base1 = Convert.ToDecimal(textBox1.Text);
                decimal altura1 = Convert.ToDecimal(textBox1.Text);
                decimal respuesta = (base1 * altura1) / 2;
                label1.Text = Convert.ToString(respuesta);
            }

            if (rb_cuadrilatero.Checked == true)
            {
                decimal base1 = Convert.ToDecimal(textBox1.Text);
                decimal altura1 = Convert.ToDecimal(textBox1.Text);
                decimal respuesta = base1 * altura1;
                label1.Text = Convert.ToString(respuesta);
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}