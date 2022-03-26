using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Windows.Forms;

namespace Ejercicicio03
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        ProductoDA productoAcceso = new ProductoDA();
        string operacion = string.Empty;
        PedidoDA pedidoAcceso = new PedidoDA();
        Producto producto;
        
        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            IdPedidTextBox.Enabled = true;                  
            CantidTextBox.Enabled = true;
            NombreClienTextBox.Enabled = true;
            CdgProductoTextBox.Enabled = true;

            NuevoButton.Enabled = false;
            GuardarButton.Enabled = true;
        }

        private void DesabilitarControles()
        {
            IdPedidTextBox.Enabled = false;                      
            CantidTextBox.Enabled = false;
            NombreClienTextBox.Enabled = false;
            CdgProductoTextBox.Enabled = false;

            NuevoButton.Enabled = true;
            GuardarButton.Enabled = false;
        }

        private void LimpiarControles()
        {
            IdPedidTextBox.Clear();
            DescpTextBox.Clear();
            TotalTextBox.Clear();
            CantidTextBox.Clear();
            NombreClienTextBox.Clear();
            CdgProductoTextBox.Clear();
            PrecioTextBox.Clear();
        }
        private void PedidoVista_Load(object sender, EventArgs e)
        {
            ListarPedidos();
        }

        private void ListarPedidos()
        {
            PedidoGridView1.DataSource = pedidoAcceso.ListarPedidos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IdPedidTextBox.Text))
                {
                    errorProvider1.SetError(IdPedidTextBox, "Ingrese el Id del Pedido");
                    IdPedidTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(DescpTextBox.Text))
                {
                    errorProvider1.SetError(DescpTextBox, "Ingrese la descripcion");
                    DescpTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(TotalTextBox.Text))
                {
                    errorProvider1.SetError(TotalTextBox, "Ingrese el total");
                    TotalTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(CantidTextBox.Text))
                {
                    errorProvider1.SetError(CantidTextBox, "Ingrese la cantidad");
                    CantidTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(NombreClienTextBox.Text))
                {
                    errorProvider1.SetError(NombreClienTextBox, "Ingrese el Nombre del Cliente");
                    NombreClienTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(CdgProductoTextBox.Text))
                {
                    errorProvider1.SetError(CdgProductoTextBox, "Ingrese el codigo del producto");
                    CdgProductoTextBox.Focus();
                    return;
                }

                Pedido pedido = new Pedido();
                pedido.Cliente = NombreClienTextBox.Text;
                pedido.Total = Convert.ToDecimal(TotalTextBox.Text);
                pedido.Cantidad = Convert.ToInt32(CantidTextBox.Text);
                pedido.IdProducto = CdgProductoTextBox.Text;
                pedido.Codigo = Convert.ToInt32(IdPedidTextBox.Text);

                if (operacion == "Nuevo")
                {
                    bool inserto = pedidoAcceso.InsertarPedidos(pedido);

                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        ListarPedidos();
                        MessageBox.Show("Pedido insertado");
                    }
                }

            }
            catch (Exception ex)
            {


            }
        }

        private void CodigoProductoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = new Producto();
                producto = productoAcceso.GetProductoPorCodigo(CdgProductoTextBox.Text);
                DescpTextBox.Text = producto.Descripcion;
                PrecioTextBox.Text = Convert.ToString(producto.Precio);
                TotalTextBox.Text = Convert.ToString(Convert.ToDecimal(PrecioTextBox.Text) * Convert.ToDecimal(CantidTextBox.Text)); ;
            }
            else
            {
                //producto = null;
                //DescripcionTextBox.Clear();
                //CantidadTextBox.Clear();
                //PrecioTextBox.Clear();
            }
        }
    }
}
