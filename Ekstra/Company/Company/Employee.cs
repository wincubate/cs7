namespace Company
{
    abstract class Employee
    {
        // Data
        public string FirstName { get; protected set; } // 1
        public string LastName { get; protected set; }  // 2

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        // Constructor
        public Employee(
            string firstName,
            string lastName )
        {
            FirstName = firstName; // 1
            LastName = lastName;   // 2
        }

        // Behavior
        public abstract void Work(); // <-- must be overridden!
    }
}
