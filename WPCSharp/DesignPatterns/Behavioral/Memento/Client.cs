using System;

namespace DesignPatterns.Behavioral.Memento
{
    public class Client
    {
        public static void Execute()
        {
            var person = new Person()
            {
                Name = "Adam Adamski",
                BirthDate = new DateTime(1989, 12, 12)
            };

            var caretaker = new Caretaker<Person>(person);
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Save();

            person.Name = "Ewa Adamska";
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Save();

            person.Name = "Ewa Ewowska";
            Console.WriteLine($"Name: {person.Name}");


            Console.WriteLine(caretaker);
            //while (true)
            //{
            //    caretaker.Save();
            //    Console.WriteLine(caretaker);
            //}

            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");
            caretaker.Undo();
            Console.WriteLine($"Name: {person.Name}");
        }
    }
}
