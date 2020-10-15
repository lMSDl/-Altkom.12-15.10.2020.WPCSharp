using RepositoryDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.Services
{
    public class PeopleService : GenericService<Person, int>
    {
        public Person ReadByName(string name)
        {
            using (var context = new Context())
            {
                return context.Set<Person>().FirstOrDefault(x => x.FirstName == name);
            }
        }

    }
}
