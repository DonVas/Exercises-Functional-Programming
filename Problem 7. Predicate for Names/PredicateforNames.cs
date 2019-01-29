using System;
using System.Linq;

namespace Problem_7._Predicate_for_Names
{
    public class PredicateforNames
    {
        public static void Main()
        {
            int nameLenght = int.Parse(Console.ReadLine());

            Predicate<string> lenghtIsOk = x => x.Length <= nameLenght;
            Func<string, bool> condition = x => lenghtIsOk(x);

            Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Where(condition)
                .ToList()
                .ForEach(x=> Console.WriteLine(x));
        }
    }
}
