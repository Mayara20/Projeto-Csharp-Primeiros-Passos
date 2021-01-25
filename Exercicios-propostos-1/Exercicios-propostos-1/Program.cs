using System;
using System.Globalization;

namespace Exercicios_propostos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());
            double[] A = new double[N];

            string[] vet = Console.ReadLine().Split(' ');

               for (int i = 0; i < N; i++) {
                A[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }
            double maior = A[0];
            int posicao = 0;

            for (int i = 0; i < N; i++) {
                     if (A[i] > maior) {
                    maior = A[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}
