using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    internal class Power
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Please Enter range for finding power table");
                string n = Console.ReadLine();
                int num = int.Parse(n);

                if (num < 0 || num > 30)
                {
                    Console.WriteLine("Please enter number between 0 to 30");
                }
                else
                {
                    // Console.WriteLine("Power of 2^" + num + " is: " + (Math.Pow(2, num)));
                    Console.WriteLine();
                    Console.WriteLine("Printing all till Power Value " + num);


                    for (int i = 0; i <= num; i++)
                    {
                        Console.WriteLine("Power of 2^" + i + " is: " + (Math.Pow(2, i)));
                    }
                }

            }
        }
    }
