﻿using System;

namespace sintaxe_opcional_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            string[] vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }
            Console.WriteLine("Nomes lidos: ");
             foreach (string teste in vet) {
                Console.WriteLine(teste);
            }
        }
    }
}
