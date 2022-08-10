using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07e04
{
    //Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.
    //Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.Write("Informe o valor do 1º número: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o valor do 2º número: ");
            B = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                C = A + B;
                Console.Write("A soma do número {0} e do número {1} é igual a {2}", A, B, C);
            }
            else
            {
                C = A * B;
                Console.Write("A multiplicação do número {0} e do número {1} é igual a {2}", A, B, C);
            }




            Console.ReadKey();
        }
    }
}
