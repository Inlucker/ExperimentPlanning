using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
  class Service
  {
    public Service(double _a, double _b)
    {
      a = _a;
      b = _b;
    }
    public void reset()
    {
      this.free_time = 0;
      this.avg_serve_time = 0;
      this.served_n = 0;
      this.min_time = -1;
      this.max_time = -1;
    }
    public bool isFree(double t)
    {
      return (t >= free_time);
    }
    public void serve(Request r, double t)
    {
      updateFreeTime(t);
      served_n++;
      r.serve_time = free_time;
      double res = rnd.NextDouble();
    }
    public void updateFreeTime(double t)
    {
      double res = a + (b - a) * rnd.NextDouble();
      avg_serve_time += res;
      free_time = t + Math.Round(res, 2);

      if (min_time == -1)
        min_time = res;
      else if (res < min_time)
        min_time = res;

      if (max_time == -1)
        max_time = res;
      else if (res > max_time)
        max_time = res;
    }

    public double a;
    public double b;
    public double free_time = 0;
    public double avg_serve_time = 0;
    public int served_n = 0;

    private Random rnd = new Random();
    private double min_time = -1;
    private double max_time = -1;
  }
}
