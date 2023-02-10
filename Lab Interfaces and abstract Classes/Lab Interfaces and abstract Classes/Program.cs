using System.Security.Cryptography.X509Certificates;

namespace Lab_Interfaces_and_abstract_Classes;
class Program
{
    static void Main(string[] args)
    {
        //part1 dog
        Console.WriteLine("What is Dog Name?");
        string dogname = Console.ReadLine();
        
        Dog myDog = new Dog();
        myDog.name = dogname;
        myDog.color = "White";
        myDog.age = 1;

        Console.WriteLine("Dog name:" + myDog.name);
        Console.WriteLine("Dog color:" + myDog.color);
        Console.WriteLine("Dog age:" + myDog.age);

        myDog.Eat();
        
        //part1 cat
        Console.WriteLine("\nWhat is Cat Name?");
        string catname = Console.ReadLine();

        Cat myCat = new Cat();
        myCat.name = catname;
        myCat.color = "Black";
        myCat.age = 12;

        Console.WriteLine("Cat name:" + myCat.name);
        Console.WriteLine("Cat color:" + myCat.color);
        Console.WriteLine("Cat age:" + myCat.age);

        myCat.Eat();

        //part2 dog
        Console.WriteLine("\nWhat is Dog Name?");
        string dogname2 = Console.ReadLine();
        Dog myDog2 = new Dog() { name = dogname2 };
        Console.WriteLine("What is the dog's height in feet?");
        myDog2.Height = int.Parse(Console.ReadLine());

        Console.WriteLine("What color is the dog?");
        myDog2.Color = Console.ReadLine();

        Console.WriteLine("What is dog's Age?");
        myDog2.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("The dog name is " +dogname2);
        Console.WriteLine("The dog's height is " + myDog2.Height);
        Console.WriteLine("The dog's color is " + myDog2.Color);
        Console.WriteLine("The dog's age is " + myDog2.Age);

        myDog2.Eat();
        Console.WriteLine("The dog's cries " + myDog2.Cry());

        //part2 cat
        Console.WriteLine("\nWhat is Cat Name?");
        string catname2 = Console.ReadLine();
        Cat myCat2 = new Cat() { name = catname2 };
        Console.WriteLine("What is the cat's height in feet?");
        myCat2.Height = int.Parse(Console.ReadLine());

        Console.WriteLine("What color is the cat?");
        myCat2.Color = Console.ReadLine();

        Console.WriteLine("What is cat's Age?");
        myCat2.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("The cat name is " + catname2);
        Console.WriteLine("The cat's height is " + myCat2.Height);
        Console.WriteLine("The cat's color is " + myCat2.Color);
        Console.WriteLine("The cat's age is " + myCat2.Age);

        myCat2.Eat();
        Console.WriteLine("The cat's cries " + myCat2.Cry());

        //creating list
        List<Animal> list = new List<Animal>();
        list.Add(myDog);
        list.Add(myCat);
        list.Add(myDog2);
        list.Add(myCat2);

        //Print the names of all the animals 
        foreach (Animal animal in list)
        {
            Console.WriteLine(animal.name);
        }

        //Keep the program
        Console.ReadKey();
    }
}

