using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsExercise
{
    internal class FiveUniqueNumber
    {
        public static void PrintSortedNumbers()
        {
            int[] sortedNumbers = SortEnteredNumber();
            Console.WriteLine("\nHere it is sorted numbers: ");
            sortedNumbers.ToList().ForEach(p => Console.WriteLine($"-> {p}"));
        }

        public static int[] SortEnteredNumber()
        {
            int[] result = EnterNumber().ToArray();
            Array.Sort(result);
            return result;
        }

        public static List<int> EnterNumber()
        {
            var NumberList = new List<int>();
            int number;

            do
            { 
                number = Convert.ToInt32(Console.ReadLine());

                if( IsInList(number, NumberList) == false )
                {
                    NumberList.Add(number);
                }
                else
                {
                    Console.WriteLine("you entered an iterated number");
                }

            }
            while (NumberList.Count < 5);
            
            return NumberList;
        }

        public static bool IsInList(int number, List<int>NumberList)
        {
            if(NumberList.Contains(number) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
