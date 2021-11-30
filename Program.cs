using System;
using System.Collections.Generic;

namespace GitDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //getSomeNames().ForEach(x => Console.WriteLine(x));
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

        public static List<string> GetSomeNames()
        {
            return new List<string>() {"Martin","Kalle"};
        }

        public static bool IsEven(int v)
        {
            return v % 2 == 0;
        }
    }
}
