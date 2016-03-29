using System;
using Magento.RestApi.Json;
using Newtonsoft.Json;
using Magento.RestApi.Core;

namespace Magento.RestApi.Models
{
    /// <summary>
    /// A product
    /// </summary>
    [JsonConverter(typeof(OrderItemConverter))]
    [Serializable]
    public class OrderItem : ChangeTracking<OrderItem>
    {
        public OrderItem()
        {
            this.StartTracking();
        }
        /// <summary>
        /// 
        /// </summary>
        public string sku
        {
            get { return this.GetValue(x => x.sku); }
            set { this.SetValue(x => x.sku, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double price
        {
            get { return this.GetValue(x => x.price); }
            set { this.SetValue(x => x.price, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_price
        {
            get { return this.GetValue(x => x.base_price); }
            set { this.SetValue(x => x.base_price, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_original_price
        {
            get { return this.GetValue(x => x.base_original_price); }
            set { this.SetValue(x => x.base_original_price, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double original_price
        {
            get { return this.GetValue(x => x.original_price); }
            set { this.SetValue(x => x.original_price, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double tax_percent
        {
            get { return this.GetValue(x => x.tax_percent); }
            set { this.SetValue(x => x.tax_percent, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double tax_amount
        {
            get { return this.GetValue(x => x.tax_amount); }
            set { this.SetValue(x => x.tax_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_tax_amount
        {
            get { return this.GetValue(x => x.base_tax_amount); }
            set { this.SetValue(x => x.base_tax_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_discount_amount
        {
            get { return this.GetValue(x => x.base_discount_amount); }
            set { this.SetValue(x => x.base_discount_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double discount_amount
        {
            get { return this.GetValue(x => x.discount_amount); }
            set { this.SetValue(x => x.discount_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_row_total
        {
            get { return this.GetValue(x => x.base_row_total); }
            set { this.SetValue(x => x.base_row_total, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double row_total
        {
            get { return this.GetValue(x => x.row_total); }
            set { this.SetValue(x => x.row_total, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_price_incl_tax
        {
            get { return this.GetValue(x => x.base_price_incl_tax); }
            set { this.SetValue(x => x.base_price_incl_tax, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double price_incl_tax
        {
            get { return this.GetValue(x => x.price_incl_tax); }
            set { this.SetValue(x => x.price_incl_tax, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_row_total_incl_tax
        {
            get { return this.GetValue(x => x.base_row_total_incl_tax); }
            set { this.SetValue(x => x.base_row_total_incl_tax, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double row_total_incl_tax
        {
            get { return this.GetValue(x => x.row_total_incl_tax); }
            set { this.SetValue(x => x.row_total_incl_tax, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public int item_id
        {
            get { return this.GetValue(x => x.item_id); }
            set { this.SetValue(x => x.item_id, value); }
        }		
		/// <summary>
        /// 
        /// </summary>
        public int? parent_item_id
        {
            get { return this.GetValue(x => x.parent_item_id); }
            set { this.SetValue(x => x.parent_item_id, value); }
        }		
		/// <summary>
        /// 
        /// </summary>
        public string name
        {
            get { return this.GetValue(x => x.name); }
            set { this.SetValue(x => x.name, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double qty_canceled
        {
            get { return this.GetValue(x => x.qty_canceled); }
            set { this.SetValue(x => x.qty_canceled, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double qty_invoiced
        {
            get { return this.GetValue(x => x.qty_invoiced); }
            set { this.SetValue(x => x.qty_invoiced, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double qty_ordered
        {
            get { return this.GetValue(x => x.qty_ordered); }
            set { this.SetValue(x => x.qty_ordered, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double qty_refunded
        {
            get { return this.GetValue(x => x.qty_refunded); }
            set { this.SetValue(x => x.qty_refunded, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double qty_shipped
        {
            get { return this.GetValue(x => x.qty_shipped); }
            set { this.SetValue(x => x.qty_shipped, value); }
        }
    }
}
