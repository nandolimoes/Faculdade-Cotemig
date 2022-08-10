using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08e01
{
    class Program
    {
        //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
        static void Main(string[] args)
        {
            double A, B, C, soma;
            string resultado;
            
            Console.Write("Informe o valor do número A: ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor do número B: ");
            B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor do número C: ");
            C = Convert.ToDouble(Console.ReadLine());

            soma = A + B;
            

           Console.WriteLine("O valor da soma de A+B é {0}", soma > C ? "maior que C" : "menor que C");

            Console.ReadKey();


        }
    }
}
