using System;

namespace GitDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MessageInSwedish());
        }

        public static string MessageInEnglish()
        {
            return "Hello";
        }

        public static string MessageInSwedish()
        {
            return "Hej";
        }
    }
}
