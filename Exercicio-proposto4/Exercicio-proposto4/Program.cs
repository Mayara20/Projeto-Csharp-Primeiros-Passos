using System;
using System.Globalization;

namespace Exercicio_proposto4
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];

            string[] S = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                vet[i] = double.Parse(S[i],CultureInfo.InvariantCulture);
            }
            double soma = 0.0;
            for (int i = 0; i < N; i++){
                soma = soma + vet[i];
            }
            double Media = soma / N;
            Console.WriteLine(Media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++) {
                if (vet[i] < Media) {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
