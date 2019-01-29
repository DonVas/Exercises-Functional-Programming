using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Problem_4._Find_Evens_or_Odds
{
    public class FindEvensorOdds
    {
        public static void Main()
        {
            Predicate<int> isOdd = x => x % 2 != 0;

            int[] range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string wish = Console.ReadLine();

            List<int> result = new List<int>(Enumerable.Range(range[0],range[1]-range[0]+1));

            result.Where(x=>wish=="odd"? isOdd(x) : !isOdd(x))
                .ToList()
                .ForEach(x=>Console.Write(x+" ")); //Last " " are not wished "to do"

        }
    }
}
