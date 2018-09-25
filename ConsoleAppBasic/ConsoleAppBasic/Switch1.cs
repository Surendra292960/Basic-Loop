using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic
{
    class Switch1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 10: Console.WriteLine("Hello 10"); break;
                case 12: Console.WriteLine("It is 12"); break;
                case 30: Console.WriteLine("It is 30"); break;
                case 40: Console.WriteLine("It is 40"); break;
                default: Console.WriteLine("Hello default"); break;

            }
            Console.ReadLine();
        }

    }
}
