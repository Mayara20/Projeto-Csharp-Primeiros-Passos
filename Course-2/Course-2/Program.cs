﻿using System;
using System.Globalization;

namespace Course_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet [1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            
            Console.WriteLine("Você Digitou!");
            Console.WriteLine(N1 +" anos.");
            Console.WriteLine(ch);
            Console.WriteLine(N2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
