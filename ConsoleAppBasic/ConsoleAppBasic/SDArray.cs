using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic
{
    class SDArray
    {
        static void Main(string[] args)
        {

            // int[] A = new int[4] { 10, 20, 30, 40 };
            String[] A = new string[4] { "a", "b", "c", "d" };

            Console.WriteLine("Elements of Array are:");
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write(A[i] + " ");
            //}
            foreach(String i in A)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        } 
    }
}
