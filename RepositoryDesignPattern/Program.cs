using Newtonsoft.Json;
using RepositoryDesignPattern.Models;
using RepositoryDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { FirstName = "Ewa", LastName = "Ewowska", BirthDate = new DateTime(2000, 5, 12) };

            var address = new Address() { Id = 1, Street = "Łódzka", Town = "Warszawa" };

            var addressesService = new GenericService<Address, long>();

            addressesService.Update(address.Id, address);
            Console.WriteLine(JsonConvert.SerializeObject(addressesService.Read()));
            Console.WriteLine(JsonConvert.SerializeObject(addressesService.Read(x => x.Town == "Warszawa")));



            var peopeService = new PeopleService();
            person.Address = addressesService.Read(1);
            peopeService.Update(1, person);

            Console.WriteLine(JsonConvert.SerializeObject(peopeService.ReadFull(1)));

            Console.ReadLine();
        }
    }
}
