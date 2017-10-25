using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will display a table of squared and cubed numbers for the input number.");

            bool finish = false;
            do
            {
                int integer = 0;
                bool success = false;
                while (!success)
                {
                    Console.WriteLine("Please enter an integer at least 1 or above.");
                    string input = Console.ReadLine();
                    success = int.TryParse(input, out integer);
                    if (integer < 1)
                    {
                        Console.WriteLine("Input is not valid.");
                        success = false;
                    }
                }


                    for (int i = 1; i == 1; i++)
                    {
                        Console.Write("Number\t");
                        Console.Write("Squared\t");
                        Console.Write("Cubed\t");
                        Console.WriteLine();
                    }
                    for (int i = 1; i == 1; i++)
                    {
                        Console.Write("=======\t");
                        Console.Write("=======\t");
                        Console.Write("=======\t");
                        Console.WriteLine();
                    }
                    for (int i = 1; i <= integer; i++)
                    {
                        Console.Write($"{i}\t");
                        Console.Write("{0}\t", Math.Pow(i,2));
                        Console.Write("{0}\t", Math.Pow(i,3));
                        Console.WriteLine();

                    }

                
                Console.WriteLine("Would you like to run this program again? (Y/N)");
                var repeat = Console.ReadLine();
                if (repeat == "y" || repeat == "Y")
                {
                    success = true;
                }
                else
                {

                    Environment.Exit(0);
                }

            } while (!finish);
        }
    }
}
