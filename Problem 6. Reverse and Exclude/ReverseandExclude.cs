using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Problem_6._Reverse_and_Exclude
{
    public class ReverseandExclude
    {
        public static void Main()
        {
            List<int> numberList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int number = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = x => x % number != 0;
            Func<int, bool> remove = x => isDivisible(x);

            numberList = numberList
                .Where(remove)
                .Reverse()
                .ToList();

            Console.WriteLine(string.Join(" ",numberList));
        }
    }
}
