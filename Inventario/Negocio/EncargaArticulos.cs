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
    }
}
