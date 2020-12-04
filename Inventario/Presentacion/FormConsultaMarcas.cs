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
    public partial class FormConsultaMarcas : Form
    {
        private EncargaMarcas dMarcas;

        public FormConsultaMarcas()
        {
            InitializeComponent();
            dMarcas = new EncargaMarcas();
        }

        private void FormConsultaMarcas_Load(object sender, EventArgs e)
        {
            string[,] marcas = dMarcas.FormatoMarcas();
            if (marcas == null)
            {
                MessageBox.Show("No se han podido mostrar las marcas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for(int i = 0; i < marcas.GetLength(0); i++)
            {
                dataGridView1.Rows.Add(marcas[i, 0], marcas[i, 1], marcas[i, 2]);
            }
        }
    }
}
