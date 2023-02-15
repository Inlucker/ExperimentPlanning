
namespace Lab01
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.lenOut = new System.Windows.Forms.TextBox();
      this.EventButton = new System.Windows.Forms.Button();
      this.label10 = new System.Windows.Forms.Label();
      this.pInp = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.sigInp = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.muInp = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.aInp = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.graphicBtn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // lenOut
      // 
      this.lenOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lenOut.Location = new System.Drawing.Point(280, 187);
      this.lenOut.Margin = new System.Windows.Forms.Padding(5);
      this.lenOut.Name = "lenOut";
      this.lenOut.ReadOnly = true;
      this.lenOut.Size = new System.Drawing.Size(152, 29);
      this.lenOut.TabIndex = 33;
      this.lenOut.Text = "0";
      // 
      // EventButton
      // 
      this.EventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.EventButton.Location = new System.Drawing.Point(14, 316);
      this.EventButton.Name = "EventButton";
      this.EventButton.Size = new System.Drawing.Size(310, 80);
      this.EventButton.TabIndex = 32;
      this.EventButton.Text = "Моделировать";
      this.EventButton.UseVisualStyleBackColor = true;
      this.EventButton.Click += new System.EventHandler(this.EventButton_Click);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label10.Location = new System.Drawing.Point(10, 150);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(220, 24);
      this.label10.TabIndex = 29;
      this.label10.Text = "Время моделирования:";
      // 
      // pInp
      // 
      this.pInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.pInp.Location = new System.Drawing.Point(238, 148);
      this.pInp.Margin = new System.Windows.Forms.Padding(5);
      this.pInp.Name = "pInp";
      this.pInp.Size = new System.Drawing.Size(116, 29);
      this.pInp.TabIndex = 28;
      this.pInp.Text = "1000";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(298, 115);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(90, 24);
      this.label5.TabIndex = 27;
      this.label5.Text = "Разброс:";
      // 
      // sigInp
      // 
      this.sigInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.sigInp.Location = new System.Drawing.Point(396, 113);
      this.sigInp.Margin = new System.Windows.Forms.Padding(5);
      this.sigInp.Name = "sigInp";
      this.sigInp.Size = new System.Drawing.Size(116, 29);
      this.sigInp.TabIndex = 26;
      this.sigInp.Text = "0";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(10, 115);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(156, 24);
      this.label6.TabIndex = 25;
      this.label6.Text = "Интенсивность:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(10, 80);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(645, 24);
      this.label7.TabIndex = 24;
      this.label7.Text = "Параметры обслуживающего аппарата (равномерное распределение)";
      // 
      // muInp
      // 
      this.muInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.muInp.Location = new System.Drawing.Point(174, 113);
      this.muInp.Margin = new System.Windows.Forms.Padding(5);
      this.muInp.Name = "muInp";
      this.muInp.Size = new System.Drawing.Size(116, 29);
      this.muInp.TabIndex = 23;
      this.muInp.Text = "1";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(10, 190);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(271, 24);
      this.label4.TabIndex = 22;
      this.label4.Text = "Средние время пребывания:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(10, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(156, 24);
      this.label2.TabIndex = 19;
      this.label2.Text = "Интенсивность:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(10, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(507, 24);
      this.label1.TabIndex = 18;
      this.label1.Text = "Параметры генератора (равномерное распределение)";
      // 
      // aInp
      // 
      this.aInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.aInp.Location = new System.Drawing.Point(174, 42);
      this.aInp.Margin = new System.Windows.Forms.Padding(5);
      this.aInp.Name = "aInp";
      this.aInp.Size = new System.Drawing.Size(116, 29);
      this.aInp.TabIndex = 17;
      this.aInp.Text = "1";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(10, 230);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(378, 24);
      this.label3.TabIndex = 34;
      this.label3.Text = "Теоретическая загруженность системы:";
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(396, 228);
      this.textBox1.Margin = new System.Windows.Forms.Padding(5);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(152, 29);
      this.textBox1.TabIndex = 35;
      this.textBox1.Text = "0";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(10, 270);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(365, 24);
      this.label8.TabIndex = 36;
      this.label8.Text = "Практическая загруженность системы:";
      // 
      // textBox2
      // 
      this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox2.Location = new System.Drawing.Point(396, 268);
      this.textBox2.Margin = new System.Windows.Forms.Padding(5);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new System.Drawing.Size(152, 29);
      this.textBox2.TabIndex = 37;
      this.textBox2.Text = "0";
      // 
      // chart1
      // 
      chartArea2.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea2);
      legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
      legend2.Name = "Legend1";
      this.chart1.Legends.Add(legend2);
      this.chart1.Location = new System.Drawing.Point(661, 10);
      this.chart1.Name = "chart1";
      series2.ChartArea = "ChartArea1";
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chart1.Series.Add(series2);
      this.chart1.Size = new System.Drawing.Size(517, 386);
      this.chart1.TabIndex = 38;
      this.chart1.Text = "chart1";
      // 
      // graphicBtn
      // 
      this.graphicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.graphicBtn.Location = new System.Drawing.Point(340, 316);
      this.graphicBtn.Name = "graphicBtn";
      this.graphicBtn.Size = new System.Drawing.Size(310, 80);
      this.graphicBtn.TabIndex = 39;
      this.graphicBtn.Text = "Построить график";
      this.graphicBtn.UseVisualStyleBackColor = true;
      this.graphicBtn.Click += new System.EventHandler(this.graphicBtn_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1190, 408);
      this.Controls.Add(this.graphicBtn);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lenOut);
      this.Controls.Add(this.EventButton);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.pInp);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.sigInp);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.muInp);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.aInp);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox lenOut;
    private System.Windows.Forms.Button EventButton;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox pInp;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox sigInp;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox muInp;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox aInp;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Button graphicBtn;
  }
}

