using System;
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
    }

    private void EventButton_Click(object sender, EventArgs e)
    {
      EventButton.Enabled = false;

      string txt;
      double a, b;
      txt = aInp.Text.Replace(".", ",");
      a = Convert.ToDouble(txt);

      txt = bInp.Text.Replace(".", ",");
      b = Convert.ToDouble(txt);

      double a2;
      double b2;
      txt = muInp.Text.Replace(".", ",");
      a2 = Convert.ToDouble(txt);

      txt = sigInp.Text.Replace(".", ",");
      b2 = Convert.ToDouble(txt);

      int max;
      txt = pInp.Text.Replace(".", ",");
      max = Convert.ToInt32(txt);

       EventModel model = new EventModel(a, b, a2, b2, max);

      model.modelate();

      lenOut.Text = model.avg_full_time.ToString();

      EventButton.Enabled = true;
    }
  }
}
