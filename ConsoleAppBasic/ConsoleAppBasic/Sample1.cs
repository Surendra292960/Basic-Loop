using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic
{
    class Sample1
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter two value");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Sum is:" + c);
            Console.Read();           
        }
    }
}
