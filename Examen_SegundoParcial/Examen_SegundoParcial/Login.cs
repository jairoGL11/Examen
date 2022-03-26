using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Windows.Forms;
namespace Ejercicicio03
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioAcceso = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioAcceso.Login(UsuarioTextBox.Text, ClaveTextBox.Text);
            if (usuario == null)
            {
                MessageBox.Show("Usuario NO Existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!usuario.EstaActivo)
            {
                MessageBox.Show("Usuario NO Activo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmMenu menuVista = new frmMenu();
            menuVista.Show();
            this.Hide();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
