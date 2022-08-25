using System;

namespace Algoritms_FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Fibo f = new Fibo();

            for (int i =1;i<10;i++)
            {
                Console.WriteLine($" число Фибоначи для {i} : {f.Fibo1(i)}");
            }

            Console.WriteLine("");

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($" число Фибоначи2 для {i} : {f.Fibo2(i)}");
            }

        }
    }
}
