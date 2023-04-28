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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataSet1 = new PryCampo.DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chIngresos
            // 
            chartArea3.Name = "ChartArea1";
            this.chIngresos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chIngresos.Legends.Add(legend3);
            this.chIngresos.Location = new System.Drawing.Point(50, 48);
            this.chIngresos.Name = "chIngresos";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chIngresos.Series.Add(series3);
            this.chIngresos.Size = new System.Drawing.Size(300, 300);
            this.chIngresos.TabIndex = 0;
            this.chIngresos.Text = "chart1";
            // 
            // chGastos
            // 
            chartArea4.Name = "ChartArea1";
            this.chGastos.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chGastos.Legends.Add(legend4);
            this.chGastos.Location = new System.Drawing.Point(586, 48);
            this.chGastos.Name = "chGastos";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chGastos.Series.Add(series4);
            this.chGastos.Size = new System.Drawing.Size(300, 300);
            this.chGastos.TabIndex = 1;
            this.chGastos.Text = "chart2";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInformeCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1185, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chGastos);
            this.Controls.Add(this.chIngresos);
            this.Name = "frmInformeCX";
            this.Text = "frmInformeCX";
            this.Load += new System.EventHandler(this.frmInformeCX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chIngresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGastos;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button button1;
    }
}