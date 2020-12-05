using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBD;
using System.Data.SqlClient;
using System.Data;

namespace Inventario.Persistencia
{
    public class AdministraMarcas
    {
        private static SqlException errores;

        /// <summary>
        /// Método que guarda una nueva marca.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <param name="clave">Clave de marca.</param>
        /// <param name="nombre">Nombre de Marca.</param>
        /// <param name="datos">Datos de Marca.</param>
        /// <returns>True = inserción correcta.</returns>
        public static bool AgregaMarca(string cadenaC, string clave, string nombre, string datos)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return false;
            }
            string proc = "AñadirMarca";
            SqlCommand command = new SqlCommand(proc, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idMarca", clave);
            command.Parameters.AddWithValue("@nomMarca", nombre);
            command.Parameters.AddWithValue("@datosMarca", datos);
            try
            {
                command.ExecuteNonQuery();
            }catch(SqlException e)
            {
                errores = e;
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        /// <summary>
        /// Método que consulta los atributos de las Marcas y los devuelve en un arreglo de objetos.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <returns>Arreglo de objetos de tipo Marca.</returns>
        public static Marca[] Marcas(string cadenaC)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return null;
            }
            string proc = "ConsultaMarcas";
            SqlCommand command = new SqlCommand(proc, connection);
            SqlDataReader reader = null;
            List<Marca> marcas = new List<Marca>();
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                reader = command.ExecuteReader();
            }catch(SqlException e)
            {
                errores = e;
                connection.Close();
                return null;
            }
            while (reader.Read())
            {
                string clave = reader.GetValue(0).ToString();
                string nombre = reader.GetValue(1).ToString();
                string datos = reader.GetValue(2).ToString();
                marcas.Add(new Marca(clave, nombre, datos));
            }
            Marca[] m = new Marca[marcas.Count];
            marcas.CopyTo(m);
            connection.Close();
            return m;
        }

        /// <summary>
        /// Método de consulta para nombre y clave de las marcas.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <returns>Dictionary con las marcas (llave = nombre).</returns>
        public static Dictionary<string, string> NombreClaveMarcas(string cadenaC)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return null;
            }
            string proc = "NomClaveMarcas";
            SqlCommand command = new SqlCommand(proc, connection);
            SqlDataReader reader = null;
            Dictionary<string, string> marcas = new Dictionary<string, string>();
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string clave = reader.GetValue(0).ToString();
                    string nombre = reader.GetValue(1).ToString();
                    marcas.Add(nombre, clave);
                }
            }
            catch (SqlException e)
            {
                errores = e;
                connection.Close();
                return null;
            }
            connection.Close();
            return marcas;
        }

        /// <summary>
        /// Método que consulta a la BD para determinar cuántas marcas han sido dadas de alta.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <returns>Total de marcas.
        /// -1.- Error de conexión.
        /// -2.- Error en consulta.</returns>
        public static int TotalMarcas(string cadenaC)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return -1;
            }
            SqlCommand command = new SqlCommand();
            command.CommandText = "HayMarcas";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            int cuenta = 0;
            try
            {
                cuenta = (int)command.ExecuteScalar();
            }catch(SqlException e)
            {
                errores = e;
                connection.Close();
                return -2;
            }
            connection.Close();
            return cuenta;
        }

        /// <summary>
        /// Método para determinar si una marca esta dada de alta.
        /// </summary>
        /// <param name="cadenaC">Cadena de conexión.</param>
        /// <param name="clave">Clave de marca.</param>
        /// <param name="nombre">Nombre de la marca.</param>
        /// <returns>0 = No esta la marca.
        /// 1 = Esta la marca.
        /// 2 = Error de conexión.
        /// 3 = Error de consulta.</returns>
        public static int EstaAlta(string cadenaC, string clave, string nombre)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return 2;
            }
            string proc = "ConsultaMarca";
            SqlCommand command = new SqlCommand(proc, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idMarca", clave);
            command.Parameters.AddWithValue("@nomMarca", nombre);
            int c = 1;
            try
            {
                c = (int)command.ExecuteScalar();
            }
            catch (SqlException e)
            {
                errores = e;
                connection.Close();
                return 3;
            }
            connection.Close();
            return c;
        }

        public SqlException Errores => errores;
    }
}
