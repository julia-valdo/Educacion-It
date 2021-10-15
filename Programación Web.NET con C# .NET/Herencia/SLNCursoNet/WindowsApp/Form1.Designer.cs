
namespace WindowsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnCrearEmpresa = new System.Windows.Forms.Button();
            this.btnCrearIndividuo = new System.Windows.Forms.Button();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btnCrearRemito = new System.Windows.Forms.Button();
            this.btnCrearVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(302, 146);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(260, 23);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "Crear Producto";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnCrearEmpresa
            // 
            this.btnCrearEmpresa.Location = new System.Drawing.Point(302, 57);
            this.btnCrearEmpresa.Name = "btnCrearEmpresa";
            this.btnCrearEmpresa.Size = new System.Drawing.Size(260, 23);
            this.btnCrearEmpresa.TabIndex = 1;
            this.btnCrearEmpresa.Text = "Crear Empresa";
            this.btnCrearEmpresa.UseVisualStyleBackColor = true;
            this.btnCrearEmpresa.Click += new System.EventHandler(this.btnCrearEmpresa_Click);
            // 
            // btnCrearIndividuo
            // 
            this.btnCrearIndividuo.Location = new System.Drawing.Point(302, 87);
            this.btnCrearIndividuo.Name = "btnCrearIndividuo";
            this.btnCrearIndividuo.Size = new System.Drawing.Size(260, 23);
            this.btnCrearIndividuo.TabIndex = 2;
            this.btnCrearIndividuo.Text = "Crear Individuo";
            this.btnCrearIndividuo.UseVisualStyleBackColor = true;
            this.btnCrearIndividuo.Click += new System.EventHandler(this.btnCrearIndividuo_Click);
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.Location = new System.Drawing.Point(302, 117);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(260, 23);
            this.btnCrearFactura.TabIndex = 3;
            this.btnCrearFactura.Text = "Crear Factura";
            this.btnCrearFactura.UseVisualStyleBackColor = true;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // btnCrearRemito
            // 
            this.btnCrearRemito.Location = new System.Drawing.Point(302, 175);
            this.btnCrearRemito.Name = "btnCrearRemito";
            this.btnCrearRemito.Size = new System.Drawing.Size(260, 23);
            this.btnCrearRemito.TabIndex = 5;
            this.btnCrearRemito.Text = "Crear Remito";
            this.btnCrearRemito.UseVisualStyleBackColor = true;
            this.btnCrearRemito.Click += new System.EventHandler(this.btnCrearRemito_Click);
            // 
            // btnCrearVendedor
            // 
            this.btnCrearVendedor.Location = new System.Drawing.Point(302, 204);
            this.btnCrearVendedor.Name = "btnCrearVendedor";
            this.btnCrearVendedor.Size = new System.Drawing.Size(260, 23);
            this.btnCrearVendedor.TabIndex = 6;
            this.btnCrearVendedor.Text = "Crear Vendedor";
            this.btnCrearVendedor.UseVisualStyleBackColor = true;
            this.btnCrearVendedor.Click += new System.EventHandler(this.btnCrearVendedor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearVendedor);
            this.Controls.Add(this.btnCrearRemito);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.btnCrearIndividuo);
            this.Controls.Add(this.btnCrearEmpresa);
            this.Controls.Add(this.btnProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnCrearEmpresa;
        private System.Windows.Forms.Button btnCrearIndividuo;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Button btnCrearRemito;
        private System.Windows.Forms.Button btnCrearVendedor;
    }
}

