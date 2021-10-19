
namespace WindowsAppStaticCollection
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
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnCrearClientes = new System.Windows.Forms.Button();
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.lstMostrarNombres = new System.Windows.Forms.ListBox();
            this.btnMostrarNombres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(12, 12);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 0;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnCrearClientes
            // 
            this.btnCrearClientes.Location = new System.Drawing.Point(12, 41);
            this.btnCrearClientes.Name = "btnCrearClientes";
            this.btnCrearClientes.Size = new System.Drawing.Size(151, 23);
            this.btnCrearClientes.TabIndex = 1;
            this.btnCrearClientes.Text = "Crear clientes";
            this.btnCrearClientes.UseVisualStyleBackColor = true;
            this.btnCrearClientes.Click += new System.EventHandler(this.btnCrearClientes_Click);
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Location = new System.Drawing.Point(12, 101);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(151, 23);
            this.btnCrearLista.TabIndex = 2;
            this.btnCrearLista.Text = "Crear lista de clientes";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            this.btnCrearLista.Click += new System.EventHandler(this.btnCrearLista_Click);
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(12, 130);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(520, 268);
            this.gridClientes.TabIndex = 3;
            // 
            // lstMostrarNombres
            // 
            this.lstMostrarNombres.FormattingEnabled = true;
            this.lstMostrarNombres.Location = new System.Drawing.Point(558, 130);
            this.lstMostrarNombres.Name = "lstMostrarNombres";
            this.lstMostrarNombres.Size = new System.Drawing.Size(151, 264);
            this.lstMostrarNombres.TabIndex = 4;
            // 
            // btnMostrarNombres
            // 
            this.btnMostrarNombres.Location = new System.Drawing.Point(558, 101);
            this.btnMostrarNombres.Name = "btnMostrarNombres";
            this.btnMostrarNombres.Size = new System.Drawing.Size(151, 23);
            this.btnMostrarNombres.TabIndex = 5;
            this.btnMostrarNombres.Text = "Mostrar nombres";
            this.btnMostrarNombres.UseVisualStyleBackColor = true;
            this.btnMostrarNombres.Click += new System.EventHandler(this.btnMostrarNombres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 410);
            this.Controls.Add(this.btnMostrarNombres);
            this.Controls.Add(this.lstMostrarNombres);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.btnCrearLista);
            this.Controls.Add(this.btnCrearClientes);
            this.Controls.Add(this.btnSumar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnCrearClientes;
        private System.Windows.Forms.Button btnCrearLista;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.ListBox lstMostrarNombres;
        private System.Windows.Forms.Button btnMostrarNombres;
    }
}

