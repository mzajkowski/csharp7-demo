using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp7._2._Tuples
{
    [Description("[3] Tuples part 2")]
    class TuplesAreFun
    {
        static void Main(string[] args)
        {
            #region 1. Conversion and comparison between tuples

            (long, long) longIntsTuple = (80, 1988);
            // (long, long) longIntsTyple = ((long)80, (long)1988)); // It's exactly same as above cast
            (byte, byte) byteTuple = (15, 30);

            (float, float) floatsTuple = longIntsTuple; // no errors!

            object whoAmI = longIntsTuple;
            // floatsTuple = ((float, float))whoAmI; // ooooops!

            (string, string) parametersTuple = ("test1", "test2");
            (XNamespace, XNamespace) attributesTuple = parametersTuple; // no probs!

            // Let's compare Tuples...
            var tuple1 = (a: 1988, b: 2000);
            var tuple2 = (a: 1988, b: 2017);

            var isMarcinTellingTheTruth = tuple1.GetType() == tuple2.GetType();
            Console.WriteLine(isMarcinTellingTheTruth); // True! But why?

            var tuple3 = (a: 1988L, b: 2000);
            //tuple1 = tuple3; // Fails, because cannot be done without explicit conversion

            #endregion

            #region 2. Deconstruction

            (string FirstName, string LastName) CreateHumanBeing(bool isRobotNotHuman = false)
            {
                // Do some fancy DB operations or something else...
                
                return isRobotNotHuman ? ("Callum", "Whyte") : ("Marcin", "Zajkowski");
            }

            async Task<(string FirstName, string LastName)> CreateHumanBeingAsync()
            {
                await Task.Run(() =>
                {
                    // I'm doing something async here... as we all do ;)
                });

                Console.WriteLine(">>> Async call! <<<");

                return ("Async", "Guy");
                // Below is not there yet... another bug found!
                //return await Task.FromResult<(string FirstName, string LastName)>("Async", "Guy");
            }

            var cogworker1 = CreateHumanBeing();
            var cogworker2 = CreateHumanBeing(true);
            var asyncCogworker = CreateHumanBeingAsync();

            Console.WriteLine($"{cogworker1.FirstName} {cogworker1.LastName}");
            Console.WriteLine($"{cogworker2.FirstName} {cogworker2.LastName} (He really is a robot!)");
            Console.WriteLine($"{asyncCogworker.Result.FirstName} {asyncCogworker.Result.LastName}");

            #endregion

            #region 3. Mutable FTW

            (int left, int right) counters = default; // Another founding! :muscle:

            void IncrementLeft() => counters.left++;
            void IncrementRight() => counters.right++;

            void IncrementBoth()
            {
                IncrementLeft();
                IncrementRight();
            }

            IncrementLeft();
            IncrementBoth();

            Console.WriteLine(counters);

            #endregion
        }
    }
}
