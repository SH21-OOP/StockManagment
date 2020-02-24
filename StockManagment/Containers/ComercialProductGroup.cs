using System;
using System.Collections.Generic;
using System.Linq;

namespace StockManagment.StockManagment.Containers
{
    public class ComercialProductGroup
    {
        private string _Name;
        private List<Product> _Products;
        private int _PurchasePrice;
        private int _SellPrice;
        private TimeSpan _DeliveryTime;
        private bool _Ends;
        private DateTime? _TermOfUse;

        public ComercialProductGroup(string name, int purchasePrice, int sellPrice, TimeSpan deliveryTime)
        {
            _Name = name;
            _Products = new List<Product>();
            _PurchasePrice = purchasePrice;
            _SellPrice = sellPrice;
            _DeliveryTime = deliveryTime;
        }

        public string Name
        {
            get { return _Name; }
        }

        public List<Product> Products
        {
            get { return new List<Product>(_Products); }
        }

        public int Quantity
        {
            get { return _Products.Count(); }
        }

        public int PurchasePrice
        {
            get { return _PurchasePrice; }
        }

        public int SellPrice
        {
            get { return _SellPrice; }
        }

        public TimeSpan DeliveryTime
        {
            get { return _DeliveryTime; }
        }

        public bool Ends
        {
            get { return _Ends; }
        }

        public DateTime? TermOfUse
        {
            get { return _TermOfUse; }
        }

        public void AddProduct(Product product)
        {
            _Products.Add(product);
        }

        public void RemoveProduct(int productIndex)
        {
            _Products.RemoveAt(productIndex);
        }

        public void MarkAsEnds(DateTime termOfUse)
        {
            _Ends = true;
            _TermOfUse = termOfUse;
        }

        public void MarkAsNotEnds()
        {
            _Ends = false;
            _TermOfUse = null;
        }
    }
}
