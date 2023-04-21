using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsExercise
{
    internal class ReverseName
    {
        public static void Reverse()
        {
            var name = EnterName();
            var reversedName = ReverseString(name);
            Console.WriteLine(reversedName);
        }

        public static string EnterName()
        {
            var name = "";
            while (name == "" || name == null)
            {
                name = Console.ReadLine();
            }
            return name;
        }
        public static string ReverseString(string name)
        {
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reversedStr = new string(nameArray);
            return reversedStr;
        }
    }
}
