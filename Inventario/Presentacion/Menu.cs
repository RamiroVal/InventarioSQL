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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void catálogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAggMarcas m = new FormAggMarcas();
            m.ShowDialog();
        }

        private void consultaMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncargaMarcas a = new EncargaMarcas();
            bool hay = a.HayMarcas();
            if (hay)
            {
                FormConsultaMarcas m = new FormConsultaMarcas();
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han agregado marcas.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncargaMarcas a = new EncargaMarcas();
            bool hay = a.HayMarcas();
            if (hay)
            {
                FormAggArticulos f = new FormAggArticulos();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han agregado marcas, agregue una primero.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void inventarioTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncargaArticulos a = new EncargaArticulos();
            bool hay = a.HayArticulos();
            if (hay)
            {
                FormInentarioTotal i = new FormInentarioTotal();
                i.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han añadido artículos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void consultaPorArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncargaArticulos a = new EncargaArticulos();
            bool hay = a.HayArticulos();
            if (hay)
            {
                FormConsultaPorArticulo i = new FormConsultaPorArticulo();
                i.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han añadido artículos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cambiarExistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncargaArticulos a = new EncargaArticulos();
            bool hay = a.HayArticulos();
            if (hay)
            {
                FormCambiarExistencia i = new FormCambiarExistencia();
                i.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han añadido artículos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
