using System;
using System.Collections.Generic;
using System.Reflection;

namespace ProjetoBase.Shared.Bases.BaseValueObjects
{
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;

            var other = obj as ValueObject;

            return Equals(other);
        }

        public virtual bool Equals(ValueObject other)
        {
            if (other is null)
                return false;

            Type t = GetType();
            Type otherType = other.GetType();

            if (t != otherType)
                return false;

            FieldInfo[] fields = t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var field in fields)
            {
                object valueOne = field.GetValue(other);
                object valueTwo = field.GetValue(this);

                if (valueOne is null)
                {
                    if (valueTwo != null)
                        return false;
                }
                else if (!valueOne.Equals(valueTwo))
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            IEnumerable<FieldInfo> fields = GetFields();

            int valorInicial = 17;
            int multiplicador = 59;

            int hashCode = valorInicial;

            foreach (var field in fields)
            {
                object value = field.GetValue(this);

                if (value != null)
                    hashCode = hashCode * multiplicador + value.GetHashCode();
            }

            return hashCode;
        }

        private IEnumerable<FieldInfo> GetFields()
        {
            Type t = GetType();

            List<FieldInfo> fields = new List<FieldInfo>();

            while (t != typeof(object))
            {
                fields.AddRange(t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public));
                t = t.BaseType;
            }

            return fields;
        }

        public static bool operator ==(ValueObject x, ValueObject y) => x.Equals(y);

        public static bool operator !=(ValueObject x, ValueObject y) => !(x == y);
    }
}
