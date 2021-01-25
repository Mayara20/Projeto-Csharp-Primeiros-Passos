using System;
using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, codigo2, quantidade1, quantidade2;
            double preco1, preco2, Tot;

            string[] V = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(V[0]);
            quantidade1 = int.Parse(V[1]);
            preco1 = double.Parse(V[2],CultureInfo.InvariantCulture);

            V = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(V[0]);
            quantidade2 = int.Parse(V[1]);
            preco2 = double.Parse(V[2], CultureInfo.InvariantCulture);

            Tot = preco1 * quantidade1 + preco2 * quantidade2;

            Console.WriteLine("VALOR A PAGAR = R$ " + Tot.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
