using System;

namespace uppgiften
{
    class Program
    {
        static void Main(string[] args)
        {
            Products milk = new Products();
            milk._product = "Mjölkartong";
            milk._amount = 0;


            Person david = new Person("David", milk);


            // david.ActivateItem();
            // Gör en meny så du kan lägga till ett visst antal produkter.

            Console.WriteLine("Hej " + david._name + " och välkommen till min affär som endast säljer mjölkkartoner!");
            Console.WriteLine("Hur många mjölkkartoner vill du köpa?");
            milk._amount = Convert.ToInt32(Console.ReadLine());
            david._cart.Add(milk);

            foreach (var item in david._cart)
            {
                Console.WriteLine(david._name + " Du har köpt " + milk._amount + " mjölkartoner");
            }
            
        }
    }
}
