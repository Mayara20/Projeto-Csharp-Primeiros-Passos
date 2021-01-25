using System;

namespace Exercicio_resolvido_vet
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];
           
            string[] L = Console.ReadLine().Split(' ');
               for (int i = 0; i < N; i++) {
                 vet[i] = int.Parse(L[i]);
            }
               for (int i = 0; i < N; i++) { 
                    if (vet[i] < 0) {
                    Console.WriteLine(L[i]);
                }
            }
        }
    }
}
