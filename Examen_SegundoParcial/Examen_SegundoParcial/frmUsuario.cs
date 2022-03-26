using Datos.Accesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicicio03
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        UsuarioDA usuarioAcceso = new UsuarioDA();

        private void UsuariosVista_Load(object sender, EventArgs e)
        {
            
          UsuariodataGridView.DataSource = usuarioAcceso.ListarUsuarios();
        }
    }
}
