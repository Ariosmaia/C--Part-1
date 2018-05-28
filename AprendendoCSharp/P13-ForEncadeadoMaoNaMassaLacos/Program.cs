using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeadoMaoNaMassaLacos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LacoDeRepeticaoWhile");

            int contador = 0;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
