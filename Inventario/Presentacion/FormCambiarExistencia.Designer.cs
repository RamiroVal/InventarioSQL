
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
            this.components = new System.ComponentModel.Container();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNuevaExistencia = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNuevaExistencia = new System.Windows.Forms.TextBox();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSExistencia = new System.Windows.Forms.TextBox();
            this.lblSExistencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.lblNuevaExistencia.Location = new System.Drawing.Point(26, 203);
            this.lblNuevaExistencia.Name = "lblNuevaExistencia";
            this.lblNuevaExistencia.Size = new System.Drawing.Size(89, 13);
            this.lblNuevaExistencia.TabIndex = 4;
            this.lblNuevaExistencia.Text = "Nueva existencia";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(184, 53);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.ReadOnly = true;
            this.txtExistencia.Size = new System.Drawing.Size(155, 20);
            this.txtExistencia.TabIndex = 5;
            this.txtExistencia.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(184, 129);
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(155, 20);
            this.txtClave.TabIndex = 6;
            this.txtClave.TabStop = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(184, 90);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(155, 20);
            this.txtMarca.TabIndex = 7;
            this.txtMarca.TabStop = false;
            // 
            // txtNuevaExistencia
            // 
            this.txtNuevaExistencia.Location = new System.Drawing.Point(184, 200);
            this.txtNuevaExistencia.Name = "txtNuevaExistencia";
            this.txtNuevaExistencia.Size = new System.Drawing.Size(155, 20);
            this.txtNuevaExistencia.TabIndex = 1;
            this.txtNuevaExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevaExistencia_KeyPress);
            this.txtNuevaExistencia.Validated += new System.EventHandler(this.txtNuevaExistencia_Validated);
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbArticulos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(184, 15);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(155, 21);
            this.cmbArticulos.TabIndex = 0;
            this.cmbArticulos.SelectedIndexChanged += new System.EventHandler(this.cmbArticulos_SelectedIndexChanged);
            this.cmbArticulos.TextUpdate += new System.EventHandler(this.cmbArticulos_TextUpdate);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(28, 249);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(309, 50);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // txtSExistencia
            // 
            this.txtSExistencia.Location = new System.Drawing.Point(184, 164);
            this.txtSExistencia.Name = "txtSExistencia";
            this.txtSExistencia.ReadOnly = true;
            this.txtSExistencia.Size = new System.Drawing.Size(155, 20);
            this.txtSExistencia.TabIndex = 8;
            this.txtSExistencia.TabStop = false;
            // 
            // lblSExistencia
            // 
            this.lblSExistencia.AutoSize = true;
            this.lblSExistencia.Location = new System.Drawing.Point(26, 167);
            this.lblSExistencia.Name = "lblSExistencia";
            this.lblSExistencia.Size = new System.Drawing.Size(110, 13);
            this.lblSExistencia.TabIndex = 9;
            this.lblSExistencia.Text = "Siempre en existencia";
            // 
            // FormCambiarExistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(373, 315);
            this.Controls.Add(this.txtSExistencia);
            this.Controls.Add(this.lblSExistencia);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cmbArticulos);
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
            this.MaximumSize = new System.Drawing.Size(389, 354);
            this.MinimumSize = new System.Drawing.Size(389, 354);
            this.Name = "FormCambiarExistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Existencia";
            this.Load += new System.EventHandler(this.FormCambiarExistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSExistencia;
        private System.Windows.Forms.Label lblSExistencia;
    }
}