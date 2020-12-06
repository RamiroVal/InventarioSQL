using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using LibreriaBD;

namespace Inventario.Persistencia
{
    public class AdministraArticulos
    {
        private static SqlException errores;

        /// <summary>
        /// Método para la inserción de Artículos.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <param name="clave">Clave del artículo.</param>
        /// <param name="marca">Marca del artículo.</param>
        /// <param name="descripcion">Descripción del artículo.</param>
        /// <param name="existencia">Existencia del artículo.</param>
        /// <param name="sExistencia">siempre = 1, no = 0</param>
        /// <param name="precio">Precio del artículo.</param>
        /// <returns>0 = Inserción exitosa.
        /// 1 = Error de conexión.
        /// 2 = Error en la inserción de datos.</returns>
        public static int AgregaArticulo(string cadenaC, string clave, string marca, string descripcion, int existencia, int sExistencia, double precio)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return 1;
            }
            string proc = "AñadirArticulo";
            SqlCommand command = new SqlCommand(proc, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idArticulo", clave);
            command.Parameters.AddWithValue("@idMarca", marca);
            command.Parameters.AddWithValue("@descMarca", descripcion);
            command.Parameters.AddWithValue("@existMarca", existencia);
            command.Parameters.AddWithValue("@sExistencia", sExistencia);
            command.Parameters.AddWithValue("@precioMarca", precio);
            try
            {
                command.ExecuteNonQuery();
            }catch(SqlException e)
            {
                errores = e;
                connection.Close();
                return 2;
            }
            connection.Close();
            return 0;
        }

        /// <summary>
        /// Método que hace consulta para ver si un articulo ha sido dado de alta.
        /// </summary>
        /// <param name="cadena">Cadena de conexión.</param>
        /// <param name="clave">Clave del artículo.</param>
        /// <returns>0 = No esta. 1 = Esta. 2 = Error de conexión. 3 = Error de consulta.</returns>
        public static int EstaArticulo(string cadena, string clave, string nombre)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadena);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return 2;
            }
            string proc = "EstaArticulo";
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@idArticulo", clave);
            command.Parameters.AddWithValue("@descArticulo", nombre);
            command.CommandType = CommandType.StoredProcedure;
            int c = 0;
            try
            {
                c = (int)command.ExecuteScalar();
            }catch(SqlException e)
            {
                errores = e;
                connection.Close();
                return 3;
            }
            return c;
        }

        /// <summary>
        /// Método para consultar todos los datos de los artículos.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <returns>Arreglo de tipo Articulo con los datos.</returns>
        public static Articulo[] Articulos(string cadenaC)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return null;
            }
            string proc = "ConsultaArticulos";
            SqlCommand command = new SqlCommand(proc, connection);
            SqlDataReader reader = null;
            List<Articulo> articulos = new List<Articulo>();
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string clave = reader.GetValue(0).ToString();
                    string marca = reader.GetValue(1).ToString();
                    string descripcion = reader.GetValue(2).ToString();
                    int existencia = Convert.ToInt32(reader.GetValue(3));
                    int sExistencia = Convert.ToInt32(reader.GetValue(4));
                    double precio = Convert.ToDouble(reader.GetValue(5));
                    articulos.Add(new Articulo(clave, marca, descripcion, existencia, sExistencia, precio));
                }
            }catch(SqlException e)
            {
                errores = e;
                return null;
            }
            connection.Close();
            Articulo[] a = new Articulo[articulos.Count];
            articulos.CopyTo(a);
            return a;
        }

        /// <summary>
        /// Método para consultar a la BD y determinar si hay artículos agregados.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <returns>0 = No hay marcas. 1 = Hay marcas. -1 = Error de conexión.
        /// -2 = Error en consulta.</returns>
        public static int HayArticulos(string cadenaC)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return -1;
            }
            string proc = "HayArticulos";
            SqlCommand command = new SqlCommand(proc, connection);
            command.CommandType = CommandType.StoredProcedure;
            int c = 0;
            try
            {
                c = (int)command.ExecuteScalar();
            }catch(SqlException e)
            {
                errores = e;
                connection.Close();
                return -2;
            }
            connection.Close();
            return c;
        }

        /// <summary>
        /// Método para consultar las claves y descripción de los artículos.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <returns>Dictionary con los datos Key = Descripcion.</returns>
        public static Dictionary<string, string> DescripcionClavesArticulos(string cadenaC)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return null;
            }
            string proc = "ArticulosClaves";
            SqlCommand command = new SqlCommand(proc, connection);
            SqlDataReader reader = null;
            Dictionary<string, string> articulos = new Dictionary<string, string>();
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string clave = reader.GetValue(0).ToString();
                    string desc = reader.GetValue(1).ToString();
                    articulos.Add(desc, clave);
                }
            }
            catch (SqlException e)
            {
                errores = e;
                connection.Close();
                return null;
            }
            connection.Close();
            return articulos;
        }

        /// <summary>
        /// Método que consulta los atributos de un artículo por su clave.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <param name="clave">Clave del artículo.</param>
        /// <returns>Articulo.</returns>
        public static Articulo DatosArticulo(string cadenaC, string clave)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return null;
            }
            string proc = "ConsultaArticulo";
            SqlCommand command = new SqlCommand(proc, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idArticulo", clave);
            SqlDataReader reader = null;
            Articulo articulo = new Articulo();
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    articulo.Clave = reader.GetValue(0).ToString();
                    articulo.Marca = reader.GetValue(1).ToString();
                    articulo.Descripcion = reader.GetValue(2).ToString();
                    articulo.Existencia = Convert.ToInt32(reader.GetValue(3));
                    articulo.SiempreExistencia = Convert.ToInt32(reader.GetValue(4));
                    articulo.Precio = Convert.ToDouble(reader.GetValue(5));
                }
            }catch(SqlException e)
            {
                errores = e;
                connection.Close();
                return null;
            }
            connection.Close();
            return articulo;
        }

        public static int ActualizaExistencia(string cadenaC, string clave, int nExistencia)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return 1;
            }
            string proc = "ActualizaExistencia";
            SqlCommand command = new SqlCommand(proc, connection);
            command.Parameters.AddWithValue("@idArticulo", clave);
            command.Parameters.AddWithValue("@nExistencia", nExistencia);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                command.ExecuteNonQuery();
            }catch(SqlException e)
            {
                errores = e;
                connection.Close();
                return 2;
            }
            connection.Close();
            return 0;
        }

        public SqlException Errores => errores;
    }
}
