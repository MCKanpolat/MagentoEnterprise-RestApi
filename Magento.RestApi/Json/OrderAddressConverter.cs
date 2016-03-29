using System;
using Magento.RestApi.Models;
using Newtonsoft.Json;

namespace Magento.RestApi.Json
{
    /// <summary>
    /// 
    /// </summary>
    public class OrderAddressConverter : BaseConverter<OrderAddress>
    {
        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            var orderAddress = value as OrderAddress;
            
            writer.WriteStartObject();

            this.WriteProperty(orderAddress, p => p.address_type, true, writer, serializer);
            this.WriteProperty(orderAddress, p => p.firstname, true, writer, serializer);
            this.WriteProperty(orderAddress, p => p.lastname, true, writer, serializer);
            this.WriteProperty(orderAddress, p => p.street, true, writer, serializer);
            this.WriteProperty(orderAddress, p => p.city, true, writer, serializer);
            this.WriteProperty(orderAddress, p => p.country_id, true, writer, serializer);
            this.WriteProperty(orderAddress, p => p.region, false, writer, serializer);
            this.WriteProperty(orderAddress, p => p.postcode, true, writer, serializer);
            this.WriteProperty(orderAddress, p => p.telephone, true, writer, serializer);
            this.WriteProperty(orderAddress, p => p.company, false, writer, serializer);
            this.WriteProperty(orderAddress, p => p.middlename, false, writer, serializer);
            this.WriteProperty(orderAddress, p => p.prefix, false, writer, serializer);
            this.WriteProperty(orderAddress, p => p.suffix, false, writer, serializer);

            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var OrderAddress = existingValue as OrderAddress ?? new OrderAddress();

            serializer.Populate(reader, OrderAddress);

            OrderAddress.StartTracking();
            return OrderAddress;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsAssignableFrom(typeof(OrderAddress));
        }
    }
}
