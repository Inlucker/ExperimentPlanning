using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
  class Generator
  {
    public Generator(double _sig)
    {
      sig = _sig;
    }
    public void reset()
    {
      this.gen_time = 0;
      this.generated_n = 0;
      this.avg_gen_time = 0;
      this.min_time = -1;
      this.max_time = -1;
  }
    public bool isReady(double t)
    {
      return (t >= gen_time);
    }
    public Request genRequest()
    {
      Request new_r = new Request(gen_time);
      updateGenTime();
      generated_n++;
      return new_r;
    }
    private void updateGenTime()
    {
      //double t_i = a + (b - a) * rnd.NextDouble();
      double res = Math.Sqrt(-2*sig*sig * Math.Log(1- rnd.NextDouble()));
      avg_gen_time = gen_time;
      gen_time += Math.Round(res, 2);

      if (min_time == -1)
        min_time = res;
      else if (res < min_time)
        min_time = res;

      if (max_time == -1)
        max_time = res;
      else if (res > max_time)
        max_time = res;
    }

    public double sig;
    public double gen_time = 0;
    public int generated_n = 0;

    private Random rnd = new Random();
    public double avg_gen_time = 0;
    private double min_time = -1;
    private double max_time = -1;
  }
}
