using System;
using Magento.RestApi.Core;
using Magento.RestApi.Json;
using Newtonsoft.Json;

namespace Magento.RestApi.Models
{
    [JsonConverter(typeof(OrderCommentConverter))]
    [Serializable]
    public class OrderComment : ChangeTracking<OrderComment>
    {
        /// <summary>
        /// 
        /// </summary>
        public int? is_customer_notified
        {
            get { return this.GetValue(x => x.is_customer_notified); }
            set { this.SetValue(x => x.is_customer_notified, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? is_visible_on_front
        {
            get { return this.GetValue(x => x.is_visible_on_front); }
            set { this.SetValue(x => x.is_visible_on_front, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string comment
        {
            get { return this.GetValue(x => x.comment); }
            set { this.SetValue(x => x.comment, value); }
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
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime created_at
        {
            get { return this.GetValue(x => x.created_at); }
            set { this.SetValue(x => x.created_at, value); }
        }
    }
}
