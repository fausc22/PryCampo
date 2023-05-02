namespace PryCampo.CASTEX
{
    partial class frmInformeCX
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataSet1 = new PryCampo.DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelec = new System.Windows.Forms.Button();
            this.optTotal = new System.Windows.Forms.RadioButton();
            this.optMes = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chTotal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGastos)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // chIngresos
            // 
            chartArea1.Name = "ChartArea1";
            this.chIngresos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chIngresos.Legends.Add(legend1);
            this.chIngresos.Location = new System.Drawing.Point(34, 78);
            this.chIngresos.Name = "chIngresos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chIngresos.Series.Add(series1);
            this.chIngresos.Size = new System.Drawing.Size(331, 279);
            this.chIngresos.TabIndex = 0;
            this.chIngresos.Text = "chart1";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(940, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1033, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chIngresos);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 399);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESOS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMes);
            this.groupBox2.Controls.Add(this.optTotal);
            this.groupBox2.Controls.Add(this.optMes);
            this.groupBox2.Location = new System.Drawing.Point(473, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 73);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnSelec
            // 
            this.btnSelec.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSelec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelec.Location = new System.Drawing.Point(557, 152);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(75, 23);
            this.btnSelec.TabIndex = 18;
            this.btnSelec.Text = "Seleccionar";
            this.btnSelec.UseVisualStyleBackColor = false;
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // optTotal
            // 
            this.optTotal.AutoSize = true;
            this.optTotal.Location = new System.Drawing.Point(147, 19);
            this.optTotal.Name = "optTotal";
            this.optTotal.Size = new System.Drawing.Size(60, 17);
            this.optTotal.TabIndex = 1;
            this.optTotal.TabStop = true;
            this.optTotal.Text = "Totales";
            this.optTotal.UseVisualStyleBackColor = true;
            // 
            // optMes
            // 
            this.optMes.AutoSize = true;
            this.optMes.Location = new System.Drawing.Point(6, 19);
            this.optMes.Name = "optMes";
            this.optMes.Size = new System.Drawing.Size(123, 17);
            this.optMes.TabIndex = 0;
            this.optMes.TabStop = true;
            this.optMes.Text = "Por Mes (Categorias)";
            this.optMes.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.chGastos);
            this.groupBox3.Location = new System.Drawing.Point(828, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 399);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "GASTOS";
            // 
            // chGastos
            // 
            chartArea2.Name = "ChartArea1";
            this.chGastos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chGastos.Legends.Add(legend2);
            this.chGastos.Location = new System.Drawing.Point(35, 78);
            this.chGastos.Name = "chGastos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chGastos.Series.Add(series2);
            this.chGastos.Size = new System.Drawing.Size(328, 279);
            this.chGastos.TabIndex = 0;
            this.chGastos.Text = "chart1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.chTotal);
            this.groupBox4.Location = new System.Drawing.Point(406, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 399);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "TOTAL";
            // 
            // chTotal
            // 
            chartArea3.Name = "ChartArea1";
            this.chTotal.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chTotal.Legends.Add(legend3);
            this.chTotal.Location = new System.Drawing.Point(35, 78);
            this.chTotal.Name = "chTotal";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chTotal.Series.Add(series3);
            this.chTotal.Size = new System.Drawing.Size(328, 279);
            this.chTotal.TabIndex = 0;
            this.chTotal.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "INFORMES Y ESTADÍSTICAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seleccione una opción";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(1124, 554);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 31);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "ATRAS";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Gray;
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAyuda.Location = new System.Drawing.Point(1018, 554);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(90, 31);
            this.btnAyuda.TabIndex = 24;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
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
            this.cmbMes.Location = new System.Drawing.Point(6, 42);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(123, 21);
            this.cmbMes.TabIndex = 19;
            // 
            // frmInformeCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1236, 670);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSelec);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "frmInformeCX";
            this.Text = "frmInformeCX";
            this.Load += new System.EventHandler(this.frmInformeCX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chGastos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chIngresos;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optTotal;
        private System.Windows.Forms.RadioButton optMes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGastos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTotal;
        private System.Windows.Forms.Button btnSelec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.ComboBox cmbMes;
    }
}