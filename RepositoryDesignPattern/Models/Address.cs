using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.Models
{
    public class Address : Entity<long>
    {
        public string Street { get; set; }
        public string Town { get; set; }
    }
}
