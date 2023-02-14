using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
  class EventModel
  {
    public EventModel(double a1, double b1, double a2, double b2, int _max_req_n = max_default)
    {
      generator = new Generator(a1, b1);
      queue = new ReqQue();
      service = new Service(a2, b2);
      max_req_n = _max_req_n;
    }

    public void modelate()
    {
      reset();

      while (events.Count > 0)
      {
        BaseEvent e = events[0];
        events.RemoveAt(0);

        curT = e.time;
        e.Handle(this);
      }

      this.avg_que_time /= service.served_n;
      service.avg_serve_time = service.avg_serve_time / service.served_n;
      this.avg_full_time = avg_que_time + service.avg_serve_time;

      Console.WriteLine(this.getResultsStr());
    }

    public void addEvent(BaseEvent e)
    {
      events.Add(e);
      events.Sort();
    }

    public string getResultsStr()
    {
      string res = String.Format("Прошло заявок: {0:D} | ", this.service.served_n);
      res += String.Format("Среднее время ожидания: {0:F} | ", this.avg_que_time);
      res += String.Format("Среднее время обработки: {0:F} | ", service.avg_serve_time);
      res += String.Format("Средние время пребывания: {0:F} | ", this.avg_full_time);
      res += String.Format("Время моделирования: {0:F}", this.curT);

      return res;
    }

    private void reset()
    {
      generator.reset();
      queue.reset();
      service.reset();

      curT = 0;
      generated_n = 0;
      passed_n = 0;
      avg_que_time = 0;
      avg_full_time = 0;

      Request first_req = generator.genRequest();
      events = new List<BaseEvent> { new EReqGenerate(first_req) };
    }

    public Generator generator;
    public ReqQue queue;
    public Service service;
    public double curT = 0;
    const int max_default = 100;
    public int max_req_n = max_default;
    public int generated_n = 0;
    public int passed_n = 0;
    public double avg_que_time = 0;
    public double avg_full_time = 0;

    private List<BaseEvent> events = new List<BaseEvent>();
  }
}
