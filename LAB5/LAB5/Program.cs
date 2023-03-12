using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle();
            Circle c3 = new Circle();

            try
            {
                c1.SetRadius(7);
                Console.WriteLine(c1.ToString());
            }
            catch (InvalidRadiusException e)
            {
                Console.WriteLine(c1.ToString()+ " " + e.Message);
                
            }

            try
            {
                c2.SetRadius(-4.27);
                Console.WriteLine(c2.ToString());
            }
            catch (InvalidRadiusException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                c3.SetRadius(0);
                Console.WriteLine(c3.ToString());
            }
            catch (InvalidRadiusException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
    