using System;

namespace Desafio_Lynx_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, t, f, total;

            Console.WriteLine("Informe  a hora da saída, o tempo de viagem e o fuso horário do destino com relação à origem.");
            s = int.Parse(Console.ReadLine());
            t = int.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine());

            total = s + t + f;


            if (total >= 24)
                Console.WriteLine(total-24);

            else if (total < 0) 
                Console.WriteLine(24+total);

             else
                Console.WriteLine(total);
            
        }
    }
}
