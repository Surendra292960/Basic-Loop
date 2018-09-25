using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic
{
    class Goto1
    {
        static void Main(string[] args)
        {
            ineligible:
            Console.WriteLine("Enter Age for Vote");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your age:\n");

            if (age>18)
            {
                goto ineligible;
                //Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
            Console.Read();
        }
    }
}
