namespace pryMigotti_SP1ER
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.btnSalirClientes = new System.Windows.Forms.Button();
            this.btnRegistroCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblIdentificacion1 = new System.Windows.Forms.Label();
            this.mtbIdentificacionClientes = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSalirClientes
            // 
            this.btnSalirClientes.Location = new System.Drawing.Point(27, 70);
            this.btnSalirClientes.Name = "btnSalirClientes";
            this.btnSalirClientes.Size = new System.Drawing.Size(75, 23);
            this.btnSalirClientes.TabIndex = 11;
            this.btnSalirClientes.Text = "Salir";
            this.btnSalirClientes.UseVisualStyleBackColor = true;
            this.btnSalirClientes.Click += new System.EventHandler(this.btnSalirClientes_Click);
            // 
            // btnRegistroCliente
            // 
            this.btnRegistroCliente.Location = new System.Drawing.Point(108, 70);
            this.btnRegistroCliente.Name = "btnRegistroCliente";
            this.btnRegistroCliente.Size = new System.Drawing.Size(75, 23);
            this.btnRegistroCliente.TabIndex = 10;
            this.btnRegistroCliente.Text = "Registrar";
            this.btnRegistroCliente.UseVisualStyleBackColor = true;
            this.btnRegistroCliente.Click += new System.EventHandler(this.btnRegistroCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(94, 41);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 9;
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(15, 45);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(47, 13);
            this.lblNombre1.TabIndex = 8;
            this.lblNombre1.Text = "Nombre:";
            // 
            // lblIdentificacion1
            // 
            this.lblIdentificacion1.AutoSize = true;
            this.lblIdentificacion1.Location = new System.Drawing.Point(15, 16);
            this.lblIdentificacion1.Name = "lblIdentificacion1";
            this.lblIdentificacion1.Size = new System.Drawing.Size(73, 13);
            this.lblIdentificacion1.TabIndex = 7;
            this.lblIdentificacion1.Text = "Identificación:";
            // 
            // mtbIdentificacionClientes
            // 
            this.mtbIdentificacionClientes.Location = new System.Drawing.Point(94, 13);
            this.mtbIdentificacionClientes.Mask = "99999";
            this.mtbIdentificacionClientes.Name = "mtbIdentificacionClientes";
            this.mtbIdentificacionClientes.Size = new System.Drawing.Size(100, 20);
            this.mtbIdentificacionClientes.TabIndex = 12;
            this.mtbIdentificacionClientes.ValidatingType = typeof(int);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 109);
            this.Controls.Add(this.mtbIdentificacionClientes);
            this.Controls.Add(this.btnSalirClientes);
            this.Controls.Add(this.btnRegistroCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.lblIdentificacion1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirClientes;
        private System.Windows.Forms.Button btnRegistroCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblIdentificacion1;
        private System.Windows.Forms.MaskedTextBox mtbIdentificacionClientes;
    }
}