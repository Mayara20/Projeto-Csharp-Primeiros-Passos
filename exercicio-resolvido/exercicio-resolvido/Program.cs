using System;
using System.Globalization;

namespace exercicio_resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            if (A < B && A < C)
            {
                Console.WriteLine("Menor = " + A);
            }
            else
            {
                if (B < C)
                {
                    Console.WriteLine("Menor = " + B);
                }
                else
                {
                    Console.WriteLine("Menor = " + C);
                }
            }
        }
    }
}
