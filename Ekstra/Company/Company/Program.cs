using System;

namespace Company
{
    class Program
    {
        static void Main( string[] args )
        {
            Employee e1 = new Developer("Kode", "Karlsen", 24567);
            Employee e2 = new Developer("Bitten", "Truesen", 123000);
            Employee e3 = new Manager("Bob", "Dude", "RnD");

            Employee[] all = { e1, e2, e3 };
            foreach (Employee e in all)
            {
                switch (e)
                {
                    case Developer d when d.CodeLinesProduced > 50000:
                        Console.WriteLine($"{d.FullName} has produced an amazing total of {d.CodeLinesProduced}");
                        break;
                    case Developer d:
                        Console.WriteLine($"{d.FullName} has produced an ordinary total of {d.CodeLinesProduced}");
                        break;
                    case Manager m:
                        Console.WriteLine($"{m.FullName} is in {m.Department}");
                        break;
                    case null:
                    default:
                        Console.WriteLine("Good luck with that :-)");
                        break;
                }
            }
        }
    }
}
