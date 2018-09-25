using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasic
{
    class TwoDArray
    {
       
            static void Main(string[] args)
            {
                int[, ] A = new int[3, 3] { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
                Console.WriteLine("Elements of Array");
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        Console.WriteLine(A[r, c] + " ");
                    }
                    Console.Read();
                }
            }
        }
    }
