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
            this.btnEliminarIngreso = new System.Windows.Forms.Button();
            this.btnEditarIngreso = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblResultadoTitulo = new System.Windows.Forms.Label();
            this.lblSigno1 = new System.Windows.Forms.Label();
            this.btnHistoria = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblIngresoTotal = new System.Windows.Forms.Label();
            this.lblResultadoTotal = new System.Windows.Forms.Label();
            this.lblGastoTotal = new System.Windows.Forms.Label();
            this.lblSigno2 = new System.Windows.Forms.Label();
            this.btnEditarGasto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarGasto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIngreso = new System.Windows.Forms.DataGridView();
            this.dgvGasto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblingreso
            // 
            this.lblingreso.AutoSize = true;
            this.lblingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingreso.Location = new System.Drawing.Point(621, 12);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(166, 31);
            this.lblingreso.TabIndex = 3;
            this.lblingreso.Text = "INGRESOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(643, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "GASTOS";
            // 
            // btnEliminarIngreso
            // 
            this.btnEliminarIngreso.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarIngreso.Enabled = false;
            this.btnEliminarIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarIngreso.Location = new System.Drawing.Point(378, 173);
            this.btnEliminarIngreso.Name = "btnEliminarIngreso";
            this.btnEliminarIngreso.Size = new System.Drawing.Size(90, 34);
            this.btnEliminarIngreso.TabIndex = 19;
            this.btnEliminarIngreso.Text = "ELIMINAR INGRESO";
            this.btnEliminarIngreso.UseVisualStyleBackColor = false;
            this.btnEliminarIngreso.Click += new System.EventHandler(this.btnEliminarIngreso_Click);
            // 
            // btnEditarIngreso
            // 
            this.btnEditarIngreso.BackColor = System.Drawing.Color.Thistle;
            this.btnEditarIngreso.Enabled = false;
            this.btnEditarIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarIngreso.Location = new System.Drawing.Point(378, 133);
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
            this.lblTitulo.Location = new System.Drawing.Point(73, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(333, 37);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "PLAN DE CUENTAS";
            // 
            // lblResultadoTitulo
            // 
            this.lblResultadoTitulo.AutoSize = true;
            this.lblResultadoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTitulo.Location = new System.Drawing.Point(4, 233);
            this.lblResultadoTitulo.Name = "lblResultadoTitulo";
            this.lblResultadoTitulo.Size = new System.Drawing.Size(336, 31);
            this.lblResultadoTitulo.TabIndex = 25;
            this.lblResultadoTitulo.Text = "RESULTADO MENSUAL";
            this.lblResultadoTitulo.Visible = false;
            // 
            // lblSigno1
            // 
            this.lblSigno1.AutoSize = true;
            this.lblSigno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno1.Location = new System.Drawing.Point(63, 41);
            this.lblSigno1.Name = "lblSigno1";
            this.lblSigno1.Size = new System.Drawing.Size(209, 25);
            this.lblSigno1.TabIndex = 30;
            this.lblSigno1.Text = "TOTAL INGRESOS";
            this.lblSigno1.Visible = false;
            // 
            // btnHistoria
            // 
            this.btnHistoria.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHistoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHistoria.Location = new System.Drawing.Point(96, 356);
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
            this.btnSalir.Location = new System.Drawing.Point(114, 529);
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
            this.btnAyuda.Location = new System.Drawing.Point(12, 529);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 31);
            this.btnAyuda.TabIndex = 35;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
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
            this.cmbMes.Location = new System.Drawing.Point(176, 73);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(136, 21);
            this.cmbMes.TabIndex = 40;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // lblIngresoTotal
            // 
            this.lblIngresoTotal.AutoSize = true;
            this.lblIngresoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoTotal.Location = new System.Drawing.Point(138, 66);
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
            this.lblResultadoTotal.Location = new System.Drawing.Point(137, 264);
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
            this.lblGastoTotal.Location = new System.Drawing.Point(127, 154);
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
            this.lblSigno2.Location = new System.Drawing.Point(63, 129);
            this.lblSigno2.Name = "lblSigno2";
            this.lblSigno2.Size = new System.Drawing.Size(185, 25);
            this.lblSigno2.TabIndex = 44;
            this.lblSigno2.Text = "TOTAL GASTOS";
            this.lblSigno2.Visible = false;
            // 
            // btnEditarGasto
            // 
            this.btnEditarGasto.BackColor = System.Drawing.Color.Thistle;
            this.btnEditarGasto.Enabled = false;
            this.btnEditarGasto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarGasto.Location = new System.Drawing.Point(378, 395);
            this.btnEditarGasto.Name = "btnEditarGasto";
            this.btnEditarGasto.Size = new System.Drawing.Size(90, 34);
            this.btnEditarGasto.TabIndex = 46;
            this.btnEditarGasto.Text = "EDITAR GASTO";
            this.btnEditarGasto.UseVisualStyleBackColor = false;
            this.btnEditarGasto.Click += new System.EventHandler(this.btnEditarGasto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Seleccionar MES";
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarGasto.Enabled = false;
            this.btnEliminarGasto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarGasto.Location = new System.Drawing.Point(378, 435);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(90, 34);
            this.btnEliminarGasto.TabIndex = 48;
            this.btnEliminarGasto.Text = "ELIMINAR GASTO";
            this.btnEliminarGasto.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultadoTitulo);
            this.groupBox1.Controls.Add(this.lblResultadoTotal);
            this.groupBox1.Controls.Add(this.lblSigno1);
            this.groupBox1.Controls.Add(this.lblIngresoTotal);
            this.groupBox1.Controls.Add(this.lblGastoTotal);
            this.groupBox1.Controls.Add(this.lblSigno2);
            this.groupBox1.Controls.Add(this.btnHistoria);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 406);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvIngreso
            // 
            this.dgvIngreso.AllowUserToAddRows = false;
            this.dgvIngreso.AllowUserToDeleteRows = false;
            this.dgvIngreso.AutoGenerateColumns = false;
            this.dgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvIngreso.DataSource = this.productosBindingSource3;
            this.dgvIngreso.Location = new System.Drawing.Point(475, 56);
            this.dgvIngreso.Name = "dgvIngreso";
            this.dgvIngreso.ReadOnly = true;
            this.dgvIngreso.Size = new System.Drawing.Size(474, 215);
            this.dgvIngreso.TabIndex = 50;
            // 
            // dgvGasto
            // 
            this.dgvGasto.AllowUserToAddRows = false;
            this.dgvGasto.AllowUserToDeleteRows = false;
            this.dgvGasto.AutoGenerateColumns = false;
            this.dgvGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGasto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvGasto.DataSource = this.productosBindingSource3;
            this.dgvGasto.Location = new System.Drawing.Point(474, 341);
            this.dgvGasto.Name = "dgvGasto";
            this.dgvGasto.ReadOnly = true;
            this.dgvGasto.Size = new System.Drawing.Size(474, 215);
            this.dgvGasto.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Seleccionar MES";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // productosBindingSource3
            // 
            this.productosBindingSource3.DataSource = typeof(PryCampo.Productos);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 120;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 75;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 80;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 140;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = typeof(PryCampo.Productos);
            // 
            // productosBindingSource2
            // 
            this.productosBindingSource2.DataSource = typeof(PryCampo.Productos);
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataSource = typeof(PryCampo.Productos);
            // 
            // frmFlujoCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGasto);
            this.Controls.Add(this.dgvIngreso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarGasto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditarGasto);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEditarIngreso);
            this.Controls.Add(this.btnEliminarIngreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblingreso);
            this.Name = "frmFlujoCX";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmFlujoCX_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblingreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarIngreso;
        private System.Windows.Forms.Button btnEditarIngreso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultadoTitulo;
        private System.Windows.Forms.Label lblSigno1;
        private System.Windows.Forms.Button btnHistoria;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.Label lblIngresoTotal;
        private System.Windows.Forms.Label lblResultadoTotal;
        private System.Windows.Forms.Label lblGastoTotal;
        private System.Windows.Forms.Label lblSigno2;
        private System.Windows.Forms.Button btnEditarGasto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarGasto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private System.Windows.Forms.BindingSource productosBindingSource2;
        private System.Windows.Forms.DataGridView dgvIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productosBindingSource3;
        private System.Windows.Forms.DataGridView dgvGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbMes;
    }
}