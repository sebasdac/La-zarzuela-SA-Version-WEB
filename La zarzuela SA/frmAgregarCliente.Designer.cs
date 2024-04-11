using System.Windows.Forms;

namespace La_zarzuela_SA
{
    partial class frmAgregarCliente
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.lbldire = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(40, 39);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(40, 271);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 16);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Provincia";
            this.lblDireccion.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(40, 329);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(40, 378);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(120, 16);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo electronico ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 310);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 7;
            // 
            // cbTipoCliente
            // 
            this.cbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCliente.FormattingEnabled = true;
            this.cbTipoCliente.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbTipoCliente.Items.AddRange(new object[] {
            "Fisico",
            "Juridico"});
            this.cbTipoCliente.Location = new System.Drawing.Point(176, 95);
            this.cbTipoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipoCliente.Name = "cbTipoCliente";
            this.cbTipoCliente.Size = new System.Drawing.Size(132, 24);
            this.cbTipoCliente.TabIndex = 8;
            this.cbTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cbTipoCliente_SelectedIndexChanged);
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(40, 97);
            this.lblTipoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(96, 16);
            this.lblTipoCliente.TabIndex = 9;
            this.lblTipoCliente.Text = "Tipo de cliente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(176, 39);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(176, 319);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 22);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(176, 374);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(132, 22);
            this.txtCorreo.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(483, 427);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 52);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(436, 39);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(1000, 367);
            this.dgvClientes.TabIndex = 15;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(176, 151);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 155);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(176, 207);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(132, 22);
            this.txtCedula.TabIndex = 19;
            this.txtCedula.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(40, 213);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(50, 16);
            this.lblCedula.TabIndex = 18;
            this.lblCedula.Text = "Cédula";
            this.lblCedula.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // cbProvincia
            // 
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Items.AddRange(new object[] {
            "Cartago",
            "San José",
            "Heredia",
            "Alajuela",
            "Limón",
            "Puntarenas",
            "Guanacaste"});
            this.cbProvincia.Location = new System.Drawing.Point(176, 262);
            this.cbProvincia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(132, 24);
            this.cbProvincia.TabIndex = 20;
            this.cbProvincia.SelectedIndexChanged += new System.EventHandler(this.cbProvincia_SelectedIndexChanged);
            // 
            // lbldire
            // 
            this.lbldire.AutoSize = true;
            this.lbldire.Location = new System.Drawing.Point(44, 496);
            this.lbldire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldire.Name = "lbldire";
            this.lbldire.Size = new System.Drawing.Size(64, 16);
            this.lbldire.TabIndex = 21;
            this.lbldire.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(176, 475);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(248, 120);
            this.txtDireccion.TabIndex = 22;
            this.txtDireccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(483, 497);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 52);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(629, 427);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 52);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(176, 427);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(132, 22);
            this.txtContrasena.TabIndex = 26;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(40, 431);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(76, 16);
            this.lblContrasena.TabIndex = 25;
            this.lblContrasena.Text = "Contraseña";
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 643);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbldire);
            this.Controls.Add(this.cbProvincia);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.cbTipoCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgregarCliente_FormClosing);
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipoCliente;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Label lbldire;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private TextBox txtContrasena;
        private Label lblContrasena;
    }
}