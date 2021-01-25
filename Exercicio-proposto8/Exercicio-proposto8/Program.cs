using System;
using System.Globalization;

namespace Exercicio_proposto7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] alturas = new double[N];
            char[] sexos = new char[N];

            for (int i = 0; i < N; i++) {
                string[] S = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(S[0], CultureInfo.InvariantCulture);
                sexos[i] = char.Parse(S[1]);
            }
            double menorAltura = alturas[0];
            for (int i = 0; i < N; i++) {
                if (alturas[i] < menorAltura) {
                    menorAltura = alturas[i];
                 }
            }
            double maiorAltura = alturas[0];
            for (int i = 0; i < N; i++) {
                if (alturas[i] > maiorAltura){
                    maiorAltura = alturas[i];
                }
            }
            double somaMulheres = 0.0;
            int mulheres = 0;
            for (int i = 0; i < N; i++) {
                if (sexos[i] == 'F') {
                    somaMulheres = somaMulheres + alturas[i];
                    mulheres++;
                }
            }
            double Media = somaMulheres / mulheres;
            double somaHomens = 0.0;
            int homens = 0;
            for (int i = 0; i < N; i++) {
                if (sexos[i] == 'M') {
                    somaHomens = somaHomens + alturas[i];
                    homens++;
                }
            }
            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + Media.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + homens);
        }
    }
}
 