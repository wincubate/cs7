using System;
using System.Collections.Generic;
using System.Linq;

namespace Wincubate.Module12.Slide27
{

    public class PersonRepository
    {
        private readonly List<Person> _persons;

        public PersonRepository()
        {
            Person bo = new Person
            {
                FirstName = "Bo",
                LastName = "Rammstein"
            };
            Person pehn = new Person
            {
                FirstName = "Peter",
                LastName = "Nothing Henriksen"
            };
            Person jeshe = new Person
            {
                FirstName = "Jesper",
                LastName = "Guldfisk Henriksen"
            };

            _persons = new List<Person>
            {
                bo, pehn, jeshe
            };
        }

        public IEnumerable<Person> GetAll()
        {
            return _persons.ToList();
        }

        public void Add( Person person )
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            _persons.Add(person);
        }
    }
}
