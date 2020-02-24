using StockManagment.DataExchange;
using StockManagment.StockManagment.Containers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockManagment
{
    public partial class Form : System.Windows.Forms.Form
    {
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

        private Notifier _CreateProduct;
        private Notifier _DeleteProduct;
        private Notifier _UpdateProduct;
        private Notifier _CreateCommertialProductGroup;
        private Notifier _DeleteCommertialProductGroup;
        private Notifier _UpdateCommertialProductGroup;
        private Notifier _MarkAsEnds;
        private Notifier _MarkAsNotEnds;

        public Form(AppFields appFields)
        {
            InitializeComponent();
            SetUpDataExchange(appFields);
        }

        public void SetUpDataExchange(AppFields appFields)
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

            _CreateProduct = appFields.CreateProduct;
            _DeleteProduct = appFields.DeleteProduct;
            _UpdateProduct = appFields.UpdateProduct;
            _CreateCommertialProductGroup = appFields.CreateCommertialProductGroup;
            _DeleteCommertialProductGroup = appFields.DeleteCommertialProductGroup;
            _UpdateCommertialProductGroup = appFields.UpdateCommertialProductGroup;
            _MarkAsEnds = appFields.MarkAsEnds;
            _MarkAsNotEnds = appFields.MarkAsNotEnds;

            _CommercialProductGroups.Subscribe(UpdateCommercialProductGroups);
            _Products.Subscribe(UpdateProducts);

            _ProductPreparation.Set(ProductPreparation.Value);
            _ProductExpiration.Set(ProductExpiration.Value);
        }

        private void UpdateCommercialProductGroups()
        {
            CommercialProductGroupsView.DataSource = _CommercialProductGroups.Value;
            CommercialProductGroupsView.ClearSelection();
            if (CommercialProductGroupsView.Rows.Count != 0)
            {
                int lastRowIndex = CommercialProductGroupsView.Rows.Count - 1;
                DataGridViewRow row = CommercialProductGroupsView.Rows[lastRowIndex];
                CommercialProductGroupsView.CurrentCell = row.Cells[0];
            }
        }

        private void UpdateProducts()
        {
            ProductsView.DataSource = _Products.Value;
        }

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            if (CommercialProductGroupsView.CurrentCell != null)
                _CreateProduct.Notify();
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsView.CurrentCell != null)
                _DeleteProduct.Notify();
        }

        private void CreateProductGroupButton_Click(object sender, EventArgs e)
        {
            _CreateCommertialProductGroup.Notify();
        }

        private void DeleteProductGroupButton_Click(object sender, EventArgs e)
        {
            if (CommercialProductGroupsView.CurrentCell != null)
            {
                _IndexOfSelectedProduct.Set(-1);
                _DeleteCommertialProductGroup.Notify();
            }
        }
        private void ProductName_TextChanged(object sender, EventArgs e)
        {
            _ProductName.Set(ProductName.Text);
        }

        private void ProductPreparation_ValueChanged(object sender, EventArgs e)
        {
            _ProductPreparation.Set(ProductPreparation.Value);
        }

        private void ProductExpiration_ValueChanged(object sender, EventArgs e)
        {
            _ProductExpiration.Set(ProductExpiration.Value);
        }

        private void CommercialProductGroupName_TextChanged(object sender, EventArgs e)
        {
            _ComercialProductGroupName.Set(CommercialProductGroupName.Text);
        }
        private void CommercialProductGroupPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            int price;
            if (int.TryParse(CommercialProductGroupPurchasePrice.Text, out price))
                _ComercialProductGroupPurchasePrice.Set(price);
        }

        private void CommercialProductGroupSellPrice_TextChanged(object sender, EventArgs e)
        {
            int price;
            if (int.TryParse(CommercialProductGroupSellPrice.Text, out price))
                _ComercialProductGroupSellPrice.Set(price);
        }

        private void CommercialProductGroupDeliveryTime_TextChanged(object sender, EventArgs e)
        {
            int days;
            if (int.TryParse(CommercialProductGroupDeliveryTime.Text, out days))
                _ComercialProductGroupDeliveryTime.Set(days);
        }

        private void ComercialProductGroupTermOfUse_TextChanged(object sender, EventArgs e)
        {
            int days;
            if (int.TryParse(ComercialProductGroupTermOfUse.Text, out days))
                _ComercialProductGroupTermOfUse.Set(days);
        }

        private void CommercialProductGroupsView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (CommercialProductGroupsView.CurrentCell != null)
                _IndexOfSelectedComercialProductGroup.Set(CommercialProductGroupsView.CurrentRow.Index);
        }

        private void ProductsView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (ProductsView.CurrentCell != null)
                _IndexOfSelectedProduct.Set(ProductsView.CurrentCell.RowIndex);
        }

        private void UpdateProductDataButton_Click(object sender, EventArgs e)
        {
            if (ProductsView.CurrentCell != null)
                _UpdateProduct.Notify();
        }

        private void UpdateComercialProductGroupButton_Click(object sender, EventArgs e)
        {
            if (CommercialProductGroupsView.CurrentCell != null)
                _UpdateCommertialProductGroup.Notify();
        }

        private void MarkAsEndsButton_Click(object sender, EventArgs e)
        {
            if (CommercialProductGroupsView.CurrentCell != null)
                _MarkAsEnds.Notify();
        }

        private void MarkAsNotEndsButton_Click(object sender, EventArgs e)
        {
            if (CommercialProductGroupsView.CurrentCell != null)
                _MarkAsNotEnds.Notify();
        }
    }
}
