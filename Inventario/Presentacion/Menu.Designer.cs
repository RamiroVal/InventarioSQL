
namespace Inventario.Presentacion
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.modificacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.catálogosToolStripMenuItem.Text = "Altas";
            this.catálogosToolStripMenuItem.Click += new System.EventHandler(this.catálogosToolStripMenuItem_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.artículosToolStripMenuItem.Text = "Artículos";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioTotalToolStripMenuItem,
            this.consultaPorArtículosToolStripMenuItem,
            this.consultaMarcasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // inventarioTotalToolStripMenuItem
            // 
            this.inventarioTotalToolStripMenuItem.Name = "inventarioTotalToolStripMenuItem";
            this.inventarioTotalToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.inventarioTotalToolStripMenuItem.Text = "Inventario Total";
            // 
            // consultaPorArtículosToolStripMenuItem
            // 
            this.consultaPorArtículosToolStripMenuItem.Name = "consultaPorArtículosToolStripMenuItem";
            this.consultaPorArtículosToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.consultaPorArtículosToolStripMenuItem.Text = "Consulta Por Artículos";
            // 
            // consultaMarcasToolStripMenuItem
            // 
            this.consultaMarcasToolStripMenuItem.Name = "consultaMarcasToolStripMenuItem";
            this.consultaMarcasToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.consultaMarcasToolStripMenuItem.Text = "Consulta Marcas";
            this.consultaMarcasToolStripMenuItem.Click += new System.EventHandler(this.consultaMarcasToolStripMenuItem_Click);
            // 
            // modificacionesToolStripMenuItem
            // 
            this.modificacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarExistenciaToolStripMenuItem,
            this.eliminarMarcaToolStripMenuItem});
            this.modificacionesToolStripMenuItem.Name = "modificacionesToolStripMenuItem";
            this.modificacionesToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.modificacionesToolStripMenuItem.Text = "Modificaciones";
            // 
            // cambiarExistenciaToolStripMenuItem
            // 
            this.cambiarExistenciaToolStripMenuItem.Name = "cambiarExistenciaToolStripMenuItem";
            this.cambiarExistenciaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.cambiarExistenciaToolStripMenuItem.Text = "Cambiar Existencia";
            // 
            // eliminarMarcaToolStripMenuItem
            // 
            this.eliminarMarcaToolStripMenuItem.Name = "eliminarMarcaToolStripMenuItem";
            this.eliminarMarcaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.eliminarMarcaToolStripMenuItem.Text = "Eliminar Marca";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(745, 234);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(763, 281);
            this.MinimumSize = new System.Drawing.Size(763, 281);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Inventario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPorArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarExistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarcaToolStripMenuItem;
    }
}