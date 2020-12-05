using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Persistencia
{
    public class Articulo
    {
        private string clave;
        private string marca;
        private string descripcion;
        private int existencia;
        private int sExistencia;
        private double precio;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="clave">Clave del artículo.</param>
        /// <param name="marca">Marca del artículo.</param>
        /// <param name="descripcion">Descripción del artículo.</param>
        /// <param name="existencia">Existencia del artículo.</param>
        /// <param name="sExistencia">Siempre en existencia (0 = no, 1 = sí).</param>
        /// <param name="precio">Precio del artículo.</param>
        public Articulo(string clave, string marca, string descripcion, int existencia, int sExistencia, double precio)
        {
            this.clave = clave;
            this.marca = marca;
            this.descripcion = descripcion;
            this.existencia = existencia;
            this.sExistencia = sExistencia;
            this.precio = precio;
        }

        /// <summary>
        /// Propiedad que obtiene clave.
        /// </summary>
        public string Clave => clave;

        /// <summary>
        /// Propiedad que obtiene marca.
        /// </summary>
        public string Marca => marca;

        /// <summary>
        /// Propiedad que obtiene descripción.
        /// </summary>
        public string Descripcion => descripcion;

        /// <summary>
        /// Propiedad que obtiene existencia.
        /// </summary>
        public int Existencia => existencia;

        /// <summary>
        /// Propiedad que obtiene SiempreExistencia.
        /// </summary>
        public int SiempreExistencia => sExistencia;

        /// <summary>
        /// Propiedad que obtiene el precio.
        /// </summary>
        public double Precio => precio;

    }
}
