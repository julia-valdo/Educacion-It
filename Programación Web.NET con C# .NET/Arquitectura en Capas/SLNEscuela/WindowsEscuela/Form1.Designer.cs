
namespace WindowsEscuela
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
            this.btnCrearProfesor = new System.Windows.Forms.Button();
            this.btnCrearAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearProfesor
            // 
            this.btnCrearProfesor.Location = new System.Drawing.Point(323, 129);
            this.btnCrearProfesor.Name = "btnCrearProfesor";
            this.btnCrearProfesor.Size = new System.Drawing.Size(146, 23);
            this.btnCrearProfesor.TabIndex = 0;
            this.btnCrearProfesor.Text = "Crear Profesor";
            this.btnCrearProfesor.UseVisualStyleBackColor = true;
            this.btnCrearProfesor.Click += new System.EventHandler(this.btnCrearProfesor_Click);
            // 
            // btnCrearAlumno
            // 
            this.btnCrearAlumno.Location = new System.Drawing.Point(323, 158);
            this.btnCrearAlumno.Name = "btnCrearAlumno";
            this.btnCrearAlumno.Size = new System.Drawing.Size(146, 23);
            this.btnCrearAlumno.TabIndex = 1;
            this.btnCrearAlumno.Text = "Crear Alumno";
            this.btnCrearAlumno.UseVisualStyleBackColor = true;
            this.btnCrearAlumno.Click += new System.EventHandler(this.btnCrearAlumno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearAlumno);
            this.Controls.Add(this.btnCrearProfesor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProfesor;
        private System.Windows.Forms.Button btnCrearAlumno;
    }
}

