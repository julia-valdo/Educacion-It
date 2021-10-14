
namespace WindowsFiguras
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
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.btnSupCirculo = new System.Windows.Forms.Button();
            this.btnSupTriangulo = new System.Windows.Forms.Button();
            this.btnSupRectangulo = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(62, 92);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Base";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(59, 121);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(58, 151);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(35, 13);
            this.lblRadio.TabIndex = 2;
            this.lblRadio.Text = "Radio";
            // 
            // btnSupCirculo
            // 
            this.btnSupCirculo.Location = new System.Drawing.Point(61, 190);
            this.btnSupCirculo.Name = "btnSupCirculo";
            this.btnSupCirculo.Size = new System.Drawing.Size(75, 23);
            this.btnSupCirculo.TabIndex = 3;
            this.btnSupCirculo.Text = "Circulo";
            this.btnSupCirculo.UseVisualStyleBackColor = true;
            this.btnSupCirculo.Click += new System.EventHandler(this.btnSupCirculo_Click);
            // 
            // btnSupTriangulo
            // 
            this.btnSupTriangulo.Location = new System.Drawing.Point(224, 190);
            this.btnSupTriangulo.Name = "btnSupTriangulo";
            this.btnSupTriangulo.Size = new System.Drawing.Size(75, 23);
            this.btnSupTriangulo.TabIndex = 4;
            this.btnSupTriangulo.Text = "Triangulo";
            this.btnSupTriangulo.UseVisualStyleBackColor = true;
            this.btnSupTriangulo.Click += new System.EventHandler(this.btnSupTriangulo_Click);
            // 
            // btnSupRectangulo
            // 
            this.btnSupRectangulo.Location = new System.Drawing.Point(142, 190);
            this.btnSupRectangulo.Name = "btnSupRectangulo";
            this.btnSupRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnSupRectangulo.TabIndex = 5;
            this.btnSupRectangulo.Text = "Rectangulo";
            this.btnSupRectangulo.UseVisualStyleBackColor = true;
            this.btnSupRectangulo.Click += new System.EventHandler(this.btnSupRectangulo_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(114, 89);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(185, 20);
            this.txtBase.TabIndex = 6;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(114, 118);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(185, 20);
            this.txtAltura.TabIndex = 7;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(114, 148);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(185, 20);
            this.txtRadio.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btnSupRectangulo);
            this.Controls.Add(this.btnSupTriangulo);
            this.Controls.Add(this.btnSupCirculo);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Button btnSupCirculo;
        private System.Windows.Forms.Button btnSupTriangulo;
        private System.Windows.Forms.Button btnSupRectangulo;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtRadio;
    }
}

