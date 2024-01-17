using Microsoft.Data.Sqlite;
using System.Data.Common;
using System.Data.SqlClient;

namespace WinFormsApp2_LogIn
{
    public partial class Form1 : Form
    {

        string email = "franbertinetti@hotmail.com.ar";
        string password = "Franco123456";
        string password1 = null;
        string password2 = null;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            panel2.Visible = true;
            panel3.Visible = false;
            SqliteDataReader db;
            i = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == email && textBox2.Text == password)
            {
                MessageBox.Show("Ha iniciado sesion correctamente", "Correcto", MessageBoxButtons.OK);
                i = 0;
            }
            else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                i++;
                errorProvider1.SetError(textBox1, email + " " + i);
                errorProvider1.SetError(textBox2, password + " " + i);
            }
            else if (textBox1.Text != email || textBox2.Text != password)
            {
                i++;
                errorProvider1.SetError(textBox1, email + " " + i);
                errorProvider1.SetError(textBox2, password + " " + i);
            }


            if (i >= 5)
            {
                MessageBox.Show("Ya ha intentado 5 veces, intente mas tarde o bloqueara su cuenta", "Error", MessageBoxButtons.OK);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.Black;
            password2 = textBox4.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
            password1 = textBox3.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = checkBox2.Checked ? '\0' : '*';
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (password2 != password1)
            {
                errorProvider1.SetError(textBox3, "Las contrasenias no coinciden");
                errorProvider1.SetError(textBox4, "Las contrasenias no coinciden");
            }
            else
            {
                password = password1;
                MessageBox.Show("Se a reestablecido correctamente su contrasenia", "Correcto", MessageBoxButtons.OK);
                panel3.Visible = false;
                panel2.Visible = true;
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}