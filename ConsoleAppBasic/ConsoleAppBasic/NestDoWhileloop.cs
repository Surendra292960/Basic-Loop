using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic
{
    class NestDoWhileloop
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine(i+","+j);
                    j++;
                }
                while (j <= 4);
                i++;
            }
            while (i <= 10);
            Console.ReadLine();
        }
    }
}
