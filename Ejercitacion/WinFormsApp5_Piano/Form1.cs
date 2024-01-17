using System.Media;

namespace WinFormsApp5_Piano
{
    public partial class Form1 : Form
    {
        private bool estadoBoton = true;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            estadoBoton = !estadoBoton;
            buttonOnOff.Text = estadoBoton ? "ON" : "OFF";

            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void buttonDO1_Click(object sender, EventArgs e)
        {
            SoundPlayer do1 = new SoundPlayer();
            do1.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Do.wav";
            do1.Play();
        }


        private void buttonRE1_Click(object sender, EventArgs e)
        {
            SoundPlayer re1 = new SoundPlayer();
            re1.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Re.wav";
            re1.Play();
        }

        private void buttonMI1_Click(object sender, EventArgs e)
        {
            SoundPlayer mi1 = new SoundPlayer();
            mi1.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Mi.wav";
            mi1.Play();
        }

        private void buttonFA1_Click(object sender, EventArgs e)
        {
            SoundPlayer fa1 = new SoundPlayer();
            fa1.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Fa.wav";
            fa1.Play();
        }

        private void buttonSOL1_Click(object sender, EventArgs e)
        {
            SoundPlayer sol1 = new SoundPlayer();
            sol1.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Sol.wav";
            sol1.Play();
        }

        private void buttonLA1_Click(object sender, EventArgs e)
        {
            SoundPlayer la1 = new SoundPlayer();
            la1.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/La.wav";
            la1.Play();
        }

        private void buttonSI1_Click(object sender, EventArgs e)
        {
            SoundPlayer si1 = new SoundPlayer();
            si1.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Si.wav";
            si1.Play();
        }

        private void buttonDo11_Click(object sender, EventArgs e)
        {
            SoundPlayer doo1 = new SoundPlayer();
            doo1.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/DoOctava.wav";
            doo1.Play();
        }

        private void buttonDO2_Click(object sender, EventArgs e)
        {
            SoundPlayer do2 = new SoundPlayer();
            do2.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Do.wav";
            do2.Play();
        }

        private void buttonRE2_Click(object sender, EventArgs e)
        {
            SoundPlayer re2 = new SoundPlayer();
            re2.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Re.wav";
            re2.Play();
        }

        private void buttonMI2_Click(object sender, EventArgs e)
        {
            SoundPlayer mi2 = new SoundPlayer();
            mi2.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Mi.wav";
            mi2.Play();
        }

        private void buttonFA2_Click(object sender, EventArgs e)
        {
            SoundPlayer fa2 = new SoundPlayer();
            fa2.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Fa.wav";
            fa2.Play();
        }

        private void buttonSOL2_Click(object sender, EventArgs e)
        {
            SoundPlayer sol2 = new SoundPlayer();
            sol2.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Sol.wav";
            sol2.Play();
        }

        private void buttonLA2_Click(object sender, EventArgs e)
        {
            SoundPlayer la2 = new SoundPlayer();
            la2.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/La.wav";
            la2.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer si2 = new SoundPlayer();
            si2.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/Si.wav";
            si2.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer doo2 = new SoundPlayer();
            doo2.SoundLocation = "C:/Users/Usuario/OneDrive/Escritorio/Programacion/NotasPiano/DoOctava.wav";
            doo2.Play();
        }

        private void buttonDO1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'Q' || e.KeyValue == 'q')
            {
                buttonDO1.PerformClick();
            }
        }

        private void buttonRE1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'W' || e.KeyValue == 'w')
            {
                buttonRE1.PerformClick();
            }
        }

        private void buttonMI1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'E' || e.KeyValue == 'e')
            {
                buttonMI1.PerformClick();
            }
        }

        private void buttonFA1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'R' || e.KeyValue == 'r')
            {
                buttonFA1.PerformClick();
            }
        }

        private void buttonSOL1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'T' || e.KeyValue == 't')
            {
                buttonSOL1.PerformClick();
            }
        }

        private void buttonLA1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'Y' || e.KeyValue == 'y')
            {
                buttonLA1.PerformClick();
            }
        }

        private void buttonSI1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'U' || e.KeyValue == 'u')
            {
                buttonSI1.PerformClick();
            }
        }

        private void buttonDo11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'I' || e.KeyValue == 'i')
            {
                buttonDo11.PerformClick();
            }
        }
    }
}