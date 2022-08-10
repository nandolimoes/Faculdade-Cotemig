using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08e07
{
    class Program
    {
        //Faça um algoritmo que leia uma variável e some 5 caso seja par ou some 8 caso seja ímpar, imprimir o resultado desta operação.

        static void Main(string[] args)
        {
            double var;

            Console.Write("Informe um número: ");
            var = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0}", var % 2 == 0 ? var + 5 : var + 8);

            Console.ReadKey();
        }
    }
}
