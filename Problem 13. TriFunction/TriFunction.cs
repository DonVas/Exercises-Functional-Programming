using System;
using System.Linq;

namespace Problem_13._TriFunction
{
    public class TriFunction
    {
        public static void Main()
        {

            int number = int.Parse(Console.ReadLine());

            Func<string, char[]> funcToCharArr = x => x.ToCharArray();
            Func<char, int> castFunc = y => (int) y;
            Func<string, bool> finalFunc = x => funcToCharArr(x).Select(castFunc).Sum() >= number;

            Console.WriteLine(Console.ReadLine()
                .Split()
                .FirstOrDefault(finalFunc));
        }
    }
}
