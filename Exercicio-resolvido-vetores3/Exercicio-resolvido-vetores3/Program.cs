using System;
using System.Globalization;

namespace Exercicio_resolvido_vetores3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];

            int[] idades = new int[N];

            double[] alturas = new double[N];
            // leitura dos dados
            for (int i = 0; i < N; i++)
            {
                string[] L = Console.ReadLine().Split(' ');
                nomes[i] = L[0];
                idades[i] = int.Parse(L[1]);
                alturas[i] = double.Parse(L[2], CultureInfo.InvariantCulture);
            }
            // cálculo da altura média das pessoas
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + alturas[i];
            }
            double Media = soma / N;
            Console.WriteLine("Altura média: " + Media.ToString("F2", CultureInfo.InvariantCulture));

            //porcentagem de pessoas abaixo de 16 anos
            int cont = 0;
            for (int i = 0; i < N; i++) {
                if (idades[i] < 16) {
                    cont++;
                }
            }

            double porcentagem = (double) cont / N * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString
                ("F1", CultureInfo.InvariantCulture) + "%");
        }
    }
}
