using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Magento.RestApi.Core
{
    [Serializable]
    public class Property<T> : IProperty
    {
        protected T _initialValue;
        protected T _value;

        public T InitialValue
        {
            get { return this._initialValue; }
        }

        public T Value { get { return this._value; } set { this._value = value; } }

        public bool HasChanged()
        {
            var hasChanged = false;
            if (typeof (T).IsAssignableFrom(typeof (IChangeTracking<T>)))
            {
                hasChanged = (this.Value as IChangeTracking).HasChanged();
            }
            else if (typeof(T).GetInterfaces().Any(x =>
                                                   x.IsGenericType &&
                                                   x.GetGenericTypeDefinition() == typeof(IList<>)) &&
                !typeof(T).IsAssignableFrom(typeof(byte[])))
            {
                var genericType = typeof (T).GetGenericArguments()[0];
                var initialValue = this._initialValue as IList;
                var value = this._value as IList;
                if (!(value == null && initialValue == null))
                {
                    if ((value == null && initialValue != null) || (value != null && initialValue == null))
                    {
                        hasChanged = true;
                    }
                    else
                    {
                        if (initialValue.Count != value.Count)
                        {
                            hasChanged = true;
                        }
                        else
                        {
                            if (genericType.GetInterfaces().Any(x =>
                                                   x.IsGenericType &&
                                                   x.GetGenericTypeDefinition() == typeof(IChangeTracking<>)))
                            {
                                hasChanged = value.Cast<object>().Aggregate(hasChanged, (current, item) => current | (item as IChangeTracking).HasChanged());
                            }
                            else
                            {
                                for (var i = 0; i < initialValue.Count; i++)
                                {
                                    if (!Equals(initialValue[i], value[i]))
                                    {
                                        hasChanged = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                hasChanged |= !Equals(this._initialValue, this._value);
            }
            return hasChanged;
        }

        public void SetValueAsInitial()
        {
            this._initialValue = this.DeepClone(this._value);
        }

        protected C DeepClone<C>(C obj)
        {
            if (obj == null) return default(C);
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (C)formatter.Deserialize(ms);
            }
        }
    }
}
