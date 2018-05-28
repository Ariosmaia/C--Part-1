using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeadosFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            int anterior = 1;

            for (int n = 1; n <= 10; n++)
            {
                fatorial = n * anterior;                              
                Console.WriteLine("Fatorial de " + n + " = "+ fatorial );
                anterior = fatorial;
            }

            Console.WriteLine("Outra opção");

            int fat = 1;
            for (int i = 1; i < 11; i++)
            {
                fat *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fat);
            }

            Console.ReadLine();
        }
    }
}
