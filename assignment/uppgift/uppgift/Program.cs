using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Products cart = new Products();
            cart._food = "Bread";
            cart._drink = "Milk";
            cart._neccesity = "Toilet paper";

            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age + name);
            Person customer = new Person(name, age);
        }
    }
}
