using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.Prototype
{
    public class Person : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<string> Address { get; set; }
        public IdInfo IdInfo { get; set; }
        private DateTime _creationDate = DateTime.Now;

        public object Clone()
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
    }
}
