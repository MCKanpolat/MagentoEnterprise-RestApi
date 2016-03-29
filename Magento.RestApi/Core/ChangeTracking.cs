using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Newtonsoft.Json;

namespace Magento.RestApi.Core
{
    [Serializable]
    public class ChangeTracking<T> : IChangeTracking<T>
    {
        protected readonly Dictionary<string, IProperty> _properties = new Dictionary<string, IProperty>();

        [JsonIgnore]
        public bool HasStartedTracking { get; protected set; }

        public virtual bool HasChanged()
        {
            return this._properties.Aggregate(false, (current, property) => current | property.Value.HasChanged());
        }

        public bool HasChanged<P>(Expression<Func<T, P>> expression)
        {
            var name = (expression.Body as MemberExpression).Member.Name;
            return this._properties.ContainsKey(name) && this._properties[name].HasChanged();
        }

        public virtual void StartTracking()
        {
            this.HasStartedTracking = true;
            foreach (var property in this._properties)
            {
                property.Value.SetValueAsInitial();
            }
        }

        public P GetValue<P>(Expression<Func<T, P>> expression)
        {
            var name = (expression.Body as MemberExpression).Member.Name;
            if (this._properties.ContainsKey(name)) return (this._properties[name] as Property<P>).Value;
            var property = new Property<P>();
            if (this.HasStartedTracking) property.SetValueAsInitial();
            this._properties.Add(name, property);
            return (this._properties[name] as Property<P>).Value;
        }

        public void SetValue<P>(Expression<Func<T, P>> expression, P value)
        {
            var name = (expression.Body as MemberExpression).Member.Name;
            if (!this._properties.ContainsKey(name))
            {
                var property = new Property<P>();
                if (this.HasStartedTracking) property.SetValueAsInitial();
                this._properties.Add(name, property);

            }
            (this._properties[name] as Property<P>).Value = value;
        }

        public Property<P> GetProperty<P>(Expression<Func<T, P>> expression)
        {
            var name = (expression.Body as MemberExpression).Member.Name;
            if (this._properties.ContainsKey(name))
            {
                return this._properties[name] as Property<P>;
            }
            return null;
        }
    }
}
