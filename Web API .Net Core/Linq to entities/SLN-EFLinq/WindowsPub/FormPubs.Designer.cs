
namespace WindowsPub
{
    partial class FormPubs
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
            this.gridPubs = new System.Windows.Forms.DataGridView();
            this.btnTraerAutores = new System.Windows.Forms.Button();
            this.btnTraerPublicadores = new System.Windows.Forms.Button();
            this.btnTraerAutoresPorCiudad = new System.Windows.Forms.Button();
            this.btnTraerAutorPorId = new System.Windows.Forms.Button();
            this.btnTraerPublicadorPorNombre = new System.Windows.Forms.Button();
            this.btnMostrarListaSalesStores = new System.Windows.Forms.Button();
            this.btnMostrarListaEmployeePublishers = new System.Windows.Forms.Button();
            this.btnMostrarEmployeeMismoPaisPublisher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPubs)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPubs
            // 
            this.gridPubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPubs.Location = new System.Drawing.Point(12, 100);
            this.gridPubs.Name = "gridPubs";
            this.gridPubs.Size = new System.Drawing.Size(1026, 508);
            this.gridPubs.TabIndex = 0;
            // 
            // btnTraerAutores
            // 
            this.btnTraerAutores.Location = new System.Drawing.Point(13, 13);
            this.btnTraerAutores.Name = "btnTraerAutores";
            this.btnTraerAutores.Size = new System.Drawing.Size(314, 23);
            this.btnTraerAutores.TabIndex = 1;
            this.btnTraerAutores.Text = "TRAER AUTORES";
            this.btnTraerAutores.UseVisualStyleBackColor = true;
            this.btnTraerAutores.Click += new System.EventHandler(this.btnTraerAutores_Click);
            // 
            // btnTraerPublicadores
            // 
            this.btnTraerPublicadores.Location = new System.Drawing.Point(333, 13);
            this.btnTraerPublicadores.Name = "btnTraerPublicadores";
            this.btnTraerPublicadores.Size = new System.Drawing.Size(314, 23);
            this.btnTraerPublicadores.TabIndex = 2;
            this.btnTraerPublicadores.Text = "TRAER PUBLICADORES";
            this.btnTraerPublicadores.UseVisualStyleBackColor = true;
            this.btnTraerPublicadores.Click += new System.EventHandler(this.btnTraerPublicadores_Click);
            // 
            // btnTraerAutoresPorCiudad
            // 
            this.btnTraerAutoresPorCiudad.Location = new System.Drawing.Point(13, 42);
            this.btnTraerAutoresPorCiudad.Name = "btnTraerAutoresPorCiudad";
            this.btnTraerAutoresPorCiudad.Size = new System.Drawing.Size(314, 23);
            this.btnTraerAutoresPorCiudad.TabIndex = 3;
            this.btnTraerAutoresPorCiudad.Text = "TRAER AUTORES QUE VIVEN EN LA MISMA CIUDAD";
            this.btnTraerAutoresPorCiudad.UseVisualStyleBackColor = true;
            this.btnTraerAutoresPorCiudad.Click += new System.EventHandler(this.btnTraerAutoresPorCiudad_Click);
            // 
            // btnTraerAutorPorId
            // 
            this.btnTraerAutorPorId.Location = new System.Drawing.Point(13, 71);
            this.btnTraerAutorPorId.Name = "btnTraerAutorPorId";
            this.btnTraerAutorPorId.Size = new System.Drawing.Size(314, 23);
            this.btnTraerAutorPorId.TabIndex = 4;
            this.btnTraerAutorPorId.Text = "TRAER AUTOR POR SU ID";
            this.btnTraerAutorPorId.UseVisualStyleBackColor = true;
            this.btnTraerAutorPorId.Click += new System.EventHandler(this.btnTraerAutorPorId_Click);
            // 
            // btnTraerPublicadorPorNombre
            // 
            this.btnTraerPublicadorPorNombre.Location = new System.Drawing.Point(334, 42);
            this.btnTraerPublicadorPorNombre.Name = "btnTraerPublicadorPorNombre";
            this.btnTraerPublicadorPorNombre.Size = new System.Drawing.Size(313, 23);
            this.btnTraerPublicadorPorNombre.TabIndex = 5;
            this.btnTraerPublicadorPorNombre.Text = "TRAER PUBLICADOR POR SU NOMBRE";
            this.btnTraerPublicadorPorNombre.UseVisualStyleBackColor = true;
            this.btnTraerPublicadorPorNombre.Click += new System.EventHandler(this.btnTraerPublicadorPorNombre_Click);
            // 
            // btnMostrarListaSalesStores
            // 
            this.btnMostrarListaSalesStores.Location = new System.Drawing.Point(653, 13);
            this.btnMostrarListaSalesStores.Name = "btnMostrarListaSalesStores";
            this.btnMostrarListaSalesStores.Size = new System.Drawing.Size(313, 23);
            this.btnMostrarListaSalesStores.TabIndex = 6;
            this.btnMostrarListaSalesStores.Text = "MOSTRAR PERSONALIZADO SALES-STORES";
            this.btnMostrarListaSalesStores.UseVisualStyleBackColor = true;
            this.btnMostrarListaSalesStores.Click += new System.EventHandler(this.btnMostrarListaSalesStores_Click);
            // 
            // btnMostrarListaEmployeePublishers
            // 
            this.btnMostrarListaEmployeePublishers.Location = new System.Drawing.Point(654, 42);
            this.btnMostrarListaEmployeePublishers.Name = "btnMostrarListaEmployeePublishers";
            this.btnMostrarListaEmployeePublishers.Size = new System.Drawing.Size(312, 23);
            this.btnMostrarListaEmployeePublishers.TabIndex = 7;
            this.btnMostrarListaEmployeePublishers.Text = "MOSTRAR PERSONALIZADO EMPLOYEE-PUBLISHERS";
            this.btnMostrarListaEmployeePublishers.UseVisualStyleBackColor = true;
            this.btnMostrarListaEmployeePublishers.Click += new System.EventHandler(this.btnMostrarListaEmployeePublishers_Click);
            // 
            // btnMostrarEmployeeMismoPaisPublisher
            // 
            this.btnMostrarEmployeeMismoPaisPublisher.Location = new System.Drawing.Point(654, 72);
            this.btnMostrarEmployeeMismoPaisPublisher.Name = "btnMostrarEmployeeMismoPaisPublisher";
            this.btnMostrarEmployeeMismoPaisPublisher.Size = new System.Drawing.Size(312, 23);
            this.btnMostrarEmployeeMismoPaisPublisher.TabIndex = 8;
            this.btnMostrarEmployeeMismoPaisPublisher.Text = "MOSTRAR LISTA EMPLOYEE (mismo pais) -PUBLISHER";
            this.btnMostrarEmployeeMismoPaisPublisher.UseVisualStyleBackColor = true;
            this.btnMostrarEmployeeMismoPaisPublisher.Click += new System.EventHandler(this.btnMostrarEmployeeMismoPaisPublisher_Click);
            // 
            // FormPubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.btnMostrarEmployeeMismoPaisPublisher);
            this.Controls.Add(this.btnMostrarListaEmployeePublishers);
            this.Controls.Add(this.btnMostrarListaSalesStores);
            this.Controls.Add(this.btnTraerPublicadorPorNombre);
            this.Controls.Add(this.btnTraerAutorPorId);
            this.Controls.Add(this.btnTraerAutoresPorCiudad);
            this.Controls.Add(this.btnTraerPublicadores);
            this.Controls.Add(this.btnTraerAutores);
            this.Controls.Add(this.gridPubs);
            this.Name = "FormPubs";
            this.Text = "FormPubs";
            ((System.ComponentModel.ISupportInitialize)(this.gridPubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPubs;
        private System.Windows.Forms.Button btnTraerAutores;
        private System.Windows.Forms.Button btnTraerPublicadores;
        private System.Windows.Forms.Button btnTraerAutoresPorCiudad;
        private System.Windows.Forms.Button btnTraerAutorPorId;
        private System.Windows.Forms.Button btnTraerPublicadorPorNombre;
        private System.Windows.Forms.Button btnMostrarListaSalesStores;
        private System.Windows.Forms.Button btnMostrarListaEmployeePublishers;
        private System.Windows.Forms.Button btnMostrarEmployeeMismoPaisPublisher;
    }
}

