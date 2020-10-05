using System;

namespace metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var apa = 1;
            var bapa = 2;

            Console.WriteLine(Add(apa,bapa));
        }

        static int Add(int tal1, int tal2)
        {
            var sum = 0;

            sum = tal1 + tal2;

            return sum;
        }
    }
}
