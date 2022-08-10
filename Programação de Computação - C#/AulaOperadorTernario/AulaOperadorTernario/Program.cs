using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero1 = 3, numero2 = 5; //maiorNumero
            string resposta;

            //if (numero % 2 == 0);
            //{
            // Console.WriteLine("Número par!");
            //}
            //else 
            //{
            // Console.WriteLine("Número Ímpar!");
            //}
            //console.WriteLine(resposta);

            //variavel = condição ? true : false;

            resposta = numero1 % 2 == 0 ? "Número Par!" : "Número Ímpar";

            // Console.WriteLine(numero % 2 == 0 ? "Numero Par!" : "Numero Impar!");

            Console.WriteLine("O maior é {0}", numero1 > numero2 ? numero1 : numero2);

            //maiornumero = numero1 > numero2 ? numero1 : numero2;

            //Console.WriteLine("O namior número é {0}", maiorNumero);

            Console.WriteLine(resposta);

            Console.ReadKey();


        }
    }
}
