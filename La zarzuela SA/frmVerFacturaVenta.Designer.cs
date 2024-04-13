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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.dgvFacturaCompra = new System.Windows.Forms.DataGridView();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnBuscarporCedula = new FontAwesome.Sharp.IconButton();
            this.btnBuscarporFactura = new FontAwesome.Sharp.IconButton();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(111, 516);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 80);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
           
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarporFactura);
            this.groupBox1.Controls.Add(this.btnBuscarporCedula);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.lblCedula);
            this.groupBox1.Controls.Add(this.txtNumeroFactura);
            this.groupBox1.Controls.Add(this.lblNumeroFactura);
            this.groupBox1.Location = new System.Drawing.Point(66, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 62);
            this.groupBox1.TabIndex = 4;
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
            // dgvFacturaCompra
            // 
            this.dgvFacturaCompra.AllowUserToDeleteRows = false;
            this.dgvFacturaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaCompra.Location = new System.Drawing.Point(66, 81);
            this.dgvFacturaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFacturaCompra.Name = "dgvFacturaCompra";
            this.dgvFacturaCompra.ReadOnly = true;
            this.dgvFacturaCompra.RowHeadersWidth = 51;
            this.dgvFacturaCompra.Size = new System.Drawing.Size(419, 495);
            this.dgvFacturaCompra.TabIndex = 3;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(140, 28);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroFactura.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(396, 26);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 22);
            this.txtCedula.TabIndex = 3;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(337, 29);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(53, 16);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cedula:";
            // 
            // btnBuscarporCedula
            // 
            this.btnBuscarporCedula.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarporCedula.IconColor = System.Drawing.Color.Black;
            this.btnBuscarporCedula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarporCedula.IconSize = 30;
            this.btnBuscarporCedula.Location = new System.Drawing.Point(502, 17);
            this.btnBuscarporCedula.Name = "btnBuscarporCedula";
            this.btnBuscarporCedula.Size = new System.Drawing.Size(45, 39);
            this.btnBuscarporCedula.TabIndex = 4;
            this.btnBuscarporCedula.UseVisualStyleBackColor = true;
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
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(514, 81);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(540, 495);
            this.dgvDetalles.TabIndex = 5;
            // 
            // frmVerFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 610);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFacturaCompra);
            this.Controls.Add(this.btnEliminar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVerFacturaVenta";
            this.Text = "frmVerFacturaVenta";
            this.Load += new System.EventHandler(this.frmVerFacturaVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnBuscarporCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.DataGridView dgvFacturaCompra;
        private FontAwesome.Sharp.IconButton btnBuscarporFactura;
        private System.Windows.Forms.DataGridView dgvDetalles;
    }
}