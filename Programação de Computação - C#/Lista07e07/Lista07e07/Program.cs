using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07e07
{
    class Program
    {
        //Faça um algoritmo que leia uma variável e some 5 caso seja par ou some 8 caso seja ímpar, imprimir o resultado desta operação.

        static void Main(string[] args)
        {
            double numero;

            Console.Write("Informe o valor de um número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("{0}", numero + 5);
            }
            else
            {
                Console.WriteLine("{0}", numero + 8);
            }


            Console.ReadKey();
        }
    }
}
