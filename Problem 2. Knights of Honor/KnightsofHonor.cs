using System;
using System.Linq;

namespace Problem_2._Knights_of_Honor
{
    public class KnightsofHonor
    {
        public static void Main()
        {
            string prefix = "Sir ";
            Action<string> printThem =x=> Console.WriteLine(prefix+x);

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList().ForEach(printThem);
        }
    }
}
