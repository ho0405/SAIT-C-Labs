using System;
namespace Lab_Interfaces_and_abstract_Classes
{
	public class Dog : Animal, IAnimal
	{
		
		public override void Eat()
		{
			Console.WriteLine("Dog Eat Meat");
		}
		public string Cry()
		{
			return "Woof";
		}
	}

}

