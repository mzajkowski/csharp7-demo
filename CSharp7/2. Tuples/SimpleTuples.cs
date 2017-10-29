using System;

namespace CSharp7._2._Tuples
{
    class SimpleTuples
    {
        static void Main()
        {
            var myTuple = (1, "Hello #umbUKFest!", DateTime.UtcNow);
            Console.WriteLine(myTuple.Item1);
            Console.WriteLine(myTuple.Item2);
            Console.WriteLine(myTuple.Item3); // Bug in the C# compiler here? ;)

            var myValueTuple = new ValueTuple<int, string, DateTime>(1, "Hello #umbUKFest!", DateTime.UtcNow);
            Console.WriteLine(myValueTuple.Item1);
            Console.WriteLine(myValueTuple.Item2);
            Console.WriteLine(myValueTuple.Item3);

            var myNamedTuple = (id: 1, message: "Hello #umbUKFest!", when: DateTime.UtcNow);
            Console.WriteLine(myNamedTuple.id);
            Console.WriteLine(myNamedTuple.message);
            Console.WriteLine(myNamedTuple.when);

            (int id, string message, DateTime when) myNamedTuple2 = (1, "Hello #umbUKFest!", DateTime.UtcNow);
        }
    }
}
