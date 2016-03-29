using System;
using Magento.RestApi.Core;
using Magento.RestApi.Json;
using Newtonsoft.Json;

namespace Magento.RestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(StockItemConverter))]
    public class StockItem : ChangeTracking<StockItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public StockItem()
        {
            this.StartTracking();
        }

        /// <summary>
        /// Item ID
        /// </summary>
        public int? item_id
        {
            get { return this.GetValue(x => x.item_id); }
            set { this.SetValue(x => x.item_id, value); }
        }

        /// <summary>
        /// Product ID
        /// </summary>
        public int? product_id
        {
            get { return this.GetValue(x => x.product_id); }
            set { this.SetValue(x => x.product_id, value); }
        }

        /// <summary>
        /// Stock ID
        /// </summary>
        public int? stock_id
        {
            get { return this.GetValue(x => x.stock_id); }
            set { this.SetValue(x => x.stock_id, value); }
        }

        /// <summary>
        /// Quantity of stock items for the current product
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? qty
        {
            get { return this.GetValue(x => x.qty); }
            set { this.SetValue(x => x.qty, value); }
        }

        /// <summary>
        /// Quantity for stock items to become out of stock
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? min_qty
        {
            get { return this.GetValue(x => x.min_qty); }
            set { this.SetValue(x => x.min_qty, value); }
        }

        /// <summary>
        /// Choose whether the Config settings will be applied for the Qty for Item's Status to Become Out of Stock option
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? use_config_min_qty
        {
            get { return this.GetValue(x => x.use_config_min_qty); }
            set { this.SetValue(x => x.use_config_min_qty, value); }
        }

        /// <summary>
        /// Choose whether the product can be sold using decimals (e.g., you can buy 2.5 product)
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? is_qty_decimal
        {
            get { return this.GetValue(x => x.is_qty_decimal); }
            set { this.SetValue(x => x.is_qty_decimal, value); }
        }

        /// <summary>
        /// The customer can place the order for products that are out of stock at the moment (0 - No Backorders, 1 - Allow Qty Below 0, and 2 - Allow Qty Below 0 and Notify Customer)
        /// </summary>
        public BackOrderStatus? backorders
        {
            get { return this.GetValue(x => x.backorders); }
            set { this.SetValue(x => x.backorders, value); }
        }

        /// <summary>
        /// Choose whether the Config settings will be applied for the Backorders option
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? use_config_backorders
        {
            get { return this.GetValue(x => x.use_config_backorders); }
            set { this.SetValue(x => x.use_config_backorders, value); }
        }

        /// <summary>
        /// Minimum number of items in the shopping cart to be sold
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? min_sale_qty
        {
            get { return this.GetValue(x => x.min_sale_qty); }
            set { this.SetValue(x => x.min_sale_qty, value); }
        }

        /// <summary>
        /// Choose whether the Config settings will be applied for the Minimum Qty Allowed in Shopping Cart option
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? use_config_min_sale_qty
        {
            get { return this.GetValue(x => x.use_config_min_sale_qty); }
            set { this.SetValue(x => x.use_config_min_sale_qty, value); }
        }

        /// <summary>
        /// Maximum number of items in the shopping cart to be sold
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? max_sale_qty
        {
            get { return this.GetValue(x => x.max_sale_qty); }
            set { this.SetValue(x => x.max_sale_qty, value); }
        }

        /// <summary>
        /// Choose whether the Config settings will be applied for the Maximum Qty Allowed in Shopping Cart option
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? use_config_max_sale_qty
        {
            get { return this.GetValue(x => x.use_config_max_sale_qty); }
            set { this.SetValue(x => x.use_config_max_sale_qty, value); }
        }

        /// <summary>
        /// Defines whether the product is available for selling (0 - Out of Stock, 1 - In Stock)
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? is_in_stock
        {
            get { return this.GetValue(x => x.is_in_stock); }
            set { this.SetValue(x => x.is_in_stock, value); }
        }

        /// <summary>
        /// Date when the number of stock items became lower than the number defined in the Notify for Quantity Below option.
        /// This is a readonly field, it can't be updated in Magento.
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? low_stock_date
        {
            get { return this.GetValue(x => x.low_stock_date); }
            set { this.SetValue(x => x.low_stock_date, value); }
        }

        /// <summary>
        /// The number of inventory items below which the customer will be notified via the RSS feed
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? notify_stock_qty
        {
            get { return this.GetValue(x => x.notify_stock_qty); }
            set { this.SetValue(x => x.notify_stock_qty, value); }
        }

        /// <summary>
        /// Choose whether the Config settings will be applied for the Notify for Quantity Below option
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? use_config_notify_stock_qty
        {
            get { return this.GetValue(x => x.use_config_notify_stock_qty); }
            set { this.SetValue(x => x.use_config_notify_stock_qty, value); }
        }

        /// <summary>
        /// Choose whether to view and specify the product quantity and availability and whether the product is in stock management( 0 - No, 1 - Yes)
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? manage_stock
        {
            get { return this.GetValue(x => x.manage_stock); }
            set { this.SetValue(x => x.manage_stock, value); }
        }

        /// <summary>
        /// Choose whether the Config settings will be applied for the Manage Stock option
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? use_config_manage_stock
        {
            get { return this.GetValue(x => x.use_config_manage_stock); }
            set { this.SetValue(x => x.use_config_manage_stock, value); }
        }

        /// <summary>
        /// Defines whether products can be automatically returned to stock when the refund for an order is created
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? stock_status_changed_auto
        {
            get { return this.GetValue(x => x.stock_status_changed_auto); }
            set { this.SetValue(x => x.stock_status_changed_auto, value); }
        }

        /// <summary>
        /// Choose whether the Config settings will be applied for the Enable Qty Increments option
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? use_config_qty_increments
        {
            get { return this.GetValue(x => x.use_config_qty_increments); }
            set { this.SetValue(x => x.use_config_qty_increments, value); }
        }

        /// <summary>
        /// The product quantity increment value
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? qty_increments
        {
            get { return this.GetValue(x => x.qty_increments); }
            set { this.SetValue(x => x.qty_increments, value); }
        }

        /// <summary>
        /// Choose whether the Config settings will be applied for the Qty Increments option
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? use_config_enable_qty_inc
        {
            get { return this.GetValue(x => x.use_config_enable_qty_inc); }
            set { this.SetValue(x => x.use_config_enable_qty_inc, value); }
        }

        /// <summary>
        /// Defines whether the customer can add products only in increments to the shopping cart
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? enable_qty_increments
        {
            get { return this.GetValue(x => x.enable_qty_increments); }
            set { this.SetValue(x => x.enable_qty_increments, value); }
        }

        /// <summary>
        /// Defines whether the stock items can be divided into multiple boxes for shipping.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? is_decimal_divided
        {
            get { return this.GetValue(x => x.is_decimal_divided); }
            set { this.SetValue(x => x.is_decimal_divided, value); }
        }
    }
}
