using System;
using Magento.RestApi.Core;
using Magento.RestApi.Json;
using Newtonsoft.Json;

namespace Magento.RestApi.Models
{
    [JsonConverter(typeof(OrderAddressConverter))]
    [Serializable]
    public class OrderAddress : ChangeTracking<OrderAddress>
    {
        /// <summary>
        /// 
        /// </summary>
        public string firstname
        {
            get { return this.GetValue(x => x.firstname); }
            set { this.SetValue(x => x.firstname, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string lastname
        {
            get { return this.GetValue(x => x.lastname); }
            set { this.SetValue(x => x.lastname, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string middlename
        {
            get { return this.GetValue(x => x.middlename); }
            set { this.SetValue(x => x.middlename, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string prefix
        {
            get { return this.GetValue(x => x.prefix); }
            set { this.SetValue(x => x.prefix, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string suffix
        {
            get { return this.GetValue(x => x.suffix); }
            set { this.SetValue(x => x.suffix, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string email
        {
            get { return this.GetValue(x => x.email); }
            set { this.SetValue(x => x.email, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string company
        {
            get { return this.GetValue(x => x.company); }
            set { this.SetValue(x => x.company, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string postcode
        {
            get { return this.GetValue(x => x.postcode); }
            set { this.SetValue(x => x.postcode, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string city
        {
            get { return this.GetValue(x => x.city); }
            set { this.SetValue(x => x.city, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string street
        {
            get { return this.GetValue(x => x.street); }
            set { this.SetValue(x => x.street, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string telephone
        {
            get { return this.GetValue(x => x.telephone); }
            set { this.SetValue(x => x.telephone, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string address_type
        {
            get { return this.GetValue(x => x.address_type); }
            set { this.SetValue(x => x.address_type, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string region
        {
            get { return this.GetValue(x => x.region); }
            set { this.SetValue(x => x.region, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string country_id
        {
            get { return this.GetValue(x => x.country_id); }
            set { this.SetValue(x => x.country_id, value); }
        }
    }
}
