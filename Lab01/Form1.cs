﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      CreateGraph();
    }

    private void EventButton_Click(object sender, EventArgs e)
    {
      EventButton.Enabled = false;

      string txt;
      double intensity1;
      txt = aInp.Text.Replace(".", ",");
      intensity1 = Convert.ToDouble(txt);

      double intensity2;
      double scatter2;
      txt = muInp.Text.Replace(".", ",");
      intensity2 = Convert.ToDouble(txt);

      txt = sigInp.Text.Replace(".", ",");
      scatter2 = Convert.ToDouble(txt);

      int max;
      txt = pInp.Text.Replace(".", ",");
      max = Convert.ToInt32(txt);

      EventModel model = new EventModel(intensity1, intensity2, scatter2, max);

      model.modelate();

      lenOut.Text = Math.Round(model.avg_que_time, 2).ToString();
      textBox1.Text = Math.Round(model.theory_drain, 2).ToString();
      textBox2.Text = Math.Round(model.practice_drain, 2).ToString();

      EventButton.Enabled = true;
    }

    private void graphicBtn_Click(object sender, EventArgs e)
    {
      graphicBtn.Enabled = false;

      CreateGraph();

      graphicBtn.Enabled = true;
    }

    private void CreateGraph()
    {

      chart1.Series.Clear();
      chart1.Series.Add("Зависимость ср. времени ожидания от загрузки");
      chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      //chart1.Series[0].Points.AddXY(0, 0);

      int iters = 100; // 20 200 100
      for (int i = 1; i <= iters; i++)
      {

        double intensity2 = iters;
        double intensity1 = i;

        int max = 1000; // 1000 100 10000

        EventModel model = new EventModel(intensity1, intensity2, 0, max);

        double x = 0;
        double y = 0;

        int iters2 = 100; // 1 1000 100
        for (int j = 0; j < iters2; j ++)
        {
          model.modelate();
          x += model.theory_drain;
          //y += model.avg_full_time;
          y += model.avg_que_time;
        }
        x /= iters2;
        y /= iters2;

        //Render
        chart1.Series[0].Points.AddXY(x, y);
        //chart1.Series[0].Points.AddXY(x, y - 1);
      }

      chart1.ChartAreas[0].AxisX.Interval = 0.10;
      //chart1.ChartAreas[0].AxisX.IntervalOffset = 0.01;
      chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0.##}";
    }
  } 
}
