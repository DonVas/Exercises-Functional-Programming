using System;
using System.Linq;

namespace Problem_8._Custom_Comparator
{
    public class CustomComparator
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(array, (x, y) =>
            {
                int remX = Math.Abs(x % 2);
                int remY = Math.Abs(y % 2);
                return remX.CompareTo(remY);
            });
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
