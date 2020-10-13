using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Adapter.II
{
    public class DbPeopleServiceAdapter : IPeopleService
    {
        private DbPeopleService _dbPeopleService;

        public DbPeopleServiceAdapter(DbPeopleService dbPeopleService)
        {
            _dbPeopleService = dbPeopleService;
        }

        public IEnumerable<IPerson> Get()
        {
            var dbPeople = _dbPeopleService.Get();
            return dbPeople.Select(x => new DbPersonAdapter(x));
        }
    }
}
