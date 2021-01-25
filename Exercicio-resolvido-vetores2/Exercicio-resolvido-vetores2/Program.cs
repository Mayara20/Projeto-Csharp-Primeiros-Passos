using System;
using System.Globalization;

namespace Exercicio_resolvido_vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;
            double Media, soma;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] A = Console.ReadLine().Split(' ');
              for (int i = 0; i < N; i++){
                vet[i] = double.Parse(A[i],CultureInfo.InvariantCulture);
            }
              for (int i = 0; i < N; i++) {
                Console.Write(vet[i].ToString("F1",CultureInfo.InvariantCulture) + " ");
             }
            Console.WriteLine();

            soma = 0.0;
            for (int i = 0; i < N; i++) {
                soma = soma + vet[i];
            }
            Media = soma / N;

            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(Media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
