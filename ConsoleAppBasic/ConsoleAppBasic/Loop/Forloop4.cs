using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic.Loop
{
    class Forloop4
    {
        static void Main(string[] args)
        {
           
         for(int i=0; i<=5; i++)
            {
                for(int j=0; j<=(i-1); j++)
                {
                    Console.Write(" ");
                }
                for(int k=0; k<(((5-i)*2)-1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
