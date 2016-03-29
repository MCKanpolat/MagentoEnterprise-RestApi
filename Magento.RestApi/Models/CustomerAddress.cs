using System;
using System.Collections.Generic;
using Magento.RestApi.Core;
using Magento.RestApi.Json;
using Newtonsoft.Json;

namespace Magento.RestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(CustomerAddressConverter))]
    [Serializable]
    public class CustomerAddress : ChangeTracking<CustomerAddress>
    {
        /// <summary>
        /// 
        /// </summary>
        public CustomerAddress()
        {
            this.StartTracking();
        }

        /// <summary>
        /// Id of the customeraddress
        /// </summary>
        public int entity_id
        {
            get { return this.GetValue(x => x.entity_id); }
            set { this.SetValue(x => x.entity_id, value); }
        }
        /// <summary>
        /// Customer first name
        /// </summary>
        public string firstname
        {
            get { return this.GetValue(x => x.firstname); }
            set { this.SetValue(x => x.firstname, value); }
        }
        /// <summary>
        /// Customer last name
        /// </summary>
        public string lastname
        {
            get { return this.GetValue(x => x.lastname); }
            set { this.SetValue(x => x.lastname, value); }
        }
        /// <summary>
        /// Name of the city
        /// </summary>
        public string city
        {
            get { return this.GetValue(x => x.city); }
            set { this.SetValue(x => x.city, value); }
        }
        /// <summary>
        /// Region name or code
        /// </summary>
        public string region
        {
            get { return this.GetValue(x => x.region); }
            set { this.SetValue(x => x.region, value); }
        }
        /// <summary>
        /// Customer ZIP/postal code
        /// </summary>
        public string postcode
        {
            get { return this.GetValue(x => x.postcode); }
            set { this.SetValue(x => x.postcode, value); }
        }
        /// <summary>
        /// Name of the country
        /// </summary>
        public string country_id
        {
            get { return this.GetValue(x => x.country_id); }
            set { this.SetValue(x => x.country_id, value); }
        }
        /// <summary>
        /// Customer phone number
        /// </summary>
        public string telephone
        {
            get { return this.GetValue(x => x.telephone); }
            set { this.SetValue(x => x.telephone, value); }
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
        public string middlename
        {
            get { return this.GetValue(x => x.middlename); }
            set { this.SetValue(x => x.middlename, value); }
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
        public string company
        {
            get { return this.GetValue(x => x.company); }
            set { this.SetValue(x => x.company, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fax
        {
            get { return this.GetValue(x => x.fax); }
            set { this.SetValue(x => x.fax, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string vat_id
        {
            get { return this.GetValue(x => x.vat_id); }
            set { this.SetValue(x => x.vat_id, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? is_default_billing
        {
            get { return this.GetValue(x => x.is_default_billing); }
            set { this.SetValue(x => x.is_default_billing, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? is_default_shipping
        {
            get { return this.GetValue(x => x.is_default_shipping); }
            set { this.SetValue(x => x.is_default_shipping, value); }
        }
        /// <summary>
        /// Customer street address. There can be more than one street address.
        /// </summary>
        public List<string> street
        {
            get { return this.GetValue(x => x.street); }
            set { this.SetValue(x => x.street, value); }
        }
    }
}
