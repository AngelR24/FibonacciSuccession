using System;

namespace FibonacciSucession
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Inserte un número N para imprimir la sucesión Fibonnacci.");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************");
            printFibonacci(n);
            Console.WriteLine("**************************************");
            Console.WriteLine("Completado.");
            Console.ReadKey();
        }

        static void printFibonacci(int n)
        {
            int first = 0;
            int second = 1;
            Console.WriteLine(first);
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(second);
                int sum = first + second;
                first = second;
                second = sum;
            }
        }
    }
}
