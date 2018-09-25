using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic.Loop
{
    class Forloop2
    {
        static void Main(string[] args)
        {
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
