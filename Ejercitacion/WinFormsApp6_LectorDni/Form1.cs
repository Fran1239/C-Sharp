namespace WinFormsApp6_LectorDni
{
    public partial class Form1 : Form
    {
        string apellido = string.Empty;
        string nombre = string.Empty;
        string sexo = string.Empty;
        string nacionalidad = string.Empty;
        string nacimiento = string.Empty;
        string emision = string.Empty;
        string vencimiento = string.Empty;
        string numTramite = string.Empty;
        string documento = string.Empty;
        string domicilio = string.Empty;

        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            domainUpDownSexo.Visible = true;
            domainUpDownSexo.Items.Add("  Masculino");
            domainUpDownSexo.Items.Add("  Femenino");
            domainUpDownSexo.Items.Add("  Otro");
        }

        private void tituloLBL_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            button1.Text = apellido;
            button1.Enabled = false;
            button2.Text = nombre;
            button2.Enabled = false;
            button3.Text = documento;
            button3.Enabled = false;
            button4.Text = nacionalidad;
            button4.Enabled = false;

            button5.Text = emision;
            button5.Enabled = false;
            button6.Text = sexo;
            button6.Enabled = false;
            button7.Text = vencimiento;
            button7.Enabled = false;
            button8.Text = domicilio;
            button8.Enabled = false;

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            apellido = textBoxApellido.Text;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = textBoxNombre.Text;
        }

        private void textBoxDocumento_TextChanged(object sender, EventArgs e)
        {
            documento = textBoxDocumento.Text;
        }

        private void textBoxNacionalidad_TextChanged(object sender, EventArgs e)
        {
            nacionalidad = textBoxNacionalidad.Text;
        }

        private void textBoxDomicilio_TextChanged(object sender, EventArgs e)
        {
            domicilio = textBoxDomicilio.Text;
        }

        private void textBoxNacimiento_TextChanged(object sender, EventArgs e)
        {
            nacimiento = textBoxNacimiento.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numTramite = textBox1.Text;
        }

        private void textBoxEmision_TextChanged(object sender, EventArgs e)
        {
            emision = textBoxEmision.Text;
        }

        private void textBoxVencimiento_TextChanged(object sender, EventArgs e)
        {
            vencimiento = textBoxVencimiento.Text;
        }

        private void domainUpDownSexo_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDownSexo.SelectedItem == "  Masculino")
            {
                sexo = domainUpDownSexo.SelectedItem.ToString();
            }
            else if (domainUpDownSexo.SelectedItem == "  Femenino")
            {
                sexo = domainUpDownSexo.SelectedItem.ToString();
            }
            else
            {
                sexo = domainUpDownSexo.SelectedItem.ToString();
            }

            Console.WriteLine(sexo);
        }
    }
}