using System;
using System.Globalization;
   namespace Curso { 
    class Program {
        static void Main(string[] args) {
            double x = 10.35784;
           
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F1"));
            Console.WriteLine(x.ToString("F6"));
            Console.WriteLine(x.ToString("F1", CultureInfo.InvariantCulture));

                Console.ReadLine();
            }
    }
}
