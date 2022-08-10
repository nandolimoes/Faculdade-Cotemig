using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07e02
{
    class Program
    {
        //Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa.
        //Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos).
        static void Main(string[] args)
        {
            String nome, estadoCivil;
            Char sexo;
            int tempoDeCasada;

            Console.Write("Qual é o seu nome ? ");
            nome = Console.ReadLine();

            Console.Write("Qual é o seu sexo (M) ou (F) ? ");
            sexo = Convert.ToChar(Console.ReadLine());

            Console.Write("Qual é o seu estado civil (solteira ou casada) ");
            estadoCivil = Console.ReadLine();

            if (sexo == 'F' && estadoCivil == "casada")
            {
                Console.Write("Quanto tempo de casada (anos): ");
                tempoDeCasada = Convert.ToInt32(Console.ReadLine());
           

            }
            Console.ReadKey();
        }

            


        
    }
}
