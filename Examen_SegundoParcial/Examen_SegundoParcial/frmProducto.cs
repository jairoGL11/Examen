using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Windows.Forms;

namespace Ejercicicio03
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;
        ProductoDA productoAcceso = new ProductoDA();

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }
        
     
        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            ExistenciaTextBox.Enabled = true;               
            NuevoButton.Enabled = false;
            GuardarButton.Enabled = true;
        }

        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ExistenciaTextBox.Enabled = false;        
            GuardarButton.Enabled = false;           
            NuevoButton.Enabled = true;       
        }
        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciaTextBox.Clear();          
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese el código");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(DescripcionTextBox.Text))
                {
                    errorProvider1.SetError(DescripcionTextBox, "Ingrese una descripción");
                    DescripcionTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PrecioTextBox.Text))
                {
                    errorProvider1.SetError(PrecioTextBox, "Ingrese un precio");
                    PrecioTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ExistenciaTextBox.Text))
                {
                    errorProvider1.SetError(ExistenciaTextBox, "Ingrese una existencia");
                    ExistenciaTextBox.Focus();
                    return;
                }

                Producto producto = new Producto();
                producto.Codigo = CodigoTextBox.Text;
                producto.Descripcion = DescripcionTextBox.Text;
                producto.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                producto.Existencia = Convert.ToInt32(ExistenciaTextBox.Text);

                if (operacion == "Nuevo")
                {
                    bool inserto = productoAcceso.InsertarProducto(producto);

                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        ListarProductos();
                        MessageBox.Show("Producto insertado");
                    }
                }
            }
            catch (Exception ex)
            {

                
            }
        }

        private void ProductoVista_Load(object sender, EventArgs e)
        {
           ListarProductos();
        }

        private void ListarProductos()
        {
            ProductosDataGridView.DataSource = productoAcceso.ListarProductos();
        }
    }
}
