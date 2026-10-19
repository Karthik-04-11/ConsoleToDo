using System;
namespace ConsoleToDo
{
    internal class ConsoleIO
    {
        public static string ReadString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? userInput = Console.ReadLine()?.Trim() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    return userInput;
                }
                Console.WriteLine("Please enter a valid input");
            }
        }

        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine()?.Trim() ?? string.Empty;
                if(int.TryParse(input, out int userInput))
                {
                    return userInput;
                }
                Console.WriteLine("Please enter a valid value");
            }
        }

        public static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}