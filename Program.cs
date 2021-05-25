using System;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(message());
        }

        static string EnglishMessage()
        {
            return "Hello";
        }
        
        static string SwedishMessage()
        {
            return "Hej";
        }
    }
}
