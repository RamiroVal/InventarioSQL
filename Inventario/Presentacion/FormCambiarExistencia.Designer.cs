
namespace Inventario.Presentacion
{
    partial class FormCambiarExistencia
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
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNuevaExistencia = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNuevaExistencia = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(26, 15);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(115, 13);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Seleccione un Artículo";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(26, 56);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(112, 13);
            this.lblExistencia.TabIndex = 1;
            this.lblExistencia.Text = "Existencia del Artículo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(26, 90);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(26, 129);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Clave";
            // 
            // lblNuevaExistencia
            // 
            this.lblNuevaExistencia.AutoSize = true;
            this.lblNuevaExistencia.Location = new System.Drawing.Point(26, 171);
            this.lblNuevaExistencia.Name = "lblNuevaExistencia";
            this.lblNuevaExistencia.Size = new System.Drawing.Size(125, 13);
            this.lblNuevaExistencia.TabIndex = 4;
            this.lblNuevaExistencia.Text = "Ingrese nueva existencia";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(184, 53);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.ReadOnly = true;
            this.txtExistencia.Size = new System.Drawing.Size(155, 20);
            this.txtExistencia.TabIndex = 5;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(184, 129);
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(155, 20);
            this.txtClave.TabIndex = 6;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(184, 90);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(155, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // txtNuevaExistencia
            // 
            this.txtNuevaExistencia.Location = new System.Drawing.Point(184, 168);
            this.txtNuevaExistencia.Name = "txtNuevaExistencia";
            this.txtNuevaExistencia.Size = new System.Drawing.Size(155, 20);
            this.txtNuevaExistencia.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(29, 212);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(310, 50);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // FormCambiarExistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(373, 278);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNuevaExistencia);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.lblNuevaExistencia);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.lblArticulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 317);
            this.MinimumSize = new System.Drawing.Size(389, 317);
            this.Name = "FormCambiarExistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Existencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNuevaExistencia;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNuevaExistencia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnActualizar;
    }
}