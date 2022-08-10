using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("----------------------------------");

            string palavra = "teste";

            while (palavra != "aula")
            {
                Console.Write("Digite uma palavra: ");
                palavra = Console.ReadLine();
            }
            Console.WriteLine("----------------------------------");
            Random numeroRandom = new Random();
            int numero = 0, cont = 1;

            while (numero != 7)
            {
                numero = numeroRandom.Next(1, 100);
                Console.WriteLine(numero);
                cont++;
            }
            Console.WriteLine("Acertou Mizeravi!");
            Console.WriteLine("Foram realizadas {0} tentativas", cont);

            Console.WriteLine("----------------------------------");
            int num, con = 1;

            Console.Write("Adivinhe o número de 1 a 7: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 3)
            {
                Console.WriteLine("Errou mizeravi! kkkkkkkkkkk");
                Console.WriteLine("Tente outra vez!");
                Console.WriteLine("----------------------------");
                Console.Write("Adivinhe o número de 1 a 7: ");
                num = Convert.ToInt32(Console.ReadLine());
                con++;
            }
            Console.WriteLine("Acertou Mizeravi!");
            Console.WriteLine("Você acertou na {0}ª tentativa(s)!", con);
            

            Console.ReadKey();

        }
    }
}
