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
            double a = 6;
            double b = 4;
            double c = 3;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}.");
            Console.ReadKey();
        }
    }
}
