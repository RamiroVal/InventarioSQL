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
        
        public bool AltaArticulo(string clave, string marca, string descripcion, int existencia, int sExistencia, double precio )
        {
            int comprueba = AdministraArticulos.EstaArticulo(cadenaC, clave);
            if (comprueba == 0)
            {
                int agrego = AdministraArticulos.AgregaArticulo(cadenaC, clave, marca, descripcion, existencia, sExistencia, precio);
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
                datos[i, 4] = (articulos[i].SiempreExistencia == 1) ? "Verdadero" : "Falso";
                datos[i, 5] = articulos[i].Precio.ToString("C2");
            }
            return datos;
        }
    }
}
