﻿using System;
using Magento.RestApi.Models;
using Newtonsoft.Json;

namespace Magento.RestApi.Json
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerConverter : BaseConverter<Customer>
    {
        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            var product = value as Customer;
            
            writer.WriteStartObject();

            this.WriteProperty(product, p => p.entity_id, true, writer, serializer);
            this.WriteProperty(product, p => p.firstname, false, writer, serializer);
            this.WriteProperty(product, p => p.lastname, false, writer, serializer);
            this.WriteProperty(product, p => p.email, false, writer, serializer);
            this.WriteProperty(product, p => p.group_id, false, writer, serializer);
            this.WriteProperty(product, p => p.middlename, false, writer, serializer);
            this.WriteProperty(product, p => p.prefix, false, writer, serializer);
            this.WriteProperty(product, p => p.suffix, false, writer, serializer);
            this.WriteProperty(product, p => p.taxvat, false, writer, serializer);
            this.WriteProperty(product, p => p.password, false, writer, serializer);
            this.WriteProperty(product, p => p.website_id, false, writer, serializer);
            this.WriteProperty(product, p => p.disable_auto_group_change, false, writer, serializer);

            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var customer = existingValue as Customer ?? new Customer();

            serializer.Populate(reader, customer);

            customer.StartTracking();
            return customer;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsAssignableFrom(typeof(Customer));
        }
    }
}
