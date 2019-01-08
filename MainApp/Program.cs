using System;

namespace MainApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintStartMessage();
            Console.ReadKey();
        }

        public static void PrintStartMessage()
        {
            Console.WriteLine("Main application.");
        }
    }
}
