using System;
using System.Collections.Generic;

namespace StockManagment.DataExchange
{
    public class Exchanger<T> : Notifier
    {
        private T _Value;
        private List<Delegate> _Subsribers;

        public Exchanger()
        {
            _Subsribers = new List<Delegate>();
        }
        public T Value
        {
            get { return _Value; }
        }

        public void Set(T value)
        {
            _Value = value;
            Notify();
        }
    }
}
