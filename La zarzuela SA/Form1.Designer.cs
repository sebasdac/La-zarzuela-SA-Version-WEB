namespace La_zarzuela_SA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosMensualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarInvetarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarPinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.lblIstsema = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.agregarProductoToolStripMenuItem,
            this.agregarUsuarioToolStripMenuItem,
            this.cambiarPinToolStripMenuItem,
            this.compraToolStripMenuItem,
            this.verMasToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 88);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1205, 53);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem1,
            this.agregarClienteToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.impuestosMensualesToolStripMenuItem,
            this.agregarInvetarioToolStripMenuItem,
            this.facturasCompraToolStripMenuItem,
            this.facturasVentaToolStripMenuItem});
            this.agregarProductoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarProductoToolStripMenuItem.Image")));
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(44, 49);
            this.agregarProductoToolStripMenuItem.Text = "Ver";
            this.agregarProductoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // agregarProductoToolStripMenuItem1
            // 
            this.agregarProductoToolStripMenuItem1.Name = "agregarProductoToolStripMenuItem1";
            this.agregarProductoToolStripMenuItem1.Size = new System.Drawing.Size(233, 26);
            this.agregarProductoToolStripMenuItem1.Text = "Productos";
            this.agregarProductoToolStripMenuItem1.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem1_Click);
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.agregarClienteToolStripMenuItem.Text = "Clientes";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // impuestosMensualesToolStripMenuItem
            // 
            this.impuestosMensualesToolStripMenuItem.Name = "impuestosMensualesToolStripMenuItem";
            this.impuestosMensualesToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.impuestosMensualesToolStripMenuItem.Text = "Impuestos mensuales";
            this.impuestosMensualesToolStripMenuItem.Click += new System.EventHandler(this.impuestosMensualesToolStripMenuItem_Click);
            // 
            // agregarInvetarioToolStripMenuItem
            // 
            this.agregarInvetarioToolStripMenuItem.Name = "agregarInvetarioToolStripMenuItem";
            this.agregarInvetarioToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.agregarInvetarioToolStripMenuItem.Text = "Agregar inventario";
            this.agregarInvetarioToolStripMenuItem.Click += new System.EventHandler(this.agregarInvetarioToolStripMenuItem_Click);
            // 
            // facturasCompraToolStripMenuItem
            // 
            this.facturasCompraToolStripMenuItem.Name = "facturasCompraToolStripMenuItem";
            this.facturasCompraToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.facturasCompraToolStripMenuItem.Text = "Facturas compra";
            this.facturasCompraToolStripMenuItem.Click += new System.EventHandler(this.facturasCompraToolStripMenuItem_Click);
            // 
            // facturasVentaToolStripMenuItem
            // 
            this.facturasVentaToolStripMenuItem.Name = "facturasVentaToolStripMenuItem";
            this.facturasVentaToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.facturasVentaToolStripMenuItem.Text = "Facturas venta";
            this.facturasVentaToolStripMenuItem.Click += new System.EventHandler(this.facturasVentaToolStripMenuItem_Click);
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarUsuarioToolStripMenuItem.Image")));
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(129, 49);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar usuario";
            this.agregarUsuarioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // cambiarPinToolStripMenuItem
            // 
            this.cambiarPinToolStripMenuItem.Image = global::La_zarzuela_SA.Properties.Resources.key;
            this.cambiarPinToolStripMenuItem.Name = "cambiarPinToolStripMenuItem";
            this.cambiarPinToolStripMenuItem.Size = new System.Drawing.Size(104, 49);
            this.cambiarPinToolStripMenuItem.Text = "Cambiar pin";
            this.cambiarPinToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cambiarPinToolStripMenuItem.Click += new System.EventHandler(this.cambiarPinToolStripMenuItem_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compraToolStripMenuItem.Image")));
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(125, 49);
            this.compraToolStripMenuItem.Text = "Venta producto";
            this.compraToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // verMasToolStripMenuItem1
            // 
            this.verMasToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("verMasToolStripMenuItem1.Image")));
            this.verMasToolStripMenuItem1.Name = "verMasToolStripMenuItem1";
            this.verMasToolStripMenuItem1.Size = new System.Drawing.Size(75, 49);
            this.verMasToolStripMenuItem1.Text = "Ver mas";
            this.verMasToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.verMasToolStripMenuItem1.Click += new System.EventHandler(this.verMasToolStripMenuItem1_Click);
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1205, 88);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // lblIstsema
            // 
            this.lblIstsema.AutoSize = true;
            this.lblIstsema.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblIstsema.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIstsema.ForeColor = System.Drawing.Color.White;
            this.lblIstsema.Location = new System.Drawing.Point(26, 28);
            this.lblIstsema.Name = "lblIstsema";
            this.lblIstsema.Size = new System.Drawing.Size(264, 32);
            this.lblIstsema.TabIndex = 2;
            this.lblIstsema.Text = "Sistema de ventas";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 141);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1205, 484);
            this.panelContenedor.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 25;
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 49);
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 625);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.lblIstsema);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarPinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestosMensualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarInvetarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasVentaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label lblIstsema;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconMenuItem btnSalir;
    }
}

