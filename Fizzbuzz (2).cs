using System;
namespace Fizzbuzz
{
    class Fizzbuzz
    {
        public static void fizzbuzz(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        void testcase()
        {
            for (int i = 0; i <= 100; i++)
            {
                fizzbuzz(i);
            }
        }
        static void Main()
        {
            Fizzbuzz a = new Fizzbuzz();
            a.testcase();
        }


    }

}


