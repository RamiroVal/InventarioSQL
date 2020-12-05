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
    public partial class FormAggMarcas : Form
    {
        public FormAggMarcas() => InitializeComponent();

        #region Eventos Click
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (HayErrores())
            {
                string clave = txtClave.Text;
                string nombre = txtNombre.Text;
                string datos = txtDatos.Text;
                if (Validar.ValidaBlanco(clave))
                    errorProvider1.SetError(txtClave, "Ingrese clave");
                if(Validar.ValidaBlanco(nombre))
                    errorProvider1.SetError(txtNombre, "Ingrese nombre");
                if(Validar.ValidaBlanco(datos))
                    errorProvider1.SetError(txtDatos, "Ingrese datos");
                MessageBox.Show("Hay campos erroneos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Guardar();
            }
        }
        #endregion

        #region Eventos Validated
        private void textBox1_Validated(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            if (Validar.ValidaBlanco(clave))
            {
                errorProvider1.SetError(txtClave, "Ingrese clave");
                return;
            }
            if (clave.Length != 4)
            {
                errorProvider1.SetError(txtClave, "Clave de 4 dígitos");
                return;
            }
            errorProvider1.SetError(txtClave, "");
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            string nombre = txtNombre.Text;
            if (Validar.ValidaBlanco(nombre))
            {
                errorProvider1.SetError(txtNombre, "Ingrese nombre");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtDatos_Validated(object sender, EventArgs e)
        {
            string datos = txtDatos.Text;
            if (Validar.ValidaBlanco(datos))
            {
                errorProvider1.SetError(txtDatos, "Ingrese datos");
            }
            else
            {
                errorProvider1.SetError(txtDatos, "");
            }
        }
        #endregion

        # region Eventos KeyPress
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validar.ValidaClave(e.KeyChar))
            {
                errorProvider1.SetError(txtClave, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtClave, "Sólo dígitos");
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
        #endregion

        #region Utilidades
        private bool HayErrores()
        {
            if(errorProvider1.GetError(txtClave).Length != 0 || errorProvider1.GetError(txtNombre).Length != 0 || errorProvider1.GetError(txtDatos).Length != 0)
            {
                return true;
            }
            return false;
        }

        private void Guardar()
        {
            EncargaMarcas guarda = new EncargaMarcas();
            string clave = txtClave.Text;
            string nombre = txtNombre.Text;
            string datos = txtDatos.Text;
            DialogResult resultado = MessageBox.Show("Se agregará la Marca:" +
                $"\nMarca: {nombre}" +
                $"\nClave: {clave}" +
                $"\nDatos: {datos}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
            {
                if (guarda.AltaMarca(clave, nombre, datos))
                {
                    MessageBox.Show($"La Marca {nombre}, ha sido agregada.");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Marca repetida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txtClave, "Clave");
                    errorProvider1.SetError(txtNombre, "Nombre");
                }
            }
        }

        private void Limpiar()
        {
            txtClave.Clear();
            txtNombre.Clear();
            txtDatos.Clear();
        }
        #endregion
    }
}
