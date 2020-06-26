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
            int a = 8;
            int b = 5;
     
            int c = a + b;
            Console.WriteLine($"Addition: {c}");

            c = a - b;
            Console.WriteLine($"Subtraction: {c}");

            c = a * b;
            Console.WriteLine($"Multiplication: {c}");

            c = a / b;
            Console.WriteLine($"Division: {c}");
            Console.ReadKey();
        }
    }
}
