using StockManagment.DataExchange;
using StockManagment.StockManagment.Containers;
using System;
using System.Collections.Generic;

namespace StockManagment.StockManagment.Logic
{
    class StockManager
    {
        private Stock _Stock;

        private Exchanger<string> _ProductName;
        private Exchanger<DateTime> _ProductPreparation;
        private Exchanger<DateTime> _ProductExpiration;
        private Exchanger<string> _ComercialProductGroupName;
        private Exchanger<int> _ComercialProductGroupPurchasePrice;
        private Exchanger<int> _ComercialProductGroupSellPrice;
        private Exchanger<int> _ComercialProductGroupDeliveryTime; // days
        private Exchanger<int> _ComercialProductGroupTermOfUse; // days
        private Exchanger<List<Product>> _Products;
        private Exchanger<List<ComercialProductGroup>> _CommercialProductGroups;
        private Exchanger<int> _IndexOfSelectedProduct;
        private Exchanger<int> _IndexOfSelectedComercialProductGroup;

        private static List<Product> _EmptyProductList = new List<Product>();

        public StockManager(AppFields appFields)
        {
            SetUpDataExchange(appFields);
            _Stock = new Stock();
        }

        public StockManager(AppFields appFields, Stock stock)
        {
            SetUpDataExchange(appFields);
            _Stock = stock;
        }

        private void SetUpDataExchange(AppFields appFields)
        {
            _ProductName = appFields.ProductName;
            _ProductPreparation = appFields.ProductPreparation;
            _ProductExpiration = appFields.ProductExpiration;
            _ComercialProductGroupName = appFields.ComercialProductGroupName;
            _ComercialProductGroupPurchasePrice = appFields.ComercialProductGroupPurchasePrice;
            _ComercialProductGroupSellPrice = appFields.ComercialProductGroupSellPrice;
            _ComercialProductGroupDeliveryTime = appFields.ComercialProductGroupDeliveryTime;
            _ComercialProductGroupTermOfUse = appFields.ComercialProductGroupTermOfUse;
            _CommercialProductGroups = appFields.CommercialProductGroups;
            _Products = appFields.Products;
            _IndexOfSelectedProduct = appFields.IndexOfSelectedProduct;
            _IndexOfSelectedComercialProductGroup = appFields.IndexOfSelectedComercialProductGroup;

            appFields.CreateProduct.Subscribe(CreateProduct);
            appFields.CreateCommertialProductGroup.Subscribe(CreateCommertialProductGroup);
            appFields.IndexOfSelectedComercialProductGroup.Subscribe(UpdateProducts);
            appFields.DeleteCommertialProductGroup.Subscribe(DeleteCommertialProductGroup);
            appFields.DeleteProduct.Subscribe(DeleteProduct);
            appFields.UpdateProduct.Subscribe(UpdateProductData);
            appFields.UpdateCommertialProductGroup.Subscribe(UpdateCommertialProductGroupData);
            appFields.MarkAsEnds.Subscribe(MarkAsEnds);
            appFields.MarkAsNotEnds.Subscribe(MarkAsNotEnds);
        }

        private void MarkAsNotEnds()
        {
            _Stock.MarkGroupAsNotEnds(_IndexOfSelectedComercialProductGroup.Value);
            UpdateComercialProductGroups();
        }

        private void MarkAsEnds()
        {
            DateTime today = DateTime.Now;
            DateTime endTermOfUse = today.AddDays(_ComercialProductGroupTermOfUse.Value);
            _Stock.MarkGroupAsEnds(_IndexOfSelectedComercialProductGroup.Value, endTermOfUse);
            UpdateComercialProductGroups();
        }

        private void UpdateCommertialProductGroupData()
        {
            DeleteCommertialProductGroup();
            CreateCommertialProductGroup();
        }

        private void UpdateProductData()
        {
            DeleteProduct();
            CreateProduct();
        }

        private void DeleteCommertialProductGroup()
        {
            _Stock.RemoveComercialProductGroup(_IndexOfSelectedComercialProductGroup.Value);
            UpdateComercialProductGroups();
        }

        private void DeleteProduct()
        {
            _Stock.RemoveProductFromGroup(_IndexOfSelectedComercialProductGroup.Value, _IndexOfSelectedProduct.Value);
            UpdateComercialProductGroups();
        }

        private void UpdateProducts()
        {
            if (_Stock.ComercialProductGroups.Count > 0)
                _Products.Set(_Stock.ComercialProductGroups[_IndexOfSelectedComercialProductGroup.Value].Products);
            else
                _Products.Set(_EmptyProductList);
        }

        private void UpdateComercialProductGroups()
        {
            _CommercialProductGroups.Set(_Stock.ComercialProductGroups);
            UpdateProducts();
        }

        private void CreateProduct()
        {
            Product product = new Product(_ProductName.Value,
                                          _ProductPreparation.Value,
                                          _ProductExpiration.Value);
            _Stock.AddProductToGroup(_IndexOfSelectedComercialProductGroup.Value, product);
            UpdateComercialProductGroups();
        }

        private void CreateCommertialProductGroup()
        {
            TimeSpan deliveryTime = new TimeSpan(_ComercialProductGroupDeliveryTime.Value, 0, 0, 0);
            ComercialProductGroup group = new ComercialProductGroup(_ComercialProductGroupName.Value,
                                                                    _ComercialProductGroupPurchasePrice.Value,
                                                                    _ComercialProductGroupSellPrice.Value,
                                                                    deliveryTime);
            _Stock.AddComercialProductGroup(group);
            UpdateComercialProductGroups();
        }
    }
}
