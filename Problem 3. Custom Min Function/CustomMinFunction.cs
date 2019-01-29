using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Custom_Min_Function
{
    public class CustomMinFunction
    {
        public static void Main()
        {
            Func<List<int>, int> findMin = x => x.Min();

            List<int> numberList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(findMin(numberList));
        }
    }
}
