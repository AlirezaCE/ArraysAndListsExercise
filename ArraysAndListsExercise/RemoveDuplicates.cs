
namespace ArraysAndListsExercise
{
    internal class RemoveDuplicates
    {
        public static void PrintArray(List<int> arrayNumber)
        {
            arrayNumber.ForEach(p => Console.WriteLine($"-> {p}"));
        }

        public static void EnterNumber()
        {
            var strNumber = "";
            var arrayNumber = new List<int>();

            do
            {
                strNumber = Console.ReadLine();
                if (strNumber != null && ValidateNumber(strNumber))
                {
                    arrayNumber.Add(Convert.ToInt32(strNumber));
                }
            }
            while (strNumber != "Quit");   

            var uniqueArrayNumber = DeleteIterativeNumber(arrayNumber);
            PrintArray(uniqueArrayNumber);
        }

        public static bool ValidateNumber(string number)
        {
            if (int.TryParse(number, out int intNumber))
            {
                return true;
            }
            else
            {
                Console.WriteLine("you should enter a valid number");
                return false;
            }
        }

        public static List<int> DeleteIterativeNumber(List<int> arrayNumber)
        {
            var result = new List<int>();

            foreach (int item in arrayNumber)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

    }
}
