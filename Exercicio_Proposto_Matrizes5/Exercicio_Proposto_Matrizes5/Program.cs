using System;

namespace Exercicio_Proposto_Matrizes5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] S = Console.ReadLine().Split(' ');
            int M = int.Parse(S[0]);
            int N = int.Parse(S[1]);

            int[,] A = new int[M, N];
            int[,] B = new int[M, N];
            int[,] C = new int[M, N];

            for (int i = 0; i < M; i++) {
                S = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(S[j]);
                }
            }

            for (int i = 0; i < N; i++) {
                S = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++) {
                   B[i, j] = int.Parse(S[j]);
                }
            }

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            for (int i = 0; i < M; i++) { 
                for (int j = 0; j < N; j++) {
                    Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
            }
        }
    }
}
