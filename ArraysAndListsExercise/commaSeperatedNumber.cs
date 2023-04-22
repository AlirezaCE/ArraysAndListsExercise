using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsExercise
{
    internal class commaSeperatedNumber
    {
        public static void EnterNumber()
        {
            var userInput = "";
            var listNumberEntered = new List<int>();

            do
            {
                userInput = Console.ReadLine();
                if (!IsNullOrEmpty(userInput))
                {
                    listNumberEntered = userInput.Split(',').Select(i => int.Parse(i)).ToList();
                }
            }
            while (!CheckInputLenght(listNumberEntered));

            var smallestNumber = SortNumbers(listNumberEntered);
            PrintList(smallestNumber);

        }

        private static int[] SortNumbers(List<int> listNumberEntered)
        {
            int[] result = listNumberEntered.ToArray();
            Array.Sort(result);
            return result;

        }

        private static void PrintList(int[] listNumberEntered)
        {
            Console.WriteLine("\nHere it is sorted numbers: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"here it is {i}th number: {listNumberEntered[i]}");
            }
        }

        public static bool CheckInputLenght(List<int> numberEntered)
        {
            if(numberEntered.Count < 5)
            {
                Console.WriteLine("you should enter at least 5 numbers.");
                return false;
            }
            else 
            {
                return true;    
            }
        }

        public static bool IsNullOrEmpty(string userInput)
        {
            if (userInput == "" || userInput == null)
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
