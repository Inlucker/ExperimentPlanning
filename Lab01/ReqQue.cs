using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
  class ReqQue : Queue<Request>
  {
    public void reset()
    {
      this.max_size = 0;
      this.Clear();
    }
    public bool push(Request r)
    {
      Enqueue(r);
      if (Count > max_size)
      {
        max_size = Count;
        return true;
      }
      return false;
    }
    public Request pop()
    {
      return Dequeue();
    }

    public int max_size = 0;
  }
}
