using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"David","Niklas","Jacob","Gabbe","Andreas"};

            int i = 4;
            while (i < names.Length && i > -1){
                Console.WriteLine(names[i]);
                i--;
            }
        }
    }
}
