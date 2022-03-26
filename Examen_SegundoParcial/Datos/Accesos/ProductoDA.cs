using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Datos.Accesos
{
    public class ProductoDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=programacion; Uid=root; Pwd=123456;";
        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable ListarProductos()
        {
            DataTable lista = new DataTable();
            try
            {
                string sql = "SELECT * FROM producto;";
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

        public bool InsertarProducto(Producto producto)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO producto VALUES (@Codigo, @Descripcion, @Precio, @Existencia);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);                
                cmd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }

        public Producto GetProductoPorCodigo(string codigo)
        {
            Producto producto = new Producto();
            try
            {
                string sql = "Select * from producto WHERE Codigo = @Codigo;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Codigo", codigo);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    producto.Codigo = reader["Codigo"].ToString();
                    producto.Descripcion = reader["Descripcion"].ToString();
                    producto.Precio = Convert.ToDecimal(reader["Precio"]);
                    producto.Existencia = Convert.ToInt32(reader["Descripcion"].ToString());
                }

                conn.Close();
            }
            catch (Exception)
            {
            }
            return producto;
        }

        //public bool ModificarProducto(Producto producto)
        //{
        //    bool modifico = false;
        //    try
        //    {
        //        string sql = "UPDATE producto SET Codigo = @Codigo, Descripcion = @Descripcion, " +
        //                     "Precio = @Precio, Existencia = @Existencia, Imagen = @Imagen WHERE Codigo = @Codigo;";

        //        conn = new MySqlConnection(cadena);
        //        conn.Open();

        //        cmd = new MySqlCommand(sql, conn);

        //        cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
        //        cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
        //        cmd.Parameters.AddWithValue("@Precio", producto.Precio);
        //        cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
        //        //cmd.Parameters.AddWithValue("@Imagen", producto.Imagen);
        //        cmd.ExecuteNonQuery();
        //        modifico = true;
        //        conn.Close();
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    return modifico;
        //}
        //public bool EliminarProducto(string codigo)
        //{
        //    bool elimino = false;
        //    try
        //    {
        //        string sql = "DELETE FROM producto WHERE Codigo = @Codigo;";

        //        conn = new MySqlConnection(cadena);
        //        conn.Open();

        //        cmd = new MySqlCommand(sql, conn);

        //        cmd.Parameters.AddWithValue("@Codigo", codigo);

        //        cmd.ExecuteNonQuery();
        //        elimino = true;
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return elimino;
        //}
    }
}
