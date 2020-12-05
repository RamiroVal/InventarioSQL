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
using System.Text.RegularExpressions;

namespace Inventario.Presentacion
{
    public partial class FormAggArticulos : Form
    {
        private EncargaMarcas m;
        public FormAggArticulos()
        {
            InitializeComponent();
            m = new EncargaMarcas();
            string[] nombres = m.NombreMarcas();
            cmbMarcas.Items.AddRange(nombres);
            cmbMarcas.SelectedIndex = 0;
        }

        #region Eventos Click
        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (HayError())
            {
                if(Validar.ValidaBlanco(txtClave.Text))
                    errorProvider1.SetError(txtClave, "Ingrese clave");
                if(Validar.ValidaBlanco(txtNombre.Text))
                    errorProvider1.SetError(txtNombre, "Ingrese Nombre");
                if(Validar.ValidaBlanco(txtPrecio.Text))
                    errorProvider1.SetError(txtPrecio, "Ingrese Precio");
                if(Validar.ValidaBlanco(txtExistencia.Text))
                    errorProvider1.SetError(txtExistencia, "Ingrese Existencia");
                MessageBox.Show("Hay errores en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Guardar();
            }
        }
        #endregion

        #region Eventos Validated
        private void txtClave_Validated(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            if (Validar.ValidaBlanco(clave))
            {
                errorProvider1.SetError(txtClave, "Ingrese clave");
            }
            else
            {
                errorProvider1.SetError(txtClave, "");
            }
            if (clave.Length != 4)
            {
                errorProvider1.SetError(txtClave, "Ingrese clave");
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (Validar.ValidaBlanco(nombre))
            {
                errorProvider1.SetError(txtNombre, "Ingrese Nombre");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }
        
        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            string precio = txtPrecio.Text;
            bool valido = Double.TryParse(precio, out double s);
            if(Regex.IsMatch(precio, "^[0-9]{1,6}(.[0-9]{1,2})?$"))
            {
                errorProvider1.SetError(txtPrecio, "");
            }
            else
            {
                errorProvider1.SetError(txtPrecio, "Ingrese precio válido (######.##)");
            }
        }
        
        private void txtExistencia_Validated(object sender, EventArgs e)
        {
            string existencia = txtExistencia.Text;
            if (Validar.ValidaBlanco(existencia))
            {
                errorProvider1.SetError(txtExistencia, "Ingrese Existencia");
            }
            else
            {
                errorProvider1.SetError(txtExistencia, "");
            }
            if (chkExistencia.Checked)
            {
                if (existencia == "0")
                {
                    errorProvider1.SetError(txtExistencia, "Ingrese existencia o cambie estatus");
                }
                else
                {
                    errorProvider1.SetError(txtExistencia, "");
                }
            }
        }
        #endregion

        #region Eventos KeyPress
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar.ValidaClave(e.KeyChar))
            {
                errorProvider1.SetError(txtClave, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtClave, "Sólo números");
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar.ValidaNombre(e.KeyChar))
            {
                errorProvider1.SetError(txtNombre, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "Sólo letras");
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete || Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || (char)Keys.Back == e.KeyChar)
            {
                errorProvider1.SetError(txtPrecio, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtPrecio, "Caracter inválido");
                e.Handled = true;
            }
        }

        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar.ValidaClave(e.KeyChar))
            {
                errorProvider1.SetError(txtExistencia, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtExistencia, "Sólo números");
                e.Handled = true;
            }
        }
        #endregion

        #region Utilidades
        private bool HayError()
        {
            if(errorProvider1.GetError(txtClave) != "" || errorProvider1.GetError(txtNombre) != "" || errorProvider1.GetError(txtPrecio) != "" || errorProvider1.GetError(txtExistencia) != "")
            {
                return true;
            }
            return false;
        }

        private void Guardar()
        {
            EncargaArticulos guardar = new EncargaArticulos();
            string clave = txtClave.Text;
            string nMarca = cmbMarcas.SelectedItem.ToString();
            string marca = m.ClaveMarca(nMarca);
            string nombre = txtNombre.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);
            string sExistencia = (chkExistencia.Checked) ? "Verdadero" : "Falso";
            int sExis = (chkExistencia.Checked) ? 1 : 0;
            int existencia = Convert.ToInt32(txtExistencia.Text);
            DialogResult result = MessageBox.Show("Se agregará el´Artículo:" +
                $"\nClave: {clave}" +
                $"\nDescripción: {nombre}" +
                $"\nMarca: {nMarca}" +
                $"\nPrecio: ${precio.ToString("C2")}" +
                $"\nSiempre en existencia: {sExistencia}" +
                $"\nExistencia: {existencia}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (guardar.AltaArticulo(clave, marca, nombre, existencia, sExis, precio))
                {
                    MessageBox.Show($"El artículo {nombre}, ha sido agregado con éxito");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Artículo repetido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txtClave, "Ingrese clave");
                    errorProvider1.SetError(txtNombre, "Ingrese nombre");
                }
            }
        }

        private void Limpiar()
        {
            txtClave.Clear();
            cmbMarcas.SelectedIndex = 0;
            txtNombre.Clear();
            txtPrecio.Clear();
            chkExistencia.Checked = false;
            txtExistencia.Clear();
        }
        #endregion

        private void chkExistencia_CheckedChanged(object sender, EventArgs e)
        {
            string c = txtExistencia.Text;
            if (chkExistencia.Checked)
            {
                if (c == "0")
                {
                    errorProvider1.SetError(txtExistencia, "Ingrese existencia o cambie estatus");
                }
                else
                {
                    errorProvider1.SetError(txtExistencia, "");
                }
            }
        }
    }
}
