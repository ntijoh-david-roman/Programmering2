using System;

namespace mata_in_namn_och_ålder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hej detta är mitt program som vill veta vad din ålder och namn är!"); // Detta behövs nog inte förklaras.
            Console.WriteLine();
            Console.WriteLine("Börja gärna med att skriva in ditt namn och sedan ålder");

            String name = Console.ReadLine(); // Console.ReadLine är att consolen ska mata in ett värde som i detta tillfället ska vara en string då ditt namn.
            Console.WriteLine("Hej " + name + " Hur gammal är du?");
            Console.WriteLine();

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Så du är alltså " + age + " år gammal");

            if (age > 100)
            {
                Console.WriteLine("du är fan död om du är " + age + " år gammal");
            }
            else
            {
                Console.WriteLine("Du är ej död grattis!");
            }



        }
    }
}