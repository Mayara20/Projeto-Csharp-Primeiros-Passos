using System;

namespace Exercicio_proposto2
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];

            string[] S = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vet[i] = int.Parse(S[i]);
            }
            for (int i = 0; i < N; i++) {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                }
            }
             Console.WriteLine();

              int pares = 0;
             for (int i = 0; i < N; i++) { 
                  if (vet[i] % 2 == 0) {
                        pares++;
                    }
                }
                Console.WriteLine(pares);
        }
    }
}
