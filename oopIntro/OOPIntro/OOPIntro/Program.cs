using System;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal azerbaijan = new Animal();
            azerbaijan._name = "Azerbaijan";
            azerbaijan._species = "Dog";
            azerbaijan._color = "Purple";


            Person david = new Person("David", 18, azerbaijan); // david är ett object som följer beskrivning av Person.cs

            

            david.Eat();
            david.Sleep();

            david.ActivatePet();

            

        }
    }
}
