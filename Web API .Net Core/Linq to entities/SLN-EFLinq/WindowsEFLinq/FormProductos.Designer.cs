
namespace WindowsEFLinq
{
    partial class FormProductos
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
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.btnTraerPorCategoria = new System.Windows.Forms.Button();
            this.btnTraerPorNombreProducto = new System.Windows.Forms.Button();
            this.btnTraerPorId = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.btnTraerProductoCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(12, 12);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(592, 23);
            this.btnTraerTodos.TabIndex = 0;
            this.btnTraerTodos.Text = "TRAER TODOS LOS PRODUCTOS";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // btnTraerPorCategoria
            // 
            this.btnTraerPorCategoria.Location = new System.Drawing.Point(11, 41);
            this.btnTraerPorCategoria.Name = "btnTraerPorCategoria";
            this.btnTraerPorCategoria.Size = new System.Drawing.Size(294, 23);
            this.btnTraerPorCategoria.TabIndex = 1;
            this.btnTraerPorCategoria.Text = "TRAER TODOS LOS PRODUCTOS POR CATEGORIA";
            this.btnTraerPorCategoria.UseVisualStyleBackColor = true;
            this.btnTraerPorCategoria.Click += new System.EventHandler(this.btnTraerPorCategoria_Click);
            // 
            // btnTraerPorNombreProducto
            // 
            this.btnTraerPorNombreProducto.Location = new System.Drawing.Point(311, 42);
            this.btnTraerPorNombreProducto.Name = "btnTraerPorNombreProducto";
            this.btnTraerPorNombreProducto.Size = new System.Drawing.Size(293, 23);
            this.btnTraerPorNombreProducto.TabIndex = 2;
            this.btnTraerPorNombreProducto.Text = "TRAER POR NOMBRE DE PRODUCTO";
            this.btnTraerPorNombreProducto.UseVisualStyleBackColor = true;
            this.btnTraerPorNombreProducto.Click += new System.EventHandler(this.btnTraerPorNombreProducto_Click);
            // 
            // btnTraerPorId
            // 
            this.btnTraerPorId.Location = new System.Drawing.Point(311, 71);
            this.btnTraerPorId.Name = "btnTraerPorId";
            this.btnTraerPorId.Size = new System.Drawing.Size(293, 23);
            this.btnTraerPorId.TabIndex = 3;
            this.btnTraerPorId.Text = "TRAER POR ID";
            this.btnTraerPorId.UseVisualStyleBackColor = true;
            this.btnTraerPorId.Click += new System.EventHandler(this.btnTraerPorId_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(12, 100);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(1144, 467);
            this.gridProductos.TabIndex = 4;
            // 
            // btnTraerProductoCategoria
            // 
            this.btnTraerProductoCategoria.Location = new System.Drawing.Point(12, 70);
            this.btnTraerProductoCategoria.Name = "btnTraerProductoCategoria";
            this.btnTraerProductoCategoria.Size = new System.Drawing.Size(293, 23);
            this.btnTraerProductoCategoria.TabIndex = 5;
            this.btnTraerProductoCategoria.Text = "TRAER PRODUCTO-CATEGORIA";
            this.btnTraerProductoCategoria.UseVisualStyleBackColor = true;
            this.btnTraerProductoCategoria.Click += new System.EventHandler(this.btnTraerProductoCategoria_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 579);
            this.Controls.Add(this.btnTraerProductoCategoria);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnTraerPorId);
            this.Controls.Add(this.btnTraerPorNombreProducto);
            this.Controls.Add(this.btnTraerPorCategoria);
            this.Controls.Add(this.btnTraerTodos);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.Button btnTraerPorCategoria;
        private System.Windows.Forms.Button btnTraerPorNombreProducto;
        private System.Windows.Forms.Button btnTraerPorId;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Button btnTraerProductoCategoria;
    }
}

