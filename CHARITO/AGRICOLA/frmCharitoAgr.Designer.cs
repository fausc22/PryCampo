namespace PryCampo
{
    partial class frmCharitoAgr
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCharitoAgr));
            this.btnPlanCuenta = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnFlujo = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlanCuenta
            // 
            this.btnPlanCuenta.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPlanCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlanCuenta.Location = new System.Drawing.Point(12, 64);
            this.btnPlanCuenta.Name = "btnPlanCuenta";
            this.btnPlanCuenta.Size = new System.Drawing.Size(144, 61);
            this.btnPlanCuenta.TabIndex = 0;
            this.btnPlanCuenta.Text = "PLAN DE CUENTAS";
            this.btnPlanCuenta.UseVisualStyleBackColor = false;
            this.btnPlanCuenta.Click += new System.EventHandler(this.btnPlanCuenta_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(115, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(168, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "El Charito";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistro.Location = new System.Drawing.Point(222, 64);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(144, 61);
            this.btnRegistro.TabIndex = 3;
            this.btnRegistro.Text = "REGISTROS";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInforme.Location = new System.Drawing.Point(222, 138);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(144, 61);
            this.btnInforme.TabIndex = 4;
            this.btnInforme.Text = "INFORMES Y ESTADÍSTICAS";
            this.btnInforme.UseVisualStyleBackColor = false;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnFlujo
            // 
            this.btnFlujo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFlujo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFlujo.Location = new System.Drawing.Point(12, 138);
            this.btnFlujo.Name = "btnFlujo";
            this.btnFlujo.Size = new System.Drawing.Size(144, 61);
            this.btnFlujo.TabIndex = 5;
            this.btnFlujo.Text = "FLUJO DE CAJA";
            this.btnFlujo.UseVisualStyleBackColor = false;
            this.btnFlujo.Click += new System.EventHandler(this.btnFlujo_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Gray;
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAyuda.Location = new System.Drawing.Point(3, 266);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 31);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(291, 266);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 31);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCharitoAgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(393, 309);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnFlujo);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnPlanCuenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCharitoAgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGRICOLA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlanCuenta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnFlujo;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnSalir;
    }
}

