namespace PryCampo
{
    partial class frmCharitoMain
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
            this.btnGanado = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgro = new System.Windows.Forms.Button();
            this.lblSeleccionar = new System.Windows.Forms.Label();
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
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnGanado
            // 
            this.btnGanado.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGanado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGanado.Location = new System.Drawing.Point(248, 138);
            this.btnGanado.Name = "btnGanado";
            this.btnGanado.Size = new System.Drawing.Size(144, 61);
            this.btnGanado.TabIndex = 10;
            this.btnGanado.Text = "GANADERIA";
            this.btnGanado.UseVisualStyleBackColor = false;
            this.btnGanado.Click += new System.EventHandler(this.btnGanado_Click);
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
            // btnAgro
            // 
            this.btnAgro.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAgro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgro.Location = new System.Drawing.Point(38, 138);
            this.btnAgro.Name = "btnAgro";
            this.btnAgro.Size = new System.Drawing.Size(144, 61);
            this.btnAgro.TabIndex = 8;
            this.btnAgro.Text = "AGRICOLA";
            this.btnAgro.UseVisualStyleBackColor = false;
            this.btnAgro.Click += new System.EventHandler(this.btnAgro_Click);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.Location = new System.Drawing.Point(62, 65);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(290, 29);
            this.lblSeleccionar.TabIndex = 15;
            this.lblSeleccionar.Text = "Seleccione la actividad:";
            // 
            // frmCharitoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 322);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnGanado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAgro);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmCharitoMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FC SOFTWARE ©";
            this.Load += new System.EventHandler(this.frmCharitoMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnGanado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgro;
        private System.Windows.Forms.Label lblSeleccionar;
    }
}