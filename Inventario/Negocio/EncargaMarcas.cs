using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Persistencia;

namespace Inventario.Negocio
{
    public class EncargaMarcas
    {
        private string cadenaC = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=INVENTARIO;Integrated Security=True";
        private Dictionary<string, string> marcas;

        public EncargaMarcas()
        {
            marcas = new Dictionary<string, string>();
        }

        /// <summary>
        /// Método para determinar si hay marcas o no.
        /// </summary>
        /// <returns>True = hay marcas.</returns>
        public bool HayMarcas()
        {
            int total = AdministraMarcas.HayMarcas(cadenaC);
            return (total > 0) ? true : false;
        }

        /// <summary>
        /// Método para enviar a la capa de presentación las marcas consultadas en la capa de persistencia.
        /// </summary>
        /// <returns>Matriz de string con los datos de las marcas.</returns>
        public string[,] FormatoMarcas()
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

        /// <summary>
        /// Método que guarda los nombres de las marcas en un arreglo de string.
        /// </summary>
        /// <returns>Arreglo de string con los nombres de las marcas.</returns>
        public string[] NombreMarcas()
        {
            marcas = AdministraMarcas.NombreClaveMarcas(cadenaC);
            string[] nombres = new string[marcas.Count];
            int i = 0;
            foreach(KeyValuePair<string, string> item in marcas)
            {
                nombres[i] = item.Key;
                i++;
            }
            return nombres;
        }

        /// <summary>
        /// Método que comprueba si la marca no ha sido dada de alta.
        /// </summary>
        /// <param name="clave">Clave de la marca.</param>
        /// <param name="nombre">Nombre de la marca.</param>
        /// <param name="datos">Datos de la marca.</param>
        /// <returns></returns>
        public bool AltaMarca(string clave, string nombre, string datos)
        {
            int comprueba = AdministraMarcas.EstaAlta(cadenaC, clave, nombre);
            if (comprueba == 0)
            {
                if (AdministraMarcas.AgregaMarca(cadenaC, clave, nombre, datos))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public string ClaveMarca(string nombre) => marcas[nombre];
    }
}
