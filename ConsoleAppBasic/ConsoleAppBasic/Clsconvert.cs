﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic
{
    class Clsconvert
    {
        static void Main(string[] args)
        {
            String s = null;
           // String s = "100";
            Console.WriteLine(Convert.ToInt32(s));
            Console.WriteLine(int.Parse(s));
            Console.Read();
        }
    }
}
