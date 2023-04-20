namespace PryCampo.CASTEX
{
    partial class frmFlujoCX
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
            this.components = new System.ComponentModel.Container();
            this.lblingreso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditarIngreso = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblResultadoTitulo = new System.Windows.Forms.Label();
            this.lblSigno3 = new System.Windows.Forms.Label();
            this.lblSigno1 = new System.Windows.Forms.Label();
            this.btnHistoria = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.dgvIngreso = new System.Windows.Forms.DataGridView();
            this.dgvGasto = new System.Windows.Forms.DataGridView();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblIngresoTotal = new System.Windows.Forms.Label();
            this.lblResultadoTotal = new System.Windows.Forms.Label();
            this.lblGastoTotal = new System.Windows.Forms.Label();
            this.lblSigno2 = new System.Windows.Forms.Label();
            this.btnEditarGasto = new System.Windows.Forms.Button();
            this.fechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblingreso
            // 
            this.lblingreso.AutoSize = true;
            this.lblingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingreso.Location = new System.Drawing.Point(158, 53);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(166, 31);
            this.lblingreso.TabIndex = 3;
            this.lblingreso.Text = "INGRESOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(832, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "GASTOS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(500, 178);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 34);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "ELIMINAR REGISTRO";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditarIngreso
            // 
            this.btnEditarIngreso.BackColor = System.Drawing.Color.Thistle;
            this.btnEditarIngreso.Enabled = false;
            this.btnEditarIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarIngreso.Location = new System.Drawing.Point(12, 318);
            this.btnEditarIngreso.Name = "btnEditarIngreso";
            this.btnEditarIngreso.Size = new System.Drawing.Size(90, 34);
            this.btnEditarIngreso.TabIndex = 21;
            this.btnEditarIngreso.Text = "EDITAR INGRESO";
            this.btnEditarIngreso.UseVisualStyleBackColor = false;
            this.btnEditarIngreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(397, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(333, 37);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "PLAN DE CUENTAS";
            // 
            // lblResultadoTitulo
            // 
            this.lblResultadoTitulo.AutoSize = true;
            this.lblResultadoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTitulo.Location = new System.Drawing.Point(398, 315);
            this.lblResultadoTitulo.Name = "lblResultadoTitulo";
            this.lblResultadoTitulo.Size = new System.Drawing.Size(336, 31);
            this.lblResultadoTitulo.TabIndex = 25;
            this.lblResultadoTitulo.Text = "RESULTADO MENSUAL";
            this.lblResultadoTitulo.Visible = false;
            // 
            // lblSigno3
            // 
            this.lblSigno3.AutoSize = true;
            this.lblSigno3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno3.Location = new System.Drawing.Point(526, 346);
            this.lblSigno3.Name = "lblSigno3";
            this.lblSigno3.Size = new System.Drawing.Size(30, 31);
            this.lblSigno3.TabIndex = 27;
            this.lblSigno3.Text = "$";
            this.lblSigno3.Visible = false;
            // 
            // lblSigno1
            // 
            this.lblSigno1.AutoSize = true;
            this.lblSigno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno1.Location = new System.Drawing.Point(261, 315);
            this.lblSigno1.Name = "lblSigno1";
            this.lblSigno1.Size = new System.Drawing.Size(25, 25);
            this.lblSigno1.TabIndex = 30;
            this.lblSigno1.Text = "$";
            this.lblSigno1.Visible = false;
            // 
            // btnHistoria
            // 
            this.btnHistoria.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHistoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHistoria.Location = new System.Drawing.Point(490, 401);
            this.btnHistoria.Name = "btnHistoria";
            this.btnHistoria.Size = new System.Drawing.Size(144, 34);
            this.btnHistoria.TabIndex = 34;
            this.btnHistoria.Text = "VER MAS";
            this.btnHistoria.UseVisualStyleBackColor = false;
            this.btnHistoria.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(1019, 440);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 31);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "ATRAS";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Gray;
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAyuda.Location = new System.Drawing.Point(12, 440);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 31);
            this.btnAyuda.TabIndex = 35;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // dgvIngreso
            // 
            this.dgvIngreso.AutoGenerateColumns = false;
            this.dgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvIngreso.DataSource = this.productosBindingSource;
            this.dgvIngreso.Location = new System.Drawing.Point(12, 97);
            this.dgvIngreso.Name = "dgvIngreso";
            this.dgvIngreso.Size = new System.Drawing.Size(473, 215);
            this.dgvIngreso.TabIndex = 38;
            // 
            // dgvGasto
            // 
            this.dgvGasto.AutoGenerateColumns = false;
            this.dgvGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGasto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn1,
            this.tipoDataGridViewTextBoxColumn1,
            this.precioDataGridViewTextBoxColumn1,
            this.descripcionDataGridViewTextBoxColumn1});
            this.dgvGasto.DataSource = this.productosBindingSource;
            this.dgvGasto.Location = new System.Drawing.Point(664, 97);
            this.dgvGasto.Name = "dgvGasto";
            this.dgvGasto.Size = new System.Drawing.Size(473, 215);
            this.dgvGasto.TabIndex = 39;
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
            this.cmbMes.Location = new System.Drawing.Point(500, 73);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(136, 21);
            this.cmbMes.TabIndex = 40;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // lblIngresoTotal
            // 
            this.lblIngresoTotal.AutoSize = true;
            this.lblIngresoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoTotal.Location = new System.Drawing.Point(282, 315);
            this.lblIngresoTotal.Name = "lblIngresoTotal";
            this.lblIngresoTotal.Size = new System.Drawing.Size(21, 24);
            this.lblIngresoTotal.TabIndex = 41;
            this.lblIngresoTotal.Text = "$";
            this.lblIngresoTotal.Visible = false;
            // 
            // lblResultadoTotal
            // 
            this.lblResultadoTotal.AutoSize = true;
            this.lblResultadoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTotal.Location = new System.Drawing.Point(562, 352);
            this.lblResultadoTotal.Name = "lblResultadoTotal";
            this.lblResultadoTotal.Size = new System.Drawing.Size(25, 25);
            this.lblResultadoTotal.TabIndex = 43;
            this.lblResultadoTotal.Text = "$";
            this.lblResultadoTotal.Visible = false;
            // 
            // lblGastoTotal
            // 
            this.lblGastoTotal.AutoSize = true;
            this.lblGastoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastoTotal.Location = new System.Drawing.Point(943, 315);
            this.lblGastoTotal.Name = "lblGastoTotal";
            this.lblGastoTotal.Size = new System.Drawing.Size(21, 24);
            this.lblGastoTotal.TabIndex = 45;
            this.lblGastoTotal.Text = "$";
            this.lblGastoTotal.Visible = false;
            // 
            // lblSigno2
            // 
            this.lblSigno2.AutoSize = true;
            this.lblSigno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno2.Location = new System.Drawing.Point(922, 315);
            this.lblSigno2.Name = "lblSigno2";
            this.lblSigno2.Size = new System.Drawing.Size(25, 25);
            this.lblSigno2.TabIndex = 44;
            this.lblSigno2.Text = "$";
            this.lblSigno2.Visible = false;
            // 
            // btnEditarGasto
            // 
            this.btnEditarGasto.BackColor = System.Drawing.Color.Thistle;
            this.btnEditarGasto.Enabled = false;
            this.btnEditarGasto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarGasto.Location = new System.Drawing.Point(1047, 315);
            this.btnEditarGasto.Name = "btnEditarGasto";
            this.btnEditarGasto.Size = new System.Drawing.Size(90, 34);
            this.btnEditarGasto.TabIndex = 46;
            this.btnEditarGasto.Text = "EDITAR GASTO";
            this.btnEditarGasto.UseVisualStyleBackColor = false;
            this.btnEditarGasto.Click += new System.EventHandler(this.btnEditarGasto_Click);
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            this.fechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            this.fechaDataGridViewTextBoxColumn1.Width = 80;
            // 
            // tipoDataGridViewTextBoxColumn1
            // 
            this.tipoDataGridViewTextBoxColumn1.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn1.Name = "tipoDataGridViewTextBoxColumn1";
            this.tipoDataGridViewTextBoxColumn1.Width = 120;
            // 
            // precioDataGridViewTextBoxColumn1
            // 
            this.precioDataGridViewTextBoxColumn1.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn1.Name = "precioDataGridViewTextBoxColumn1";
            this.precioDataGridViewTextBoxColumn1.Width = 75;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            this.descripcionDataGridViewTextBoxColumn1.Width = 140;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = typeof(PryCampo.Productos);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Width = 120;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 75;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(487, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Seleccionar MES";
            // 
            // frmFlujoCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1149, 483);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditarGasto);
            this.Controls.Add(this.lblGastoTotal);
            this.Controls.Add(this.lblSigno2);
            this.Controls.Add(this.lblResultadoTotal);
            this.Controls.Add(this.lblIngresoTotal);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.dgvGasto);
            this.Controls.Add(this.dgvIngreso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnHistoria);
            this.Controls.Add(this.lblSigno1);
            this.Controls.Add(this.lblSigno3);
            this.Controls.Add(this.lblResultadoTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEditarIngreso);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblingreso);
            this.Name = "frmFlujoCX";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmFlujoCX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblingreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditarIngreso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultadoTitulo;
        private System.Windows.Forms.Label lblSigno3;
        private System.Windows.Forms.Label lblSigno1;
        private System.Windows.Forms.Button btnHistoria;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.DataGridView dgvIngreso;
        private System.Windows.Forms.DataGridView dgvGasto;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblIngresoTotal;
        private System.Windows.Forms.Label lblResultadoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblGastoTotal;
        private System.Windows.Forms.Label lblSigno2;
        private System.Windows.Forms.Button btnEditarGasto;
        private System.Windows.Forms.Label label5;
    }
}