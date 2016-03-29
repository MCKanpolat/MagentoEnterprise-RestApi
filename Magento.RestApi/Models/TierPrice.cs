using System;
using Magento.RestApi.Core;
using Magento.RestApi.Json;
using Newtonsoft.Json;

namespace Magento.RestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(TierPriceConverter))]
    public class TierPrice : ChangeTracking<TierPrice>
    {
        /// <summary>
        /// 
        /// </summary>
        public TierPrice()
        {
            this.StartTracking();
        }

        /// <summary>
        /// Website ID
        /// </summary>
        /// <remarks>optional</remarks>
        public int? website_id
        {
            get { return this.GetValue(x => x.website_id); }
            set { this.SetValue(x => x.website_id, value); }
        }
        /// <summary>
        /// Customer group
        /// </summary>
        /// <remarks>optional</remarks>
        public int? cust_group
        {
            get { return this.GetValue(x => x.cust_group); }
            set { this.SetValue(x => x.cust_group, value); }
        }
        /// <summary>
        /// Tier price
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(DoubleConverter))]
        public double? price
        {
            get { return this.GetValue(x => x.price); }
            set { this.SetValue(x => x.price, value); }
        }
        /// <summary>
        /// Price quantity
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(DoubleConverter))]
        public double? price_qty
        {
            get { return this.GetValue(x => x.price_qty); }
            set { this.SetValue(x => x.price_qty, value); }
        }
    }
}
