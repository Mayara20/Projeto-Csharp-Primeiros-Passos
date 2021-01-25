using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string M = Console.ReadLine();

            string[] V = Console.ReadLine().Split(' ');
            string b = V[0];
            string c = V[1];
            string d = V[2];

            Console.WriteLine("A frase digitada foi ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(M);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
