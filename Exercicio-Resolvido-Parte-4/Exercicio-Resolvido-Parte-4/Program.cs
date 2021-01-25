using System;
using System.Globalization;

namespace Exercicio_Resolvido_Parte_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, ano, resto, mes, dias;

            N = int.Parse(Console.ReadLine());

            ano = N / 365;
            resto = N % 365;
            mes = resto / 30;
            dias = resto % 30;

            Console.WriteLine(ano + " ano (s) " );
            Console.WriteLine(mes + " mes (es) ");
            Console.WriteLine(dias + " dia (s) ");
        }
    }
}
