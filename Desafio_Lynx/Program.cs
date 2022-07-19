using System;

namespace Desafio_Lynx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, domino;
            Console.WriteLine("Qual o número que deseja calcular seu jogo de Dominó: Duplo-N?");
            n = int.Parse(Console.ReadLine());
            if (n <= 0 || n >= 10000)
                Console.WriteLine("Número inválido!");
            else
            {
                domino = ((n + 1) * (n + 2)) / 2;
                Console.WriteLine($"O número de peças do seu jogo será de: {domino}");
            }   
        }
    }
}
