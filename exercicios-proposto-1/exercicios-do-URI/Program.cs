using System;
using System.Globalization;

namespace exercicios_do_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int age1, age2;
            double Media;

            string[] vet;
            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            age1 = int.Parse(vet[1]);

            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            age2 = int.Parse(vet[1]);

            Media = (double) (age1 + age2)/ 2.0;

            Console.WriteLine("A idade Média de " + nome1 + " e " + nome2 + " é de " 
                + Media.ToString("F1",CultureInfo.InvariantCulture) + " anos");

        }
    }
}
