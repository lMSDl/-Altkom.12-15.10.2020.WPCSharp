using RepositoryDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.Configurations
{
    class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
        }
    }
}
