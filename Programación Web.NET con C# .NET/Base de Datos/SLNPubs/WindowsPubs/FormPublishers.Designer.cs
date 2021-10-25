
namespace WindowsPubs
{
    partial class FormPublishers
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
            this.gridPublishers = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnFiltrarCiudadEstado = new System.Windows.Forms.Button();
            this.btnFiltrarCiudad = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnFiltrarCiudadEstadoPais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPublishers
            // 
            this.gridPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublishers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPublishers.Location = new System.Drawing.Point(0, 124);
            this.gridPublishers.Name = "gridPublishers";
            this.gridPublishers.Size = new System.Drawing.Size(800, 326);
            this.gridPublishers.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(19, 95);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(335, 23);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "TRAER TODOS";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnFiltrarCiudadEstado
            // 
            this.btnFiltrarCiudadEstado.Location = new System.Drawing.Point(171, 37);
            this.btnFiltrarCiudadEstado.Name = "btnFiltrarCiudadEstado";
            this.btnFiltrarCiudadEstado.Size = new System.Drawing.Size(183, 23);
            this.btnFiltrarCiudadEstado.TabIndex = 13;
            this.btnFiltrarCiudadEstado.Text = "Filtrar por ciudad y estado";
            this.btnFiltrarCiudadEstado.UseVisualStyleBackColor = true;
            this.btnFiltrarCiudadEstado.Click += new System.EventHandler(this.btnFiltrarCiudadEstado_Click);
            // 
            // btnFiltrarCiudad
            // 
            this.btnFiltrarCiudad.Location = new System.Drawing.Point(171, 7);
            this.btnFiltrarCiudad.Name = "btnFiltrarCiudad";
            this.btnFiltrarCiudad.Size = new System.Drawing.Size(183, 23);
            this.btnFiltrarCiudad.TabIndex = 12;
            this.btnFiltrarCiudad.Text = "Filtrar por ciudad";
            this.btnFiltrarCiudad.UseVisualStyleBackColor = true;
            this.btnFiltrarCiudad.Click += new System.EventHandler(this.btnFiltrarCiudad_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(65, 40);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 11;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(65, 9);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 43);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(16, 12);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(16, 70);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(30, 13);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Text = "Pais:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(65, 67);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 16;
            // 
            // btnFiltrarCiudadEstadoPais
            // 
            this.btnFiltrarCiudadEstadoPais.Location = new System.Drawing.Point(171, 66);
            this.btnFiltrarCiudadEstadoPais.Name = "btnFiltrarCiudadEstadoPais";
            this.btnFiltrarCiudadEstadoPais.Size = new System.Drawing.Size(183, 23);
            this.btnFiltrarCiudadEstadoPais.TabIndex = 17;
            this.btnFiltrarCiudadEstadoPais.Text = "Filtrar por ciudad, estado y pais";
            this.btnFiltrarCiudadEstadoPais.UseVisualStyleBackColor = true;
            this.btnFiltrarCiudadEstadoPais.Click += new System.EventHandler(this.btnFiltrarCiudadEstadoPais_Click);
            // 
            // FormPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltrarCiudadEstadoPais);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnFiltrarCiudadEstado);
            this.Controls.Add(this.btnFiltrarCiudad);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.gridPublishers);
            this.Name = "FormPublishers";
            this.Text = "FormPublishers";
            this.Load += new System.EventHandler(this.FormPublishers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPublishers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPublishers;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnFiltrarCiudadEstado;
        private System.Windows.Forms.Button btnFiltrarCiudad;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnFiltrarCiudadEstadoPais;
    }
}