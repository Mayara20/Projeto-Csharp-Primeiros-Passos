using System;
using System.Globalization;

namespace URI_atividades
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, KML;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            KML = (double)X / Y;

            Console.WriteLine(KML.ToString("F3",CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
