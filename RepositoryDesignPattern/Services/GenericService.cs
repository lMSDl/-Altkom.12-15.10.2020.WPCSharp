using RepositoryDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.Services
{
    public class GenericService<T, TId> where T : Entity<TId>
    {
        public T Read(Expression<Func<T, bool>> predicate)
        {
            using (var context = new Context())
            {
                return context.Set<T>().Where(predicate).FirstOrDefault();
            }
        }


        public T Read(TId id)
        {
            using (var context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public IEnumerable<T> Read()
        {
            using (var context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public TId Create(T entity)
        {
            using (var context = new Context())
            {
                entity = context.Set<T>().Add(entity);
                context.SaveChanges();
                return entity.Id;
            }
        }

        public void Update(TId id, T entity)
        {
            using (var context = new Context())
            {
                context.Set<T>().Attach(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TId id)
        {
            using (var context = new Context())
            {
                var entity = context.Set<T>().Find(id);
                if(entity != null)
                    context.Set<T>().Remove(entity);
            }
        }
    }
}
