using System;
using System.Windows.Forms;

namespace InicioCession
{
    public partial class FormCrearCuenta : Form
    {
        private Form1 formPrincipal;


        public FormCrearCuenta(Form1 form)
        {
            InitializeComponent();
            formPrincipal = form;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void texCorreoElectronico_TextChanged(object sender, EventArgs e)
        {
        }

        private void texNombreUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void texContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnRegistrase_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(texCorreoElectronico.Text) ||
                string.IsNullOrWhiteSpace(texNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(texContraseña.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            formPrincipal.UsuarioRegistrado = texNombreUsuario.Text;
            formPrincipal.ContraseñaRegistrada = texContraseña.Text;

            MessageBox.Show("Cuenta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            texCorreoElectronico.Clear();
            texNombreUsuario.Clear();
            texContraseña.Clear();
        }
    }
}
