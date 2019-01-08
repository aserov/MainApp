using System;
using HelpfulLibrary;

namespace MainApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var model = new
            {
                Param1 = 1,
                Param2 = "some string"
            };
            Console.WriteLine(JsonHelper.ToJson(model));

            PrintStartMessage();
            Console.ReadKey();
        }

        public static void PrintStartMessage()
        {
            Console.WriteLine("Main application.");
        }
    }
}
