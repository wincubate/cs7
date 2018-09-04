using System;
using Wincubate.Module08.Data;

namespace Wincubate.Module08.Slide26
{
    class Program
    {
        static void Main( string[] args )
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee[] all = repository.GetAll();

            foreach (Employee e in all)
            {
                //For software engineers:
                //
                //Console.WriteLine($"{se.FullName} has produced {se.CodeLinesProduced} lines of C#");
            }
        }
    }
}
