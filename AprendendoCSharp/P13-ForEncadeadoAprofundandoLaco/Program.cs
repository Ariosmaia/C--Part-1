using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeadoAprofundandoLaco
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Laço de repetição For");

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.WriteLine(multiplicador + " x " + contador + "= " + multiplicador * contador);
                    Console.Write("");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Laço de repetição For 2");

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Laço de repetição For 2 melhorado");

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
