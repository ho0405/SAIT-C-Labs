using System;
namespace Lab_Interfaces_and_abstract_Classes
{
    public class Cat : Animal, IAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat Eat Mice");
        }
        public string Cry()
        {
            return "Meow!";
        }
    }
}

