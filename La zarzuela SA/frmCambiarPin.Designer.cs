namespace La_zarzuela_SA
{
    partial class frmCambiarPin
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
            this.lblPinActual = new System.Windows.Forms.Label();
            this.lblPinNuevo = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPinActual
            // 
            this.lblPinActual.AutoSize = true;
            this.lblPinActual.Location = new System.Drawing.Point(25, 31);
            this.lblPinActual.Name = "lblPinActual";
            this.lblPinActual.Size = new System.Drawing.Size(57, 13);
            this.lblPinActual.TabIndex = 0;
            this.lblPinActual.Text = "Pin actual:";
            // 
            // lblPinNuevo
            // 
            this.lblPinNuevo.AutoSize = true;
            this.lblPinNuevo.Location = new System.Drawing.Point(25, 79);
            this.lblPinNuevo.Name = "lblPinNuevo";
            this.lblPinNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPinNuevo.Size = new System.Drawing.Size(58, 13);
            this.lblPinNuevo.TabIndex = 1;
            this.lblPinNuevo.Text = "Pin nuevo:";
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(101, 29);
            this.txtActual.Name = "txtActual";
            this.txtActual.Size = new System.Drawing.Size(42, 20);
            this.txtActual.TabIndex = 2;
            this.txtActual.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(101, 77);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(42, 20);
            this.txtNuevo.TabIndex = 3;
            this.txtNuevo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(41, 125);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(84, 42);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // frmCambiarPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 179);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.lblPinNuevo);
            this.Controls.Add(this.lblPinActual);
            this.Name = "frmCambiarPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar pin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPinActual;
        private System.Windows.Forms.Label lblPinNuevo;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.Button btnCambiar;
    }
}