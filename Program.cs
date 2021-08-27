using System;

namespace ContagemRegressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 5 - Faça um programa que exiba uma contagem regressiva no seguinte formato:
            // Preparar...
            // Apontar...
            // FOGO!
            // Aguarde o pressionamento de uma tecla antes de cada transição.

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Contagem regressiva:");

            Console.ResetColor();

            // Resolução do exercício
            Console.WriteLine("Preparar. . .");
            Console.ReadKey();
            Console.WriteLine("Apontar. . .");  
            Console.ReadKey();
            Console.WriteLine("FOGO !!!");

            Console.Write("Pressione <ENTER> para finalizar o programa. . .");
            while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
        }
    }
}