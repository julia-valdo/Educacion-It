
namespace WindowsPubs
{
    partial class FormAutores
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
            this.gridAutores = new System.Windows.Forms.DataGridView();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnFiltrarCiudad = new System.Windows.Forms.Button();
            this.btnFiltrarCiudadEstado = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAutores
            // 
            this.gridAutores.AllowUserToAddRows = false;
            this.gridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAutores.Location = new System.Drawing.Point(0, 96);
            this.gridAutores.Name = "gridAutores";
            this.gridAutores.Size = new System.Drawing.Size(800, 354);
            this.gridAutores.TabIndex = 0;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(13, 13);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 1;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(13, 44);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(62, 10);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 3;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(62, 41);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 4;
            // 
            // btnFiltrarCiudad
            // 
            this.btnFiltrarCiudad.Location = new System.Drawing.Point(168, 8);
            this.btnFiltrarCiudad.Name = "btnFiltrarCiudad";
            this.btnFiltrarCiudad.Size = new System.Drawing.Size(143, 23);
            this.btnFiltrarCiudad.TabIndex = 5;
            this.btnFiltrarCiudad.Text = "Filtrar por ciudad";
            this.btnFiltrarCiudad.UseVisualStyleBackColor = true;
            this.btnFiltrarCiudad.Click += new System.EventHandler(this.btnFiltrarCiudad_Click);
            // 
            // btnFiltrarCiudadEstado
            // 
            this.btnFiltrarCiudadEstado.Location = new System.Drawing.Point(168, 38);
            this.btnFiltrarCiudadEstado.Name = "btnFiltrarCiudadEstado";
            this.btnFiltrarCiudadEstado.Size = new System.Drawing.Size(143, 23);
            this.btnFiltrarCiudadEstado.TabIndex = 6;
            this.btnFiltrarCiudadEstado.Text = "Filtrar por ciudad y estado";
            this.btnFiltrarCiudadEstado.UseVisualStyleBackColor = true;
            this.btnFiltrarCiudadEstado.Click += new System.EventHandler(this.btnFiltrarCiudadEstado_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(16, 67);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(489, 23);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "TRAER TODOS";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(384, 25);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cbCiudad.TabIndex = 9;
            this.cbCiudad.SelectionChangeCommitted += new System.EventHandler(this.cbCiudad_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ciudad:";
            // 
            // FormAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnFiltrarCiudadEstado);
            this.Controls.Add(this.btnFiltrarCiudad);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.gridAutores);
            this.Name = "FormAutores";
            this.Text = "FormAutores";
            this.Load += new System.EventHandler(this.FormAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAutores;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnFiltrarCiudad;
        private System.Windows.Forms.Button btnFiltrarCiudadEstado;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label label2;
    }
}

