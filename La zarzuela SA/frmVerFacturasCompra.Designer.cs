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
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturaCompra
            // 
            this.dgvFacturaCompra.AllowUserToDeleteRows = false;
            this.dgvFacturaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaCompra.Location = new System.Drawing.Point(48, 28);
            this.dgvFacturaCompra.Name = "dgvFacturaCompra";
            this.dgvFacturaCompra.ReadOnly = true;
            this.dgvFacturaCompra.Size = new System.Drawing.Size(708, 366);
            this.dgvFacturaCompra.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(111, 418);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 65);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmVerFacturasCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvFacturaCompra);
            this.Name = "frmVerFacturasCompra";
            this.Text = "Ver facturas de compra";
            this.Load += new System.EventHandler(this.frmVerFacturasCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturaCompra;
        private System.Windows.Forms.Button btnEliminar;
    }
}