using System;
using System.Globalization;

namespace Exercicio_proposto7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] nota01 = new double[N];
            double[] nota02 = new double[N];

            for (int i = 0; i < N; i++) {
                string[] S = Console.ReadLine().Split(' ');
                nomes[i] = S[0];
                nota01[i] = double.Parse(S[1], CultureInfo.InvariantCulture);
                nota02[i] = double.Parse(S[2], CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0; i < N; i++) {
                double Media = (nota01[i] + nota02[i]) / 2.0;
                 if (Media >= 6.0) {
                     Console.WriteLine(nomes[i]);
                  
                }
            }
        }
    }
}
