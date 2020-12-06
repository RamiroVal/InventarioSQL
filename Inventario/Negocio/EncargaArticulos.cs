using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Persistencia;

namespace Inventario.Negocio
{
    class EncargaArticulos
    {
        private string cadenaC = "Data Source=LAPTOP-NF0LIA82;Initial Catalog=INVENTARIO;Integrated Security=True";
        private Dictionary<string, string> articulos;

        public EncargaArticulos() => articulos = new Dictionary<string, string>();
        
        /// <summary>
        /// Método para agregar un nuevo artículo.
        /// </summary>
        /// <param name="clave">Clave del artículo.</param>
        /// <param name="marca">Marca del artículo.</param>
        /// <param name="descripcion">Descripción del artículo.</param>
        /// <param name="existencia">Existencia del artículo.</param>
        /// <param name="sExistencia">Estatus siempre en existencia o no.</param>
        /// <param name="precio">Precio del artículo.</param>
        /// <returns>True = se agegó correctamente.</returns>
        public bool AltaArticulo(string clave, string marca, string nombre, int existencia, int sExistencia, double precio )
        {
            int comprueba = AdministraArticulos.EstaArticulo(cadenaC, clave, nombre);
            if (comprueba == 0)
            {
                int agrego = AdministraArticulos.AgregaArticulo(cadenaC, clave, marca, nombre, existencia, sExistencia, precio);
                if (agrego == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Método que determina si hay o no artículos.
        /// </summary>
        /// <returns>True = hay artículos.</returns>
        public bool HayArticulos()
        {
            int a = AdministraArticulos.HayArticulos(cadenaC);
            return (a == 1) ? true : false;
        }

        /// <summary>
        /// Método para dar formato a los datos obtenidos de la consulta a los artículos.
        /// </summary>
        /// <returns>Matriz de string con los datos de los artículos.</returns>
        public string [,] FormatoArticulos()
        {
            Articulo[] articulos = AdministraArticulos.Articulos(cadenaC);
            if (articulos == null)
            {
                return null;
            }
            string[,] datos = new string[articulos.Length, 6];
            for(int i = 0; i < articulos.Length; i++)
            {
                datos[i, 0] = articulos[i].Clave;
                datos[i, 1] = articulos[i].Marca;
                datos[i, 2] = articulos[i].Descripcion;
                datos[i, 3] = articulos[i].Existencia.ToString();
                datos[i, 4] = (articulos[i].SiempreExistencia == 1) ? "VERDADERO" : "FALSO";
                datos[i, 5] = articulos[i].Precio.ToString("C2");
            }
            return datos;
        }

        /// <summary>
        /// Método que guarda todas las descripciones de los artículos en un vector.
        /// </summary>
        /// <returns>Vector de string con las descripciones.</returns>
        public string[] DescripcionArticulos()
        {
            articulos = AdministraArticulos.DescripcionClavesArticulos(cadenaC);
            string[] desc = new string[articulos.Count];
            int i = 0;
            foreach(KeyValuePair<string, string> item in articulos)
            {
                desc[i] = item.Key;
                i++;
            }
            return desc;
        }

        /// <summary>
        /// Método que devuelve un arreglo de string con todos los atributos de un artículo.
        /// </summary>
        /// <param name="clave">Clave del artículo.</param>
        /// <returns>Arreglo de string con los datos.</returns>
        public string[] Articulo(string clave)
        {
            Articulo ar = AdministraArticulos.DatosArticulo(cadenaC, clave);
            string[] articulo = new string[6];
            articulo[0] = ar.Clave;
            articulo[1] = ar.Marca;
            articulo[2] = ar.Descripcion;
            articulo[3] = ar.Existencia.ToString();
            articulo[4] = (ar.SiempreExistencia == 1) ? "VERDADERO" : "FALSO";
            articulo[5] = ar.Precio.ToString("C2");
            return articulo;
        }

        /// <summary>
        /// Método para cambiar la existencia de un artículo.
        /// </summary>
        /// <param name="clave">Clave del artículo.</param>
        /// <param name="nExistencia">Existencia del artículo.</param>
        /// <returns>True = actualización exitosa.</returns>
        public bool CambiarExistencia(string clave, int nExistencia)
        {
            int c = AdministraArticulos.ActualizaExistencia(cadenaC, clave, nExistencia);
            if (c == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ArticulosPorMarca(string claveMarca)
        {
            int cArticulos = AdministraArticulos.ArticulosPorMarca(cadenaC, claveMarca);
            if (cArticulos == -1 || cArticulos == -2)
            {
                return "Error con la base de datos, intentelo más tarde.";
            }
            return cArticulos.ToString();
        }

        /// <summary>
        /// Método que devuelve la clave de un artículo por su descripción.
        /// </summary>
        /// <param name="desc">Descripción del artículo.</param>
        /// <returns>Clave del artículo.</returns>
        public string ClaveArticulo(string desc) => articulos[desc];
    }
}
