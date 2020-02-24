using StockManagment.StockManagment.Containers;
using System;
using System.Collections.Generic;

namespace StockManagment.DataExchange
{
    public class AppFields
    {
        public readonly Exchanger<string> ProductName;
        public readonly Exchanger<DateTime> ProductPreparation;
        public readonly Exchanger<DateTime> ProductExpiration;
        public readonly Exchanger<string> ComercialProductGroupName;
        public readonly Exchanger<int> ComercialProductGroupPurchasePrice;
        public readonly Exchanger<int> ComercialProductGroupSellPrice;
        public readonly Exchanger<int> ComercialProductGroupDeliveryTime; // days
        public readonly Exchanger<int> ComercialProductGroupTermOfUse; // days
        public readonly Exchanger<List<Product>> Products;
        public readonly Exchanger<List<ComercialProductGroup>> CommercialProductGroups;
        public readonly Exchanger<int> IndexOfSelectedProduct;
        public readonly Exchanger<int> IndexOfSelectedComercialProductGroup;

        public readonly Notifier CreateProduct;
        public readonly Notifier DeleteProduct;
        public readonly Notifier UpdateProduct;
        public readonly Notifier CreateCommertialProductGroup;
        public readonly Notifier DeleteCommertialProductGroup;
        public readonly Notifier UpdateCommertialProductGroup;
        public readonly Notifier MarkAsEnds;
        public readonly Notifier MarkAsNotEnds;

        public AppFields()
        {
            ProductName = new Exchanger<string>();
            ProductPreparation = new Exchanger<DateTime>();
            ProductExpiration = new Exchanger<DateTime>();
            ComercialProductGroupName = new Exchanger<string>();
            ComercialProductGroupPurchasePrice = new Exchanger<int>();
            ComercialProductGroupSellPrice = new Exchanger<int>();
            ComercialProductGroupDeliveryTime = new Exchanger<int>();
            ComercialProductGroupTermOfUse = new Exchanger<int>();
            Products = new Exchanger<List<Product>>();
            CommercialProductGroups = new Exchanger<List<ComercialProductGroup>>();
            IndexOfSelectedProduct = new Exchanger<int>();
            IndexOfSelectedComercialProductGroup = new Exchanger<int>();

            CreateProduct = new Notifier();
            DeleteProduct = new Notifier();
            UpdateProduct = new Notifier();
            CreateCommertialProductGroup = new Notifier();
            DeleteCommertialProductGroup = new Notifier();
            UpdateCommertialProductGroup = new Notifier();
            MarkAsEnds = new Notifier();
            MarkAsNotEnds = new Notifier();
        }
    }
}
