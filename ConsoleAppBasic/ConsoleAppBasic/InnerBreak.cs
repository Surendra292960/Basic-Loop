﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic
{
    class InnerBreak
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        break;
                    }
                    Console.WriteLine(i + " " + j);
                }
            }
            Console.Read();
        }
    }
}
