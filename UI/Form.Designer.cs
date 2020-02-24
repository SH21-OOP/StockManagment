namespace StockManagment
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductName = new System.Windows.Forms.TextBox();
            this.CommercialProductGroupPurchasePrice = new System.Windows.Forms.TextBox();
            this.CommercialProductGroupName = new System.Windows.Forms.TextBox();
            this.LabelProductNamel = new System.Windows.Forms.Label();
            this.LabelProductPreparation = new System.Windows.Forms.Label();
            this.LabelProductExpiration = new System.Windows.Forms.Label();
            this.LabelCommercialProductGroupName = new System.Windows.Forms.Label();
            this.LabelCommercialProductGroupPurchasePrice = new System.Windows.Forms.Label();
            this.LabelCommercialProductGroupSellPrice = new System.Windows.Forms.Label();
            this.LabelCommercialProductGroupDeliveryTime = new System.Windows.Forms.Label();
            this.LabelComercialProductGroupTermOfUse = new System.Windows.Forms.Label();
            this.ProductPreparation = new System.Windows.Forms.DateTimePicker();
            this.ProductExpiration = new System.Windows.Forms.DateTimePicker();
            this.CommercialProductGroupSellPrice = new System.Windows.Forms.TextBox();
            this.ProductsView = new System.Windows.Forms.DataGridView();
            this.CommercialProductGroupsView = new System.Windows.Forms.DataGridView();
            this.CommercialProductGroupDeliveryTime = new System.Windows.Forms.TextBox();
            this.ComercialProductGroupTermOfUse = new System.Windows.Forms.TextBox();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.CreateProductGroupButton = new System.Windows.Forms.Button();
            this.CreateProductButton = new System.Windows.Forms.Button();
            this.UpdateProductDataButton = new System.Windows.Forms.Button();
            this.DeleteProductGroupButton = new System.Windows.Forms.Button();
            this.UpdateComercialProductGroupButton = new System.Windows.Forms.Button();
            this.MarkAsEndsButton = new System.Windows.Forms.Button();
            this.MarkAsNotEndsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialProductGroupsView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(177, 287);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(200, 20);
            this.ProductName.TabIndex = 0;
            this.ProductName.TextChanged += new System.EventHandler(this.ProductName_TextChanged);
            // 
            // CommercialProductGroupPurchasePrice
            // 
            this.CommercialProductGroupPurchasePrice.Location = new System.Drawing.Point(206, 61);
            this.CommercialProductGroupPurchasePrice.Name = "CommercialProductGroupPurchasePrice";
            this.CommercialProductGroupPurchasePrice.Size = new System.Drawing.Size(200, 20);
            this.CommercialProductGroupPurchasePrice.TabIndex = 1;
            this.CommercialProductGroupPurchasePrice.TextChanged += new System.EventHandler(this.CommercialProductGroupPurchasePrice_TextChanged);
            // 
            // CommercialProductGroupName
            // 
            this.CommercialProductGroupName.Location = new System.Drawing.Point(206, 35);
            this.CommercialProductGroupName.Name = "CommercialProductGroupName";
            this.CommercialProductGroupName.Size = new System.Drawing.Size(200, 20);
            this.CommercialProductGroupName.TabIndex = 2;
            this.CommercialProductGroupName.TextChanged += new System.EventHandler(this.CommercialProductGroupName_TextChanged);
            // 
            // LabelProductNamel
            // 
            this.LabelProductNamel.AutoSize = true;
            this.LabelProductNamel.Location = new System.Drawing.Point(44, 287);
            this.LabelProductNamel.Name = "LabelProductNamel";
            this.LabelProductNamel.Size = new System.Drawing.Size(72, 13);
            this.LabelProductNamel.TabIndex = 3;
            this.LabelProductNamel.Text = "ProductName";
            // 
            // LabelProductPreparation
            // 
            this.LabelProductPreparation.AutoSize = true;
            this.LabelProductPreparation.Location = new System.Drawing.Point(44, 310);
            this.LabelProductPreparation.Name = "LabelProductPreparation";
            this.LabelProductPreparation.Size = new System.Drawing.Size(98, 13);
            this.LabelProductPreparation.TabIndex = 4;
            this.LabelProductPreparation.Text = "ProductPreparation";
            // 
            // LabelProductExpiration
            // 
            this.LabelProductExpiration.AutoSize = true;
            this.LabelProductExpiration.Location = new System.Drawing.Point(44, 336);
            this.LabelProductExpiration.Name = "LabelProductExpiration";
            this.LabelProductExpiration.Size = new System.Drawing.Size(90, 13);
            this.LabelProductExpiration.TabIndex = 5;
            this.LabelProductExpiration.Text = "ProductExpiration";
            // 
            // LabelCommercialProductGroupName
            // 
            this.LabelCommercialProductGroupName.AutoSize = true;
            this.LabelCommercialProductGroupName.Location = new System.Drawing.Point(12, 35);
            this.LabelCommercialProductGroupName.Name = "LabelCommercialProductGroupName";
            this.LabelCommercialProductGroupName.Size = new System.Drawing.Size(147, 13);
            this.LabelCommercialProductGroupName.TabIndex = 6;
            this.LabelCommercialProductGroupName.Text = "ComercialProductGroupName";
            // 
            // LabelCommercialProductGroupPurchasePrice
            // 
            this.LabelCommercialProductGroupPurchasePrice.AutoSize = true;
            this.LabelCommercialProductGroupPurchasePrice.Location = new System.Drawing.Point(12, 61);
            this.LabelCommercialProductGroupPurchasePrice.Name = "LabelCommercialProductGroupPurchasePrice";
            this.LabelCommercialProductGroupPurchasePrice.Size = new System.Drawing.Size(188, 13);
            this.LabelCommercialProductGroupPurchasePrice.TabIndex = 7;
            this.LabelCommercialProductGroupPurchasePrice.Text = "ComercialProductGroupPurchasePrice";
            // 
            // LabelCommercialProductGroupSellPrice
            // 
            this.LabelCommercialProductGroupSellPrice.AutoSize = true;
            this.LabelCommercialProductGroupSellPrice.Location = new System.Drawing.Point(12, 87);
            this.LabelCommercialProductGroupSellPrice.Name = "LabelCommercialProductGroupSellPrice";
            this.LabelCommercialProductGroupSellPrice.Size = new System.Drawing.Size(160, 13);
            this.LabelCommercialProductGroupSellPrice.TabIndex = 8;
            this.LabelCommercialProductGroupSellPrice.Text = "ComercialProductGroupSellPrice";
            // 
            // LabelCommercialProductGroupDeliveryTime
            // 
            this.LabelCommercialProductGroupDeliveryTime.AutoSize = true;
            this.LabelCommercialProductGroupDeliveryTime.Location = new System.Drawing.Point(12, 113);
            this.LabelCommercialProductGroupDeliveryTime.Name = "LabelCommercialProductGroupDeliveryTime";
            this.LabelCommercialProductGroupDeliveryTime.Size = new System.Drawing.Size(180, 13);
            this.LabelCommercialProductGroupDeliveryTime.TabIndex = 9;
            this.LabelCommercialProductGroupDeliveryTime.Text = "ComercialProductGroupDeliveryTime";
            // 
            // LabelComercialProductGroupTermOfUse
            // 
            this.LabelComercialProductGroupTermOfUse.AutoSize = true;
            this.LabelComercialProductGroupTermOfUse.Location = new System.Drawing.Point(12, 183);
            this.LabelComercialProductGroupTermOfUse.Name = "LabelComercialProductGroupTermOfUse";
            this.LabelComercialProductGroupTermOfUse.Size = new System.Drawing.Size(173, 13);
            this.LabelComercialProductGroupTermOfUse.TabIndex = 10;
            this.LabelComercialProductGroupTermOfUse.Text = "ComercialProductGroupTermOfUse";
            // 
            // ProductPreparation
            // 
            this.ProductPreparation.Location = new System.Drawing.Point(177, 310);
            this.ProductPreparation.Name = "ProductPreparation";
            this.ProductPreparation.Size = new System.Drawing.Size(200, 20);
            this.ProductPreparation.TabIndex = 11;
            this.ProductPreparation.ValueChanged += new System.EventHandler(this.ProductPreparation_ValueChanged);
            // 
            // ProductExpiration
            // 
            this.ProductExpiration.Location = new System.Drawing.Point(177, 336);
            this.ProductExpiration.Name = "ProductExpiration";
            this.ProductExpiration.Size = new System.Drawing.Size(200, 20);
            this.ProductExpiration.TabIndex = 12;
            this.ProductExpiration.ValueChanged += new System.EventHandler(this.ProductExpiration_ValueChanged);
            // 
            // CommercialProductGroupSellPrice
            // 
            this.CommercialProductGroupSellPrice.Location = new System.Drawing.Point(206, 87);
            this.CommercialProductGroupSellPrice.Name = "CommercialProductGroupSellPrice";
            this.CommercialProductGroupSellPrice.Size = new System.Drawing.Size(200, 20);
            this.CommercialProductGroupSellPrice.TabIndex = 15;
            this.CommercialProductGroupSellPrice.TextChanged += new System.EventHandler(this.CommercialProductGroupSellPrice_TextChanged);
            // 
            // ProductsView
            // 
            this.ProductsView.AllowUserToAddRows = false;
            this.ProductsView.AllowUserToDeleteRows = false;
            this.ProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsView.Location = new System.Drawing.Point(412, 257);
            this.ProductsView.Name = "ProductsView";
            this.ProductsView.ReadOnly = true;
            this.ProductsView.Size = new System.Drawing.Size(597, 169);
            this.ProductsView.TabIndex = 16;
            this.ProductsView.CurrentCellChanged += new System.EventHandler(this.ProductsView_CurrentCellChanged);
            // 
            // CommercialProductGroupsView
            // 
            this.CommercialProductGroupsView.AllowUserToAddRows = false;
            this.CommercialProductGroupsView.AllowUserToDeleteRows = false;
            this.CommercialProductGroupsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommercialProductGroupsView.Location = new System.Drawing.Point(412, 9);
            this.CommercialProductGroupsView.Name = "CommercialProductGroupsView";
            this.CommercialProductGroupsView.Size = new System.Drawing.Size(597, 239);
            this.CommercialProductGroupsView.TabIndex = 17;
            this.CommercialProductGroupsView.CurrentCellChanged += new System.EventHandler(this.CommercialProductGroupsView_CurrentCellChanged);
            // 
            // CommercialProductGroupDeliveryTime
            // 
            this.CommercialProductGroupDeliveryTime.Location = new System.Drawing.Point(206, 113);
            this.CommercialProductGroupDeliveryTime.Name = "CommercialProductGroupDeliveryTime";
            this.CommercialProductGroupDeliveryTime.Size = new System.Drawing.Size(200, 20);
            this.CommercialProductGroupDeliveryTime.TabIndex = 18;
            this.CommercialProductGroupDeliveryTime.TextChanged += new System.EventHandler(this.CommercialProductGroupDeliveryTime_TextChanged);
            // 
            // ComercialProductGroupTermOfUse
            // 
            this.ComercialProductGroupTermOfUse.Location = new System.Drawing.Point(206, 183);
            this.ComercialProductGroupTermOfUse.Name = "ComercialProductGroupTermOfUse";
            this.ComercialProductGroupTermOfUse.Size = new System.Drawing.Size(200, 20);
            this.ComercialProductGroupTermOfUse.TabIndex = 19;
            this.ComercialProductGroupTermOfUse.TextChanged += new System.EventHandler(this.ComercialProductGroupTermOfUse_TextChanged);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(128, 364);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductButton.TabIndex = 20;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // CreateProductGroupButton
            // 
            this.CreateProductGroupButton.Location = new System.Drawing.Point(15, 139);
            this.CreateProductGroupButton.Name = "CreateProductGroupButton";
            this.CreateProductGroupButton.Size = new System.Drawing.Size(75, 23);
            this.CreateProductGroupButton.TabIndex = 21;
            this.CreateProductGroupButton.Text = "Create";
            this.CreateProductGroupButton.UseVisualStyleBackColor = true;
            this.CreateProductGroupButton.Click += new System.EventHandler(this.CreateProductGroupButton_Click);
            // 
            // CreateProductButton
            // 
            this.CreateProductButton.Location = new System.Drawing.Point(47, 364);
            this.CreateProductButton.Name = "CreateProductButton";
            this.CreateProductButton.Size = new System.Drawing.Size(75, 23);
            this.CreateProductButton.TabIndex = 22;
            this.CreateProductButton.Text = "Create";
            this.CreateProductButton.UseVisualStyleBackColor = true;
            this.CreateProductButton.Click += new System.EventHandler(this.CreateProductButton_Click);
            // 
            // UpdateProductDataButton
            // 
            this.UpdateProductDataButton.Location = new System.Drawing.Point(209, 364);
            this.UpdateProductDataButton.Name = "UpdateProductDataButton";
            this.UpdateProductDataButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateProductDataButton.TabIndex = 23;
            this.UpdateProductDataButton.Text = "Update";
            this.UpdateProductDataButton.UseVisualStyleBackColor = true;
            this.UpdateProductDataButton.Click += new System.EventHandler(this.UpdateProductDataButton_Click);
            // 
            // DeleteProductGroupButton
            // 
            this.DeleteProductGroupButton.Location = new System.Drawing.Point(96, 139);
            this.DeleteProductGroupButton.Name = "DeleteProductGroupButton";
            this.DeleteProductGroupButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductGroupButton.TabIndex = 24;
            this.DeleteProductGroupButton.Text = "Delete";
            this.DeleteProductGroupButton.UseVisualStyleBackColor = true;
            this.DeleteProductGroupButton.Click += new System.EventHandler(this.DeleteProductGroupButton_Click);
            // 
            // UpdateComercialProductGroupButton
            // 
            this.UpdateComercialProductGroupButton.Location = new System.Drawing.Point(177, 139);
            this.UpdateComercialProductGroupButton.Name = "UpdateComercialProductGroupButton";
            this.UpdateComercialProductGroupButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateComercialProductGroupButton.TabIndex = 26;
            this.UpdateComercialProductGroupButton.Text = "Update";
            this.UpdateComercialProductGroupButton.UseVisualStyleBackColor = true;
            this.UpdateComercialProductGroupButton.Click += new System.EventHandler(this.UpdateComercialProductGroupButton_Click);
            // 
            // MarkAsEndsButton
            // 
            this.MarkAsEndsButton.Location = new System.Drawing.Point(15, 208);
            this.MarkAsEndsButton.Name = "MarkAsEndsButton";
            this.MarkAsEndsButton.Size = new System.Drawing.Size(105, 23);
            this.MarkAsEndsButton.TabIndex = 27;
            this.MarkAsEndsButton.Text = "MarkAsEnds";
            this.MarkAsEndsButton.UseVisualStyleBackColor = true;
            this.MarkAsEndsButton.Click += new System.EventHandler(this.MarkAsEndsButton_Click);
            // 
            // MarkAsNotEndsButton
            // 
            this.MarkAsNotEndsButton.Location = new System.Drawing.Point(126, 208);
            this.MarkAsNotEndsButton.Name = "MarkAsNotEndsButton";
            this.MarkAsNotEndsButton.Size = new System.Drawing.Size(126, 23);
            this.MarkAsNotEndsButton.TabIndex = 28;
            this.MarkAsNotEndsButton.Text = "MarkAsNotEnds";
            this.MarkAsNotEndsButton.UseVisualStyleBackColor = true;
            this.MarkAsNotEndsButton.Click += new System.EventHandler(this.MarkAsNotEndsButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 438);
            this.Controls.Add(this.MarkAsNotEndsButton);
            this.Controls.Add(this.MarkAsEndsButton);
            this.Controls.Add(this.UpdateComercialProductGroupButton);
            this.Controls.Add(this.DeleteProductGroupButton);
            this.Controls.Add(this.UpdateProductDataButton);
            this.Controls.Add(this.CreateProductButton);
            this.Controls.Add(this.CreateProductGroupButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ComercialProductGroupTermOfUse);
            this.Controls.Add(this.CommercialProductGroupDeliveryTime);
            this.Controls.Add(this.CommercialProductGroupsView);
            this.Controls.Add(this.ProductsView);
            this.Controls.Add(this.CommercialProductGroupSellPrice);
            this.Controls.Add(this.ProductExpiration);
            this.Controls.Add(this.ProductPreparation);
            this.Controls.Add(this.LabelComercialProductGroupTermOfUse);
            this.Controls.Add(this.LabelCommercialProductGroupDeliveryTime);
            this.Controls.Add(this.LabelCommercialProductGroupSellPrice);
            this.Controls.Add(this.LabelCommercialProductGroupPurchasePrice);
            this.Controls.Add(this.LabelCommercialProductGroupName);
            this.Controls.Add(this.LabelProductExpiration);
            this.Controls.Add(this.LabelProductPreparation);
            this.Controls.Add(this.LabelProductNamel);
            this.Controls.Add(this.CommercialProductGroupName);
            this.Controls.Add(this.CommercialProductGroupPurchasePrice);
            this.Controls.Add(this.ProductName);
            this.Name = "Form";
            this.Text = "StockManagment";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CommercialProductGroupsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox CommercialProductGroupPurchasePrice;
        private System.Windows.Forms.TextBox CommercialProductGroupName;
        private System.Windows.Forms.Label LabelProductNamel;
        private System.Windows.Forms.Label LabelProductPreparation;
        private System.Windows.Forms.Label LabelProductExpiration;
        private System.Windows.Forms.Label LabelCommercialProductGroupName;
        private System.Windows.Forms.Label LabelCommercialProductGroupPurchasePrice;
        private System.Windows.Forms.Label LabelCommercialProductGroupSellPrice;
        private System.Windows.Forms.Label LabelCommercialProductGroupDeliveryTime;
        private System.Windows.Forms.Label LabelComercialProductGroupTermOfUse;
        private System.Windows.Forms.DateTimePicker ProductPreparation;
        private System.Windows.Forms.DateTimePicker ProductExpiration;
        private System.Windows.Forms.TextBox CommercialProductGroupSellPrice;
        private System.Windows.Forms.DataGridView ProductsView;
        private System.Windows.Forms.DataGridView CommercialProductGroupsView;
        private System.Windows.Forms.TextBox CommercialProductGroupDeliveryTime;
        private System.Windows.Forms.TextBox ComercialProductGroupTermOfUse;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button CreateProductGroupButton;
        private System.Windows.Forms.Button CreateProductButton;
        private System.Windows.Forms.Button UpdateProductDataButton;
        private System.Windows.Forms.Button DeleteProductGroupButton;
        private System.Windows.Forms.Button UpdateComercialProductGroupButton;
        private System.Windows.Forms.Button MarkAsEndsButton;
        private System.Windows.Forms.Button MarkAsNotEndsButton;
    }
}

