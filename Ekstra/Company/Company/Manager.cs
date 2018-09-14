using System;

namespace Company
{
    // Inherited class
    class Manager : Employee
    {
        public string Department { get; protected set; } // 3

        public Manager(
            string firstName,
            string lastName,
            string department ) : base( firstName, lastName )
        {
            Department = department; // 3
        }

        // Behavior (Overridden)
        public override void Work()
        {
            Console.WriteLine( $"{FullName} attends a meeting in {Department}");
        }
    }
}
