using System;

namespace Datos.Entidades
{
    public class Producto
    {
        public string Codigo { get; set; }
        public String Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }

        public Producto()
        {

        }

        public Producto(string codigo, string descripcion, decimal precio, int existencia)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;
        }
    }
}
