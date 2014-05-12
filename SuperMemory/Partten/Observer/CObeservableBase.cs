using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Partten.Observer
{
    public class CObeservableBase
    {
        private List<IObserver> obs = new List<IObserver>();

        public void add(IObserver ob)
        {
            obs.Add(ob);
        }

        public void remove(IObserver ob)
        {
            if(!obs.Contains(ob))
            {
                return;
            }
            obs.Remove(ob);
        }

        protected void notifyAllObservers(int eventId)
        {
            if(obs.Count == 0)
            {
                return;
            }

            foreach(IObserver ob in obs)
            {
                ob.notified(eventId);
            }
        }

        protected void notifyAllObservers()
        {
            notifyAllObservers(-1);
        }
    }
}
