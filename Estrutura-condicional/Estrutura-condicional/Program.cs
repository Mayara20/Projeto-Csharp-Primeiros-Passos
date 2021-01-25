using System;
using System.Globalization;

namespace Estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, resultado;

            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + resultado.ToString("F1",CultureInfo.InvariantCulture));

            if (resultado > 60.00)
            {
                Console.WriteLine("Aprovado");
            }
            else
                Console.WriteLine("REPROVADO");
             
            
            }
        }
    }
