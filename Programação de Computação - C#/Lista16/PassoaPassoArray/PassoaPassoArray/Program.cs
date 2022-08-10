using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassoaPassoArray
{
    class Program
    {

        /*Inserir valores
         Maior valor
         Menor valor
         Soma dos valores
         Tamanho do array
         Média
         Primeiro e último valor
         Busca e atribuição de valores(Get e Set)
         Exibindo valores
         Ordenação de valores*/

        static Random numeroRandom = new Random();
        
        static void ExibirArray (int[] pArrayInteiros)
        {
            for (int i = 0; i < pArrayInteiros.Length; i++)
            {
                Console.WriteLine("Indice {0} com valor {1}", i, pArrayInteiros[i]);
            }
        }

        static int[] PreencherArray (int[] pArrayInterios)
        {
            for (int i = 0; i < pArrayInterios.Length; i++)
            {
                Console.WriteLine("Informe o indice {0} do array: ", i);
                pArrayInterios[i] = Convert.ToInt32(Console.ReadLine());
            }
            return pArrayInterios;
        }

        static int[] PreencheArrayRandom (int[] pArrayInteiros, int pValorInicial, int pValorFinal)
        {
            for (int i = 0; i < pArrayInteiros.Length; i++)
            {
                pArrayInteiros[i] = numeroRandom.Next (pValorInicial, pValorFinal + 1);
            }
        }
        return pArrayInteiros;

        static void Main(string[] args)
        {
            int[] idade = new int[5];

            ExibirArray(idade);

            idade[0] = 77;
            idade[1] = 33;
            idade[2] = 77;
            idade[3] = 22;
            idade[4] = 11;

            PreencherArray(idade);

            ExibirArray(idade);
            PreencheArrayRandom(idade);
           
            Console.ReadKey();

        }
    }
}
