
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
      this.iters1 = new System.Windows.Forms.TextBox();
      this.max = new System.Windows.Forms.TextBox();
      this.iters2 = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // lenOut
      // 
      this.lenOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lenOut.Location = new System.Drawing.Point(373, 231);
      this.lenOut.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.lenOut.Name = "lenOut";
      this.lenOut.ReadOnly = true;
      this.lenOut.Size = new System.Drawing.Size(201, 34);
      this.lenOut.TabIndex = 33;
      this.lenOut.Text = "0";
      // 
      // EventButton
      // 
      this.EventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.EventButton.Location = new System.Drawing.Point(16, 438);
      this.EventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.EventButton.Name = "EventButton";
      this.EventButton.Size = new System.Drawing.Size(413, 98);
      this.EventButton.TabIndex = 32;
      this.EventButton.Text = "Моделировать";
      this.EventButton.UseVisualStyleBackColor = true;
      this.EventButton.Click += new System.EventHandler(this.EventButton_Click);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label10.Location = new System.Drawing.Point(13, 185);
      this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(441, 29);
      this.label10.TabIndex = 29;
      this.label10.Text = "Количество сгенерированых заявок:";
      // 
      // pInp
      // 
      this.pInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.pInp.Location = new System.Drawing.Point(483, 182);
      this.pInp.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.pInp.Name = "pInp";
      this.pInp.Size = new System.Drawing.Size(153, 34);
      this.pInp.TabIndex = 28;
      this.pInp.Text = "1000";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(397, 142);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(115, 29);
      this.label5.TabIndex = 27;
      this.label5.Text = "Разброс:";
      // 
      // sigInp
      // 
      this.sigInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.sigInp.Location = new System.Drawing.Point(528, 139);
      this.sigInp.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.sigInp.Name = "sigInp";
      this.sigInp.Size = new System.Drawing.Size(153, 34);
      this.sigInp.TabIndex = 26;
      this.sigInp.Text = "0";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(13, 142);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(199, 29);
      this.label6.TabIndex = 25;
      this.label6.Text = "Интенсивность:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(13, 98);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(836, 29);
      this.label7.TabIndex = 24;
      this.label7.Text = "Параметры обслуживающего аппарата (равномерное распределение)";
      // 
      // muInp
      // 
      this.muInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.muInp.Location = new System.Drawing.Point(232, 139);
      this.muInp.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.muInp.Name = "muInp";
      this.muInp.Size = new System.Drawing.Size(153, 34);
      this.muInp.TabIndex = 23;
      this.muInp.Text = "1";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(13, 234);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(324, 29);
      this.label4.TabIndex = 22;
      this.label4.Text = "Среднее время ожидания:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(13, 55);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(199, 29);
      this.label2.TabIndex = 19;
      this.label2.Text = "Интенсивность:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(13, 12);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(568, 29);
      this.label1.TabIndex = 18;
      this.label1.Text = "Параметры генератора (распределение Рэлея)";
      // 
      // aInp
      // 
      this.aInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.aInp.Location = new System.Drawing.Point(232, 52);
      this.aInp.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.aInp.Name = "aInp";
      this.aInp.Size = new System.Drawing.Size(153, 34);
      this.aInp.TabIndex = 17;
      this.aInp.Text = "1";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(13, 332);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(409, 29);
      this.label3.TabIndex = 34;
      this.label3.Text = "Теоретическая загрузка системы:";
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(433, 330);
      this.textBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(201, 34);
      this.textBox1.TabIndex = 35;
      this.textBox1.Text = "0";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(13, 382);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(393, 29);
      this.label8.TabIndex = 36;
      this.label8.Text = "Практическая загрузка системы:";
      // 
      // textBox2
      // 
      this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox2.Location = new System.Drawing.Point(417, 380);
      this.textBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new System.Drawing.Size(201, 34);
      this.textBox2.TabIndex = 37;
      this.textBox2.Text = "0";
      // 
      // chart1
      // 
      chartArea5.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea5);
      legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
      legend5.Name = "Legend1";
      this.chart1.Legends.Add(legend5);
      this.chart1.Location = new System.Drawing.Point(881, 12);
      this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.chart1.Name = "chart1";
      series5.ChartArea = "ChartArea1";
      series5.Legend = "Legend1";
      series5.Name = "Series1";
      this.chart1.Series.Add(series5);
      this.chart1.Size = new System.Drawing.Size(855, 524);
      this.chart1.TabIndex = 38;
      this.chart1.Text = "chart1";
      // 
      // graphicBtn
      // 
      this.graphicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.graphicBtn.Location = new System.Drawing.Point(451, 438);
      this.graphicBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.graphicBtn.Name = "graphicBtn";
      this.graphicBtn.Size = new System.Drawing.Size(413, 98);
      this.graphicBtn.TabIndex = 39;
      this.graphicBtn.Text = "Построить график";
      this.graphicBtn.UseVisualStyleBackColor = true;
      this.graphicBtn.Click += new System.EventHandler(this.graphicBtn_Click);
      // 
      // iters1
      // 
      this.iters1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.iters1.Location = new System.Drawing.Point(731, 560);
      this.iters1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.iters1.Name = "iters1";
      this.iters1.Size = new System.Drawing.Size(132, 34);
      this.iters1.TabIndex = 40;
      this.iters1.Text = "100";
      // 
      // max
      // 
      this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.max.Location = new System.Drawing.Point(731, 608);
      this.max.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.max.Name = "max";
      this.max.Size = new System.Drawing.Size(132, 34);
      this.max.TabIndex = 41;
      this.max.Text = "1000";
      // 
      // iters2
      // 
      this.iters2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.iters2.Location = new System.Drawing.Point(731, 656);
      this.iters2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.iters2.Name = "iters2";
      this.iters2.Size = new System.Drawing.Size(132, 34);
      this.iters2.TabIndex = 42;
      this.iters2.Text = "100";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(427, 564);
      this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(284, 29);
      this.label9.TabIndex = 43;
      this.label9.Text = "Кол-во шагов загрузки:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label11.Location = new System.Drawing.Point(463, 612);
      this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(248, 29);
      this.label11.TabIndex = 44;
      this.label11.Text = "Кол-во сген. заявок:";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label12.Location = new System.Drawing.Point(320, 660);
      this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(392, 29);
      this.label12.TabIndex = 45;
      this.label12.Text = "Кол-во итер-ий моделирования:";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label13.Location = new System.Drawing.Point(13, 283);
      this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(350, 29);
      this.label13.TabIndex = 46;
      this.label13.Text = "Среднее время пребывания:";
      // 
      // textBox3
      // 
      this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox3.Location = new System.Drawing.Point(373, 281);
      this.textBox3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.textBox3.Name = "textBox3";
      this.textBox3.ReadOnly = true;
      this.textBox3.Size = new System.Drawing.Size(201, 34);
      this.textBox3.TabIndex = 47;
      this.textBox3.Text = "0";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1748, 545);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.iters2);
      this.Controls.Add(this.max);
      this.Controls.Add(this.iters1);
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
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    private System.Windows.Forms.TextBox iters1;
    private System.Windows.Forms.TextBox max;
    private System.Windows.Forms.TextBox iters2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox textBox3;
  }
}

