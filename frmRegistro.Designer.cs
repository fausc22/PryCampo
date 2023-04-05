namespace PryCampo
{
    partial class frmRegistro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.txtMes = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.btnGasto = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.mrcGasto = new System.Windows.Forms.GroupBox();
            this.optInversiones = new System.Windows.Forms.RadioButton();
            this.optImpuestos = new System.Windows.Forms.RadioButton();
            this.optMaquinaria = new System.Windows.Forms.RadioButton();
            this.optRh = new System.Windows.Forms.RadioButton();
            this.optMateriaPrima = new System.Windows.Forms.RadioButton();
            this.optServiciosG = new System.Windows.Forms.RadioButton();
            this.optInsumos = new System.Windows.Forms.RadioButton();
            this.MrcIngreso = new System.Windows.Forms.GroupBox();
            this.optGanado = new System.Windows.Forms.RadioButton();
            this.optMaiz = new System.Windows.Forms.RadioButton();
            this.optSoja = new System.Windows.Forms.RadioButton();
            this.lblDia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultadoDelDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartIngreso = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGasto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblIngresoTitulo = new System.Windows.Forms.Label();
            this.lblIngresoTotal = new System.Windows.Forms.Label();
            this.lblGastoTitulo = new System.Windows.Forms.Label();
            this.lblGastoTotal = new System.Windows.Forms.Label();
            this.lblTotalTitulo = new System.Windows.Forms.Label();
            this.lblResultadoTotal = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mrcGasto.SuspendLayout();
            this.MrcIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGasto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(79, 13);
            this.txtMes.Name = "txtMes";
            this.txtMes.ReadOnly = true;
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 49;
            this.txtMes.Text = "ABRIL";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(12, 9);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(61, 25);
            this.lblMes.TabIndex = 48;
            this.lblMes.Text = "MES";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(169, 208);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(152, 51);
            this.btnMostrar.TabIndex = 47;
            this.btnMostrar.Text = "Flujo de Caja";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDia.Location = new System.Drawing.Point(272, 13);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(52, 21);
            this.cmbDia.TabIndex = 46;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
            // 
            // btnGasto
            // 
            this.btnGasto.Location = new System.Drawing.Point(345, 194);
            this.btnGasto.Name = "btnGasto";
            this.btnGasto.Size = new System.Drawing.Size(75, 23);
            this.btnGasto.TabIndex = 45;
            this.btnGasto.Text = "Ingresar";
            this.btnGasto.UseVisualStyleBackColor = true;
            this.btnGasto.Click += new System.EventHandler(this.btnGasto_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(64, 194);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 44;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // mrcGasto
            // 
            this.mrcGasto.Controls.Add(this.optInversiones);
            this.mrcGasto.Controls.Add(this.optImpuestos);
            this.mrcGasto.Controls.Add(this.optMaquinaria);
            this.mrcGasto.Controls.Add(this.optRh);
            this.mrcGasto.Controls.Add(this.optMateriaPrima);
            this.mrcGasto.Controls.Add(this.optServiciosG);
            this.mrcGasto.Controls.Add(this.optInsumos);
            this.mrcGasto.Location = new System.Drawing.Point(265, 76);
            this.mrcGasto.Name = "mrcGasto";
            this.mrcGasto.Size = new System.Drawing.Size(227, 112);
            this.mrcGasto.TabIndex = 43;
            this.mrcGasto.TabStop = false;
            this.mrcGasto.Text = "Tipo";
            // 
            // optInversiones
            // 
            this.optInversiones.AutoSize = true;
            this.optInversiones.Location = new System.Drawing.Point(128, 65);
            this.optInversiones.Name = "optInversiones";
            this.optInversiones.Size = new System.Drawing.Size(79, 17);
            this.optInversiones.TabIndex = 20;
            this.optInversiones.TabStop = true;
            this.optInversiones.Text = "Inversiones";
            this.optInversiones.UseVisualStyleBackColor = true;
            // 
            // optImpuestos
            // 
            this.optImpuestos.AutoSize = true;
            this.optImpuestos.Location = new System.Drawing.Point(130, 42);
            this.optImpuestos.Name = "optImpuestos";
            this.optImpuestos.Size = new System.Drawing.Size(73, 17);
            this.optImpuestos.TabIndex = 19;
            this.optImpuestos.TabStop = true;
            this.optImpuestos.Text = "Impuestos";
            this.optImpuestos.UseVisualStyleBackColor = true;
            // 
            // optMaquinaria
            // 
            this.optMaquinaria.AutoSize = true;
            this.optMaquinaria.Location = new System.Drawing.Point(130, 19);
            this.optMaquinaria.Name = "optMaquinaria";
            this.optMaquinaria.Size = new System.Drawing.Size(77, 17);
            this.optMaquinaria.TabIndex = 17;
            this.optMaquinaria.TabStop = true;
            this.optMaquinaria.Text = "Maquinaria";
            this.optMaquinaria.UseVisualStyleBackColor = true;
            // 
            // optRh
            // 
            this.optRh.AutoSize = true;
            this.optRh.Location = new System.Drawing.Point(15, 89);
            this.optRh.Name = "optRh";
            this.optRh.Size = new System.Drawing.Size(57, 17);
            this.optRh.TabIndex = 16;
            this.optRh.TabStop = true;
            this.optRh.Text = "RRHH";
            this.optRh.UseVisualStyleBackColor = true;
            // 
            // optMateriaPrima
            // 
            this.optMateriaPrima.AutoSize = true;
            this.optMateriaPrima.Location = new System.Drawing.Point(15, 65);
            this.optMateriaPrima.Name = "optMateriaPrima";
            this.optMateriaPrima.Size = new System.Drawing.Size(89, 17);
            this.optMateriaPrima.TabIndex = 15;
            this.optMateriaPrima.TabStop = true;
            this.optMateriaPrima.Text = "Materia Prima";
            this.optMateriaPrima.UseVisualStyleBackColor = true;
            // 
            // optServiciosG
            // 
            this.optServiciosG.AutoSize = true;
            this.optServiciosG.Location = new System.Drawing.Point(15, 42);
            this.optServiciosG.Name = "optServiciosG";
            this.optServiciosG.Size = new System.Drawing.Size(68, 17);
            this.optServiciosG.TabIndex = 14;
            this.optServiciosG.TabStop = true;
            this.optServiciosG.Text = "Servicios";
            this.optServiciosG.UseVisualStyleBackColor = true;
            // 
            // optInsumos
            // 
            this.optInsumos.AutoSize = true;
            this.optInsumos.Location = new System.Drawing.Point(15, 19);
            this.optInsumos.Name = "optInsumos";
            this.optInsumos.Size = new System.Drawing.Size(64, 17);
            this.optInsumos.TabIndex = 13;
            this.optInsumos.TabStop = true;
            this.optInsumos.Text = "Insumos";
            this.optInsumos.UseVisualStyleBackColor = true;
            // 
            // MrcIngreso
            // 
            this.MrcIngreso.Controls.Add(this.optGanado);
            this.MrcIngreso.Controls.Add(this.optMaiz);
            this.MrcIngreso.Controls.Add(this.optSoja);
            this.MrcIngreso.Location = new System.Drawing.Point(14, 80);
            this.MrcIngreso.Name = "MrcIngreso";
            this.MrcIngreso.Size = new System.Drawing.Size(207, 108);
            this.MrcIngreso.TabIndex = 42;
            this.MrcIngreso.TabStop = false;
            this.MrcIngreso.Text = "Tipo";
            // 
            // optGanado
            // 
            this.optGanado.AutoSize = true;
            this.optGanado.Location = new System.Drawing.Point(102, 19);
            this.optGanado.Name = "optGanado";
            this.optGanado.Size = new System.Drawing.Size(63, 17);
            this.optGanado.TabIndex = 15;
            this.optGanado.TabStop = true;
            this.optGanado.Text = "Ganado";
            this.optGanado.UseVisualStyleBackColor = true;
            // 
            // optMaiz
            // 
            this.optMaiz.AutoSize = true;
            this.optMaiz.Location = new System.Drawing.Point(15, 42);
            this.optMaiz.Name = "optMaiz";
            this.optMaiz.Size = new System.Drawing.Size(47, 17);
            this.optMaiz.TabIndex = 14;
            this.optMaiz.TabStop = true;
            this.optMaiz.Text = "Maiz";
            this.optMaiz.UseVisualStyleBackColor = true;
            // 
            // optSoja
            // 
            this.optSoja.AutoSize = true;
            this.optSoja.Location = new System.Drawing.Point(15, 19);
            this.optSoja.Name = "optSoja";
            this.optSoja.Size = new System.Drawing.Size(46, 17);
            this.optSoja.TabIndex = 13;
            this.optSoja.TabStop = true;
            this.optSoja.Text = "Soja";
            this.optSoja.UseVisualStyleBackColor = true;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(213, 9);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(47, 25);
            this.lblDia.TabIndex = 41;
            this.lblDia.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Gasto";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(26, 48);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblIngreso.TabIndex = 39;
            this.lblIngreso.Text = "Ingreso";
            // 
            // txtGasto
            // 
            this.txtGasto.Enabled = false;
            this.txtGasto.Location = new System.Drawing.Point(345, 45);
            this.txtGasto.MaxLength = 8;
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(100, 20);
            this.txtGasto.TabIndex = 38;
            // 
            // txtIngreso
            // 
            this.txtIngreso.Enabled = false;
            this.txtIngreso.Location = new System.Drawing.Point(92, 48);
            this.txtIngreso.MaxLength = 8;
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtIngreso.TabIndex = 37;
            this.txtIngreso.Text = " ";
            this.txtIngreso.TextChanged += new System.EventHandler(this.txtIngreso_TextChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.InfoText;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeight = 42;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.Ingreso,
            this.Gasto,
            this.ResultadoDelDia});
            this.dgvDatos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDatos.Location = new System.Drawing.Point(904, 9);
            this.dgvDatos.Name = "dgvDatos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDatos.Size = new System.Drawing.Size(349, 575);
            this.dgvDatos.TabIndex = 50;
            this.dgvDatos.Visible = false;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.Width = 48;
            // 
            // Ingreso
            // 
            this.Ingreso.HeaderText = "Ingreso ($)";
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.Width = 76;
            // 
            // Gasto
            // 
            this.Gasto.HeaderText = "Gastos ($)";
            this.Gasto.Name = "Gasto";
            this.Gasto.Width = 74;
            // 
            // ResultadoDelDia
            // 
            this.ResultadoDelDia.HeaderText = "Resultado del Día ($)";
            this.ResultadoDelDia.Name = "ResultadoDelDia";
            this.ResultadoDelDia.Width = 92;
            // 
            // chartIngreso
            // 
            this.chartIngreso.BackColor = System.Drawing.Color.YellowGreen;
            this.chartIngreso.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chartIngreso.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartIngreso.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartIngreso.Legends.Add(legend1);
            this.chartIngreso.Location = new System.Drawing.Point(12, 355);
            this.chartIngreso.Name = "chartIngreso";
            this.chartIngreso.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chartIngreso.Size = new System.Drawing.Size(348, 349);
            this.chartIngreso.TabIndex = 51;
            this.chartIngreso.Visible = false;
            // 
            // chartGasto
            // 
            this.chartGasto.BackColor = System.Drawing.Color.Firebrick;
            this.chartGasto.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea2.Name = "ChartArea1";
            this.chartGasto.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGasto.Legends.Add(legend2);
            this.chartGasto.Location = new System.Drawing.Point(381, 355);
            this.chartGasto.Name = "chartGasto";
            this.chartGasto.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chartGasto.Size = new System.Drawing.Size(348, 353);
            this.chartGasto.TabIndex = 52;
            this.chartGasto.Text = "chart1";
            this.chartGasto.Visible = false;
            // 
            // lblIngresoTitulo
            // 
            this.lblIngresoTitulo.AutoSize = true;
            this.lblIngresoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoTitulo.Location = new System.Drawing.Point(132, 288);
            this.lblIngresoTitulo.Name = "lblIngresoTitulo";
            this.lblIngresoTitulo.Size = new System.Drawing.Size(0, 25);
            this.lblIngresoTitulo.TabIndex = 53;
            // 
            // lblIngresoTotal
            // 
            this.lblIngresoTotal.AutoSize = true;
            this.lblIngresoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoTotal.Location = new System.Drawing.Point(132, 315);
            this.lblIngresoTotal.Name = "lblIngresoTotal";
            this.lblIngresoTotal.Size = new System.Drawing.Size(0, 25);
            this.lblIngresoTotal.TabIndex = 54;
            // 
            // lblGastoTitulo
            // 
            this.lblGastoTitulo.AutoSize = true;
            this.lblGastoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastoTitulo.Location = new System.Drawing.Point(487, 288);
            this.lblGastoTitulo.Name = "lblGastoTitulo";
            this.lblGastoTitulo.Size = new System.Drawing.Size(0, 25);
            this.lblGastoTitulo.TabIndex = 55;
            // 
            // lblGastoTotal
            // 
            this.lblGastoTotal.AutoSize = true;
            this.lblGastoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastoTotal.Location = new System.Drawing.Point(487, 312);
            this.lblGastoTotal.Name = "lblGastoTotal";
            this.lblGastoTotal.Size = new System.Drawing.Size(0, 25);
            this.lblGastoTotal.TabIndex = 56;
            // 
            // lblTotalTitulo
            // 
            this.lblTotalTitulo.AutoSize = true;
            this.lblTotalTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitulo.Location = new System.Drawing.Point(925, 600);
            this.lblTotalTitulo.Name = "lblTotalTitulo";
            this.lblTotalTitulo.Size = new System.Drawing.Size(0, 25);
            this.lblTotalTitulo.TabIndex = 57;
            // 
            // lblResultadoTotal
            // 
            this.lblResultadoTotal.AutoSize = true;
            this.lblResultadoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTotal.Location = new System.Drawing.Point(990, 634);
            this.lblResultadoTotal.Name = "lblResultadoTotal";
            this.lblResultadoTotal.Size = new System.Drawing.Size(0, 25);
            this.lblResultadoTotal.TabIndex = 58;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1119, 227);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 59;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1439, 708);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblResultadoTotal);
            this.Controls.Add(this.lblTotalTitulo);
            this.Controls.Add(this.lblGastoTotal);
            this.Controls.Add(this.lblGastoTitulo);
            this.Controls.Add(this.lblIngresoTotal);
            this.Controls.Add(this.lblIngresoTitulo);
            this.Controls.Add(this.chartGasto);
            this.Controls.Add(this.chartIngreso);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.btnGasto);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.mrcGasto);
            this.Controls.Add(this.MrcIngreso);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.txtIngreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistro";
            this.Text = "REGISTROS";
            this.Load += new System.EventHandler(this.frmPlanCuentas_Load);
            this.mrcGasto.ResumeLayout(false);
            this.mrcGasto.PerformLayout();
            this.MrcIngreso.ResumeLayout(false);
            this.MrcIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGasto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Button btnGasto;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox mrcGasto;
        private System.Windows.Forms.RadioButton optInversiones;
        private System.Windows.Forms.RadioButton optImpuestos;
        private System.Windows.Forms.RadioButton optMaquinaria;
        private System.Windows.Forms.RadioButton optRh;
        private System.Windows.Forms.RadioButton optMateriaPrima;
        private System.Windows.Forms.RadioButton optServiciosG;
        private System.Windows.Forms.RadioButton optInsumos;
        private System.Windows.Forms.GroupBox MrcIngreso;
        private System.Windows.Forms.RadioButton optGanado;
        private System.Windows.Forms.RadioButton optMaiz;
        private System.Windows.Forms.RadioButton optSoja;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultadoDelDia;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGasto;
        private System.Windows.Forms.Label lblIngresoTitulo;
        private System.Windows.Forms.Label lblIngresoTotal;
        private System.Windows.Forms.Label lblGastoTitulo;
        private System.Windows.Forms.Label lblGastoTotal;
        private System.Windows.Forms.Label lblTotalTitulo;
        private System.Windows.Forms.Label lblResultadoTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngreso;
        private System.Windows.Forms.ListView listView1;
    }
}