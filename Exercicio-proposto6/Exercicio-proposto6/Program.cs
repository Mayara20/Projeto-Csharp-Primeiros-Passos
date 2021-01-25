using System;

namespace Exercicio_proposto6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];

            
            for (int i = 0; i < N; i++) {
                string[] dados = Console.ReadLine().Split(' ');
                nomes[i] = dados[0];
                idades[i] = int.Parse(dados[1]);
            }
            int mais18 = idades[0];
            int posicaomais18 = 0;

            for (int i = 0; i < N; i++){
                if(idades[i] > mais18) {
                    mais18 = idades[i];
                    posicaomais18 = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomes[posicaomais18]);
        }
    }
}
