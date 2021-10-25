
namespace WindowsDataReader
{
    partial class FormDatos
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
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.btnTraerPorCategoriaID = new System.Windows.Forms.Button();
            this.lblCategoriaID = new System.Windows.Forms.Label();
            this.txtCategoriaID = new System.Windows.Forms.TextBox();
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridProductos.Location = new System.Drawing.Point(0, 38);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(1060, 570);
            this.gridProductos.TabIndex = 3;
            // 
            // btnTraerPorCategoriaID
            // 
            this.btnTraerPorCategoriaID.Location = new System.Drawing.Point(233, 9);
            this.btnTraerPorCategoriaID.Name = "btnTraerPorCategoriaID";
            this.btnTraerPorCategoriaID.Size = new System.Drawing.Size(75, 23);
            this.btnTraerPorCategoriaID.TabIndex = 4;
            this.btnTraerPorCategoriaID.Text = "Buscar";
            this.btnTraerPorCategoriaID.UseVisualStyleBackColor = true;
            this.btnTraerPorCategoriaID.Click += new System.EventHandler(this.btnTraerPorCategoriaID_Click);
            // 
            // lblCategoriaID
            // 
            this.lblCategoriaID.AutoSize = true;
            this.lblCategoriaID.CausesValidation = false;
            this.lblCategoriaID.Location = new System.Drawing.Point(9, 14);
            this.lblCategoriaID.Name = "lblCategoriaID";
            this.lblCategoriaID.Size = new System.Drawing.Size(112, 13);
            this.lblCategoriaID.TabIndex = 6;
            this.lblCategoriaID.Text = "Traer por CategoriaID:";
            // 
            // txtCategoriaID
            // 
            this.txtCategoriaID.Location = new System.Drawing.Point(127, 11);
            this.txtCategoriaID.Name = "txtCategoriaID";
            this.txtCategoriaID.Size = new System.Drawing.Size(100, 20);
            this.txtCategoriaID.TabIndex = 8;
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.BackColor = System.Drawing.Color.Orange;
            this.btnTraerTodos.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnTraerTodos.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTraerTodos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTraerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerTodos.ForeColor = System.Drawing.Color.White;
            this.btnTraerTodos.Location = new System.Drawing.Point(911, 9);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(137, 23);
            this.btnTraerTodos.TabIndex = 9;
            this.btnTraerTodos.Text = "TRAER TODOS";
            this.btnTraerTodos.UseVisualStyleBackColor = false;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(420, 11);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 10;
            this.cbCategoria.SelectionChangeCommitted += new System.EventHandler(this.cbCategoria_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtrar por categoria:";
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.txtCategoriaID);
            this.Controls.Add(this.lblCategoriaID);
            this.Controls.Add(this.btnTraerPorCategoriaID);
            this.Controls.Add(this.gridProductos);
            this.Name = "FormDatos";
            this.Text = "FormDatos";
            this.Load += new System.EventHandler(this.FormDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Button btnTraerPorCategoriaID;
        private System.Windows.Forms.Label lblCategoriaID;
        private System.Windows.Forms.TextBox txtCategoriaID;
        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label1;
    }
}