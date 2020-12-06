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
    public partial class FormInentarioTotal : Form
    {
        private EncargaArticulos dArticulos;
        public FormInentarioTotal()
        {
            InitializeComponent();
            dArticulos = new EncargaArticulos();
        }

        private void FormInentarioTotal_Load(object sender, EventArgs e)
        {
            string[,] articulos = dArticulos.FormatoArticulos();
            if (articulos == null)
            {
                MessageBox.Show("No se han agregado artículos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            for(int i = 0; i < articulos.GetLength(0); i++)
            {
                dataGridView1.Rows.Add(articulos[i, 0], articulos[i, 1], articulos[i, 2], articulos[i, 3], articulos[i, 4], articulos[i, 5]);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "existencia")
            {
                if (Convert.ToInt32(e.Value) <= 3)
                {
                    e.CellStyle.BackColor = Color.Orange;
                    if(Convert.ToInt32(e.Value) <= 1)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
