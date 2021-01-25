using System;
using System.Globalization;

namespace URI_1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(A < 0.0 || A > 10.0) {
                  Console.WriteLine("nota invalida");
                A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (B < 0.0 || B > 10.0) {
                Console.WriteLine("nota invalida");
                B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double Media = (A + B) / 2.0;
            Console.WriteLine("media = " + Media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
