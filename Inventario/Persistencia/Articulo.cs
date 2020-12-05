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

        #region Constructores
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
        /// Constructor vacío.
        /// </summary>
        public Articulo() { }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que obtiene clave.
        /// </summary>
        public string Clave
        {
            get => clave;
            set => clave = value;
        }

        /// <summary>
        /// Propiedad que obtiene marca.
        /// </summary>
        public string Marca
        {
            get => marca;
            set => marca = value;
        }

        /// <summary>
        /// Propiedad que obtiene descripción.
        /// </summary>
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        /// <summary>
        /// Propiedad que obtiene existencia.
        /// </summary>
        public int Existencia
        {
            get => existencia;
            set => existencia = value;
        }

        /// <summary>
        /// Propiedad que obtiene SiempreExistencia.
        /// </summary>
        public int SiempreExistencia
        {
            get => sExistencia;
            set => sExistencia = value;
        }

        /// <summary>
        /// Propiedad que obtiene el precio.
        /// </summary>
        public double Precio
        {
            get => precio;
            set => precio = value;
        }
        #endregion
    }
}
