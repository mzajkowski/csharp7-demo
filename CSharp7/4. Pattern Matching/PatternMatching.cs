using System;
using System.ComponentModel;

namespace CSharp7._4._Pattern_Matching
{
    [Description("[5] Pattern Matching")]
    class PatternMatching
    {
        static void Main(string[] args)
        {
            void TypesMagicBallOrCodeArghhhYouNameIt(object input)
            {
                switch (input)
                {
                    case int x:
                        Console.WriteLine($"{x} is an int!");
                        return;

                    // Below shall not pass!
                    //case string _:
                    //    Console.WriteLine("It's a string!");
                    //    return;

                    case string oooo when oooo.Length > 5:
                        Console.WriteLine("It's a string (and long enough to pass this check!)");
                        return;

                    // But here works fine! Magic.
                    case string _: // Note what we can do if we don't want to assign variable
                        Console.WriteLine("It's a string!");
                        return;
                }
            }

            TypesMagicBallOrCodeArghhhYouNameIt(1);
            TypesMagicBallOrCodeArghhhYouNameIt("Umb");
            TypesMagicBallOrCodeArghhhYouNameIt("Umbraco");
        }
    }
}
