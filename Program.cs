using System;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(message());
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
