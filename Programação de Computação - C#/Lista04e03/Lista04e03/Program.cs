using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista04e03
{
    class Program
    {

/*Faça um programa em "C#" que solicite 2 números e informe:
a) A soma dos números;
b) O produto do primeiro número pelo quadrado do segundo;
c) O quadrado do primeiro número;
d) A raiz quadrada da soma dos quadrados;*/

        static void Main(string[] args)
        {
            double numero1, numero2;

            Console.Write("Informe o 1º número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o 2º número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            //result = numero1 + numero2;
            Console.WriteLine("A soma {0} + {1} é igual a {2}", numero1, numero2, numero1 + numero2); //"soma {0}", numero1 + numero2 //"a soma é {0}", result
            Console.WriteLine("O produto do primeiro número pelo quadrado do segundo = {0}", numero1 * Math.Pow(numero2,2));
            Console.WriteLine("O quadrado do número {0} é igual a {1}", numero1, numero1 * numero1);
            Console.WriteLine("A raiz quadrada da soma dos quadrados = {0}", Math.Sqrt(Math.Pow(numero1,2) + Math.Pow(numero2,2)));

            Console.ReadKey();




        }
    }
}
