using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    abstract class BaseEvent : IComparable<BaseEvent>
    {
        public BaseEvent(double _time)
        {
            time = _time;
        }

        public int CompareTo(BaseEvent other)
        {
            if (this.time > other.time)
                return 1;
            else
                return -1;
        }
        abstract public void Handle(EventModel model);

        public double time;
    }

  class EReqGenerate : BaseEvent
  {
    public EReqGenerate(Request _req) : base(_req.create_time)
    {
      req = _req;
    }

    public override void Handle(EventModel model)
    {
      model.generated_n++;
      if (model.generated_n < model.max_req_n)
      {
        Request next_req = model.generator.genRequest();
        model.addEvent(new EReqGenerate(next_req));
      }

      model.queue.push(req);
      if (model.service.isFree(this.time))
        model.addEvent(new EReqServe(this.time));
    }

    private Request req;
  }
  class EReqServe : BaseEvent
  {
    public EReqServe(double _time) : base(_time) { }

    public override void Handle(EventModel model)
    {
      model.curT = this.time;
      if (model.queue.Count != 0)
      {
        Request req = model.queue.pop();
        model.avg_que_time += this.time - req.create_time;
        model.service.serve(req, this.time);
        model.addEvent(new EReqServe(model.service.free_time));
      }
    }
  }
}
