using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic.Loop
{
    class Class1
    {
        static void Main(string[] args)
        {
    
            Console.WriteLine("You are not Eligible to vote");
            Console.WriteLine("Enter your name:/n");
            String s = Console.ReadLine();
      
            Console.WriteLine("Enter Age for Vote");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("Valid for Vote");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
            Console.ReadLine();
        }
    }
}
