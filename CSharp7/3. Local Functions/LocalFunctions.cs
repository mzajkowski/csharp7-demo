using System;
using System.ComponentModel;

namespace CSharp7._3._Local_Functions
{
    [Description("[4] Local Functions")]
    class LocalFunctions
    {
        static void Main(string[] args)
        {
            //ImLocalFunctionButICanBeALinqExpCantI(); // Will I work from here?

            void ImLocalFunctionButICanBeALinqExpCantI()
            {
                // Do stuff...
                Console.WriteLine("Local function called.");
            }

            ImLocalFunctionButICanBeALinqExpCantI();

            void ThingsGettingSeriousHere()
            {
                #region Fibonacci with delegates

                void FibonacciWithDelegates()
                {
                    Func<int, int> fib = null;

                    // Version to show for the Professor
                    fib = n =>
                    {
                        if (n == 0)
                            return 0;

                        if (n == 1)
                            return 1;

                        return fib(n - 2) + fib(n - 1);
                    };

                    // Real (thug) life ;)
                    // fib = n => n < 2 ? n : fib(n - 1) + fib(n - 2);

                    // What if someone will replace fib variable here???

                    for (var i = 0; i < 15; i++)
                    {
                        Console.WriteLine(fib(i));
                    }
                }

                #endregion

                #region Fibonacci with local function

                void FibonacciWithLocalFunction()
                {
                    // Oh what a sweet oneliner!
                    int Fib(int n) => n < 2 ? n : Fib(n - 1) + Fib(n - 2);

                    for (var i = 0; i < 15; i++)
                    {
                        Console.WriteLine(Fib(i));
                    }
                }

                #endregion

                //FibonacciWithDelegates();
                FibonacciWithLocalFunction();
            }

            ThingsGettingSeriousHere();
        }
    }
}
