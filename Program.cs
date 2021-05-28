using System;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MessageInSwedish());
        }

        static string MessageInEnglish()
        {
            return "Hello";
        }

        static string MessageInSwedish()
        {
            return "Hej";
        }
    }
}
