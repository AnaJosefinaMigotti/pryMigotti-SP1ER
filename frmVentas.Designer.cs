namespace pryMigotti_SP1ER
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.btnSalirVentas = new System.Windows.Forms.Button();
            this.btnRegistroVentas = new System.Windows.Forms.Button();
            this.mtbMontoVentas = new System.Windows.Forms.MaskedTextBox();
            this.mtbFechasVentas = new System.Windows.Forms.MaskedTextBox();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lstCliente = new System.Windows.Forms.ComboBox();
            this.lstVendedor = new System.Windows.Forms.ComboBox();
            this.lblNFactura = new System.Windows.Forms.Label();
            this.mtbNFactura = new System.Windows.Forms.MaskedTextBox();
            this.lstTipoFactura = new System.Windows.Forms.ComboBox();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalirVentas
            // 
            this.btnSalirVentas.Location = new System.Drawing.Point(29, 176);
            this.btnSalirVentas.Name = "btnSalirVentas";
            this.btnSalirVentas.Size = new System.Drawing.Size(75, 23);
            this.btnSalirVentas.TabIndex = 20;
            this.btnSalirVentas.Text = "Salir";
            this.btnSalirVentas.UseVisualStyleBackColor = true;
            this.btnSalirVentas.Click += new System.EventHandler(this.btnSalirVentas_Click);
            // 
            // btnRegistroVentas
            // 
            this.btnRegistroVentas.Location = new System.Drawing.Point(110, 176);
            this.btnRegistroVentas.Name = "btnRegistroVentas";
            this.btnRegistroVentas.Size = new System.Drawing.Size(75, 23);
            this.btnRegistroVentas.TabIndex = 19;
            this.btnRegistroVentas.Text = "Registrar";
            this.btnRegistroVentas.UseVisualStyleBackColor = true;
            this.btnRegistroVentas.Click += new System.EventHandler(this.btnRegistroVentas_Click);
            // 
            // mtbMontoVentas
            // 
            this.mtbMontoVentas.Location = new System.Drawing.Point(100, 37);
            this.mtbMontoVentas.Mask = "999999999";
            this.mtbMontoVentas.Name = "mtbMontoVentas";
            this.mtbMontoVentas.Size = new System.Drawing.Size(100, 20);
            this.mtbMontoVentas.TabIndex = 16;
            this.mtbMontoVentas.ValidatingType = typeof(int);
            // 
            // mtbFechasVentas
            // 
            this.mtbFechasVentas.Location = new System.Drawing.Point(100, 11);
            this.mtbFechasVentas.Mask = "00/00/0000";
            this.mtbFechasVentas.Name = "mtbFechasVentas";
            this.mtbFechasVentas.Size = new System.Drawing.Size(100, 20);
            this.mtbFechasVentas.TabIndex = 15;
            this.mtbFechasVentas.ValidatingType = typeof(System.DateTime);
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Location = new System.Drawing.Point(12, 95);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(56, 13);
            this.lblVendedorID.TabIndex = 14;
            this.lblVendedorID.Text = "Vendedor:";
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(12, 68);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(42, 13);
            this.lblClienteID.TabIndex = 13;
            this.lblClienteID.Text = "Cliente:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(12, 41);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 12;
            this.lblMonto.Text = "Monto:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 14);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha:";
            // 
            // lstCliente
            // 
            this.lstCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(100, 63);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(100, 21);
            this.lstCliente.TabIndex = 21;
            // 
            // lstVendedor
            // 
            this.lstVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVendedor.FormattingEnabled = true;
            this.lstVendedor.Location = new System.Drawing.Point(100, 90);
            this.lstVendedor.Name = "lstVendedor";
            this.lstVendedor.Size = new System.Drawing.Size(100, 21);
            this.lstVendedor.TabIndex = 22;
            // 
            // lblNFactura
            // 
            this.lblNFactura.AutoSize = true;
            this.lblNFactura.Location = new System.Drawing.Point(12, 122);
            this.lblNFactura.Name = "lblNFactura";
            this.lblNFactura.Size = new System.Drawing.Size(61, 13);
            this.lblNFactura.TabIndex = 23;
            this.lblNFactura.Text = "N° Factura:";
            // 
            // mtbNFactura
            // 
            this.mtbNFactura.Location = new System.Drawing.Point(100, 117);
            this.mtbNFactura.Mask = "999999999";
            this.mtbNFactura.Name = "mtbNFactura";
            this.mtbNFactura.Size = new System.Drawing.Size(100, 20);
            this.mtbNFactura.TabIndex = 24;
            this.mtbNFactura.ValidatingType = typeof(int);
            // 
            // lstTipoFactura
            // 
            this.lstTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipoFactura.FormattingEnabled = true;
            this.lstTipoFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstTipoFactura.Location = new System.Drawing.Point(100, 143);
            this.lstTipoFactura.Name = "lstTipoFactura";
            this.lstTipoFactura.Size = new System.Drawing.Size(100, 21);
            this.lstTipoFactura.TabIndex = 25;
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Location = new System.Drawing.Point(12, 149);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(85, 13);
            this.lblTipoFactura.TabIndex = 26;
            this.lblTipoFactura.Text = "Tipo de Factura:";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 211);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.lstTipoFactura);
            this.Controls.Add(this.mtbNFactura);
            this.Controls.Add(this.lblNFactura);
            this.Controls.Add(this.lstVendedor);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.btnSalirVentas);
            this.Controls.Add(this.btnRegistroVentas);
            this.Controls.Add(this.mtbMontoVentas);
            this.Controls.Add(this.mtbFechasVentas);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirVentas;
        private System.Windows.Forms.Button btnRegistroVentas;
        private System.Windows.Forms.MaskedTextBox mtbMontoVentas;
        private System.Windows.Forms.MaskedTextBox mtbFechasVentas;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox lstCliente;
        private System.Windows.Forms.ComboBox lstVendedor;
        private System.Windows.Forms.Label lblNFactura;
        private System.Windows.Forms.MaskedTextBox mtbNFactura;
        private System.Windows.Forms.ComboBox lstTipoFactura;
        private System.Windows.Forms.Label lblTipoFactura;
    }
}