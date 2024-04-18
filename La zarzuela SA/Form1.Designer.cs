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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btnSalir = new FontAwesome.Sharp.IconMenuItem();
            this.btnAgregarUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.btnProductos = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.btnCambiarPin = new FontAwesome.Sharp.IconMenuItem();
            this.btnClientes = new FontAwesome.Sharp.IconMenuItem();
            this.btnVentaProducto = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.btnFacutras = new FontAwesome.Sharp.IconMenuItem();
            this.bbtnReciboVenta = new FontAwesome.Sharp.IconMenuItem();
            this.btnReciboCOmpra = new FontAwesome.Sharp.IconMenuItem();
            this.btnImpuestos = new FontAwesome.Sharp.IconMenuItem();
            this.btnVerMas = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.lblIstsema = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconMenuItem();
            this.btnVerProductos = new FontAwesome.Sharp.IconMenuItem();
            this.btnAgregarInventario = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.btnAgregarUsuario,
            this.btnProductos,
            this.iconMenuItem1,
            this.btnCambiarPin,
            this.btnClientes,
            this.btnVentaProducto,
            this.iconMenuItem2,
            this.btnFacutras,
            this.btnImpuestos,
            this.btnVerMas});
            this.menu.Location = new System.Drawing.Point(0, 88);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1360, 76);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 72);
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem3,
            this.iconMenuItem4});
            this.btnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            this.btnAgregarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(129, 72);
            this.btnAgregarUsuario.Text = "Agregar usuario";
            this.btnAgregarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(198, 26);
            this.iconMenuItem3.Text = "Ver usuarios";
            this.iconMenuItem3.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(198, 26);
            this.iconMenuItem4.Text = "Agregar usuario";
            this.iconMenuItem4.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarProducto,
            this.btnVerProductos,
            this.btnAgregarInventario});
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.btnProductos.IconColor = System.Drawing.Color.Black;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(89, 72);
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(105, 72);
            this.iconMenuItem1.Text = "Proveedores";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItem1.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // btnCambiarPin
            // 
            this.btnCambiarPin.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnCambiarPin.IconColor = System.Drawing.Color.Black;
            this.btnCambiarPin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarPin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCambiarPin.Name = "btnCambiarPin";
            this.btnCambiarPin.Size = new System.Drawing.Size(104, 72);
            this.btnCambiarPin.Text = "Cambiar pin";
            this.btnCambiarPin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCambiarPin.Click += new System.EventHandler(this.btnCambiarPin_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnClientes.IconColor = System.Drawing.Color.Black;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 72);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentaProducto
            // 
            this.btnVentaProducto.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnVentaProducto.IconColor = System.Drawing.Color.Black;
            this.btnVentaProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentaProducto.IconSize = 45;
            this.btnVentaProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVentaProducto.Name = "btnVentaProducto";
            this.btnVentaProducto.Size = new System.Drawing.Size(125, 72);
            this.btnVentaProducto.Text = "Venta producto";
            this.btnVentaProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVentaProducto.Click += new System.EventHandler(this.btnVentaProducto_Click);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(147, 72);
            this.iconMenuItem2.Text = "Agregar inventario";
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItem2.Click += new System.EventHandler(this.iconMenuItem2_Click_1);
            // 
            // btnFacutras
            // 
            this.btnFacutras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bbtnReciboVenta,
            this.btnReciboCOmpra});
            this.btnFacutras.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnFacutras.IconColor = System.Drawing.Color.Black;
            this.btnFacutras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacutras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFacutras.Name = "btnFacutras";
            this.btnFacutras.Size = new System.Drawing.Size(76, 72);
            this.btnFacutras.Text = "Facturas";
            this.btnFacutras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFacutras.Click += new System.EventHandler(this.btnFacutras_Click);
            // 
            // bbtnReciboVenta
            // 
            this.bbtnReciboVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bbtnReciboVenta.IconColor = System.Drawing.Color.Black;
            this.bbtnReciboVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bbtnReciboVenta.Name = "bbtnReciboVenta";
            this.bbtnReciboVenta.Size = new System.Drawing.Size(220, 26);
            this.bbtnReciboVenta.Text = "Recibos de venta";
            this.bbtnReciboVenta.Click += new System.EventHandler(this.bbtnReciboVenta_Click);
            // 
            // btnReciboCOmpra
            // 
            this.btnReciboCOmpra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReciboCOmpra.IconColor = System.Drawing.Color.Black;
            this.btnReciboCOmpra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReciboCOmpra.Name = "btnReciboCOmpra";
            this.btnReciboCOmpra.Size = new System.Drawing.Size(220, 26);
            this.btnReciboCOmpra.Text = "Recibos de compra";
            this.btnReciboCOmpra.Click += new System.EventHandler(this.btnReciboCOmpra_Click);
            // 
            // btnImpuestos
            // 
            this.btnImpuestos.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnImpuestos.IconColor = System.Drawing.Color.Black;
            this.btnImpuestos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImpuestos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImpuestos.Name = "btnImpuestos";
            this.btnImpuestos.Size = new System.Drawing.Size(91, 72);
            this.btnImpuestos.Text = "Impuestos";
            this.btnImpuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImpuestos.Click += new System.EventHandler(this.btnImpuestos_Click);
            // 
            // btnVerMas
            // 
            this.btnVerMas.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnVerMas.IconColor = System.Drawing.Color.Black;
            this.btnVerMas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerMas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.Size = new System.Drawing.Size(75, 72);
            this.btnVerMas.Text = "Ver mas";
            this.btnVerMas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1360, 88);
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
            this.panelContenedor.Location = new System.Drawing.Point(0, 164);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1360, 732);
            this.panelContenedor.TabIndex = 3;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(224, 26);
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerProductos.IconColor = System.Drawing.Color.Black;
            this.btnVerProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(224, 26);
            this.btnVerProductos.Text = "Ver productos";
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnAgregarInventario
            // 
            this.btnAgregarInventario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarInventario.IconColor = System.Drawing.Color.Black;
            this.btnAgregarInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarInventario.Name = "btnAgregarInventario";
            this.btnAgregarInventario.Size = new System.Drawing.Size(224, 26);
            this.btnAgregarInventario.Text = "Agregar inventario";
            this.btnAgregarInventario.Click += new System.EventHandler(this.btnAgregarInventario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 896);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.lblIstsema);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label lblIstsema;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconMenuItem btnVentaProducto;
        private FontAwesome.Sharp.IconMenuItem btnSalir;
        private FontAwesome.Sharp.IconMenuItem btnAgregarUsuario;
        private FontAwesome.Sharp.IconMenuItem btnCambiarPin;
        private FontAwesome.Sharp.IconMenuItem btnVerMas;
        private FontAwesome.Sharp.IconMenuItem btnProductos;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem btnClientes;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem btnFacutras;
        private FontAwesome.Sharp.IconMenuItem bbtnReciboVenta;
        private FontAwesome.Sharp.IconMenuItem btnReciboCOmpra;
        private FontAwesome.Sharp.IconMenuItem btnImpuestos;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem btnAgregarProducto;
        private FontAwesome.Sharp.IconMenuItem btnVerProductos;
        private FontAwesome.Sharp.IconMenuItem btnAgregarInventario;
    }
}

