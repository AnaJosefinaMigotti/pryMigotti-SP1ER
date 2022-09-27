namespace pryMigotti_SP1ER
{
    partial class frmVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedores));
            this.btnSalirVendedores = new System.Windows.Forms.Button();
            this.btnRegistroVendedores = new System.Windows.Forms.Button();
            this.txtNombreVendedores = new System.Windows.Forms.TextBox();
            this.mtbIdentificacionVendedores = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblIdentificacion2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalirVendedores
            // 
            this.btnSalirVendedores.Location = new System.Drawing.Point(23, 67);
            this.btnSalirVendedores.Name = "btnSalirVendedores";
            this.btnSalirVendedores.Size = new System.Drawing.Size(75, 23);
            this.btnSalirVendedores.TabIndex = 17;
            this.btnSalirVendedores.Text = "Salir";
            this.btnSalirVendedores.UseVisualStyleBackColor = true;
            this.btnSalirVendedores.Click += new System.EventHandler(this.btnSalirVendedores_Click);
            // 
            // btnRegistroVendedores
            // 
            this.btnRegistroVendedores.Location = new System.Drawing.Point(104, 67);
            this.btnRegistroVendedores.Name = "btnRegistroVendedores";
            this.btnRegistroVendedores.Size = new System.Drawing.Size(75, 23);
            this.btnRegistroVendedores.TabIndex = 16;
            this.btnRegistroVendedores.Text = "Registrar";
            this.btnRegistroVendedores.UseVisualStyleBackColor = true;
            this.btnRegistroVendedores.Click += new System.EventHandler(this.btnRegistroVendedores_Click);
            // 
            // txtNombreVendedores
            // 
            this.txtNombreVendedores.Location = new System.Drawing.Point(90, 41);
            this.txtNombreVendedores.Name = "txtNombreVendedores";
            this.txtNombreVendedores.Size = new System.Drawing.Size(100, 20);
            this.txtNombreVendedores.TabIndex = 15;
            // 
            // mtbIdentificacionVendedores
            // 
            this.mtbIdentificacionVendedores.Location = new System.Drawing.Point(90, 12);
            this.mtbIdentificacionVendedores.Mask = "99999";
            this.mtbIdentificacionVendedores.Name = "mtbIdentificacionVendedores";
            this.mtbIdentificacionVendedores.Size = new System.Drawing.Size(100, 20);
            this.mtbIdentificacionVendedores.TabIndex = 14;
            this.mtbIdentificacionVendedores.ValidatingType = typeof(int);
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(10, 45);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2.TabIndex = 13;
            this.lblNombre2.Text = "Nombre:";
            // 
            // lblIdentificacion2
            // 
            this.lblIdentificacion2.AutoSize = true;
            this.lblIdentificacion2.Location = new System.Drawing.Point(10, 16);
            this.lblIdentificacion2.Name = "lblIdentificacion2";
            this.lblIdentificacion2.Size = new System.Drawing.Size(73, 13);
            this.lblIdentificacion2.TabIndex = 12;
            this.lblIdentificacion2.Text = "Identificación:";
            // 
            // frmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 100);
            this.Controls.Add(this.btnSalirVendedores);
            this.Controls.Add(this.btnRegistroVendedores);
            this.Controls.Add(this.txtNombreVendedores);
            this.Controls.Add(this.mtbIdentificacionVendedores);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.lblIdentificacion2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirVendedores;
        private System.Windows.Forms.Button btnRegistroVendedores;
        private System.Windows.Forms.TextBox txtNombreVendedores;
        private System.Windows.Forms.MaskedTextBox mtbIdentificacionVendedores;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblIdentificacion2;
    }
}