using System;
using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double X;
            int quociente, moedas, resto, nota;

            X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int)(X * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");
            
            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            moedas = 100;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % moedas;

            moedas = 50;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % moedas;

            moedas = 20;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % moedas;

            moedas = 10;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % moedas;

            moedas = 5;
            quociente = resto / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto = resto % moedas;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");


        }
    }
}
