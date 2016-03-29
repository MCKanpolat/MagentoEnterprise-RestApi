using System;
using Magento.RestApi.Core;
using Magento.RestApi.Json;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Magento.RestApi.Models
{
    /// <summary>
    /// A product
    /// </summary>
    [JsonConverter(typeof(OrderConverter))]
    [Serializable]
    public class Order : ChangeTracking<Order>
    {
        public Order()
        {
            this.StartTracking();
        }

        /// <summary>
        /// Id of the order
        /// </summary>
        public int entity_id
        {
            get { return this.GetValue(x => x.entity_id); }
            set { this.SetValue(x => x.entity_id, value); }
        }
        /// <summary>
        /// Id of the customer
        /// </summary>
        public int? customer_id
        {
            get { return this.GetValue(x => x.customer_id); }
            set { this.SetValue(x => x.customer_id, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? base_discount_amount
        {
            get { return this.GetValue(x => x.base_discount_amount); }
            set { this.SetValue(x => x.base_discount_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_shipping_amount
        {
            get { return this.GetValue(x => x.base_shipping_amount); }
            set { this.SetValue(x => x.base_shipping_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_shipping_tax_amount
        {
            get { return this.GetValue(x => x.base_shipping_tax_amount); }
            set { this.SetValue(x => x.base_shipping_tax_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_subtotal
        {
            get { return this.GetValue(x => x.base_subtotal); }
            set { this.SetValue(x => x.base_subtotal, value); }
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
        public double base_grand_total
        {
            get { return this.GetValue(x => x.base_grand_total); }
            set { this.SetValue(x => x.base_grand_total, value); }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? base_total_paid
        {
            get { return this.GetValue(x => x.base_total_paid); }
            set { this.SetValue(x => x.base_total_paid, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? base_total_refunded
        {
            get { return this.GetValue(x => x.base_total_refunded); }
            set { this.SetValue(x => x.base_total_refunded, value); }
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
        public double grand_total
        {
            get { return this.GetValue(x => x.grand_total); }
            set { this.SetValue(x => x.grand_total, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double subtotal
        {
            get { return this.GetValue(x => x.subtotal); }
            set { this.SetValue(x => x.subtotal, value); }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double shipping_amount
        {
            get { return this.GetValue(x => x.shipping_amount); }
            set { this.SetValue(x => x.shipping_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double shipping_tax_amount
        {
            get { return this.GetValue(x => x.shipping_tax_amount); }
            set { this.SetValue(x => x.shipping_tax_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double store_to_order_rate
        {
            get { return this.GetValue(x => x.store_to_order_rate); }
            set { this.SetValue(x => x.store_to_order_rate, value); }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? total_paid
        {
            get { return this.GetValue(x => x.total_paid); }
            set { this.SetValue(x => x.total_paid, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? total_refunded
        {
            get { return this.GetValue(x => x.total_refunded); }
            set { this.SetValue(x => x.total_refunded, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double? discount_amount
        {
            get { return this.GetValue(x => x.discount_amount); }
            set { this.SetValue(x => x.discount_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_shipping_discount_amount
        {
            get { return this.GetValue(x => x.base_shipping_discount_amount); }
            set { this.SetValue(x => x.base_shipping_discount_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_subtotal_incl_tax
        {
            get { return this.GetValue(x => x.base_subtotal_incl_tax); }
            set { this.SetValue(x => x.base_subtotal_incl_tax, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double base_total_due
        {
            get { return this.GetValue(x => x.base_total_due); }
            set { this.SetValue(x => x.base_total_due, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double total_due
        {
            get { return this.GetValue(x => x.total_due); }
            set { this.SetValue(x => x.total_due, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string base_currency_code
        {
            get { return this.GetValue(x => x.base_currency_code); }
            set { this.SetValue(x => x.base_currency_code, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string discount_description
        {
            get { return this.GetValue(x => x.discount_description); }
            set { this.SetValue(x => x.discount_description, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double shipping_discount_amount
        {
            get { return this.GetValue(x => x.shipping_discount_amount); }
            set { this.SetValue(x => x.shipping_discount_amount, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double subtotal_incl_tax
        {
            get { return this.GetValue(x => x.subtotal_incl_tax); }
            set { this.SetValue(x => x.subtotal_incl_tax, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DoubleConverter))]
        public double shipping_incl_tax
        {
            get { return this.GetValue(x => x.shipping_incl_tax); }
            set { this.SetValue(x => x.shipping_incl_tax, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string payment_method
        {
            get { return this.GetValue(x => x.payment_method); }
            set { this.SetValue(x => x.payment_method, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string gift_message_from
        {
            get { return this.GetValue(x => x.gift_message_from); }
            set { this.SetValue(x => x.gift_message_from, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string gift_message_to
        {
            get { return this.GetValue(x => x.gift_message_to); }
            set { this.SetValue(x => x.gift_message_to, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string gift_message_body
        {
            get { return this.GetValue(x => x.gift_message_body); }
            set { this.SetValue(x => x.gift_message_body, value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string tax_name
        {
            get { return this.GetValue(x => x.tax_name); }
            set { this.SetValue(x => x.tax_name, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tax_rate
        {
            get { return this.GetValue(x => x.tax_rate); }
            set { this.SetValue(x => x.tax_rate, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        
        public List<OrderAddress> addresses
        {
            get { return this.GetValue(x => x.addresses); }
            set { this.SetValue(x => x.addresses, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public List<OrderItem> order_items
        {
            get { return this.GetValue(x => x.order_items); }
            set { this.SetValue(x => x.order_items, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public List<OrderComment> order_comments
        {
            get { return this.GetValue(x => x.order_comments); }
            set { this.SetValue(x => x.order_comments, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime created_at
        {
            get { return this.GetValue(x => x.created_at); }
            set { this.SetValue(x => x.created_at, value); }
        }
		/// <summary>
        /// 
        /// </summary>
        public string remote_ip
        {
            get { return this.GetValue(x => x.remote_ip); }
            set { this.SetValue(x => x.remote_ip, value); }
        }
		/// <summary>
        /// 
        /// </summary>
        public string store_currency_code
        {
            get { return this.GetValue(x => x.store_currency_code); }
            set { this.SetValue(x => x.store_currency_code, value); }
        }
		/// <summary>
        /// 
        /// </summary>
        public string store_name
        {
            get { return this.GetValue(x => x.store_name); }
            set { this.SetValue(x => x.store_name, value); }
        }		
		/// <summary>
        /// 
        /// </summary>
        public string increment_id
        {
            get { return this.GetValue(x => x.increment_id); }
            set { this.SetValue(x => x.increment_id, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string status
        {
            get { return this.GetValue(x => x.status); }
            set { this.SetValue(x => x.status, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string coupon_code
        {
            get { return this.GetValue(x => x.coupon_code); }
            set { this.SetValue(x => x.coupon_code, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string shipping_description
        {
            get { return this.GetValue(x => x.shipping_description); }
            set { this.SetValue(x => x.shipping_description, value); }
        }
    }
}
