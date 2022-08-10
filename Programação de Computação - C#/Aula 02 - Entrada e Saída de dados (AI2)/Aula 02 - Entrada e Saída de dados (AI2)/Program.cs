using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02___Entrada_e_Saída_de_dados__AI2_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool temFilhos; // true ou flase
            string nome, cidade; // caracteres "Belo Horizonte"
            int idade; // 1, 13, 20, -30, 0
            double salario; // 0.1, 13.13, -10.777, 7 (7.00000)
            char opcao; // v, t, r, 1, 't' 

            Console.Write("Você tem filhos ? "); 
            temFilhos = Convert.ToBoolean(Console.ReadLine()); // true ou false

            Console.Write("Qual o seu nome ? ");
            nome = Console.ReadLine();

            Console.Write("Qual a sua idade ? ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o seu salário ? ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a inicial do seu nome: ");
            opcao = Convert.ToChar(Console.ReadLine());

            Console.ReadKey();


        }
    }
}
