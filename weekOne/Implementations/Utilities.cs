namespace weekOne.Implementations
{
    internal class Utilities
    {
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }

        public static void RequestToContinue()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
        public static void RequestToExit()
        {
            Console.WriteLine("Press ENTER button twice to Exit");
            Console.ReadLine();
        }
    }
}
