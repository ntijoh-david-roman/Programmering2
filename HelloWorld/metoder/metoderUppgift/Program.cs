using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace metoderUppgift
{
    class Program
    {
        
        static int MyMethodNumbers(int a, int b)
        {
            
            return a + b;
        }
        static void myMethodWords(string[] words)
        {
            int i = 2;
            while (i < words.Length && i > -1)
            {
                Console.WriteLine(words[i]);
                i--;
            }

        }
        static int[] MyMethodSorting(int[] numbers)
        {
            int biggest = numbers.Max();
            int smallest = numbers.Min();

            int[] biggestsmallest = { biggest, smallest };

            return biggestsmallest;
        }
       
        static void Main(string[] args)
        {
            string[] words = { "Hej", "på", "dig"};

            int[] numbers = { 1, 5, 3, 7, 10 };

            Console.WriteLine(MyMethodNumbers(10, 5));

            myMethodWords(words);



            int[] bigpepesmallpepe = MyMethodSorting(numbers);

            for (int i = 0; i < bigpepesmallpepe.Length; i++)
            {
                Console.WriteLine(bigpepesmallpepe[i]);
            }


            




        }
    }
}
