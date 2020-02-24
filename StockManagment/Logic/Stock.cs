using StockManagment.StockManagment.Containers;
using System;
using System.Collections.Generic;

namespace StockManagment.StockManagment.Logic
{
    class Stock
    {
        private List<ComercialProductGroup> _ComercialProductGroups;

        public Stock()
        {
            _ComercialProductGroups = new List<ComercialProductGroup>();
        }

        public List<ComercialProductGroup> ComercialProductGroups
        {
            get { return new List<ComercialProductGroup>(_ComercialProductGroups); }
        }

        public void AddComercialProductGroup(ComercialProductGroup group)
        {
            _ComercialProductGroups.Add(group);
        }

        public void RemoveComercialProductGroup(int groupIndex)
        {
            _ComercialProductGroups.RemoveAt(groupIndex);
        }

        public void AddProductToGroup(int groupIndex, Product product)
        {
            _ComercialProductGroups[groupIndex].AddProduct(product);
        }

        public void RemoveProductFromGroup(int groupIndex, int productIndex)
        {
            _ComercialProductGroups[groupIndex].RemoveProduct(productIndex);
        }

        public void MarkGroupAsEnds(int groupIndex, DateTime termOfUse)
        {
            _ComercialProductGroups[groupIndex].MarkAsEnds(termOfUse);
        }

        public void MarkGroupAsNotEnds(int groupIndex)
        {
            _ComercialProductGroups[groupIndex].MarkAsNotEnds();
        }
    }
}
