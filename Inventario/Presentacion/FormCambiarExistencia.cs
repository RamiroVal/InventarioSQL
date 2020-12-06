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
    public partial class FormCambiarExistencia : Form
    {
        private EncargaArticulos art;
        public FormCambiarExistencia()
        {
            InitializeComponent();
            art = new EncargaArticulos();
        }
        
        private void FormCambiarExistencia_Load(object sender, EventArgs e)
        {
            string[] desc = art.DescripcionArticulos();
            cmbArticulos.Items.AddRange(desc);
            cmbArticulos.SelectedIndex = 0;
            try
            {
                string nombre = cmbArticulos.SelectedItem.ToString();
                string clave = art.ClaveArticulo(nombre);
                string[] datos = art.Articulo(clave);
                txtClave.Text = datos[0];
                txtMarca.Text = datos[1];
                txtExistencia.Text = datos[3];
            }
            catch (NullReferenceException) { }
        }

        private void txtNuevaExistencia_Validated(object sender, EventArgs e)
        {
            string ex = txtNuevaExistencia.Text;
            if (Validar.ValidaBlanco(ex))
            {
                errorProvider1.SetError(txtNuevaExistencia, "Ingrese existencia");
            }
            else
            {
                errorProvider1.SetError(txtNuevaExistencia, "");
            }
        }

        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenaInformacion();
        }

        private void cmbArticulos_TextUpdate(object sender, EventArgs e)
        {
            txtClave.Clear();
            txtMarca.Clear();
            txtExistencia.Clear();
            txtSExistencia.Clear();
            errorProvider1.SetError(cmbArticulos, "");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                MessageBox.Show("Seleccione un artículo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(cmbArticulos, "Seleccione un artículo.");
            }
            else
            {
                if (HayErrores())
                {
                    MessageBox.Show("Errores en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nombre = cmbArticulos.SelectedItem.ToString();
                    string clave = art.ClaveArticulo(nombre);
                    int nExistencia = Convert.ToInt32(txtNuevaExistencia.Text);
                    if(txtSExistencia.Text == "VERDADERO" && nExistencia == 0)
                    {
                        DialogResult r = MessageBox.Show("Siempre debe de haber stock del artículo seleccionado, se cambiará a 0. " +
                            "\n¿Desea continuar?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (r == DialogResult.Yes)
                        {
                            bool conf = art.CambiarExistencia(clave, nExistencia);
                            if (conf)
                            {
                                MessageBox.Show($"Se ha cambiado la existencia de {nombre} a {nExistencia}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("Reponer stock a la brevedad.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LlenaInformacion();
                                txtNuevaExistencia.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido actualizar la existencia", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        return;
                    }
                    DialogResult resultado = MessageBox.Show($"Se cambiará la existencia de {nombre} a {nExistencia}.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {
                        bool conf = art.CambiarExistencia(clave, nExistencia);
                        if (conf)
                        {
                            MessageBox.Show($"Se ha cambiado la existencia de {nombre} a {nExistencia}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LlenaInformacion();
                            txtNuevaExistencia.Clear();
                        }
                    }
                }
            }
        }

        private void txtNuevaExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar.ValidaClave(e.KeyChar))
            {
                errorProvider1.SetError(txtNuevaExistencia, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtNuevaExistencia, "Sólo números");
                e.Handled = true;
            }
        }

        private bool HayErrores()
        {
            if (errorProvider1.GetError(txtNuevaExistencia) != "" || errorProvider1.GetError(cmbArticulos) != "")
            {
                return true;
            }
            return false;
        }

        private void LlenaInformacion()
        {
            try
            {
                string nombre = cmbArticulos.SelectedItem.ToString();
                string clave = art.ClaveArticulo(nombre);
                string[] datos = art.Articulo(clave);
                txtClave.Text = datos[0];
                txtMarca.Text = datos[1];
                txtExistencia.Text = datos[3];
                txtSExistencia.Text = datos[4];
                errorProvider1.SetError(cmbArticulos, "");
            }
            catch (NullReferenceException)
            {
                txtClave.Clear();
                txtMarca.Clear();
                txtExistencia.Clear();
                txtSExistencia.Clear();
            }
        }
    }
}
