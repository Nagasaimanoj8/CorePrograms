using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderQuotient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend , divisor;
            Console.WriteLine("Enter Dividend number");
            dividend= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor number");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
    }
