using System;
using System.Globalization;

namespace URI_1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha, N;

            senha = int.Parse(Console.ReadLine());

            N = 2002;

            while(senha != N) {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            if (senha == N) {
                Console.WriteLine("Acesso Permitido");
            }
        }
    }
}
