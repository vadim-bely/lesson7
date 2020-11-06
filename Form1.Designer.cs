using System.Drawing;
using System.Windows.Forms;

namespace lesson7
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonF3 = new System.Windows.Forms.RadioButton();
            this.radioButtonFSin = new System.Windows.Forms.RadioButton();
            this.radioButtonF1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxXn = new System.Windows.Forms.TextBox();
            this.textBoxDx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonPoint = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonSrline = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {System.Drawing.Color.Empty};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "y = x + 20";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1030, 408);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Function";
            this.chart1.Titles.Add(title1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonF3);
            this.groupBox1.Controls.Add(this.radioButtonFSin);
            this.groupBox1.Controls.Add(this.radioButtonF1);
            this.groupBox1.Location = new System.Drawing.Point(1104, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // radioButtonF3
            // 
            this.radioButtonF3.Location = new System.Drawing.Point(16, 94);
            this.radioButtonF3.Name = "radioButtonF3";
            this.radioButtonF3.Size = new System.Drawing.Size(122, 24);
            this.radioButtonF3.TabIndex = 2;
            this.radioButtonF3.TabStop = true;
            this.radioButtonF3.Text = "y = x² ";
            this.radioButtonF3.UseVisualStyleBackColor = true;
            this.radioButtonF3.CheckedChanged += new System.EventHandler(this.radioButtonF3_CheckedChanged);
            // 
            // radioButtonFSin
            // 
            this.radioButtonFSin.Location = new System.Drawing.Point(16, 64);
            this.radioButtonFSin.Name = "radioButtonFSin";
            this.radioButtonFSin.Size = new System.Drawing.Size(122, 24);
            this.radioButtonFSin.TabIndex = 1;
            this.radioButtonFSin.TabStop = true;
            this.radioButtonFSin.Text = "y = sin(x) + 3";
            this.radioButtonFSin.UseVisualStyleBackColor = true;
            this.radioButtonFSin.CheckedChanged += new System.EventHandler(this.radioButtonFSin_CheckedChanged);
            // 
            // radioButtonF1
            // 
            this.radioButtonF1.Checked = true;
            this.radioButtonF1.Location = new System.Drawing.Point(16, 34);
            this.radioButtonF1.Name = "radioButtonF1";
            this.radioButtonF1.Size = new System.Drawing.Size(104, 24);
            this.radioButtonF1.TabIndex = 0;
            this.radioButtonF1.TabStop = true;
            this.radioButtonF1.Text = " y = x + 20";
            this.radioButtonF1.UseVisualStyleBackColor = true;
            this.radioButtonF1.CheckedChanged += new System.EventHandler(this.radioButtonF1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1069, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Xn";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1069, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "X0";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1069, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "dX";
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(1094, 172);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(72, 22);
            this.textBoxX0.TabIndex = 6;
            this.textBoxX0.Text = "-100";
            this.textBoxX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX0_KeyPress);
            // 
            // textBoxXn
            // 
            this.textBoxXn.Location = new System.Drawing.Point(1094, 213);
            this.textBoxXn.Name = "textBoxXn";
            this.textBoxXn.Size = new System.Drawing.Size(72, 22);
            this.textBoxXn.TabIndex = 7;
            this.textBoxXn.Text = "100";
            this.textBoxXn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxXn_KeyPress);
            // 
            // textBoxDx
            // 
            this.textBoxDx.Location = new System.Drawing.Point(1094, 252);
            this.textBoxDx.Name = "textBoxDx";
            this.textBoxDx.Size = new System.Drawing.Size(72, 22);
            this.textBoxDx.TabIndex = 8;
            this.textBoxDx.Text = "1";
            this.textBoxDx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDx_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (100)))), ((int) (((byte) (127)))), ((int) (((byte) (255)))), ((int) (((byte) (0)))));
            this.button1.Font = new System.Drawing.Font("Vadim\'s Writing", 27F);
            this.button1.Location = new System.Drawing.Point(1069, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 134);
            this.button1.TabIndex = 9;
            this.button1.Text = "Build a graph";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonPoint);
            this.groupBox2.Controls.Add(this.radioButtonLine);
            this.groupBox2.Controls.Add(this.radioButtonSrline);
            this.groupBox2.Location = new System.Drawing.Point(105, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 60);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chart type";
            // 
            // radioButtonPoint
            // 
            this.radioButtonPoint.Location = new System.Drawing.Point(174, 21);
            this.radioButtonPoint.Name = "radioButtonPoint";
            this.radioButtonPoint.Size = new System.Drawing.Size(104, 24);
            this.radioButtonPoint.TabIndex = 2;
            this.radioButtonPoint.TabStop = true;
            this.radioButtonPoint.Text = "Point";
            this.radioButtonPoint.UseVisualStyleBackColor = true;
            this.radioButtonPoint.CheckedChanged += new System.EventHandler(this.radioButtonPoint_CheckedChanged);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.Location = new System.Drawing.Point(95, 21);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(104, 24);
            this.radioButtonLine.TabIndex = 1;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Line\r\n";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.radioButtonLine_CheckedChanged);
            // 
            // radioButtonSrline
            // 
            this.radioButtonSrline.Checked = true;
            this.radioButtonSrline.Location = new System.Drawing.Point(6, 21);
            this.radioButtonSrline.Name = "radioButtonSrline";
            this.radioButtonSrline.Size = new System.Drawing.Size(104, 24);
            this.radioButtonSrline.TabIndex = 0;
            this.radioButtonSrline.TabStop = true;
            this.radioButtonSrline.Text = "Spline";
            this.radioButtonSrline.UseVisualStyleBackColor = true;
            this.radioButtonSrline.CheckedChanged += new System.EventHandler(this.radioButtonSrline_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1337, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDx);
            this.Controls.Add(this.textBoxXn);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton radioButtonPoint;

        private System.Windows.Forms.RadioButton radioButtonLine;

        private System.Windows.Forms.RadioButton radioButtonSrline;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox textBoxDx;
        private System.Windows.Forms.TextBox textBoxXn;

        private System.Windows.Forms.TextBox textBoxX0;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.RadioButton radioButtonF3;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonF1;
        private System.Windows.Forms.RadioButton radioButtonFSin;

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}