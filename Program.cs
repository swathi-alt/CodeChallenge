using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleProject
{
    class Program
    {
        // int a = 7, b = 14, c = 16;
        public static void checktraingle(int a, int b, int c)
        {



            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("The sides given forms a Traingle");
            }

            else
                Console.WriteLine("The sides given does not form a Traingle");

        }



        public static void Main(string[] args)
        {

            Program.checktraingle(7, 14, 16);
        }
    }
}
