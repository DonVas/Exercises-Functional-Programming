using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_5._Applied_Arithmetics
{
    public class AppliedArithmetics
    {
        public static void Main()
        {
            List<int> numbersList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<List<int>, List<int>> add = x => x.Select(y => y + 1).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(y => y * 2).ToList();
            Func<List<int>, List<int>> subtract = x => x.Select(y => y - 1).ToList();
            Action<List<int>> printThem = x => Console.WriteLine(string.Join(" ", x));

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbersList = add(numbersList);
                        break;
                    case "multiply":
                        numbersList = multiply(numbersList);
                        break;
                    case "subtract":
                        numbersList = subtract(numbersList);
                        break;
                    case "print":
                        printThem(numbersList);
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
