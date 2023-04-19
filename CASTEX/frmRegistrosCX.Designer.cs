namespace PryCampo.CASTEX
{
    partial class frmRegistrosCX
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
            this.mrcIngreso = new System.Windows.Forms.GroupBox();
            this.btnNuevoIngreso = new System.Windows.Forms.Button();
            this.txtDescripcionI = new System.Windows.Forms.RichTextBox();
            this.txtPrecioIngreso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoGasto = new System.Windows.Forms.Button();
            this.txtDescripcionG = new System.Windows.Forms.RichTextBox();
            this.txtPrecioGasto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblingreso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnHistoria = new System.Windows.Forms.Button();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mrcIngreso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIngreso
            // 
            this.mrcIngreso.Controls.Add(this.txtIngreso);
            this.mrcIngreso.Controls.Add(this.btnNuevoIngreso);
            this.mrcIngreso.Controls.Add(this.txtDescripcionI);
            this.mrcIngreso.Controls.Add(this.txtPrecioIngreso);
            this.mrcIngreso.Controls.Add(this.label2);
            this.mrcIngreso.Controls.Add(this.lblDescripcion);
            this.mrcIngreso.Controls.Add(this.lblTipo);
            this.mrcIngreso.Location = new System.Drawing.Point(4, 192);
            this.mrcIngreso.Name = "mrcIngreso";
            this.mrcIngreso.Size = new System.Drawing.Size(347, 308);
            this.mrcIngreso.TabIndex = 0;
            this.mrcIngreso.TabStop = false;
            this.mrcIngreso.Enter += new System.EventHandler(this.mrcIngreso_Enter);
            // 
            // btnNuevoIngreso
            // 
            this.btnNuevoIngreso.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNuevoIngreso.Enabled = false;
            this.btnNuevoIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoIngreso.Location = new System.Drawing.Point(89, 268);
            this.btnNuevoIngreso.Name = "btnNuevoIngreso";
            this.btnNuevoIngreso.Size = new System.Drawing.Size(144, 34);
            this.btnNuevoIngreso.TabIndex = 18;
            this.btnNuevoIngreso.Text = "REGISTRAR";
            this.btnNuevoIngreso.UseVisualStyleBackColor = false;
            this.btnNuevoIngreso.Click += new System.EventHandler(this.btnNuevoIngreso_Click);
            // 
            // txtDescripcionI
            // 
            this.txtDescripcionI.Enabled = false;
            this.txtDescripcionI.Location = new System.Drawing.Point(66, 161);
            this.txtDescripcionI.MaxLength = 50;
            this.txtDescripcionI.Name = "txtDescripcionI";
            this.txtDescripcionI.Size = new System.Drawing.Size(198, 91);
            this.txtDescripcionI.TabIndex = 14;
            this.txtDescripcionI.Text = "";
            // 
            // txtPrecioIngreso
            // 
            this.txtPrecioIngreso.Enabled = false;
            this.txtPrecioIngreso.Location = new System.Drawing.Point(183, 61);
            this.txtPrecioIngreso.MaxLength = 10;
            this.txtPrecioIngreso.Name = "txtPrecioIngreso";
            this.txtPrecioIngreso.Size = new System.Drawing.Size(136, 20);
            this.txtPrecioIngreso.TabIndex = 3;
            this.txtPrecioIngreso.TextChanged += new System.EventHandler(this.txtPrecioIngreso_TextChanged);
            this.txtPrecioIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioIngreso_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRECIO ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(84, 133);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(166, 25);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cmbMes.Location = new System.Drawing.Point(306, 103);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(136, 21);
            this.cmbMes.TabIndex = 1;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbTipoIngreso_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(34, 32);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(64, 25);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "TIPO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGasto);
            this.groupBox1.Controls.Add(this.btnNuevoGasto);
            this.groupBox1.Controls.Add(this.txtDescripcionG);
            this.groupBox1.Controls.Add(this.txtPrecioGasto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(402, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnNuevoGasto
            // 
            this.btnNuevoGasto.BackColor = System.Drawing.Color.Crimson;
            this.btnNuevoGasto.Enabled = false;
            this.btnNuevoGasto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoGasto.Location = new System.Drawing.Point(89, 268);
            this.btnNuevoGasto.Name = "btnNuevoGasto";
            this.btnNuevoGasto.Size = new System.Drawing.Size(144, 34);
            this.btnNuevoGasto.TabIndex = 18;
            this.btnNuevoGasto.Text = "REGISTRAR";
            this.btnNuevoGasto.UseVisualStyleBackColor = false;
            this.btnNuevoGasto.Click += new System.EventHandler(this.btnNuevoGasto_Click);
            // 
            // txtDescripcionG
            // 
            this.txtDescripcionG.Enabled = false;
            this.txtDescripcionG.Location = new System.Drawing.Point(66, 161);
            this.txtDescripcionG.MaxLength = 50;
            this.txtDescripcionG.Name = "txtDescripcionG";
            this.txtDescripcionG.Size = new System.Drawing.Size(198, 91);
            this.txtDescripcionG.TabIndex = 14;
            this.txtDescripcionG.Text = "";
            // 
            // txtPrecioGasto
            // 
            this.txtPrecioGasto.Enabled = false;
            this.txtPrecioGasto.Location = new System.Drawing.Point(194, 61);
            this.txtPrecioGasto.MaxLength = 10;
            this.txtPrecioGasto.Name = "txtPrecioGasto";
            this.txtPrecioGasto.Size = new System.Drawing.Size(136, 20);
            this.txtPrecioGasto.TabIndex = 3;
            this.txtPrecioGasto.TextChanged += new System.EventHandler(this.txtPrecioGasto_TextChanged);
            this.txtPrecioGasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioGasto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRECIO ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "DESCRIPCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "TIPO";
            // 
            // lblingreso
            // 
            this.lblingreso.AutoSize = true;
            this.lblingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingreso.Location = new System.Drawing.Point(102, 158);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(166, 31);
            this.lblingreso.TabIndex = 2;
            this.lblingreso.Text = "INGRESOS";
            this.lblingreso.Click += new System.EventHandler(this.lblingreso_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "GASTOS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 37);
            this.label7.TabIndex = 4;
            this.label7.Text = "REGISTROS";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(691, 599);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 31);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "ATRAS";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Gray;
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAyuda.Location = new System.Drawing.Point(585, 599);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 31);
            this.btnAyuda.TabIndex = 22;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnHistoria
            // 
            this.btnHistoria.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHistoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHistoria.Location = new System.Drawing.Point(279, 523);
            this.btnHistoria.Name = "btnHistoria";
            this.btnHistoria.Size = new System.Drawing.Size(188, 68);
            this.btnHistoria.TabIndex = 24;
            this.btnHistoria.Text = "HISTORIAL DE REGISTROS";
            this.btnHistoria.UseVisualStyleBackColor = false;
            this.btnHistoria.Click += new System.EventHandler(this.btnHistoria_Click);
            // 
            // txtGasto
            // 
            this.txtGasto.Enabled = false;
            this.txtGasto.Location = new System.Drawing.Point(6, 61);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(136, 20);
            this.txtGasto.TabIndex = 19;
            // 
            // txtIngreso
            // 
            this.txtIngreso.Enabled = false;
            this.txtIngreso.Location = new System.Drawing.Point(8, 61);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(136, 20);
            this.txtIngreso.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Seleccionar MES";
            // 
            // frmRegistrosCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 643);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHistoria);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblingreso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mrcIngreso);
            this.Name = "frmRegistrosCX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CASTEX";
            this.Load += new System.EventHandler(this.frmRegistrosCX_Load);
            this.mrcIngreso.ResumeLayout(false);
            this.mrcIngreso.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcIngreso;
        private System.Windows.Forms.RichTextBox txtDescripcionI;
        private System.Windows.Forms.TextBox txtPrecioIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnNuevoIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevoGasto;
        private System.Windows.Forms.RichTextBox txtDescripcionG;
        private System.Windows.Forms.TextBox txtPrecioGasto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblingreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnHistoria;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.Label label5;
    }
}