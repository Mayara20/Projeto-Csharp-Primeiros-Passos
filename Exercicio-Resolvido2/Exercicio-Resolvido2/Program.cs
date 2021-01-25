using System;

namespace Exercicio_Resolvido_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] A;

            string[] D = Console.ReadLine().Split(' ');
             M = int.Parse(D[0]);
             N = int.Parse(D[1]);
             A = new int[M, N];

            for (int i = 0; i < M; i++) {
                 D = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(D[j]);
                }
            }
            int[] soma = new int[M];
            
             for (int i = 0; i < M; i++) {
                int sum = 0;
                for (int j = 0; j < N; j++) {
                    sum = sum + A[i, j];
                }
             soma[i] = sum;
            }
            for (int i = 0; i < M; i++) {
                Console.WriteLine(soma[i]);
            }
        }
    }
}
