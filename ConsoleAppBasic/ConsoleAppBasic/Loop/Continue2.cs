using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic.Loop
{
     class Continue2
    {
        static void Main(string[] args)
        {
            for(int i=0; i<=4; i++)
                {
                    if(i==3)
                    {
                        continue;
                    }
                Console.WriteLine(i);
                }
            Console.Read();
        }
    }
}
