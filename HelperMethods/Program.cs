using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myNewerValue = myNewPrivate();
            Console.WriteLine(myNewerValue);

            Console.ReadLine();
        }

        private static string myNewPrivate()
        {
            return "Heyyy people";
        }
    }
}
