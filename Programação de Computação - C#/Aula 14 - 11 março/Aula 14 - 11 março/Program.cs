using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14___11_março
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;
            char sexo; // apenas 1 caracter
            bool deficiente;

            Console.Write("Informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o sexo (M) ou (F): ");
            sexo = Convert.ToChar(Console.ReadLine());

            Console.Write("Possui alguma deficiência ? ");
            deficiente = Convert.ToBoolean(Console.ReadLine());


            if (idade >= 18 && sexo == 'M') // true && true / == igualdade

            {
                if (deficiente == false)
                {
                    Console.WriteLine("Serviço militar obrigatório");
                }
                else
                {
                    Console.WriteLine("Serviço militar não-obrigatório");
                }
            }
            else
            {
                Console.WriteLine("Serviço militar não-obrigatório");
            }

            Console.ReadKey();
        }
    }
}
