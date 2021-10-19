
namespace WindowsAppStaticCollection
{
    partial class frmProducto
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
            this.gridProdcutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdcutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProdcutos
            // 
            this.gridProdcutos.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.gridProdcutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdcutos.GridColor = System.Drawing.Color.PaleVioletRed;
            this.gridProdcutos.Location = new System.Drawing.Point(12, 12);
            this.gridProdcutos.Name = "gridProdcutos";
            this.gridProdcutos.Size = new System.Drawing.Size(776, 366);
            this.gridProdcutos.TabIndex = 0;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 393);
            this.Controls.Add(this.gridProdcutos);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdcutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProdcutos;
    }
}