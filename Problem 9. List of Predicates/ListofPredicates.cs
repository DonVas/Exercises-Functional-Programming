using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Problem_9._List_of_Predicates
{
    public class ListofPredicates
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            List<int>numbers=new List<int>(Enumerable.Range(1,range));

            List<int> dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
           var res= isDiviteder(numbers, dividers);
            Console.WriteLine(string.Join(" ",res));
        }

        public static HashSet<int> isDiviteder(List<int>list1, List<int>list2)
        {
            HashSet<int> result= new HashSet<int>();

            foreach (var num1 in list1)
            {
                foreach (var num2 in list2)
                {
                    if (num1%num2==0)
                    {
                        result.Add(num1);
                    }
                    else
                    {
                        result.Remove(num1);
                        continue;
                    }
                }
                
            }

            return result;
        }
    }
}
