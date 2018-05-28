using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EscopoMaoNaMassa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tsta Condional 2");

            int idade = 16;
            int quantidadePessoas = 3;
            bool acompanhado = quantidadePessoas >= 2;

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {

                Console.WriteLine("infelizmente voce nao pode entrar");

            }

            Console.ReadLine();
        }
    }
}
