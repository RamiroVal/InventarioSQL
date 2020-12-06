using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validaciones;
using Inventario.Negocio;

namespace Inventario.Presentacion
{
    public partial class FormEliminarMarca : Form
    {
        private EncargaMarcas m;
        private EncargaArticulos art;
        public FormEliminarMarca()
        {
            InitializeComponent();
            m = new EncargaMarcas();
            art = new EncargaArticulos();
        }

        private void FormEliminarMarca_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            LlenarInformacion();
        }

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarInformacion();
            errorProvider1.SetError(cmbMarcas, "");
        }

        private void LlenarInformacion()
        {
            try
            {
                string nombre = cmbMarcas.SelectedItem.ToString();
                string clave = m.ClaveMarca(nombre);
                string cantidad = art.ArticulosPorMarca(clave);
                string datos = m.ProveedorMarca(clave);

                txtClave.Text = clave;
                txtNombre.Text = nombre;
                txtArticulos.Text = cantidad;
                txtDatos.Text = datos;
            }
            catch (NullReferenceException) 
            {
                txtClave.Clear();
                txtDatos.Clear();
                txtNombre.Clear();
                txtArticulos.Clear();
            }
        }

        private void LlenarCombo()
        {
            string[] marcas = m.NombreMarcas();
            cmbMarcas.Items.AddRange(marcas);
            cmbMarcas.SelectedIndex = 0;
        }

        private void cmbMarcas_TextUpdate(object sender, EventArgs e)
        {
            txtClave.Clear();
            txtDatos.Clear();
            txtNombre.Clear();
            txtArticulos.Clear();
            errorProvider1.SetError(cmbMarcas, "");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            if (Validar.ValidaBlanco(clave))
            {
                MessageBox.Show("Seleccione una marca válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(cmbMarcas, "Seleccione marca válida");
            }
            else
            {
                int art = Convert.ToInt32(txtArticulos.Text);
                string nombre = cmbMarcas.SelectedItem.ToString();
                DialogResult result = MessageBox.Show($"Se eliminará la marca {nombre}.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    bool conf = m.EliminarMarca(clave, art);
                    if (conf)
                    {
                        MessageBox.Show($"La marca {nombre} se ha eliminado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbMarcas.Items.Clear();
                        LlenarCombo();
                        cmbMarcas.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show($"No se puede eliminar la marca {nombre} ya que tiene artículos asociados.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
    }
}
