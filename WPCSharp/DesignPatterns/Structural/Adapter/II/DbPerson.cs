using System;

namespace DesignPatterns.Structural.Adapter.II
{
    public class DbPerson : ICloneable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
