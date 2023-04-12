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
            this.cmbTipoIngreso = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoGasto = new System.Windows.Forms.Button();
            this.txtDescripcionG = new System.Windows.Forms.RichTextBox();
            this.txtPrecioGasto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoGasto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblingreso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnHistoria = new System.Windows.Forms.Button();
            this.mrcIngreso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIngreso
            // 
            this.mrcIngreso.Controls.Add(this.btnNuevoIngreso);
            this.mrcIngreso.Controls.Add(this.txtDescripcionI);
            this.mrcIngreso.Controls.Add(this.txtPrecioIngreso);
            this.mrcIngreso.Controls.Add(this.label2);
            this.mrcIngreso.Controls.Add(this.lblDescripcion);
            this.mrcIngreso.Controls.Add(this.cmbTipoIngreso);
            this.mrcIngreso.Controls.Add(this.lblTipo);
            this.mrcIngreso.Location = new System.Drawing.Point(4, 124);
            this.mrcIngreso.Name = "mrcIngreso";
            this.mrcIngreso.Size = new System.Drawing.Size(347, 308);
            this.mrcIngreso.TabIndex = 0;
            this.mrcIngreso.TabStop = false;
            // 
            // btnNuevoIngreso
            // 
            this.btnNuevoIngreso.BackColor = System.Drawing.Color.SeaGreen;
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
            this.txtPrecioIngreso.Name = "txtPrecioIngreso";
            this.txtPrecioIngreso.Size = new System.Drawing.Size(136, 20);
            this.txtPrecioIngreso.TabIndex = 3;
            this.txtPrecioIngreso.TextChanged += new System.EventHandler(this.txtPrecioIngreso_TextChanged);
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
            // cmbTipoIngreso
            // 
            this.cmbTipoIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIngreso.FormattingEnabled = true;
            this.cmbTipoIngreso.Items.AddRange(new object[] {
            "comida\t",
            "pan"});
            this.cmbTipoIngreso.Location = new System.Drawing.Point(6, 60);
            this.cmbTipoIngreso.Name = "cmbTipoIngreso";
            this.cmbTipoIngreso.Size = new System.Drawing.Size(136, 21);
            this.cmbTipoIngreso.TabIndex = 1;
            this.cmbTipoIngreso.SelectedIndexChanged += new System.EventHandler(this.cmbTipoIngreso_SelectedIndexChanged);
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
            this.groupBox1.Controls.Add(this.btnNuevoGasto);
            this.groupBox1.Controls.Add(this.txtDescripcionG);
            this.groupBox1.Controls.Add(this.txtPrecioGasto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTipoGasto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(402, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnNuevoGasto
            // 
            this.btnNuevoGasto.BackColor = System.Drawing.Color.Crimson;
            this.btnNuevoGasto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoGasto.Location = new System.Drawing.Point(89, 268);
            this.btnNuevoGasto.Name = "btnNuevoGasto";
            this.btnNuevoGasto.Size = new System.Drawing.Size(144, 34);
            this.btnNuevoGasto.TabIndex = 18;
            this.btnNuevoGasto.Text = "REGISTRAR";
            this.btnNuevoGasto.UseVisualStyleBackColor = false;
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
            this.txtPrecioGasto.Location = new System.Drawing.Point(183, 61);
            this.txtPrecioGasto.Name = "txtPrecioGasto";
            this.txtPrecioGasto.Size = new System.Drawing.Size(136, 20);
            this.txtPrecioGasto.TabIndex = 3;
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
            // cmbTipoGasto
            // 
            this.cmbTipoGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoGasto.FormattingEnabled = true;
            this.cmbTipoGasto.Location = new System.Drawing.Point(6, 60);
            this.cmbTipoGasto.Name = "cmbTipoGasto";
            this.cmbTipoGasto.Size = new System.Drawing.Size(136, 21);
            this.cmbTipoGasto.TabIndex = 1;
            this.cmbTipoGasto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoGasto_SelectedIndexChanged);
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
            this.lblingreso.Location = new System.Drawing.Point(102, 90);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(166, 31);
            this.lblingreso.TabIndex = 2;
            this.lblingreso.Text = "INGRESOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "GASTOS";
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
            this.btnSalir.Location = new System.Drawing.Point(691, 502);
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
            this.btnAyuda.Location = new System.Drawing.Point(585, 502);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 31);
            this.btnAyuda.TabIndex = 22;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnHistoria
            // 
            this.btnHistoria.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHistoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHistoria.Location = new System.Drawing.Point(279, 449);
            this.btnHistoria.Name = "btnHistoria";
            this.btnHistoria.Size = new System.Drawing.Size(188, 68);
            this.btnHistoria.TabIndex = 24;
            this.btnHistoria.Text = "HISTORIAL DE REGISTROS";
            this.btnHistoria.UseVisualStyleBackColor = false;
            // 
            // frmRegistrosCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 545);
            this.Controls.Add(this.btnHistoria);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.ComboBox cmbTipoIngreso;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnNuevoIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevoGasto;
        private System.Windows.Forms.RichTextBox txtDescripcionG;
        private System.Windows.Forms.TextBox txtPrecioGasto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoGasto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblingreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnHistoria;
    }
}