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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarporFactura = new FontAwesome.Sharp.IconButton();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.dgvFacturaCompra = new System.Windows.Forms.DataGridView();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.gbFacturas = new System.Windows.Forms.GroupBox();
            this.gpDetalles = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.gbFacturas.SuspendLayout();
            this.gpDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarporFactura);
            this.groupBox1.Controls.Add(this.txtNumeroFactura);
            this.groupBox1.Controls.Add(this.lblNumeroFactura);
            this.groupBox1.Location = new System.Drawing.Point(66, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 62);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de factura";
            // 
            // btnBuscarporFactura
            // 
            this.btnBuscarporFactura.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarporFactura.IconColor = System.Drawing.Color.Black;
            this.btnBuscarporFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarporFactura.IconSize = 30;
            this.btnBuscarporFactura.Location = new System.Drawing.Point(246, 17);
            this.btnBuscarporFactura.Name = "btnBuscarporFactura";
            this.btnBuscarporFactura.Size = new System.Drawing.Size(45, 39);
            this.btnBuscarporFactura.TabIndex = 6;
            this.btnBuscarporFactura.UseVisualStyleBackColor = true;
            this.btnBuscarporFactura.Click += new System.EventHandler(this.btnBuscarporFactura_Click);
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(140, 28);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroFactura.TabIndex = 1;
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
            // dgvFacturaCompra
            // 
            this.dgvFacturaCompra.AllowUserToDeleteRows = false;
            this.dgvFacturaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaCompra.Location = new System.Drawing.Point(18, 22);
            this.dgvFacturaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFacturaCompra.Name = "dgvFacturaCompra";
            this.dgvFacturaCompra.ReadOnly = true;
            this.dgvFacturaCompra.RowHeadersWidth = 51;
            this.dgvFacturaCompra.Size = new System.Drawing.Size(861, 254);
            this.dgvFacturaCompra.TabIndex = 3;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(35, 22);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(844, 204);
            this.dgvDetalles.TabIndex = 5;
            // 
            // gbFacturas
            // 
            this.gbFacturas.Controls.Add(this.dgvFacturaCompra);
            this.gbFacturas.Location = new System.Drawing.Point(88, 100);
            this.gbFacturas.Name = "gbFacturas";
            this.gbFacturas.Size = new System.Drawing.Size(900, 289);
            this.gbFacturas.TabIndex = 6;
            this.gbFacturas.TabStop = false;
            this.gbFacturas.Text = "Facturas";
            // 
            // gpDetalles
            // 
            this.gpDetalles.Controls.Add(this.dgvDetalles);
            this.gpDetalles.Location = new System.Drawing.Point(88, 408);
            this.gpDetalles.Name = "gpDetalles";
            this.gpDetalles.Size = new System.Drawing.Size(900, 241);
            this.gpDetalles.TabIndex = 7;
            this.gpDetalles.TabStop = false;
            this.gpDetalles.Text = "Detalles";
            // 
            // frmVerFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 677);
            this.Controls.Add(this.gpDetalles);
            this.Controls.Add(this.gbFacturas);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVerFacturaVenta";
            this.Text = "frmVerFacturaVenta";
            this.Load += new System.EventHandler(this.frmVerFacturaVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.gbFacturas.ResumeLayout(false);
            this.gpDetalles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.DataGridView dgvFacturaCompra;
        private FontAwesome.Sharp.IconButton btnBuscarporFactura;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.GroupBox gbFacturas;
        private System.Windows.Forms.GroupBox gpDetalles;
    }
}