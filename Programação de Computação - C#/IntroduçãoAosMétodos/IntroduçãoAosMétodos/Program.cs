using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduçãoAosMétodos
{
    class Program
    {

        /* static bool ValidaPar (int pNumero)
         {
             bool par;

             par = pNumero % 2 == 0 ? true : false; //ternário

              if (pNumero % 2 == 0) // usando if e else
             {
                 par = true;
             } else
             {
                 par = false;
             }

             return par;*/



        /*static string ValidaPar(int pNumero)
        {
            string par;

            par = pNumero % 2 == 0 ? "Sim" : "Não";

            return par; 
        }*/

        static bool ValidaPar(int pNumero)
        {
           return pNumero % 2 == 0;
        }

        static int ContaLetras (string pPalavras) // [t][e][s][t][e]
        {
            int quantLetras;

            quantLetras = pPalavras.Length;

            return quantLetras;

            // return pPalavras.Length;
        }

        static void Main(string[] args)
        {
            bool result;
            int quantLetras;

            result = ValidaPar(15);
            Console.WriteLine(result);
            Console.WriteLine(ValidaPar(10));

            quantLetras = ContaLetras("teste");
            Console.WriteLine(quantLetras + 5);
            Console.WriteLine(ContaLetras("Teste") + ContaLetras("Aula"));

            Console.ReadKey();
        }
        
    }
}
