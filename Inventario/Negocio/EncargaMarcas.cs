using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Inventario.Persistencia;

namespace Inventario.Negocio
{
    public class EncargaMarcas
    {
        private string cadenaC = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=INVENTARIO;Integrated Security=True";

        /// <summary>
        /// Método para determinar si hay marcas o no.
        /// </summary>
        /// <returns>True = hay marcas.</returns>
        public bool HayMarcas()
        {
            int total = AdministraMarcas.TotalMarcas(cadenaC);
            return (total > 0) ? true : false;
        }

        /// <summary>
        /// Método para enviar a la capa de presentación las marcas consultadas en la capa de persistencia.
        /// </summary>
        /// <returns>Matriz de string con los datos de las marcas.</returns>
        public String[,] FormatoMarcas()
        {
            Marca[] marcas = AdministraMarcas.Marcas(cadenaC);
            if (marcas == null)
            {
                return null;
            }
            string[,] datos = new string[marcas.Length, 3];
            for (int i = 0; i < marcas.Length; i++)
            {
                datos[i, 0] = marcas[i].Clave;
                datos[i, 1] = marcas[i].Nombre;
                datos[i, 2] = marcas[i].Datos;
            }
            return datos;
        }

        public bool AltaMarca(string clave, string nombre, string datos)
        {
            if (AdministraMarcas.AgregaMarca(cadenaC, clave, nombre, datos))
            {
                return true;
            }
            return false;
        }
    }
}
