using System;

namespace Wincubate.Module13.Slide18
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main( string[] args )
        {
            Person elJefe = new Person { FirstName = "Ash", LastName = "Williams" };

            //var (first, last) = elJefe;

            //Console.WriteLine(first);
        }
    }
}
