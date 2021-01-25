using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] A;

            string[] S1 = Console.ReadLine().Split(' ');
            M = int.Parse(S1[0]);
            N = int.Parse(S1[1]);
            A = new int[M, N];

            for (int i = 0; i < M; i++) {
                string[] S = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(S[j]);
                }
            }
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(A[i, j] + " ");
               }
                Console.WriteLine();
            }

        }
    }
}
