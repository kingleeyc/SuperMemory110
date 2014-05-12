using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Partten.Observer
{
    public interface IObserver
    {
        void notified(int eventId);
    }
}
