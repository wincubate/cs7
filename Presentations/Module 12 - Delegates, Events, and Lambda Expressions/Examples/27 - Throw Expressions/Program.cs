using System;
using System.Collections.Generic;

namespace Wincubate.Module12.Slide27
{
    class Program
    {
        static void Main( string[] args )
        {
            PersonRepository repository = new PersonRepository();
            IEnumerable<Person> all = repository.GetAll();

            repository.Add(null);

            //repository.Add(new Employee { FirstName = "Anders", LastName = "Hejlsberg" });

            foreach (Person p in all)
            {
                Console.WriteLine( p.FirstName );
            }
        }
    }
}
