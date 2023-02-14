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
      avg_serve_time += free_time - t;
      double res = rnd.NextDouble();
    }
    public void updateFreeTime(double t)
    {
      double t_i = a + (b - a) * rnd.NextDouble();
      free_time = t + Math.Round(t_i, 2);
    }

    public double a;
    public double b;
    public double free_time = 0;
    public double avg_serve_time = 0;
    public int served_n = 0;

    private Random rnd = new Random();
  }
}
