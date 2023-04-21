namespace ArraysAndListsExercise
{
    internal class FacebookLikes
    {
        public static void ShowLikes()
        {
            var name = Console.ReadLine();
            var nameList = new List<string>();

            while (name != "")
            {
                nameList.Add(name);
                name = Console.ReadLine();

            }

            switch (nameList.Count)
            {
                case 0:
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine($"{nameList[0]} likes your post.");
                    break;
                case 2:
                    Console.WriteLine($"{nameList[0]} And {nameList[1]}, like your post.");
                    break;
                default:
                    Console.WriteLine($"{nameList[0]}, {nameList[1]} and {nameList.Count - 2} others like your post.");
                    break;

            }
        }
    }
}
