using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista05e01
{
    class Program
    {
        //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

        static void Main(string[] args)
        {
            Double A, B, C;

            Console.Write("Insira o valor de A: ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o valor de B: ");
            B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o valor de C: ");
            C = Convert.ToDouble(Console.ReadLine());

            if (A + B < C)
            {
                Console.WriteLine("A soma dos valores de A + B ({0}) é menor que {1}", A+B, C);
            }
            else
            {
                Console.WriteLine("A soma dos valores de A + B ({0}) é maior que {1}", A+B, C);
            }
            Console.ReadKey();


        }
    }
}
