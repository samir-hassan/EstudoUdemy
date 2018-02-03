using _02_;
using System;

namespace _02_Generics
{
    public static class ExtensionMethods
    {
        public static void Execute()
        {
            string s = "teste";
            s = s.FirstToUpper();

            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}