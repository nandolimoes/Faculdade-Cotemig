using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosOverload
{
    class Program
    {
        static int SomaValores (int pNumero1, int pNumero2)
        {
            return pNumero1 + pNumero2;
        }

        static double SomaValores (double pNumero1, int pNumero2)
        {
            return pNumero1 + pNumero2;
        }

        static double SomaValores(double pNumero1, double pNumero2)
        {
            return pNumero1 + pNumero2;
        }

        static double SomaValores (double pNumero1, double pNumero2, string pPalavra)
        {
            return pNumero1 + pNumero2 + pPalavra.Length;
        }

        static int SomaValores(int pNumero1, string pPalavra)
        {
            return pNumero1 + pPalavra.Length;
        }

        static bool ValidaCPF (string pCpf)
        {
            return true;
        }

        static bool ValidaCPF(int pCpf)
        {
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SomaValores(10, 13));
            Console.WriteLine(SomaValores(10.33, 13));
            Console.WriteLine(SomaValores(10.33, 13.33));
            Console.WriteLine(SomaValores(10, 13.33, "teste"));
            Console.WriteLine(SomaValores(10, "palavra"));

            Console.WriteLine(ValidaCPF("000.000.000-00"));
            Console.WriteLine(ValidaCPF(000000000000));
            
            Console.ReadKey();
        }
    }
}
 