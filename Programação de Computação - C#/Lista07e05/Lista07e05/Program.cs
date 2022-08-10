using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07e05
{
    class Program
    {
        //Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo, imprimindo o resultado.

        static void Main(string[] args)
        {
            double numero;

            Console.Write("Digita um número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.Write("O dobro do número {0} é igual a: {1}", numero, Math.Pow(numero,2));
            }
            else
            {
                Console.Write("O triplo do número {0} é igual a: {1}", numero, Math.Pow(numero,3));
            }

            Console.ReadKey();

        }
    }
}
