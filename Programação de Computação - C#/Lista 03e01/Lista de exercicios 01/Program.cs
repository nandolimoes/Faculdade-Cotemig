using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03_01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Exercicio 1 - Faça um programa que solicite ao usuário o valor do litro de combustível (ex. 3,05)
            e quanto em dinheiro ele deseja abastecer (ex. 50,00).
            Calcule quantos litros de combustível o usuário obterá com esses valores.*/

            double valorLitro, quantLitros, dinheiro;
                       
            Console.Write("Digite o valor do litro do combustivel: ");
            valorLitro = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor que deseja abastecer: ");
            dinheiro = Convert.ToDouble(Console.ReadLine());


            quantLitros = dinheiro / valorLitro;

            Console.WriteLine("Foram obtidos {0} litros por meio de {1} reais ", quantLitros, dinheiro);

            Console.ReadKey();



        }
    }
}
