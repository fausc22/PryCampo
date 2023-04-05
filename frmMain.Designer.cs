namespace PryCampo
{
    partial class frmMain
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
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnCastex = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCharito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.Location = new System.Drawing.Point(30, 58);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(335, 29);
            this.lblSeleccionar.TabIndex = 21;
            this.lblSeleccionar.Text = "Seleccione la organización:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(300, 185);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 31);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Gray;
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAyuda.Location = new System.Drawing.Point(12, 185);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 31);
            this.btnAyuda.TabIndex = 19;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCastex
            // 
            this.btnCastex.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCastex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCastex.Location = new System.Drawing.Point(234, 105);
            this.btnCastex.Name = "btnCastex";
            this.btnCastex.Size = new System.Drawing.Size(144, 61);
            this.btnCastex.TabIndex = 18;
            this.btnCastex.Text = "CAMPO CASTEX";
            this.btnCastex.UseVisualStyleBackColor = false;
            this.btnCastex.Click += new System.EventHandler(this.btnCastex_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(84, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(224, 37);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "BIENVENIDO";
            // 
            // btnCharito
            // 
            this.btnCharito.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCharito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCharito.Location = new System.Drawing.Point(24, 105);
            this.btnCharito.Name = "btnCharito";
            this.btnCharito.Size = new System.Drawing.Size(144, 61);
            this.btnCharito.TabIndex = 16;
            this.btnCharito.Text = "EL CHARITO";
            this.btnCharito.UseVisualStyleBackColor = false;
            this.btnCharito.Click += new System.EventHandler(this.btnCharito_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 240);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnCastex);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCharito);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FC SOFTWARE ©";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnCastex;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCharito;
    }
}