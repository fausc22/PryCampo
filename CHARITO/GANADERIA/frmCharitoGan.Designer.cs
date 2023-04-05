namespace PryCampo
{
    partial class frmCharitoGan
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnFlujo = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnPlanCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(302, 266);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 31);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Gray;
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAyuda.Location = new System.Drawing.Point(14, 266);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 31);
            this.btnAyuda.TabIndex = 13;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnFlujo
            // 
            this.btnFlujo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFlujo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFlujo.Location = new System.Drawing.Point(23, 138);
            this.btnFlujo.Name = "btnFlujo";
            this.btnFlujo.Size = new System.Drawing.Size(144, 61);
            this.btnFlujo.TabIndex = 12;
            this.btnFlujo.Text = "FLUJO DE CAJA";
            this.btnFlujo.UseVisualStyleBackColor = false;
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInforme.Location = new System.Drawing.Point(233, 138);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(144, 61);
            this.btnInforme.TabIndex = 11;
            this.btnInforme.Text = "INFORMES Y ESTADÍSTICAS";
            this.btnInforme.UseVisualStyleBackColor = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistro.Location = new System.Drawing.Point(233, 64);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(144, 61);
            this.btnRegistro.TabIndex = 10;
            this.btnRegistro.Text = "REGISTROS";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(126, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(168, 37);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "El Charito";
            // 
            // btnPlanCuenta
            // 
            this.btnPlanCuenta.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPlanCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlanCuenta.Location = new System.Drawing.Point(23, 64);
            this.btnPlanCuenta.Name = "btnPlanCuenta";
            this.btnPlanCuenta.Size = new System.Drawing.Size(144, 61);
            this.btnPlanCuenta.TabIndex = 8;
            this.btnPlanCuenta.Text = "PLAN DE CUENTAS";
            this.btnPlanCuenta.UseVisualStyleBackColor = false;
            this.btnPlanCuenta.Click += new System.EventHandler(this.btnPlanCuenta_Click);
            // 
            // frmCharitoGan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 327);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnFlujo);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnPlanCuenta);
            this.Name = "frmCharitoGan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GANADERIA";
            this.Load += new System.EventHandler(this.frmCharitoGan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnFlujo;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPlanCuenta;
    }
}