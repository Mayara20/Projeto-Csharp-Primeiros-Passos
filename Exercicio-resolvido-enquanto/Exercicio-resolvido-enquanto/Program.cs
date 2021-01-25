using System;
using System.Globalization;

namespace Exercicio_resolvido_enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, Media;
            int cont;

            soma = 0.0;
            cont = 0;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (cont == 0) {
                Console.WriteLine("Impossivel calcular");
            }
            else { 
            Media = soma / cont;
            Console.WriteLine(Media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
