using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int until;
            string output = "";

            Console.WriteLine("Welcome to FizzBuzz!");
            Console.WriteLine();
            Console.WriteLine("Would you like to FizzBuzz until we reach what number?");
            Console.WriteLine();
            int.TryParse(Console.ReadLine(), out until);

            for (int i = 1; i <= until; i++)
            {
                if (i % 3 == 0){
                    output += "Fizz";
                }
                if (i % 5 == 0){
                    output += "Buzz";
                }
                else if(i % 3 != 0 && i % 5 != 0)
                {
                    output += i;
                }
                Console.WriteLine(output);
                output = "";
            }

            Console.WriteLine();
            Console.WriteLine("Press Any Key to Exit!");
            Console.ReadKey();
        }
    }
}
