using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_01___Entrada_e_saída_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
