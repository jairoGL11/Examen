using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }    
        public decimal Total { get; set; }
        public string IdProducto { get; set; }
        public int Cantidad { get; set; }

        public Pedido()
        {

        }

        public Pedido(int codigo, string cliente, decimal total, string idProducto, int cantidad)
        {
            Codigo = codigo;
            Cliente = cliente;
            Total = total;
            IdProducto = idProducto;
            Cantidad = cantidad;
        }
    }


}
