using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03e02
{
    class Program
    {
        /*Faça um programa que calcule o valor a ser pago por uma dívida em atraso. 
         * O usuário deve informar o valor original da dívida (ex. R$ 50,00), a quantidade de dias em atraso (ex. 35 dias)
         * e o valor da multa por dia de atraso (ex. R$ 0,25).*/

        static void Main(string[] args)
        {
            double valorAtraso, valorOriginal, valorMulta;
            int quantDiasAtraso;

            Console.Write("Informe o valor original da dívida: ");
            valorOriginal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informa a quantidade de dias em atraso: ");
            quantDiasAtraso = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor da multa por dia de atraso: ");
            valorMulta = Convert.ToDouble(Console.ReadLine());

            valorAtraso = valorOriginal + (valorMulta * quantDiasAtraso);
            Console.WriteLine("O valor a ser pago pelo atraso de {0} dias é de {1} reais.", quantDiasAtraso, valorAtraso);

            Console.ReadKey();


        }
    }
}
