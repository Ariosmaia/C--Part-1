using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EscopoOpcional
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario >= 1900.00 && salario <= 2800.00)
            {
                Console.WriteLine("IR é de 7.5%");
                Console.WriteLine("Pode deduzir na declaração o valor de R$ 142");
            }
            else
            {
                if (salario >= 2800.01 && salario <= 3751.0)
                {
                    Console.WriteLine("IR é de 15%");
                    Console.WriteLine("Pode deduzir R$ 350");
                }
                else
                {
                    if (salario >= 3751.01 && salario <= 4664.0)
                    {
                        Console.WriteLine("IR é de 22.5%");
                        Console.WriteLine("Pode deduzir R$ 636");
                    }
                }

          
            }
            Console.ReadLine();
        }
    }
}
