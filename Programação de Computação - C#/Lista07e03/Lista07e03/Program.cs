using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07e03
{
    class Program
    {
        //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

        static void Main(string[] args)
        {

            double numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número {0} é par!", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar!", numero);
            }

            Console.ReadKey();

        }
    }
}
