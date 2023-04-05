namespace PryCampo
{
    partial class frmCastexMain
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
            this.btnSalir.Location = new System.Drawing.Point(303, 266);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 31);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Gray;
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAyuda.Location = new System.Drawing.Point(15, 266);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 31);
            this.btnAyuda.TabIndex = 20;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnFlujo
            // 
            this.btnFlujo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFlujo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFlujo.Location = new System.Drawing.Point(24, 138);
            this.btnFlujo.Name = "btnFlujo";
            this.btnFlujo.Size = new System.Drawing.Size(144, 61);
            this.btnFlujo.TabIndex = 19;
            this.btnFlujo.Text = "FLUJO DE CAJA";
            this.btnFlujo.UseVisualStyleBackColor = false;
            this.btnFlujo.Click += new System.EventHandler(this.btnFlujo_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInforme.Location = new System.Drawing.Point(234, 138);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(144, 61);
            this.btnInforme.TabIndex = 18;
            this.btnInforme.Text = "INFORMES Y ESTADÍSTICAS";
            this.btnInforme.UseVisualStyleBackColor = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistro.Location = new System.Drawing.Point(234, 64);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(144, 61);
            this.btnRegistro.TabIndex = 17;
            this.btnRegistro.Text = "REGISTROS";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(127, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 37);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "CASTEX";
            // 
            // btnPlanCuenta
            // 
            this.btnPlanCuenta.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPlanCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlanCuenta.Location = new System.Drawing.Point(24, 64);
            this.btnPlanCuenta.Name = "btnPlanCuenta";
            this.btnPlanCuenta.Size = new System.Drawing.Size(144, 61);
            this.btnPlanCuenta.TabIndex = 15;
            this.btnPlanCuenta.Text = "PLAN DE CUENTAS";
            this.btnPlanCuenta.UseVisualStyleBackColor = false;
            this.btnPlanCuenta.Click += new System.EventHandler(this.btnPlanCuenta_Click);
            // 
            // frmCastexMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 336);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnFlujo);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnPlanCuenta);
            this.Name = "frmCastexMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FC SOFTWARE ©";
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