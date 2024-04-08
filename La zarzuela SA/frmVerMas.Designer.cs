namespace La_zarzuela_SA
{
    partial class frmVerMas
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
            this.txtVermas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtVermas
            // 
            this.txtVermas.Enabled = false;
            this.txtVermas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVermas.Location = new System.Drawing.Point(25, 12);
            this.txtVermas.Name = "txtVermas";
            this.txtVermas.ReadOnly = true;
            this.txtVermas.Size = new System.Drawing.Size(734, 411);
            this.txtVermas.TabIndex = 0;
            this.txtVermas.Text = "";
            // 
            // frmVerMas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVermas);
            this.Name = "frmVerMas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver mas";
            this.Load += new System.EventHandler(this.frmVerMas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtVermas;
    }
}