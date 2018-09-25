using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic
{
    class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
                {
                    Console.WriteLine("Even");
                }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.Read();
        }
    }
}
