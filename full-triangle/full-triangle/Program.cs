using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace full_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please put your high of the triangle here: ");
            int n = int.Parse(Console.ReadLine());
            draw_full_triangle(n);
        }

        static void draw_full_triangle(int n)
        {
            Console.WriteLine("your high of triangle is: " + n);
            Console.WriteLine("-----------");
            int r = n + (n - 1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= r; j++)
                {
                    if (j > n - 1 - i && j <= r - (n - 1 - i))
                        Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

    }
}
