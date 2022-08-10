using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numeroRandom = new Random();

            for(int i = 0; i <= 10; i++)
            {
                //(sem parametro) do tamanho especificado
                Console.WriteLine("{0}º numero: {1}", i, numeroRandom.Next());
            }

            // numeroRandom.Next(Value inicial, value final -1)
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}º numero: {1}", i, numeroRandom.Next(3, 11));
            }
            for (int i = 0; i <= 10; i++)
            {
                // Inicia do O (zero) até ValueMax -1
                Console.WriteLine("{0}º numero: {1}", i, numeroRandom.Next(11));
            }


            Console.ReadKey();

        }
        
    }
}
