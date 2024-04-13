namespace La_zarzuela_SA
{
    partial class frmVerFacturasCompra
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
            this.dgvFacturaCompra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFacturaCompra
            // 
            this.dgvFacturaCompra.AllowUserToDeleteRows = false;
            this.dgvFacturaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaCompra.Location = new System.Drawing.Point(49, 94);
            this.dgvFacturaCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFacturaCompra.Name = "dgvFacturaCompra";
            this.dgvFacturaCompra.ReadOnly = true;
            this.dgvFacturaCompra.RowHeadersWidth = 51;
            this.dgvFacturaCompra.Size = new System.Drawing.Size(653, 495);
            this.dgvFacturaCompra.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumeroFactura);
            this.groupBox1.Location = new System.Drawing.Point(80, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de factura";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Location = new System.Drawing.Point(19, 28);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(101, 16);
            this.lblNumeroFactura.TabIndex = 0;
            this.lblNumeroFactura.Text = "Numero factura:";
            // 
            // frmVerFacturasCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 614);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFacturaCompra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVerFacturasCompra";
            this.Text = "Ver facturas de compra";
            this.Load += new System.EventHandler(this.frmVerFacturasCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturaCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumeroFactura;
    }
}