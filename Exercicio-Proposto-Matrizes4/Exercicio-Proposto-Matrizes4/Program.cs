using System;

namespace Exercicio_Proposto_Matrizes4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] A;

            N = int.Parse(Console.ReadLine());

            A = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] mat = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(mat[j]);
                }
            }
            int soma = 0;
            for (int i = 0; i < N; i++) {
                for (int j = i + 1; j < N; j++) {
                    soma = soma + A[i, j];
               }
            }
            Console.WriteLine(soma);
        }
    }
}
