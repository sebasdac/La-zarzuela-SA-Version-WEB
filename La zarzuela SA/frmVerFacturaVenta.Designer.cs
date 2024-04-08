namespace La_zarzuela_SA
{
    partial class frmVerFacturaVenta
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
            this.dgvFacturasVenta = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturasVenta
            // 
            this.dgvFacturasVenta.AllowUserToDeleteRows = false;
            this.dgvFacturasVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturasVenta.Location = new System.Drawing.Point(33, 28);
            this.dgvFacturasVenta.Name = "dgvFacturasVenta";
            this.dgvFacturasVenta.ReadOnly = true;
            this.dgvFacturasVenta.Size = new System.Drawing.Size(722, 364);
            this.dgvFacturasVenta.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(83, 419);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 65);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmVerFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvFacturasVenta);
            this.Name = "frmVerFacturaVenta";
            this.Text = "frmVerFacturaVenta";
            this.Load += new System.EventHandler(this.frmVerFacturaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturasVenta;
        private System.Windows.Forms.Button btnEliminar;
    }
}