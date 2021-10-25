
namespace WindowsDataReader
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
            this.btnTraerProductos = new System.Windows.Forms.Button();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerProductos
            // 
            this.btnTraerProductos.BackColor = System.Drawing.SystemColors.Control;
            this.btnTraerProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraerProductos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTraerProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraerProductos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTraerProductos.Location = new System.Drawing.Point(0, 0);
            this.btnTraerProductos.Name = "btnTraerProductos";
            this.btnTraerProductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTraerProductos.Size = new System.Drawing.Size(1090, 48);
            this.btnTraerProductos.TabIndex = 0;
            this.btnTraerProductos.Text = "TRAER PRODUCTOS";
            this.btnTraerProductos.UseVisualStyleBackColor = false;
            this.btnTraerProductos.Click += new System.EventHandler(this.btnTraerProductos_Click);
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridProductos.Location = new System.Drawing.Point(0, 54);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(1090, 582);
            this.gridProductos.TabIndex = 1;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 636);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.btnTraerProductos);
            this.Name = "FormProductos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerProductos;
        private System.Windows.Forms.DataGridView gridProductos;
    }
}

