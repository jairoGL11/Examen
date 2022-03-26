using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class PedidoDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=programacion; Uid=root; Pwd=123456;";
        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable ListarPedidos()
        {
            DataTable lista = new DataTable();
            try
            {
                string sql = "SELECT * FROM pedido;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                lista.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {


            }
            return lista;
        }

        public bool InsertarPedidos(Pedido pedido)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO pedido VALUES (@Codigo, @Cliente, @Total, @IdProducto,@Cantidad);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Codigo", pedido.Codigo);
                cmd.Parameters.AddWithValue("@Cliente", pedido.Cliente);
                cmd.Parameters.AddWithValue("@Total", pedido.Total);
                cmd.Parameters.AddWithValue("@IdProducto", pedido.IdProducto);
                cmd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                cmd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }
    }
}
