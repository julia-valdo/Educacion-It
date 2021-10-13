
namespace WindowsPOOClinica
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
            this.btnCrearMedico = new System.Windows.Forms.Button();
            this.btnCrearEnfermero = new System.Windows.Forms.Button();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.btnCrearDirector = new System.Windows.Forms.Button();
            this.btnCrearClinica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearMedico
            // 
            this.btnCrearMedico.Location = new System.Drawing.Point(465, 200);
            this.btnCrearMedico.Name = "btnCrearMedico";
            this.btnCrearMedico.Size = new System.Drawing.Size(148, 23);
            this.btnCrearMedico.TabIndex = 0;
            this.btnCrearMedico.Text = "Crear Medico";
            this.btnCrearMedico.UseVisualStyleBackColor = true;
            this.btnCrearMedico.Click += new System.EventHandler(this.btnCrearMedico_Click);
            // 
            // btnCrearEnfermero
            // 
            this.btnCrearEnfermero.Location = new System.Drawing.Point(465, 230);
            this.btnCrearEnfermero.Name = "btnCrearEnfermero";
            this.btnCrearEnfermero.Size = new System.Drawing.Size(148, 23);
            this.btnCrearEnfermero.TabIndex = 1;
            this.btnCrearEnfermero.Text = "Crear Enfermero";
            this.btnCrearEnfermero.UseVisualStyleBackColor = true;
            this.btnCrearEnfermero.Click += new System.EventHandler(this.btnCrearEnfermero_Click);
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Location = new System.Drawing.Point(465, 260);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(148, 23);
            this.btnCrearPaciente.TabIndex = 2;
            this.btnCrearPaciente.Text = "Crear Paciente";
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // btnCrearDirector
            // 
            this.btnCrearDirector.Location = new System.Drawing.Point(465, 290);
            this.btnCrearDirector.Name = "btnCrearDirector";
            this.btnCrearDirector.Size = new System.Drawing.Size(148, 23);
            this.btnCrearDirector.TabIndex = 3;
            this.btnCrearDirector.Text = "Crear Director";
            this.btnCrearDirector.UseVisualStyleBackColor = true;
            this.btnCrearDirector.Click += new System.EventHandler(this.btnCrearDirector_Click);
            // 
            // btnCrearClinica
            // 
            this.btnCrearClinica.Location = new System.Drawing.Point(465, 320);
            this.btnCrearClinica.Name = "btnCrearClinica";
            this.btnCrearClinica.Size = new System.Drawing.Size(148, 23);
            this.btnCrearClinica.TabIndex = 4;
            this.btnCrearClinica.Text = "Crear Clinica";
            this.btnCrearClinica.UseVisualStyleBackColor = true;
            this.btnCrearClinica.Click += new System.EventHandler(this.btnCrearClinica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 699);
            this.Controls.Add(this.btnCrearClinica);
            this.Controls.Add(this.btnCrearDirector);
            this.Controls.Add(this.btnCrearPaciente);
            this.Controls.Add(this.btnCrearEnfermero);
            this.Controls.Add(this.btnCrearMedico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearMedico;
        private System.Windows.Forms.Button btnCrearEnfermero;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.Button btnCrearDirector;
        private System.Windows.Forms.Button btnCrearClinica;
    }
}

