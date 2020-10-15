using RepositoryDesignPattern.Models;
using RefactorThis.GraphDiff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.Services
{
    public class PeopleService : GenericService<Person, int>
    {
        public Person ReadFull(int id)
        {
            using (var context = new Context())
            {
                return context.Set<Person>().Include(x => x.Address).SingleOrDefault(x => x.Id == id);
            }
        }

        public Person ReadByName(string name)
        {
            using (var context = new Context())
            {
                return context.Set<Person>().FirstOrDefault(x => x.FirstName == name);
            }
        }

        public override int Create(Person entity)
        {
            entity.Id = 0;
            return CreateOrUpdate(entity);
        }

        public override void Update(int id, Person entity)
        {
            entity.Id = id;
            CreateOrUpdate(entity);
        }

        private int CreateOrUpdate(Person entity)
        {
            using (var context = new Context())
            {
                entity = context.UpdateGraph(entity, mapping => mapping.AssociatedEntity(x => x.Address));
                context.SaveChanges();
                return entity.Id;
            }
        }
    }
}
