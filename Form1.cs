using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lesson7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar==System.Globalization.CultureInfo
                .CurrentCulture.NumberFormat.NumberDecimalSeparator[0] || e.KeyChar == '-');
        }
        
        private void textBoxXn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar==System.Globalization.CultureInfo
                .CurrentCulture.NumberFormat.NumberDecimalSeparator[0] || e.KeyChar == '-');
        }
        
        private void textBoxDx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar==System.Globalization.CultureInfo
                .CurrentCulture.NumberFormat.NumberDecimalSeparator[0] || e.KeyChar == '-');
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonF1.Checked)
            {
                chart1.Series[0].Points.Clear();
                for (double x = double.Parse(textBoxX0.Text); x <= Double.Parse(textBoxXn.Text); x += Double.Parse(textBoxDx.Text))
                {
                    chart1.Series[0].Points.AddXY(x, x + 20);
                }
            }
            if (radioButtonFSin.Checked)
            {
                chart1.Series[0].Points.Clear();
                for (double x = double.Parse(textBoxX0.Text); x <= Double.Parse(textBoxXn.Text); x += Double.Parse(textBoxDx.Text))
                {
                    chart1.Series[0].Points.AddXY(x, Math.Sin(x) +3);
                }
            }
            
            if (radioButtonF3.Checked)
            {
                chart1.Series[0].Points.Clear();
                for (double x = double.Parse(textBoxX0.Text); x <= Double.Parse(textBoxXn.Text); x += Double.Parse(textBoxDx.Text))
                {
                    chart1.Series[0].Points.AddXY(x, Math.Pow(x,2));
                }
            }
        }
        
        
        

        private void radioButtonSrline_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Spline;
        }

        private void radioButtonLine_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Line;
        }
        
        private void radioButtonPoint_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = SeriesChartType.Point;
        }

        private void radioButtonF1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].LegendText = "y = x + 20";
            chart1.Series[0].Points.Clear();
            for (double x = double.Parse(textBoxX0.Text); x <= Double.Parse(textBoxXn.Text); x += Double.Parse(textBoxDx.Text))
            {
                chart1.Series[0].Points.AddXY(x, x + 20);
            }
        }

        private void radioButtonFSin_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].LegendText  = "y = sin(x) + 3";
            chart1.Series[0].Points.Clear();
            for (double x = double.Parse(textBoxX0.Text); x <= Double.Parse(textBoxXn.Text); x += Double.Parse(textBoxDx.Text))
            {
                chart1.Series[0].Points.AddXY(x, Math.Sin(x) +3);
            }
        }

        private void radioButtonF3_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].LegendText = "y = x²";
            chart1.Series[0].Points.Clear(); 
            for (double x = double.Parse(textBoxX0.Text); x <= Double.Parse(textBoxXn.Text); x += Double.Parse(textBoxDx.Text))
            {
                chart1.Series[0].Points.AddXY(x, Math.Pow(x,2));
            }
        }
    }
}