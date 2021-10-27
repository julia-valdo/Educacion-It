
namespace WindowsDataReader
{
    partial class FormException
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
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnDemoExceptionSQL = new System.Windows.Forms.Button();
            this.btnDemoThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(13, 12);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Exception";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnDemoExceptionSQL
            // 
            this.btnDemoExceptionSQL.Location = new System.Drawing.Point(13, 42);
            this.btnDemoExceptionSQL.Name = "btnDemoExceptionSQL";
            this.btnDemoExceptionSQL.Size = new System.Drawing.Size(152, 23);
            this.btnDemoExceptionSQL.TabIndex = 1;
            this.btnDemoExceptionSQL.Text = "Demo Exception SQL";
            this.btnDemoExceptionSQL.UseVisualStyleBackColor = true;
            this.btnDemoExceptionSQL.Click += new System.EventHandler(this.btnDemoExceptionSQL_Click);
            // 
            // btnDemoThrow
            // 
            this.btnDemoThrow.Location = new System.Drawing.Point(13, 71);
            this.btnDemoThrow.Name = "btnDemoThrow";
            this.btnDemoThrow.Size = new System.Drawing.Size(92, 23);
            this.btnDemoThrow.TabIndex = 2;
            this.btnDemoThrow.Text = "Demo Throw";
            this.btnDemoThrow.UseVisualStyleBackColor = true;
            this.btnDemoThrow.Click += new System.EventHandler(this.btnDemoThrow_Click);
            // 
            // FormException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDemoThrow);
            this.Controls.Add(this.btnDemoExceptionSQL);
            this.Controls.Add(this.btnPrueba);
            this.Name = "FormException";
            this.Text = "FormException";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Button btnDemoExceptionSQL;
        private System.Windows.Forms.Button btnDemoThrow;
    }
}