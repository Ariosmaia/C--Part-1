using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeadoMultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int contador = 0; contador <= 100; contador++)
            {
                if (contador % 3 == 0)
                {
                    Console.WriteLine(contador);
                }
            }

            //Outra opção

            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }



            Console.ReadLine();
        }
    }
}
