using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Action_Point
{
    public static class ActionPoint
    {
        public static void Main()
        {
            Action<string> point = Console.WriteLine;

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList().ForEach(point);                      
        }
    }
}
