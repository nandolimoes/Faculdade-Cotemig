using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08e03
{
    class Program
    {
        //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Informe um número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O número é {0}", numero % 2 == 0 ? "par" : "ímpar");

            Console.ReadKey();

        }
    }
}
