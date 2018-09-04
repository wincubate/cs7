using System;

namespace Wincubate.Module05.Slide06
{
    class C
    {
        public static void M()
        {
            Console.WriteLine( "C.M() invoked" );
        }
    }

    class Program
    {
        static void Main()
        {
            C.M();

            // Wait for CR
            Console.ReadLine();
        }
    }
}
