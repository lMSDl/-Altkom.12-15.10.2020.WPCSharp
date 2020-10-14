using System;
using System.Linq;
using System.Reflection;

namespace DesignPatterns.Behavioral.Memento
{
    public class Person : ICloneable, IRestorable<Person>
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Restore(Person state)
        {
            var properyInfos = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead && p.CanWrite).ToList();

            properyInfos.ForEach(x =>
            {
                var oldValue = x.GetValue(state);
                x.SetValue(this, oldValue);
            });
        }
    }
}
