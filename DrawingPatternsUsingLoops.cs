using System;
using System.Runtime.CompilerServices;

namespace ForLoopPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            dashes(5);
            Console.WriteLine();
            Line(5);
            Console.WriteLine();
            Square(4);
            Console.WriteLine();
            OpenSquare(10);
            Console.WriteLine();
            Triangle(7);
        }
        public static void dashes(int num)
        {
            for( int i = 0; i < num; i++)
            {
                Console.Write("-");
            }
        }
        public static void Line(int repitions)
        {
            for (int i = 0; i < repitions; i++)
            {
                for (int j = 0; j<=i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("-");
                }

            }

        }
        public static void Square(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public static void OpenSquare(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int j = 0; j <= (num-2); j++)
            {
                Console.Write("*");
                for(int l = 0; l < (num - 1); l++)
                {
                Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int k = 0; k <=num; k++)
            {
                Console.Write("*");
            }

        }
        public static void Triangle(int num)
        {
            for(int i = 0; i < num; i++)
            {
                for(int j=0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <(num-i); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }

   }

