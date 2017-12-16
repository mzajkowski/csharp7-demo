using System;
using System.ComponentModel;

namespace CSharp7._5._Out_Vars
{
    [Description("[6] Out Vars")]
    class OutVars
    {
        static void Main(string[] args)
        {
            const string input = "Will it explode?";
            const string intput = "77";

            // The old way
            int result; // Compiler is smart!
            if (int.TryParse(input, out result))
            {
                // Do something...
            }

            // The new way
            if (int.TryParse(input, out var resultVariable))
            {
                // Wow!
            }

            Console.WriteLine(resultVariable); // Oh and it's not complaining here as well!

            if (int.TryParse(intput, out resultVariable))
            {
                // Maybe now?
            }

            // And I can do this if I don't need it anywhere else
            if (int.TryParse(input, out _))
            {
                // Usage possible inside this scope only...
            }

            Console.WriteLine(resultVariable);
        }
    }
}
