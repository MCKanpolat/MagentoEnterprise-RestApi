using System;
using System.Collections.Generic;
using Magento.RestApi.Core;
using Magento.RestApi.Json;
using Newtonsoft.Json;

namespace Magento.RestApi.Models
{
    /// <summary>
    /// A product
    /// </summary>
    [JsonConverter(typeof(ProductConverter))]
    [Serializable]
    public class Product : ChangeTracking<Product>
    {
        /// <summary>
        /// 
        /// </summary>
        public Product()
        {
            this.StartTracking();
        }

        public override void StartTracking()
        {
            base.StartTracking();
            if (this.group_price != null)
            {
                foreach (var groupPrice in this.group_price)
                {
                    groupPrice.StartTracking();
                }
            }
            if (this.tier_price != null)
            {
                foreach (var tierPrice in this.tier_price)
                {
                    tierPrice.StartTracking();
                }
            }
            if (this.stock_data != null) this.stock_data.StartTracking();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override bool HasChanged()
        {
            var hasChanged = base.HasChanged();
            
            if (!hasChanged)
            {
                var attributes = this.GetProperty(p => p.Attributes);
                foreach (var attribute in attributes.Value)
                {
                    if (!attributes.InitialValue.ContainsKey(attribute.Key))
                    {
                        hasChanged = true;
                    }
                    else
                    {
                        if (attribute.Value != attributes.InitialValue[attribute.Key])
                        {
                            hasChanged = true;
                        }
                    }
                }
            }

            return hasChanged;
        }

        /// <summary>
        /// Id of the product
        /// </summary>
        public int entity_id
        {
            get { return this.GetValue(x => x.entity_id); }
            set { this.SetValue(x => x.entity_id, value); }
        }

        /// <summary>
        /// Product type. Can have the "simple" value
        /// </summary>
        /// <remarks>required</remarks>
        public string type_id
        {
            get { return this.GetValue(x => x.type_id); }
            set { this.SetValue(x => x.type_id, value); }
        }
        /// <summary>
        /// Attribute set for the product
        /// </summary>
        /// <remarks>required</remarks>
        public int attribute_set_id
        {
            get { return this.GetValue(x => x.attribute_set_id); }
            set { this.SetValue(x => x.attribute_set_id, value); }
        }
        /// <summary>
        /// Product SKU	
        /// </summary>
        /// <remarks>required</remarks>
        public string sku
        {
            get { return this.GetValue(x => x.sku); }
            set { this.SetValue(x => x.sku, value); }
        }
        /// <summary>
        /// Product name
        /// </summary>
        /// <remarks>required</remarks>
        public string name
        {
            get { return this.GetValue(x => x.name); }
            set { this.SetValue(x => x.name, value); }
        }
        /// <summary>
        /// Product meta title
        /// </summary>
        /// <remarks>optional</remarks>
        public string meta_title
        {
            get { return this.GetValue(x => x.meta_title); }
            set { this.SetValue(x => x.meta_title, value); }
        }
        /// <summary>
        /// Product meta description
        /// </summary>
        /// <remarks>optional</remarks>
        public string meta_description
        {
            get { return this.GetValue(x => x.meta_description); }
            set { this.SetValue(x => x.meta_description, value); }
        }
        /// <summary>
        /// A friendly URL path for the product
        /// </summary>
        /// <remarks>optional</remarks>
        public string url_key
        {
            get { return this.GetValue(x => x.url_key); }
            set { this.SetValue(x => x.url_key, value); }
        }
        /// <summary>
        /// Custom design applied for the product page
        /// </summary>
        /// <remarks>optional</remarks>
        public string custom_design
        {
            get { return this.GetValue(x => x.custom_design); }
            set { this.SetValue(x => x.custom_design, value); }
        }
        /// <summary>
        /// Page template that can be applied to the product page
        /// </summary>
        /// <remarks>optional</remarks>
        public string page_layout
        {
            get { return this.GetValue(x => x.page_layout); }
            set { this.SetValue(x => x.page_layout, value); }
        }
        /// <summary>
        /// Defines how the custom options for the product will be displayed. Can have the following values: Block after Info Column or Product Info Column
        /// </summary>
        /// <remarks>optional</remarks>
        public string options_container
        {
            get { return this.GetValue(x => x.options_container); }
            set { this.SetValue(x => x.options_container, value); }
        }
        /// <summary>
        /// Product country of manufacture. This is the 2 letter ISO code of the country.
        /// </summary>
        /// <remarks>optional</remarks>
        public string country_of_manufacture
        {
            get { return this.GetValue(x => x.country_of_manufacture); }
            set { this.SetValue(x => x.country_of_manufacture, value); }
        }
        /// <summary>
        /// The Apply MAP option. Defines whether the price in the catalog in the frontend is substituted with a Click for price link
        /// </summary>
        /// <remarks>optional</remarks>
        public ManufacturerPriceEnablement? msrp_enabled
        {
            get { return this.GetValue(x => x.msrp_enabled); }
            set { this.SetValue(x => x.msrp_enabled, value); }
        }
        /// <summary>
        /// Defines how the price will be displayed in the frontend. Can have the following values: In Cart, Before Order Confirmation, and On Gesture
        /// </summary>
        /// <remarks>optional</remarks>
        public PriceTypeDisplay? msrp_display_actual_price_type
        {
            get { return this.GetValue(x => x.msrp_display_actual_price_type); }
            set { this.SetValue(x => x.msrp_display_actual_price_type, value); }
        }
        /// <summary>
        /// Defines whether the gift message is available for the product
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(BoolConverter))]
        public bool? gift_message_available
        {
            get { return this.GetValue(x => x.gift_message_available); }
            set { this.SetValue(x => x.gift_message_available, value); }
        }
        /// <summary>
        /// Product price
        /// </summary>
        /// <remarks>required</remarks>
        [JsonConverter(typeof(DoubleConverter))]
        public double price
        {
            get { return this.GetValue(x => x.price); }
            set { this.SetValue(x => x.price, value); }
        }
        /// <summary>
        /// Product special price
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(DoubleConverter))]
        public double? special_price
        {
            get { return this.GetValue(x => x.special_price); }
            set { this.SetValue(x => x.special_price, value); }
        }
        /// <summary>
        /// Product weight
        /// </summary>
        /// <remarks>required</remarks>
        [JsonConverter(typeof(DoubleConverter))]
        public double weight
        {
            get { return this.GetValue(x => x.weight); }
            set { this.SetValue(x => x.weight, value); }
        }
        /// <summary>
        /// The Manufacturer's Suggested Retail Price option. The price that a manufacturer suggests to sell the product at
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(DoubleConverter))]
        public double? msrp
        {
            get { return this.GetValue(x => x.msrp); }
            set { this.SetValue(x => x.msrp, value); }
        }
        /// <summary>
        /// Product status. Can have the following values: 1- Enabled, 2 - Disabled.
        /// </summary>
        /// <remarks>required</remarks>
        [JsonConverter(typeof(EnumConverter))]
        public ProductStatus status
        {
            get { return this.GetValue(x => x.status); }
            set { this.SetValue(x => x.status, value); }
        }
        /// <summary>
        /// Product visibility. Can have the following values: 1 - Not Visible Individually, 2 - Catalog, 3 - Search, 4 - Catalog, Search.
        /// </summary>
        /// <remarks>required</remarks>
        [JsonConverter(typeof(EnumConverter))]
        public ProductVisibility visibility
        {
            get { return this.GetValue(x => x.visibility); }
            set { this.SetValue(x => x.visibility, value); }
        }
        /// <summary>
        /// Defines whether the product can be purchased with the help of the Google Checkout payment service. Can have the following values: Yes and No
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(BoolConverter))]
        public bool? enable_googlecheckout
        {
            get { return this.GetValue(x => x.enable_googlecheckout); }
            set { this.SetValue(x => x.enable_googlecheckout, value); }
        }
        /// <summary>
        /// Product tax class. Can have the following values: 0 - None, 2 - taxable Goods, 4 - Shipping, etc., depending on created tax classes.
        /// </summary>
        /// <remarks>required</remarks>
        public int? tax_class_id
        {
            get { return this.GetValue(x => x.tax_class_id); }
            set { this.SetValue(x => x.tax_class_id, value); }
        }
        /// <summary>
        /// Product description.
        /// </summary>
        /// <remarks>required</remarks>
        public string description
        {
            get { return this.GetValue(x => x.description); }
            set { this.SetValue(x => x.description, value); }
        }
        /// <summary>
        /// Product short description.
        /// </summary>
        /// <remarks>optional</remarks>
        public string short_description
        {
            get { return this.GetValue(x => x.short_description); }
            set { this.SetValue(x => x.short_description, value); }
        }
        /// <summary>
        /// Product meta keywords
        /// </summary>
        /// <remarks>optional</remarks>
        public string meta_keyword
        {
            get { return this.GetValue(x => x.meta_keyword); }
            set { this.SetValue(x => x.meta_keyword, value); }
        }
        /// <summary>
        /// An XML block to alter the page layout
        /// </summary>
        /// <remarks>optional</remarks>
        public string custom_layout_update
        {
            get { return this.GetValue(x => x.custom_layout_update); }
            set { this.SetValue(x => x.custom_layout_update, value); }
        }
        /// <summary>
        /// Date starting from which the special price will be applied to the product
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? special_from_date
        {
            get { return this.GetValue(x => x.special_from_date); }
            set { this.SetValue(x => x.special_from_date, value); }
        }
        /// <summary>
        /// Date till which the special price will be applied to the product
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? special_to_date
        {
            get { return this.GetValue(x => x.special_to_date); }
            set { this.SetValue(x => x.special_to_date, value); }
        }
        /// <summary>
        /// Date starting from which the product is promoted as a new product
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? news_from_date
        {
            get { return this.GetValue(x => x.news_from_date); }
            set { this.SetValue(x => x.news_from_date, value); }
        }
        /// <summary>
        /// Date till which the product is promoted as a new product
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? news_to_date
        {
            get { return this.GetValue(x => x.news_to_date); }
            set { this.SetValue(x => x.news_to_date, value); }
        }
        /// <summary>
        /// Date starting from which the custom design will be applied to the product page
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? custom_design_from
        {
            get { return this.GetValue(x => x.custom_design_from); }
            set { this.SetValue(x => x.custom_design_from, value); }
        }
        /// <summary>
        /// Date till which the custom design will be applied to the product page
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? custom_design_to
        {
            get { return this.GetValue(x => x.custom_design_to); }
            set { this.SetValue(x => x.custom_design_to, value); }
        }
        /// <summary>
        /// Product group price
        /// </summary>
        /// <remarks>optional</remarks>
        public List<GroupPrice> group_price
        {
            get { return this.GetValue(x => x.group_price); }
            set { this.SetValue(x => x.group_price, value); }
        }
        /// <summary>
        /// Product tier price
        /// </summary>
        /// <remarks>optional</remarks>
        public List<TierPrice> tier_price
        {
            get { return this.GetValue(x => x.tier_price); }
            set { this.SetValue(x => x.tier_price, value); }
        }
        /// <summary>
        /// Product inventory data
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(StockDataConverter))]
        public StockData stock_data
        {
            get { return this.GetValue(x => x.stock_data); }
            set { this.SetValue(x => x.stock_data, value); }
        }
        /// <summary>
        /// A dictionary of all specified attributes
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this.GetValue(x => x.Attributes); }
            set { this.SetValue(x => x.Attributes, value); }
        }

    }
}