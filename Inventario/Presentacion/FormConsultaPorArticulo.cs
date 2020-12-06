using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Negocio;

namespace Inventario.Presentacion
{
    public partial class FormConsultaPorArticulo : Form
    {
        private EncargaArticulos art;
        public FormConsultaPorArticulo()
        {
            InitializeComponent();
            art = new EncargaArticulos();
        }

        private void FormConsultaPorArticulo_Load(object sender, EventArgs e)
        {
            string[] desc = art.DescripcionArticulos();
            cmbArticulos.Items.AddRange(desc);
            cmbArticulos.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string desc = cmbArticulos.SelectedItem.ToString();
                string clave = art.ClaveArticulo(desc);
                string[] datos = art.Articulo(clave);

                txtClave.Text = datos[0];
                txtMarca.Text = datos[1];
                txtNombre.Text = datos[2];
                txtExistencia.Text = datos[3];
                txtEstatus.Text = datos[4];
                txtPrecio.Text = datos[5];
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Seleccione artículo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(cmbArticulos, "Seleccione artículo válido");
            }
        }

        private void cmbArticulos_TextUpdate(object sender, EventArgs e) => errorProvider1.SetError(cmbArticulos, "");
    }
}
