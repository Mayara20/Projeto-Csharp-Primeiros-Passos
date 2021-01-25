using System;
using System.Globalization;

namespace Exercicio_URI_48
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario,percentual;

             salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (salario <= 400.00) {
                percentual = 15.0;
            }
            else if ((salario >= 400.01) && (salario <= 800.01)) {
                percentual = 12.0;
            }
            else if ((salario >= 800.02) && (salario <= 1200.00)) {
                percentual = 10.0;
            }
            else if ((salario >= 1200.01) && (salario <= 2000.00)) {
                percentual = 7.0;
            }
            else {
                percentual = 4.0;
            }

            double reajuste = salario * percentual / 100.0;
            double novoSal = salario + reajuste;

            Console.WriteLine("Novo salario: " + novoSal.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0",CultureInfo.InvariantCulture) + " %");
        }
    }
}
