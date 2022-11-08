using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {

            double f;
            Console.Write("Digite o numero que deseja calcular o fatorial: ");
            int numero = int.Parse(Console.ReadLine());
            //chamada da função fatorial
            f = fatorial(numero);

            Console.Write("Fatorial de " + numero + " é igual a " + f);
        }
        //Função recursiva que calcula o fatorial
        //de um numero inteiro n
        static double fatorial(int n)
        {
            double vfat;

            if (n <= 1)
                //Caso base: fatorial de n <= 1 retorna 1
                return (1);
            else
            {
                //Chamada recursiva
                vfat = n * fatorial(n - 1);
                return (vfat);
            }
        }
    }

}

