using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista06e02
{
    class Program
    {

        //Uma escola oferece desconto na mensalidade de seus alunos de acordo com o conceito obtido pelo aluno no semestre anterior, conforme a tabela abaixo.
        //tabela 
        //Fazer um programa que leia o nome do aluno, a média final e o valor normal da mensalidade. O programa deve calcular e imprimir o novo valor da mensalidade, o nome do aluno e o conceito no qual ele foi classificado.

        static void Main(string[] args)
        {
            string nomeAluno;
            double mF, valorMensalidade;

            Console.Write("Informe o nome do aluno: ");
            nomeAluno = Console.ReadLine();

            Console.Write("Informe a média final do aluno: ");
            mF = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor da mensalidade: ");
            valorMensalidade = Convert.ToDouble(Console.ReadLine());

            if (9.0 < mF && mF <= 10)
            {
                Console.WriteLine("O aluno {0} está no conceito A portanto o valor da mensalidade será de {1}",nomeAluno, valorMensalidade-(valorMensalidade*0.15));
            }
            else if (7.5 < mF && mF <= 9.0)
            {
                Console.WriteLine("O aluno {0} está no conceito B portanto o valor da mensalidade será de {1}",nomeAluno, valorMensalidade - (valorMensalidade * 0.10));
            }
            else if (6.0 < mF && mF <= 7.5)
            {
                Console.WriteLine("O aluno {0} está no conceito C portanto o valor da mensalidade será de {1}",nomeAluno, valorMensalidade - (valorMensalidade * 0.05));
            }
            else if (4.0 < mF && mF <= 6.0)
            {
                Console.WriteLine("O aluno {0} está no conceito D portanto o valor da mensalidade será de {1}",nomeAluno, valorMensalidade);
            }
            else 
                    {
                Console.WriteLine("O aluno {0} está no conceito E portanto o valor da mensalidade será de {1}",nomeAluno, valorMensalidade);
                    }




            Console.ReadKey();
        }
    }
}
