using System;
namespace Lab_Interfaces_and_abstract_Classes
{
	public abstract class Animal
	{
		public string name;
		public string color;
		public int age;
		public int height;
		/*public Animal(string name, string color, int age)
		{
			this.name = name;
			this.color = color;
			this.age = age;
		}*/
		public string Name { get; set; }
		public string Color { get; set; }
		public int Age { get; set; }
		public int Height { get; set; }

		public abstract void Eat();
	}
}

