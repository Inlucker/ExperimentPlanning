using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
  class EventModel
  {
    /*public EventModel(double sig1, double a2, double b2, int _max_req_n = max_default)
    {
      generator = new Generator(sig1);
      queue = new ReqQue();
      service = new Service(a2, b2);
      max_req_n = _max_req_n;
    }*/
    public EventModel(double intensity1, double intensity2, double scatter2, int _max_time = max_default)
    {
      this.theory_drain = intensity1 / intensity2;
      if (this.theory_drain > 1)
        this.theory_drain = 1;
      double sig = -1, a = -1, b = -1;
      int k = 1;
      while (a < 0 || b < 0 || sig < 0)
      {
        sig = k * intensity2 / intensity1 * Math.Sqrt(2 / Math.PI);
        double dif = scatter2 * Math.Sqrt(12);
        a = k * 1 - dif / 2;
        b = k * 1 + dif / 2;
        k++;
      }
      generator = new Generator(sig);
      queue = new ReqQue();
      service = new Service(a, b);
      max_time = _max_time;
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
      this.practice_drain = service.avg_serve_time / this.curT;
      service.avg_serve_time = service.avg_serve_time / service.served_n;
      this.avg_full_time = avg_que_time + service.avg_serve_time;
      generator.avg_gen_time = generator.avg_gen_time / generator.generated_n;

      Console.WriteLine(this.getResultsStr());
    }

    public void addEvent(BaseEvent e)
    {
      events.Add(e);
      events.Sort();
    }

    public string getResultsStr()
    {
      string res = String.Format("Сгенерировано заявок: {0:D} | ", this.generated_n); //Math.Round(res, 2);
      res += String.Format("Обработано заявок: {0:D} | ", this.service.served_n);
      //res += String.Format("Среднее время ожидания: {0:F} | ", this.avg_que_time);
      //res += String.Format("Среднее время обработки: {0:F} | ", service.avg_serve_time);
      res += String.Format("Средние время пребывания: {0:F} | ", Math.Round(this.avg_full_time, 2));
      res += String.Format("Теоретическая загрузка: {0:F} | ", Math.Round(this.theory_drain, 2));
      res += String.Format("Практическая загрузка: {0:F} | ", Math.Round(this.practice_drain, 2));
      res += String.Format("Время моделирования: {0:F}", Math.Round(this.curT, 2));

      return res;
    }

    private void reset()
    {
      generator.reset();
      queue.reset();
      service.reset();
      //queue = new ReqQue();
      //generator = new Generator(generator.sig);
      //service = new Service(service.a, service.b);

      curT = 0;
      generated_n = 0;
      passed_n = 0;
      avg_que_time = 0;
      avg_full_time = 0;
      practice_drain = 0;

      Request first_req = generator.genRequest();
      events = new List<BaseEvent> { new EReqGenerate(first_req) };
    }

    public Generator generator;
    public ReqQue queue;
    public Service service;
    public double curT = 0;
    const int max_default = 100;
    public int max_time = max_default;
    public int generated_n = 0;
    public int passed_n = 0;
    public double avg_que_time = 0;
    public double avg_full_time = 0;
    public double theory_drain = 0;
    public double practice_drain = 0;

    private List<BaseEvent> events = new List<BaseEvent>();
  }
}
