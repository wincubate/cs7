using System;
using Wincubate.Module08.Data;

namespace Wincubate.Module08.Slide27
{
    class Program
    {
        static void Main( string[] args )
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee[] all = repository.GetAll();

            foreach (Employee e in all)
            {
                switch (e)
                {
                    case SoftwareArchitect sa:
                        Console.WriteLine($"{sa.FullName} plays with Visio");
                        break;

                    case SoftwareEngineer se:
                        Console.WriteLine($"{se.FullName} has a fun job coding all day");
                        break;

                    case null:
                    default:
                        break;
                }

                #region when

                //case SoftwareEngineer se when se.Level == SoftwareEngineerLevel.Lead:
                //    Console.WriteLine($"{se.FullName} is a lead software engineer");
                //    break;

                #endregion
            }
        }
    }
}
