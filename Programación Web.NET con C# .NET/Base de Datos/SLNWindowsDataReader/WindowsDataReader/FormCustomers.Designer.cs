
namespace WindowsDataReader
{
    partial class FormCustomers
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
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.btnTraerCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCustomers
            // 
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridCustomers.Location = new System.Drawing.Point(0, 54);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(1090, 586);
            this.gridCustomers.TabIndex = 3;
            // 
            // btnTraerCustomers
            // 
            this.btnTraerCustomers.BackColor = System.Drawing.SystemColors.Control;
            this.btnTraerCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraerCustomers.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTraerCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraerCustomers.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTraerCustomers.Location = new System.Drawing.Point(0, 0);
            this.btnTraerCustomers.Name = "btnTraerCustomers";
            this.btnTraerCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTraerCustomers.Size = new System.Drawing.Size(1090, 48);
            this.btnTraerCustomers.TabIndex = 2;
            this.btnTraerCustomers.Text = "TRAER CUSTOMERS";
            this.btnTraerCustomers.UseVisualStyleBackColor = false;
            this.btnTraerCustomers.Click += new System.EventHandler(this.btnTraerCustomers_Click);
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 640);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.btnTraerCustomers);
            this.Name = "FormCustomers";
            this.Text = "FormCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.Button btnTraerCustomers;
    }
}