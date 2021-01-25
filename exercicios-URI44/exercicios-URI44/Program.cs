using System;
using System.Globalization;

namespace exercicios_URI44
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);

            int duracao;

            if (horaInicio < horaFinal){
                duracao = horaFinal - horaInicio;
            }
            else{
                duracao = 24 - horaInicio +  horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
