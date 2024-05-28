using Pica_Y_Fija;

namespace Pica_Y_Fija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Sistema de información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text) || string.IsNullOrWhiteSpace(textBoxContraseña.Text) || string.IsNullOrWhiteSpace(textBoxTiempo.Text) || string.IsNullOrWhiteSpace(textBoxIntentos.Text))
            {
                MessageBox.Show("Completa los campos vacios del formulario.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (!int.TryParse(textBoxTiempo.Text, out Configu.minutos) || !int.TryParse(textBoxIntentos.Text, out Configu.intentos))
            {
                MessageBox.Show("Minutos e intentos deben ser números válidos.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Configu.minutos1 = Configu.minutos - 1;

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                textBoxContraseña.Focus();
            }
        }

        private void textBoxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                textBoxTiempo.Focus();
            }
        }

        private void textBoxTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                textBoxIntentos.Focus();
                
            }
        }

        private void textBoxIntentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
            }
        }

    }
}