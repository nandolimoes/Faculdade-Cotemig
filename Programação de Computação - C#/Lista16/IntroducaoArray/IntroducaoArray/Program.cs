using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoArray
{
    class Program
    {

        static void ExibirArray(int[] pArrayInteiros)
        {
            for (int i = 0; i < pArrayInteiros.Length; i++)
            {

                Console.WriteLine("Indice {0} com valor {1}", i, pArrayInteiros[i]);


            }
        }
        static void Main(string[] args)
        {

            /*int[] numeros;
            numeros = new int[5];

            int[] arrayNumeros = new int[5];

            Console.WriteLine(arrayNumeros[3]);

            int[] arrayIdade = { 10, 15, 22, 33, 37 };

            Console.WriteLine(arrayIdade[2]);*/


            string nome = "aula";

            int[] idade = new int[10];

            idade[nome.Length + 2] = 77;

            idade[7] = 77;

            ExibirArray(idade);

            idade[2] = 13;

            ExibirArray(idade);

            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("Indice {0} com valor {1}",i, idade[i]);
            }
            idade[2] = 38;

            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("Indice {0} com valor {1}", i, idade[i]);
            }

            

            Console.ReadKey();

        }
    }
}
