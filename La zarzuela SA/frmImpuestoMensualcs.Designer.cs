namespace La_zarzuela_SA
{
    partial class frmImpuestoMensualcs
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
            this.lblImpuestoaPagar = new System.Windows.Forms.Label();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.lblNumeroMes = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtNumeroMes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblImpuestoaPagar
            // 
            this.lblImpuestoaPagar.AutoSize = true;
            this.lblImpuestoaPagar.Location = new System.Drawing.Point(12, 121);
            this.lblImpuestoaPagar.Name = "lblImpuestoaPagar";
            this.lblImpuestoaPagar.Size = new System.Drawing.Size(137, 13);
            this.lblImpuestoaPagar.TabIndex = 0;
            this.lblImpuestoaPagar.Text = "Impuesto a pagar este mes:";
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(160, 118);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.ReadOnly = true;
            this.txtImpuestos.Size = new System.Drawing.Size(100, 20);
            this.txtImpuestos.TabIndex = 1;
            this.txtImpuestos.TextChanged += new System.EventHandler(this.txtImpuestos_TextChanged);
            // 
            // lblNumeroMes
            // 
            this.lblNumeroMes.AutoSize = true;
            this.lblNumeroMes.Location = new System.Drawing.Point(15, 55);
            this.lblNumeroMes.Name = "lblNumeroMes";
            this.lblNumeroMes.Size = new System.Drawing.Size(86, 13);
            this.lblNumeroMes.TabIndex = 3;
            this.lblNumeroMes.Text = "Numero del mes:";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(107, 176);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtNumeroMes
            // 
            this.txtNumeroMes.Location = new System.Drawing.Point(107, 52);
            this.txtNumeroMes.Name = "txtNumeroMes";
            this.txtNumeroMes.Size = new System.Drawing.Size(41, 20);
            this.txtNumeroMes.TabIndex = 6;
            // 
            // frmImpuestoMensualcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.txtNumeroMes);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lblNumeroMes);
            this.Controls.Add(this.txtImpuestos);
            this.Controls.Add(this.lblImpuestoaPagar);
            this.Name = "frmImpuestoMensualcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impuesto mensual";
            this.Load += new System.EventHandler(this.frmImpuestoMensualcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImpuestoaPagar;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label lblNumeroMes;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtNumeroMes;
    }
}