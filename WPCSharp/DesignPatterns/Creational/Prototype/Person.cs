using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.Prototype
{
    public class Person : EditableObject<Person>
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<string> Address { get; set; }
        public IdInfo IdInfo { get; set; }
        private DateTime _creationDate = DateTime.Now;

        public override object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = Address.ToList();
            //clone.IdInfo = (IdInfo)IdInfo.Clone();
            clone.IdInfo = new IdInfo();
            return clone;
        }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }

        protected override void Restore(Person clone)
        {
            Age = clone.Age;
            Name = clone.Name;
            Address = clone.Address;
            IdInfo = clone.IdInfo;
            _creationDate = clone._creationDate;
        }
    }
}
