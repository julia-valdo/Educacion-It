
namespace WindowsMedicos
{
    partial class FormMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNroMatricula = new System.Windows.Forms.Label();
            this.txtNroMatricula = new System.Windows.Forms.TextBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.lblTraerEspecialidad = new System.Windows.Forms.Label();
            this.cbTraerEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtCrearEspecialidad = new System.Windows.Forms.TextBox();
            this.btnCrearEspecialidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(13, 43);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(111, 40);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblNroMatricula
            // 
            this.lblNroMatricula.AutoSize = true;
            this.lblNroMatricula.Location = new System.Drawing.Point(13, 69);
            this.lblNroMatricula.Name = "lblNroMatricula";
            this.lblNroMatricula.Size = new System.Drawing.Size(92, 13);
            this.lblNroMatricula.TabIndex = 4;
            this.lblNroMatricula.Text = "Numero matricula:";
            this.lblNroMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNroMatricula
            // 
            this.txtNroMatricula.Location = new System.Drawing.Point(111, 66);
            this.txtNroMatricula.Name = "txtNroMatricula";
            this.txtNroMatricula.Size = new System.Drawing.Size(121, 20);
            this.txtNroMatricula.TabIndex = 5;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(111, 93);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cbEspecialidad.TabIndex = 6;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(13, 96);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 7;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(111, 121);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gridMedicos
            // 
            this.gridMedicos.AllowUserToAddRows = false;
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMedicos.Location = new System.Drawing.Point(0, 150);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(800, 300);
            this.gridMedicos.TabIndex = 9;
            // 
            // lblTraerEspecialidad
            // 
            this.lblTraerEspecialidad.AutoSize = true;
            this.lblTraerEspecialidad.Location = new System.Drawing.Point(546, 126);
            this.lblTraerEspecialidad.Name = "lblTraerEspecialidad";
            this.lblTraerEspecialidad.Size = new System.Drawing.Size(115, 13);
            this.lblTraerEspecialidad.TabIndex = 10;
            this.lblTraerEspecialidad.Text = "Traer por especialidad:";
            // 
            // cbTraerEspecialidad
            // 
            this.cbTraerEspecialidad.FormattingEnabled = true;
            this.cbTraerEspecialidad.Location = new System.Drawing.Point(667, 123);
            this.cbTraerEspecialidad.Name = "cbTraerEspecialidad";
            this.cbTraerEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cbTraerEspecialidad.TabIndex = 11;
            this.cbTraerEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cbTraerEspecialidad_SelectionChangeCommitted);
            // 
            // txtCrearEspecialidad
            // 
            this.txtCrearEspecialidad.Location = new System.Drawing.Point(549, 17);
            this.txtCrearEspecialidad.Name = "txtCrearEspecialidad";
            this.txtCrearEspecialidad.Size = new System.Drawing.Size(239, 20);
            this.txtCrearEspecialidad.TabIndex = 12;
            // 
            // btnCrearEspecialidad
            // 
            this.btnCrearEspecialidad.Location = new System.Drawing.Point(549, 44);
            this.btnCrearEspecialidad.Name = "btnCrearEspecialidad";
            this.btnCrearEspecialidad.Size = new System.Drawing.Size(239, 23);
            this.btnCrearEspecialidad.TabIndex = 13;
            this.btnCrearEspecialidad.Text = "Crear especialidad";
            this.btnCrearEspecialidad.UseVisualStyleBackColor = true;
            this.btnCrearEspecialidad.Click += new System.EventHandler(this.btnCrearEspecialidad_Click);
            // 
            // FormMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearEspecialidad);
            this.Controls.Add(this.txtCrearEspecialidad);
            this.Controls.Add(this.cbTraerEspecialidad);
            this.Controls.Add(this.lblTraerEspecialidad);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.txtNroMatricula);
            this.Controls.Add(this.lblNroMatricula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormMedicos";
            this.Text = "FormMedicos";
            this.Load += new System.EventHandler(this.FormMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNroMatricula;
        private System.Windows.Forms.TextBox txtNroMatricula;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.Label lblTraerEspecialidad;
        private System.Windows.Forms.ComboBox cbTraerEspecialidad;
        private System.Windows.Forms.TextBox txtCrearEspecialidad;
        private System.Windows.Forms.Button btnCrearEspecialidad;
    }
}