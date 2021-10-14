
namespace PresentacionWindows
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
            this.btnCrearClinica = new System.Windows.Forms.Button();
            this.btnCrearHabitacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearClinica
            // 
            this.btnCrearClinica.Location = new System.Drawing.Point(12, 12);
            this.btnCrearClinica.Name = "btnCrearClinica";
            this.btnCrearClinica.Size = new System.Drawing.Size(98, 23);
            this.btnCrearClinica.TabIndex = 0;
            this.btnCrearClinica.Text = "Crear Clinica";
            this.btnCrearClinica.UseVisualStyleBackColor = true;
            this.btnCrearClinica.Click += new System.EventHandler(this.btnCrearClinica_Click);
            // 
            // btnCrearHabitacion
            // 
            this.btnCrearHabitacion.Location = new System.Drawing.Point(12, 41);
            this.btnCrearHabitacion.Name = "btnCrearHabitacion";
            this.btnCrearHabitacion.Size = new System.Drawing.Size(98, 23);
            this.btnCrearHabitacion.TabIndex = 1;
            this.btnCrearHabitacion.Text = "Crear Habitacion";
            this.btnCrearHabitacion.UseVisualStyleBackColor = true;
            this.btnCrearHabitacion.Click += new System.EventHandler(this.btnCrearHabitacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearHabitacion);
            this.Controls.Add(this.btnCrearClinica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearClinica;
        private System.Windows.Forms.Button btnCrearHabitacion;
    }
}

