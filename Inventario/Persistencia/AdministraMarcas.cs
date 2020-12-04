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

        public static int TotalMarcas(string cadenaC)
        {
            SqlConnection connection = UsoBD.ConectaBD(cadenaC);
            if (connection == null)
            {
                errores = UsoBD.ESalida;
                return 0;
            }
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT COUNT (0) FROM MARCAS";
            command.Connection = connection;
            int cuenta = (int)command.ExecuteScalar();
            connection.Close();
            return cuenta;
        }

        public SqlException Errores => errores;
    }
}
