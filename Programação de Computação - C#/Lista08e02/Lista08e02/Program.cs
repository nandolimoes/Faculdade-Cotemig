using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08e02
{
    class Program
    {
        //Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos).

        static void Main(string[] args)
        {
            string nome, estadoCivil;
            char sexo;
            int tempoCasada;

            Console.Write("Informe o seu nome: ");
            Console.ReadLine();

            Console.Write("Informe o seu Estado Civil: ");
            Console.ReadLine();

            Console.Write("Informe o seu sexo(F ou M): ");
            sexo = Convert.ToChar(Console.ReadLine());

            if (sexo = "F")
            {
                
                Console.Write("Informe o tempo de casada: ");
                tempoCasada = Convert.ToInt32(Console.ReadLine());
            }
            
           else
            {

            }
            Console.ReadKey();

        }
    }
}
