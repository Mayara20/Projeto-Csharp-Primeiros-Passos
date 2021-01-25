using System;

namespace Exercicio_proposto_matrizes2
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
            for (int i = 0; i < N; i++) {
                int soma = 0;
                for (int j = 0; j < N; j++) {
                    soma = soma + A[i, j];
                }
                Console.WriteLine(soma);
            }
           
        }
    }
}
