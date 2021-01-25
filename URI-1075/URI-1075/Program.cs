using System;
using System.Globalization;

namespace URI_1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++) {

               int X = int.Parse(Console.ReadLine());

                if (X / X == 1 && X / 1 == X){
                    Console.WriteLine(X + " eh primo");
                }
                else{
                    Console.WriteLine(X + " nao eh primo");
                }
            }
        }
    }
}
