namespace PryCampo.CASTEX
{
    partial class frmPlanCuentasCX
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
            this.lblTituloI = new System.Windows.Forms.Label();
            this.lblTituloG = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.listIngreso = new System.Windows.Forms.ListBox();
            this.listGasto = new System.Windows.Forms.ListBox();
            this.btnAgregarIngreso = new System.Windows.Forms.Button();
            this.btnAgregarGasto = new System.Windows.Forms.Button();
            this.btnEliminarIngreso = new System.Windows.Forms.Button();
            this.btnEliminarGasto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloI
            // 
            this.lblTituloI.AutoSize = true;
            this.lblTituloI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloI.Location = new System.Drawing.Point(12, 68);
            this.lblTituloI.Name = "lblTituloI";
            this.lblTituloI.Size = new System.Drawing.Size(163, 20);
            this.lblTituloI.TabIndex = 0;
            this.lblTituloI.Text = "NUEVO INGRESO:";
            // 
            // lblTituloG
            // 
            this.lblTituloG.AutoSize = true;
            this.lblTituloG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloG.Location = new System.Drawing.Point(221, 68);
            this.lblTituloG.Name = "lblTituloG";
            this.lblTituloG.Size = new System.Drawing.Size(142, 20);
            this.lblTituloG.TabIndex = 1;
            this.lblTituloG.Text = "NUEVO GASTO:";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(16, 95);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(150, 20);
            this.txtIngreso.TabIndex = 2;
            this.txtIngreso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(213, 95);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(150, 20);
            this.txtGasto.TabIndex = 3;
            this.txtGasto.TextChanged += new System.EventHandler(this.txtGasto_TextChanged);
            // 
            // listIngreso
            // 
            this.listIngreso.FormattingEnabled = true;
            this.listIngreso.Location = new System.Drawing.Point(16, 177);
            this.listIngreso.Name = "listIngreso";
            this.listIngreso.Size = new System.Drawing.Size(150, 160);
            this.listIngreso.TabIndex = 4;
            this.listIngreso.SelectedIndexChanged += new System.EventHandler(this.listIngreso_SelectedIndexChanged);
            // 
            // listGasto
            // 
            this.listGasto.FormattingEnabled = true;
            this.listGasto.Location = new System.Drawing.Point(213, 177);
            this.listGasto.Name = "listGasto";
            this.listGasto.Size = new System.Drawing.Size(150, 160);
            this.listGasto.TabIndex = 5;
            this.listGasto.SelectedIndexChanged += new System.EventHandler(this.listGasto_SelectedIndexChanged);
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarIngreso.Location = new System.Drawing.Point(16, 130);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(140, 41);
            this.btnAgregarIngreso.TabIndex = 16;
            this.btnAgregarIngreso.Text = "AGREGAR NUEVO INGRESO";
            this.btnAgregarIngreso.UseVisualStyleBackColor = false;
            this.btnAgregarIngreso.Click += new System.EventHandler(this.btnAgregarIngreso_Click);
            // 
            // btnAgregarGasto
            // 
            this.btnAgregarGasto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarGasto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarGasto.Location = new System.Drawing.Point(213, 130);
            this.btnAgregarGasto.Name = "btnAgregarGasto";
            this.btnAgregarGasto.Size = new System.Drawing.Size(140, 41);
            this.btnAgregarGasto.TabIndex = 17;
            this.btnAgregarGasto.Text = "AGREGAR NUEVO GASTO";
            this.btnAgregarGasto.UseVisualStyleBackColor = false;
            this.btnAgregarGasto.Click += new System.EventHandler(this.btnAgregarGasto_Click);
            // 
            // btnEliminarIngreso
            // 
            this.btnEliminarIngreso.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarIngreso.Location = new System.Drawing.Point(16, 343);
            this.btnEliminarIngreso.Name = "btnEliminarIngreso";
            this.btnEliminarIngreso.Size = new System.Drawing.Size(140, 41);
            this.btnEliminarIngreso.TabIndex = 18;
            this.btnEliminarIngreso.Text = "ELIMINAR INGRESO";
            this.btnEliminarIngreso.UseVisualStyleBackColor = false;
            this.btnEliminarIngreso.Click += new System.EventHandler(this.btnEliminarIngreso_Click);
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarGasto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarGasto.Location = new System.Drawing.Point(213, 343);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(144, 41);
            this.btnEliminarGasto.TabIndex = 19;
            this.btnEliminarGasto.Text = "ELIMINAR GASTO";
            this.btnEliminarGasto.UseVisualStyleBackColor = false;
            this.btnEliminarGasto.Click += new System.EventHandler(this.btnEliminarGasto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(267, 407);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 31);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Gray;
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAyuda.Location = new System.Drawing.Point(12, 407);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 31);
            this.btnAyuda.TabIndex = 22;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(333, 37);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "PLAN DE CUENTAS";
            // 
            // frmPlanCuentasCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 457);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnEliminarGasto);
            this.Controls.Add(this.btnEliminarIngreso);
            this.Controls.Add(this.btnAgregarGasto);
            this.Controls.Add(this.btnAgregarIngreso);
            this.Controls.Add(this.listGasto);
            this.Controls.Add(this.listIngreso);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.lblTituloG);
            this.Controls.Add(this.lblTituloI);
            this.Name = "frmPlanCuentasCX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CASTEX";
            this.Load += new System.EventHandler(this.frmPlanCuentasCX_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloI;
        private System.Windows.Forms.Label lblTituloG;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.ListBox listIngreso;
        private System.Windows.Forms.ListBox listGasto;
        private System.Windows.Forms.Button btnAgregarIngreso;
        private System.Windows.Forms.Button btnAgregarGasto;
        private System.Windows.Forms.Button btnEliminarIngreso;
        private System.Windows.Forms.Button btnEliminarGasto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblTitulo;
    }
}