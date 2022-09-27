namespace pryMigotti_SP1ER
{
    partial class frmConsultaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVentas));
            this.btnLimpiarCVentas = new System.Windows.Forms.Button();
            this.dgvConsultaVentas = new System.Windows.Forms.DataGridView();
            this.btnSalirCVentas = new System.Windows.Forms.Button();
            this.btnListarCVentas = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarCVentas
            // 
            this.btnLimpiarCVentas.Location = new System.Drawing.Point(93, 171);
            this.btnLimpiarCVentas.Name = "btnLimpiarCVentas";
            this.btnLimpiarCVentas.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCVentas.TabIndex = 13;
            this.btnLimpiarCVentas.Text = "Limpiar";
            this.btnLimpiarCVentas.UseVisualStyleBackColor = true;
            this.btnLimpiarCVentas.Click += new System.EventHandler(this.btnLimpiarCVentas_Click);
            // 
            // dgvConsultaVentas
            // 
            this.dgvConsultaVentas.AllowUserToAddRows = false;
            this.dgvConsultaVentas.AllowUserToDeleteRows = false;
            this.dgvConsultaVentas.AllowUserToResizeColumns = false;
            this.dgvConsultaVentas.AllowUserToResizeRows = false;
            this.dgvConsultaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvConsultaVentas.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaVentas.Name = "dgvConsultaVentas";
            this.dgvConsultaVentas.ReadOnly = true;
            this.dgvConsultaVentas.Size = new System.Drawing.Size(240, 150);
            this.dgvConsultaVentas.TabIndex = 12;
            // 
            // btnSalirCVentas
            // 
            this.btnSalirCVentas.Location = new System.Drawing.Point(12, 171);
            this.btnSalirCVentas.Name = "btnSalirCVentas";
            this.btnSalirCVentas.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCVentas.TabIndex = 11;
            this.btnSalirCVentas.Text = "Salir";
            this.btnSalirCVentas.UseVisualStyleBackColor = true;
            this.btnSalirCVentas.Click += new System.EventHandler(this.btnSalirCVentas_Click);
            // 
            // btnListarCVentas
            // 
            this.btnListarCVentas.Location = new System.Drawing.Point(174, 171);
            this.btnListarCVentas.Name = "btnListarCVentas";
            this.btnListarCVentas.Size = new System.Drawing.Size(75, 23);
            this.btnListarCVentas.TabIndex = 10;
            this.btnListarCVentas.Text = "Listar";
            this.btnListarCVentas.UseVisualStyleBackColor = true;
            this.btnListarCVentas.Click += new System.EventHandler(this.btnListarCVentas_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Monto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cliente";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vendedor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "N° Factura";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tipo de Factura";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // frmConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 204);
            this.Controls.Add(this.btnLimpiarCVentas);
            this.Controls.Add(this.dgvConsultaVentas);
            this.Controls.Add(this.btnSalirCVentas);
            this.Controls.Add(this.btnListarCVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarCVentas;
        private System.Windows.Forms.DataGridView dgvConsultaVentas;
        private System.Windows.Forms.Button btnSalirCVentas;
        private System.Windows.Forms.Button btnListarCVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}