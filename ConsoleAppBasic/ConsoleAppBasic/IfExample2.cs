using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic
{
    class IfExample2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value");
             double num = Convert.ToDouble(Console.ReadLine());
            
            if(num==10.3)
            {
                Console.WriteLine("value 10");
            }
            else if(num==11.5)
            {
                Console.WriteLine("value 11.5");
            }
            Console.Read();
        }
    }
}
