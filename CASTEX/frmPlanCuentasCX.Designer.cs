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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "aa"});
            this.listBox1.Location = new System.Drawing.Point(16, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 160);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "aa"});
            this.listBox2.Location = new System.Drawing.Point(213, 177);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 160);
            this.listBox2.TabIndex = 5;
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
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAgregarIngreso;
        private System.Windows.Forms.Button btnAgregarGasto;
        private System.Windows.Forms.Button btnEliminarIngreso;
        private System.Windows.Forms.Button btnEliminarGasto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblTitulo;
    }
}