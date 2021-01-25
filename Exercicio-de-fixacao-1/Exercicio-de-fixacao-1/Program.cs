using System;
using System.Globalization;

namespace Exercicio_de_fixacao_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantidade de quartos em sua casa:");
            int QD = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço de um produto desejável:");
            double PD = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Seu último nome,idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
           
            //feito pelo professor esse final //

            Console.WriteLine(nome);
            Console.WriteLine(QD);
            Console.WriteLine(PD.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

                    
            
    
        


        }
    }
}
