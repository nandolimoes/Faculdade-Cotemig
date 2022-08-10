using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08e06
{
    class Program
    {
        //Escreva um algoritmo que lê dois valores booleanos (lógicos) e então determina se ambos são VERDADEIROS ou FALSOS.

        static void Main(string[] args)
        {
            bool valor1, valor2;

            Console.Write("Informe se o primeiro valor é true ou false: ");
            valor1 = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Informe se o segundo valor é true ou false: ");
            valor2 = Convert.ToBoolean(Console.ReadLine());

            if (valor1 == valor2)
            {
                Console.Write("{0}", valor1 == true ? "Ambos são verdadeiros!" : "Ambos são falsos!");
            }
            else
            {
                Console.Write("Um valor é verdadeiro e o outro é falso");
            }
            Console.ReadKey();
        }
    }
}
