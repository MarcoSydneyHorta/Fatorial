using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {

            double f;
            Console.Write("Enter the number you want to calculate the factorial: ");
            int numero = int.Parse(Console.ReadLine());

            f = fatorial(numero);   // Factorial function call

            Console.Write("Factorial of " + numero + " is equal to " + f);
        }

        // Recursive function that calculates the factorial of an integer n

        static double fatorial(int n)
        {
            double vfat;

            if (n <= 1) // Base case: factorial of n <= 1 returns 1
                return (1);
            else        // Recursive call
            {
                vfat = n * fatorial(n - 1);
                return (vfat);
            }
        }
    }

}

