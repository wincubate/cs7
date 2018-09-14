using System;

namespace Company
{
    // Inherited class
    class Developer : Employee
    {
        // Data
        public int CodeLinesProduced { get; private set; } // 3

        // Constructor
        public Developer(
            string firstName, 
            string lastName,
            int codeLinesProduced = 0 ) : base( firstName, lastName )
        {
            CodeLinesProduced = codeLinesProduced; // 3
        }

        // Behavior (Overridden)
        public override void Work()
        {
            Random random = new Random( this.GetHashCode() );
            int newCodeLines = random.Next(150);
            Console.WriteLine( $"{FullName} produces {newCodeLines} code lines");

            CodeLinesProduced += newCodeLines;
        }
    }
}
