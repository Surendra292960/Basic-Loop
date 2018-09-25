using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic
{
    class IfExample
    {
        static void Main(string[] args)
        {
            int i = 1;
            if(i%2==0)
            {
                Console.WriteLine("Print Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.Read();
        }
    }
}
