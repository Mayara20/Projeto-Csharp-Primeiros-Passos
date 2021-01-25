using System;
using System.Globalization;

namespace Exercicio_proposto5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];

            string[] V = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++){
                vet[i] = double.Parse(V[i]);
            }

            int pares = 0;
            double somapar = 0.0;
            for (int i = 0; i < N; i++){
                if (vet[i] % 2 == 0){
                    somapar = somapar + vet[i];
                    pares++;
                }
            }
               if (pares == 0) {
                    Console.WriteLine();
                }
               else {
                double Media = somapar / pares;
                Console.WriteLine(Media.ToString("F1", CultureInfo.InvariantCulture));
                }
            
        }
    }
}
