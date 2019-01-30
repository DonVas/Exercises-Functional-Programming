using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Problem_10._Predicate_Party_
{
   public class PredicateParty
   {
       public static void Main()
       {
           List<string> guests = Console.ReadLine()
               .Split()
               .ToList();

           string[] input = Console.ReadLine().Split();

           while (input[0]!="Party!")
           {
               string command = input[0];
               string filterCommand = input[1];
               string criteria = input[2];
               Func<string, string, bool> predicate;
               predicate = GetFunc(filterCommand);
               switch (command) 
                {
                    case "Remove":
                        guests = guests.Where(x=> !predicate(x,criteria)).ToList();
                        break;
                    case "Double":

                        List<string> guestToAdd = new List<string>(guests.Where(x => predicate(x, criteria)).ToList());

                        foreach (var name in guestToAdd)
                        {
                            int index = guests.IndexOf(name);
                            guests.Insert(index+1,name);
                        }

                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split();
           }

           Console.WriteLine(guests.Any()?$"{string.Join(", ",guests)} are going to the party!": "Nobody is going to the party!");
       }

        static Func<string, string, bool> GetFunc(string filterCommand)
        {
            if (filterCommand=="StartsWith")
            {
                return (x, c) => x.StartsWith(c);
            }
            else if (filterCommand == "EndsWith")
            {
                return (x, c) => x.EndsWith(c);
            }
            else if (filterCommand == "Length")
            {
                return (x, c) => x.Length==int.Parse(c);
            }
            return null;
        }
   }
}
