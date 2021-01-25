using System;
using System.Globalization;

namespace EstruturaPara
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, soma;
            soma = 0;
            N = int.Parse(Console.ReadLine());

            for (int i = 1;i <= N ; i++) { 
                X = int.Parse(Console.ReadLine());
                soma = soma + X;
            }
            Console.WriteLine("Soma: " + soma);
        }
    }
}
