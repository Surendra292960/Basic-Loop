using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic.Loop
{
    class Continue1
    {
        static void Main(string[] args)
        {
            for(int i=0;i<4; i++)
            {
                for(int j=0; j<5; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        continue;
                    }
                    Console.WriteLine(i + "," + j);
                }
               
            }
            Console.Read();
        }
    }
}
