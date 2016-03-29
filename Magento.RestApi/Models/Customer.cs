using System;
using Magento.RestApi.Core;
using Magento.RestApi.Json;
using Newtonsoft.Json;

namespace Magento.RestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(CustomerConverter))]
    [Serializable]
    public class Customer : ChangeTracking<Customer>
    {
        /// <summary>
        /// 
        /// </summary>
        public Customer()
        {
            this.StartTracking();
        }

        /// <summary>
        /// Id of the customer
        /// </summary>
        public int entity_id
        {
            get { return this.GetValue(x => x.entity_id); }
            set { this.SetValue(x => x.entity_id, value); }
        }
        /// <summary>
        /// The customer first name
        /// </summary>
        /// <remarks>required</remarks>
        public string firstname
        {
            get { return this.GetValue(x => x.firstname); }
            set { this.SetValue(x => x.firstname, value); }
        }
        /// <summary>
        /// The customer last name
        /// </summary>
        /// <remarks>required</remarks>
        public string lastname
        {
            get { return this.GetValue(x => x.lastname); }
            set { this.SetValue(x => x.lastname, value); }
        }
        /// <summary>
        /// The customer email address
        /// </summary>
        /// <remarks>required</remarks>
        public string email
        {
            get { return this.GetValue(x => x.email); }
            set { this.SetValue(x => x.email, value); }
        }
        /// <summary>
        /// The customer password. The password must contain minimum 7 characters
        /// </summary>
        /// <remarks>required</remarks>
        public string password
        {
            get { return this.GetValue(x => x.password); }
            set { this.SetValue(x => x.password, value); }
        }
        /// <summary>
        /// Website ID
        /// </summary>
        /// <remarks>required</remarks>
        public int website_id
        {
            get { return this.GetValue(x => x.website_id); }
            set { this.SetValue(x => x.website_id, value); }
        }
        /// <summary>
        /// Customer group ID
        /// </summary>
        /// <remarks>required</remarks>
        public int group_id
        {
            get { return this.GetValue(x => x.group_id); }
            set { this.SetValue(x => x.group_id, value); }
        }
        /// <summary>
        /// Defines whether the automatic group change for the customer will be disabled
        /// </summary>
        /// <remarks>optional</remarks>
        [JsonConverter(typeof(BoolConverter))]
        public bool? disable_auto_group_change
        {
            get { return this.GetValue(x => x.disable_auto_group_change); }
            set { this.SetValue(x => x.disable_auto_group_change, value); }
        }
        /// <summary>
        /// Customer prefix
        /// </summary>
        /// <remarks>optional</remarks>
        public string prefix
        {
            get { return this.GetValue(x => x.prefix); }
            set { this.SetValue(x => x.prefix, value); }
        }
        /// <summary>
        /// Customer middle name or initial
        /// </summary>
        /// <remarks>optional</remarks>
        public string middlename
        {
            get { return this.GetValue(x => x.middlename); }
            set { this.SetValue(x => x.middlename, value); }
        }
        /// <summary>
        /// Customer suffix
        /// </summary>
        /// <remarks>optional</remarks>
        public string suffix
        {
            get { return this.GetValue(x => x.suffix); }
            set { this.SetValue(x => x.suffix, value); }
        }
        /// <summary>
        /// Customer Tax or VAT number	
        /// </summary>
        /// <remarks>optional</remarks>
        public string taxvat
        {
            get { return this.GetValue(x => x.taxvat); }
            set { this.SetValue(x => x.taxvat, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Can't be set</remarks>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? last_logged_in
        {
            get { return this.GetValue(x => x.last_logged_in); }
            set { this.SetValue(x => x.last_logged_in, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Can't be set</remarks>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? created_at
        {
            get { return this.GetValue(x => x.created_at); }
            set { this.SetValue(x => x.created_at, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Can't be set</remarks>
        public string created_in
        {
            get { return this.GetValue(x => x.created_in); }
            set { this.SetValue(x => x.created_in, value); }
        }
    }
}
