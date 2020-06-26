using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Csharp_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal max = decimal.MaxValue;
            decimal min = decimal.MinValue;
            Console.WriteLine($"The range of decimal is {min} to {max}.");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);
            //M - liczba ma stale używać typu decimal, gdy tego nie będzie, przyjmuje typ double
            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
            Console.ReadKey();
        }
    }
}
