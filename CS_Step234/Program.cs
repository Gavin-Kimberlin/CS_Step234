using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step234
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 1)
                {
                    throw new LessThanOneException();
                }
                int yearBorn = DateTime.Now.Year - age;
                Console.WriteLine("You were born in " + yearBorn);
            }
            catch (LessThanOneException)
            {
                Console.WriteLine("Please enter an age greater than one.");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid age");
            }
            Console.ReadLine();
        }
    }
}
