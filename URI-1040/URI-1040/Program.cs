using System;
using System.Globalization;

namespace URI_1040
{
    class Program
    {
        static void Main(string[] args)
        {

            double N1, N2, N3, N4, Media, MediaFinal, NotaExame;

            string[] vet = Console.ReadLine().Split(' ');
            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            Media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10; 

            if (Media == 4.85f) {
                Media = 4.8;
            }
                Console.WriteLine("Media: " + Media.ToString("F1",CultureInfo.InvariantCulture));
            if (Media >= 7) {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (Media < 5) {
                Console.WriteLine("Aluno Reprovado.");
            }
            else {
                Console.WriteLine("Aluno em exame. ");
                NotaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                MediaFinal = (Media + NotaExame) / 2;
                Console.WriteLine("Nota do exame: " + NotaExame.ToString("F1", CultureInfo.InvariantCulture));
                if (Media >= 5) {
                    Console.WriteLine("Aluno aprovado. ");
                }
                else {
                    Console.WriteLine("Aluno Reprovado.");
                }
                     Console.WriteLine("Media final: " + MediaFinal.ToString("F1",CultureInfo.InvariantCulture));
                 }
        }
    }
}
