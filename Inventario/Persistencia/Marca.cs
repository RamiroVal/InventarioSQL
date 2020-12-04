using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Persistencia
{
    public class Marca
    {
        private string clave;
        private string nombre;
        private string datos;

        /// <summary>
        /// Constructor que recibe clave, nombre y datos de la marca.
        /// </summary>
        /// <param name="clave">Clave de la marca.</param>
        /// <param name="nombre">Nombre de la marca.</param>
        /// <param name="datos">Datos de la marca.</param>
        public Marca(string clave, string nombre, string datos)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.datos = datos;
        }

        /// <summary>
        /// Constructor que recibe clave y nombre de marca.
        /// </summary>
        /// <param name="clave">Clave de la marca.</param>
        /// <param name="nombre">Nombre de la marca.</param>
        public Marca(string clave, string nombre)
        {
            this.clave = clave;
            this.nombre = nombre;
        }

        /// <summary>
        /// ToString sobreescrito.
        /// </summary>
        /// <returns>Nombre de la Marca.</returns>
        public override string ToString() => nombre;

        /// <summary>
        /// Propiedad que devuelve clave.
        /// </summary>
        public string Clave => clave;
        
        /// <summary>
        /// Propiedad que devuelve nombre.
        /// </summary>
        public string Nombre => nombre;

        /// <summary>
        /// Propiedad que devuelve datos.
        /// </summary>
        public string Datos => datos;
    }
}
