using System;
using System.Windows.Forms;

namespace InicioCession
{
    public partial class Form1 : Form
    {
        public string UsuarioRegistrado = "";
        public string ContraseñaRegistrada = "";
        public string CorreoRegistrado = "";

        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterPanel(); 
        }

        private void CenterPanel()
        {
            if (panelContenedor != null)
            {
                panelContenedor.Left = (this.ClientSize.Width - panelContenedor.Width) / 2;
                panelContenedor.Top = (this.ClientSize.Height - panelContenedor.Height) / 2;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void RecordarContraseña_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == "admin" && contraseña == "123456789")
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormBienvenida bienvenida = new FormBienvenida();
                bienvenida.Show();
                this.Hide();
            }
            else if (usuario == UsuarioRegistrado && contraseña == ContraseñaRegistrada)
            {
                MessageBox.Show($"Inicio de sesión exitoso\nCorreo: {CorreoRegistrado}", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormBienvenida bienvenida = new FormBienvenida();
                bienvenida.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            FormCrearCuenta crearCuenta = new FormCrearCuenta(this);
            crearCuenta.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
