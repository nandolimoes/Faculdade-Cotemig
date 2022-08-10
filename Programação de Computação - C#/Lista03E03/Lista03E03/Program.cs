using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03E03
{
    class Program
    {
        /*Faça um programa que calcula o novo valor do salário de um funcionário.
         * O usuário informa o salário atual (ex. 750,00) e o percentual do reajuste(ex. 13,5 %).*/

        static void Main(string[] args)
        {
            double salarioAtual, novoSalario, percentual;

            Console.Write("Digite o salário atual: ");
            salarioAtual = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual do reajuste: ");
            percentual = Convert.ToDouble(Console.ReadLine());

            novoSalario = salarioAtual + (salarioAtual * (percentual/100));

            Console.WriteLine("O salário {0} R$, com reajuste de {1} % passou a ser {2} R$", salarioAtual, percentual, novoSalario);

            Console.ReadKey();
        }
    }
}
