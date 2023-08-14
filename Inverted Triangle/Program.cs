using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverted_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A simple program that prints an inverted triangle pattern using a for loop

            Console.WriteLine("...Print an inverted triangle...\n");

            //Prompt user for triangle height
            Console.Write("Height of a Triangle: ");
            int height = int.Parse(Console.ReadLine());

            //Call the method InvertedTriangle
            Console.WriteLine();
            InvertedTriangle(height);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        static void InvertedTriangle(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    //Create spaces for alignment
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    //Use (*) to form a triangle
                    Console.Write("*"); 
                }

                Console.WriteLine(); // Move to the next line for the next row
            }
        }
    }
}
