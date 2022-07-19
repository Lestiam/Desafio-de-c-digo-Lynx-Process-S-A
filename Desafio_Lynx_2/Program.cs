using System;

namespace Desafio_Lynx_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 1;
            int j;

            for (j = 2; j < 101; j++)
                s += 1.00 / j;
                
            Console.WriteLine($"O valor de S é de {s.ToString("N2")}");
        }
    }
}
