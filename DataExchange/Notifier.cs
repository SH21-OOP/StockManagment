using System;
using System.Collections.Generic;

namespace StockManagment.DataExchange
{
    public class Notifier
    {
        private List<Delegate> _Subsribers;

        public Notifier()
        {
            _Subsribers = new List<Delegate>();
        }

        public void Notify()
        {
            foreach (Action action in _Subsribers)
            {
                action.Invoke();
            }
        }
        public void Subscribe(Action callback)
        {
            _Subsribers.Add(callback);
        }
    }
}
