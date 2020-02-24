using System;

namespace StockManagment.StockManagment.Containers
{
    public struct Product
    {
        private readonly string _Name;
        private readonly DateTime _Preparation;
        private readonly DateTime _Expiration;

        public string Name
        {
            get { return _Name; }
        }

        public DateTime Preparation
        {
            get { return _Preparation; }
        }

        public DateTime Expiration
        {
            get { return _Expiration; }
        }

        public Product(string name, DateTime preparation, DateTime expiration)
        {
            _Name = name;
            _Preparation = preparation;
            _Expiration = expiration;
        }
    }
}
