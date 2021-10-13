
namespace WindowsConcesionaria
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
            this.btnCrearAuto = new System.Windows.Forms.Button();
            this.btnCrearCamioneta = new System.Windows.Forms.Button();
            this.btnCrearMoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearAuto
            // 
            this.btnCrearAuto.Location = new System.Drawing.Point(292, 104);
            this.btnCrearAuto.Name = "btnCrearAuto";
            this.btnCrearAuto.Size = new System.Drawing.Size(145, 23);
            this.btnCrearAuto.TabIndex = 0;
            this.btnCrearAuto.Text = "Crear Auto";
            this.btnCrearAuto.UseVisualStyleBackColor = true;
            this.btnCrearAuto.Click += new System.EventHandler(this.btnCrearAuto_Click);
            // 
            // btnCrearCamioneta
            // 
            this.btnCrearCamioneta.Location = new System.Drawing.Point(292, 134);
            this.btnCrearCamioneta.Name = "btnCrearCamioneta";
            this.btnCrearCamioneta.Size = new System.Drawing.Size(145, 23);
            this.btnCrearCamioneta.TabIndex = 1;
            this.btnCrearCamioneta.Text = "Crear Camioneta";
            this.btnCrearCamioneta.UseVisualStyleBackColor = true;
            this.btnCrearCamioneta.Click += new System.EventHandler(this.btnCrearCamioneta_Click);
            // 
            // btnCrearMoto
            // 
            this.btnCrearMoto.Location = new System.Drawing.Point(292, 163);
            this.btnCrearMoto.Name = "btnCrearMoto";
            this.btnCrearMoto.Size = new System.Drawing.Size(145, 23);
            this.btnCrearMoto.TabIndex = 0;
            this.btnCrearMoto.Text = "Crear Moto";
            this.btnCrearMoto.Click += new System.EventHandler(this.btnCrearMoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearMoto);
            this.Controls.Add(this.btnCrearCamioneta);
            this.Controls.Add(this.btnCrearAuto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearAuto;
        private System.Windows.Forms.Button btnCrearCamioneta;
        private System.Windows.Forms.Button btnCrearMoto;
    }
}

