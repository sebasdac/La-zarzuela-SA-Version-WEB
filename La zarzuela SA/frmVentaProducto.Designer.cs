namespace La_zarzuela_SA
{
    partial class frmVentaProducto
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidadDeseada = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtDisponible = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidadDeseada = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.btnCompra = new System.Windows.Forms.Button();
            this.lblNuevoDisponible = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colImpuesto,
            this.colSubTotal,
            this.colTotal});
            this.dgvProductos.Location = new System.Drawing.Point(88, 277);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(928, 342);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 125;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 6;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.Width = 125;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 125;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 125;
            // 
            // colImpuesto
            // 
            this.colImpuesto.HeaderText = "Impuesto";
            this.colImpuesto.MinimumWidth = 6;
            this.colImpuesto.Name = "colImpuesto";
            this.colImpuesto.ReadOnly = true;
            this.colImpuesto.Width = 125;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "Subtotal";
            this.colSubTotal.MinimumWidth = 6;
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 125;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 125;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(5, 26);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(227, 24);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(8, 40);
            this.lblCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoProducto.TabIndex = 6;
            this.lblCodigoProducto.Text = "Codigo:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(5, 55);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(53, 16);
            this.lblCedula.TabIndex = 7;
            this.lblCedula.Text = "Cedula:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(5, 86);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 16);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(238, 38);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(59, 16);
            this.lblNombreProducto.TabIndex = 10;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(9, 80);
            this.lblDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(75, 16);
            this.lblDisponible.TabIndex = 11;
            this.lblDisponible.Text = "Disponible:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(239, 82);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCantidadDeseada
            // 
            this.lblCantidadDeseada.AutoSize = true;
            this.lblCantidadDeseada.Location = new System.Drawing.Point(5, 122);
            this.lblCantidadDeseada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadDeseada.Name = "lblCantidadDeseada";
            this.lblCantidadDeseada.Size = new System.Drawing.Size(122, 16);
            this.lblCantidadDeseada.TabIndex = 16;
            this.lblCantidadDeseada.Text = "Cantidad deseada:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 603);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 16);
            this.label16.TabIndex = 17;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(41, 627);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(65, 16);
            this.lblImpuesto.TabIndex = 18;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(42, 674);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 16);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total:";
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Location = new System.Drawing.Point(9, 164);
            this.lblFechaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(116, 16);
            this.lblFechaCompra.TabIndex = 20;
            this.lblFechaCompra.Text = "Fecha de compra:";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(85, 22);
            this.txtCodigoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.ReadOnly = true;
            this.txtCodigoCliente.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoCliente.TabIndex = 21;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(307, 20);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(132, 22);
            this.txtNombreCliente.TabIndex = 22;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(85, 52);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(132, 22);
            this.txtCedula.TabIndex = 23;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(85, 82);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(132, 22);
            this.txtTipo.TabIndex = 24;
            // 
            // txtDisponible
            // 
            this.txtDisponible.Location = new System.Drawing.Point(90, 77);
            this.txtDisponible.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisponible.Name = "txtDisponible";
            this.txtDisponible.ReadOnly = true;
            this.txtDisponible.Size = new System.Drawing.Size(132, 22);
            this.txtDisponible.TabIndex = 31;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(319, 80);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(132, 22);
            this.txtPrecio.TabIndex = 32;
            // 
            // txtCantidadDeseada
            // 
            this.txtCantidadDeseada.Location = new System.Drawing.Point(141, 117);
            this.txtCantidadDeseada.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadDeseada.Name = "txtCantidadDeseada";
            this.txtCantidadDeseada.Size = new System.Drawing.Size(92, 22);
            this.txtCantidadDeseada.TabIndex = 33;
            this.txtCantidadDeseada.TextChanged += new System.EventHandler(this.txtCantidadDeseada_TextChanged);
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(122, 627);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(132, 22);
            this.txtImpuesto.TabIndex = 34;
            this.txtImpuesto.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(122, 671);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 35;
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Location = new System.Drawing.Point(141, 160);
            this.dtpFechaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(208, 22);
            this.dtpFechaCompra.TabIndex = 36;
            this.dtpFechaCompra.ValueChanged += new System.EventHandler(this.dtpFechaCompra_ValueChanged);
            // 
            // btnCompra
            // 
            this.btnCompra.Enabled = false;
            this.btnCompra.Location = new System.Drawing.Point(492, 636);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(140, 57);
            this.btnCompra.TabIndex = 37;
            this.btnCompra.Text = "Generar compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNuevoDisponible
            // 
            this.lblNuevoDisponible.AutoSize = true;
            this.lblNuevoDisponible.Location = new System.Drawing.Point(44, 716);
            this.lblNuevoDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoDisponible.Name = "lblNuevoDisponible";
            this.lblNuevoDisponible.Size = new System.Drawing.Size(116, 16);
            this.lblNuevoDisponible.TabIndex = 39;
            this.lblNuevoDisponible.Text = "Nuevo disponible:";
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(178, 712);
            this.p.Margin = new System.Windows.Forms.Padding(4);
            this.p.Name = "p";
            this.p.ReadOnly = true;
            this.p.Size = new System.Drawing.Size(132, 22);
            this.p.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtCodigoCliente);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.lblCedula);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Location = new System.Drawing.Point(40, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 203);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 28;
            this.btnBuscar.Location = new System.Drawing.Point(224, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 29);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.iconButton2);
            this.groupBox2.Controls.Add(this.txtNombreProducto);
            this.groupBox2.Controls.Add(this.txtCodigoProducto);
            this.groupBox2.Controls.Add(this.iconButton1);
            this.groupBox2.Controls.Add(this.lblCodigoProducto);
            this.groupBox2.Controls.Add(this.lblNombreProducto);
            this.groupBox2.Controls.Add(this.lblDisponible);
            this.groupBox2.Controls.Add(this.lblPrecio);
            this.groupBox2.Controls.Add(this.dtpFechaCompra);
            this.groupBox2.Controls.Add(this.txtDisponible);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.txtCantidadDeseada);
            this.groupBox2.Controls.Add(this.lblCantidadDeseada);
            this.groupBox2.Controls.Add(this.lblFechaCompra);
            this.groupBox2.Location = new System.Drawing.Point(492, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 203);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // btnBorrar
            // 
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnBorrar.IconColor = System.Drawing.Color.Black;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.Location = new System.Drawing.Point(385, 122);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(71, 75);
            this.btnBorrar.TabIndex = 40;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(475, 122);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(66, 75);
            this.iconButton2.TabIndex = 39;
            this.iconButton2.Text = "Agregar";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(319, 37);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProducto.TabIndex = 38;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(85, 38);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.ReadOnly = true;
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoProducto.TabIndex = 37;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(458, 32);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(34, 29);
            this.iconButton1.TabIndex = 27;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(650, 636);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(139, 54);
            this.iconButton3.TabIndex = 43;
            this.iconButton3.Text = "Generar factura";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // frmVentaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 709);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.p);
            this.Controls.Add(this.lblNuevoDisponible);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvProductos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta producto";
            this.Load += new System.EventHandler(this.frmVentaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidadDeseada;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtDisponible;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidadDeseada;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Label lblNuevoDisponible;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}