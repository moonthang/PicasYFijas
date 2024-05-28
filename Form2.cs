using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Timers;
using System.Windows.Forms;


namespace Pica_Y_Fija
{

    public partial class Form2 : Form
    {

        Jugar op = new Jugar();
        private int contarseg = 0, picas = 0, fijas = 0, contador = 0;
        private int numero;
        private int intentosRestantes;
        private DateTime startTime;


        public Form2()
        {
            InitializeComponent();

            intentosRestantes = Configu.intentos;

            timerTiempo = new System.Windows.Forms.Timer();
            timerTiempo.Interval = 1000;
            timerTiempo.Tick += timerTiempo_Tick;

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                textBox4.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                textBox5.Focus();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                textBox6.Focus();
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();

            form1.Show();
        }

        private void ImgRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();

            form1.Show();
        }

        private void buttonReglamento_Click(object sender, EventArgs e)
        {
            string reglas = "Picas y Fijas es un juego en el que debes adivinar un número secreto de 6 dígitos, los números no se pueden repetir.\n" +
                           " • Una Pica indica que un dígito está en el número secreto, pero en la posición incorrecta.\n" +
                           " • Una Fija indica que un dígito está en el número secreto y en la posición correcta.\n" +
                           "Intenta adivinar el número secreto en la menor cantidad de intentos posible y antes de que acabe el tiempo.";

            MessageBox.Show(reglas, "Reglamento del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ImgReglamento_Click(object sender, EventArgs e)
        {
            buttonReglamento_Click(sender, e);
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            if (timerTiempo.Enabled)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas abandonar el juego actual y empezar uno nuevo?", "Reiniciar juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    ReiniciarJuego();
                }
            }

            startTime = DateTime.Now;

            labelGP.Visible = false;
            pictureBox1.Visible = false;
            numero = op.Aleatorio();
            label3.Text = numero.ToString();

            intentosRestantes = Configu.intentos;

            timerTiempo.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonComparar_Click(object sender, EventArgs e)
        {

            comparando(Jugar.a, Jugar.b, Jugar.c, Jugar.d, Jugar.e, Jugar.f);

            
            pictureBox1.Visible = true;
            intentosRestantes--;
            labelIntentos.Text = intentosRestantes.ToString();

            if (intentosRestantes == 0)
            {
                PerderJuego();
            }

            if (fijas == 6)
            {
                GanarJuego();
            }

            double progreso = (Configu.intentos - intentosRestantes) / (double)Configu.intentos * 100;

            if (progreso < 15)
            {
                pictureBox1.Image = Properties.Resources.bien;
            }
            else if (progreso < 30)
            {
                pictureBox1.Image = Properties.Resources.maso;
            }
            else if (progreso < 70)
            {
                pictureBox1.Image = Properties.Resources.todo_bien;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.perdio;
            }


        }

        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            //label6.Text = DateTime.Now.ToString("hh:mm:ss");
            if (labelH.Text.Equals("."))
            {
                labelH.Text = Configu.minutos.ToString();
                labelIntentos.Text = Configu.intentos.ToString();
                contarseg = 60;
            }
            else
            {
                contarseg--;
                labelSeg.Text = contarseg.ToString();
                if (contarseg < 10)
                {
                    labelSeg.Text = "0" + contarseg.ToString();
                }
                if (contarseg > 9)
                {
                    labelSeg.Text = contarseg.ToString();
                }
                if (contarseg == 0)
                {
                    contarseg = 60;
                    Configu.minutos--;
                    labelH.Text = Configu.minutos.ToString();
                }
                if (Configu.minutos == 0)
                {
                    timerTiempo.Enabled = false;
                }
            }
        }

        public void comparando(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            int tx1 = 0, tx2 = 0, tx3 = 0, tx4 = 0, tx5 = 0, tx6 = 0;
            tx1 = int.Parse(textBox1.Text); tx2 = int.Parse(textBox2.Text); tx3 = int.Parse(textBox3.Text); tx4 = int.Parse(textBox4.Text); tx5 = int.Parse(textBox5.Text); tx6 = int.Parse(textBox6.Text);

            fijas = 0;
            picas = 0;
            contador++;

            if (n1 == tx1)
            {
                fijas++;
            }
            if (n2 == tx2)
            {
                fijas++;
            }
            if (n3 == tx3)
            {
                fijas++;
            }
            if (n4 == tx4)
            {
                fijas++;
            }
            if (n5 == tx5)
            {
                fijas++;
            }
            if (n6 == tx6)
            {
                fijas++;
            }
            //PICAS
            if (n1 == tx2 || n1 == tx3 || n1 == tx4 || n1 == tx5 || n1 == tx6)
            {
                picas++;
            }
            if (n2 == tx1 || n2 == tx3 || n2 == tx4 || n2 == tx5 || n2 == tx6)
            {
                picas++;
            }
            if (n3 == tx1 || n3 == tx2 || n3 == tx4 || n3 == tx5 || n3 == tx6)
            {
                picas++;
            }
            if (n4 == tx1 || n4 == tx2 || n4 == tx3 || n4 == tx5 || n4 == tx6)
            {
                picas++;
            }
            if (n5 == tx1 || n5 == tx2 || n5 == tx3 || n5 == tx4 || n5 == tx6)
            {
                picas++;
            }
            if (n6 == tx1 || n6 == tx2 || n6 == tx3 || n6 == tx4 || n6 == tx5)
            {
                picas++;
            }
            string num = (tx1.ToString() + tx2.ToString() + tx3.ToString() + tx4.ToString() + tx5.ToString() + tx6.ToString());
            string cadena = "N°: " + contador + "  Num: " + num + "  Fijas: " + fijas + "  Picas: " + picas;
            listBox1.Items.Add(cadena);
            limpiar();
            textBox1.Focus();
        }
        public void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void ReiniciarJuego()
        {
            timerTiempo.Stop();
            Configu.intentos = Configu.intentos;
            labelH.Text = Configu.minutos1.ToString();
            labelIntentos.Text = Configu.intentos.ToString();
            contarseg = 60;

            listBox1.Items.Clear();
            limpiar();

            labelGP.Visible = false;
            pictureBox1.Visible = false;
        }

        private void GanarJuego()
        {
            timerTiempo.Stop();

            TimeSpan elapsedTime = DateTime.Now - startTime;

            int elapsedMinutes = (int)elapsedTime.TotalMinutes;
            int elapsedSeconds = elapsedTime.Seconds;
            string mensaje = "¡Has ganado!\nEl número era: " + numero + "\nTiempo: " + elapsedMinutes + " minutos " + elapsedSeconds + " segundos\nIntentos: " + (Configu.intentos - intentosRestantes);


            //int tM = Configu.minutos1 - 60;
            //int min = tM + 60;
            //int tiempoTranscurrido = contarseg - 60;
            //int segundos = tiempoTranscurrido < 0 ? -tiempoTranscurrido : tiempoTranscurrido;
            //string mensaje = "¡Has ganado!\nEl número era: " + numero + "\nTiempo: " + min +segundos + " segundos\nIntentos: " + (Configu.intentos - intentosRestantes);

            labelGP.Visible = true;
            pictureBox1.Image = Properties.Resources.funny_celebrate_8;
            labelGP.Text = "¡GANASTE!";

            MessageBox.Show(mensaje, "¡Has ganado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PerderJuego()
        {
            timerTiempo.Stop();
            string mensaje = "Has perdido. El número secreto era: " + numero;

            labelGP.Visible = true;
            labelGP.Text = "¡PERDISTE!";
            pictureBox1.Image = Properties.Resources.giphy;
            MessageBox.Show(mensaje, "Has perdido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

