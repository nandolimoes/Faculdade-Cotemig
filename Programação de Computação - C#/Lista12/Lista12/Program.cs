using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista12
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo lerTecla;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("| COD | Exercício            |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| F1  | Salário e Filhos     |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| F2  | Eleição              |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| F3  | Pares e Ímpares      |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| F4  | População            |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| ESC | Sair do programa     |");
            Console.WriteLine("-----------------------------");
            lerTecla = Console.ReadKey();

            switch (lerTecla.Key)
            {
                //A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o salário e número de filhos.
                //A prefeitura deseja saber:
                //a) média do salário da população;
                //b) média do número de filhos;
                //c) maior salário; d) percentual de pessoas com salário até R$1000,00.
                //O final da leitura de dados se dará com a entrada de um salário negativo

                case ConsoleKey.F1:
                    {
                        Console.Clear();
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("| F1  | Salário e Filhos     |");
                        Console.WriteLine("-----------------------------\n");

                        double salario, maiorSalario = 0, somaSalario = 0;
                        int quantFilhos, cont = 0, somaQuantFilhos = 0, contMenor1000 = 0;

                        Console.Write("Salário: ");
                        salario = Convert.ToDouble(Console.ReadLine());

                        if (salario >= 0)
                        {
                            maiorSalario = salario;
                            Console.Write("Quantidade de filhos: ");
                            quantFilhos = Convert.ToInt32(Console.ReadLine());

                            while (salario >= 0)
                            {
                                somaSalario += salario;
                                somaQuantFilhos += quantFilhos;
                                cont++;

                                if (salario <= 1000)
                                {
                                    contMenor1000++;
                                }

                                if (maiorSalario < salario)
                                {
                                    
                                    maiorSalario = salario;
                                }

                                Console.Write("Salário: ");
                                salario = Convert.ToDouble(Console.ReadLine());

                                if (salario >= 0)
                                {
                                    Console.Write("Quantidade de filhos: ");
                                    quantFilhos = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                        }
                            Console.WriteLine("Foram entrevistas {0} pessoas", cont);
                            Console.WriteLine("A média do salário da população foi: R$ {0} ", Math.Round((somaSalario / cont), 2));
                            Console.WriteLine("A média do número de filhos foi:  {0} ", somaQuantFilhos / cont);
                            Console.WriteLine("O maior salário encontrado foi R$ {0} ", maiorSalario);
                            Console.WriteLine("O percentual de pessoas com salário até R$1000, 00 foi: {0} % ", (contMenor1000 / cont) * 100);

                        
                    }
                    break;

                case ConsoleKey.F2:
                    {
                        //Em uma eleição presidencial existem quatro candidatos. Os votos são informados através de códigos.
                        //Os dados utilizados para a contagem dos votos obedecem à seguinte codificação:
                        //• 1,2,3,4 = voto para os respectivos candidatos;
                        //• 5 = voto nulo;
                        //• 6 = voto em branco;
                        //Elabore um algoritmo que leia o código do candidato em um voto.
                        //Calcule e escreva:
                        //• total de votos para cada candidato;
                        //• total de votos nulos;
                        //• total de votos em branco; Como finalizador do conjunto de votos, tem-se o valor 0.

                        Console.Clear();
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("| F2  | Eleição              |");
                        Console.WriteLine("-----------------------------\n");

                        int voto, contNulo = 0, contBranco = 0, cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, contTotal = 0;
                        string ganhador;

                        Console.WriteLine("----------------------------");
                        Console.WriteLine("| COD |    CANDIDATO        |");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("|  1  |    HADDAD           |");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("|  2  |    CIRO GOMES       |");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("|  3  |    MARINA SILVA     |");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("|  4  |    AMOEDO           |");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("|  5  |    NULO             |");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("|  6  |    BRANCO           |");
                        Console.WriteLine("----------------------------\n");

                        Console.Write("Digite o seu voto: ");
                        voto = Convert.ToInt32(Console.ReadLine());



                        while (voto != 0)
                        {
                            if (voto >= 1 && voto <= 6)
                            {
                                contTotal++;

                                switch (voto)
                                {
                                    case 1:
                                        {
                                            cont1++;
                                        }
                                        break;
                                    case 2:
                                        {
                                            cont2++;
                                        }
                                        break;
                                    case 3:
                                        {
                                            cont3++;
                                        }
                                        break;
                                    case 4:
                                        {
                                            cont4++;
                                        }
                                        break;
                                    case 5:
                                        {
                                            contNulo++;
                                        }
                                        break;
                                    case 6:
                                        {
                                            contBranco++;
                                        }
                                        break;
                                    
                                 
                                }
                            }
                            else
                            {
                                                                       
                            Console.WriteLine("Código inválido");
                               
                            }


                            Console.Write("Digite o seu voto: ");
                            voto = Convert.ToInt32(Console.ReadLine());

                        }

                        Console.WriteLine("Total de votos para o candidato Haddad {0}", cont1);
                        Console.WriteLine("Total de votos para o candidato Ciro Gomes {0}", cont2);
                        Console.WriteLine("Total de votos para o candidato Marina Silva {0}", cont3);
                        Console.WriteLine("Total de votos para o candidato Amoedo {0}", cont4);
                        Console.WriteLine("Total de votos Nulo {0}", contNulo);
                        Console.WriteLine("Total de votos Branco {0}", contBranco);
                        Console.WriteLine("O ganhador da eleição foi {0}", ganhador);


                    }
                    break;

                case ConsoleKey.F3:
                    {
                        //Faça um algoritmo que leia uma quantidade não determinada de números positivos.
                        //Calcule a quantidade de números pares e ímpares, a média de valores pares e a média geral dos números lidos.
                        //O número que encerrará a leitura será zero.

                        int numero, contpar = 0, contimpar = 0, somapar = 0, somaGeral = 0, contGeral = 0;

                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("| F3  | Pares e Ímpares      |");
                        Console.WriteLine("-----------------------------\n");

                        Console.Write("Digite um número qualquer: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        while (numero != 0)
                        {
                            contGeral++;
                            somaGeral += numero;


                            if (numero % 2 == 0)
                            {
                                contpar++;
                                somapar += numero;
                            }
                            else
                            {
                                contimpar++;
                        
                            }    
                                
                            Console.Write("Digite um número qualquer: ");
                            numero = Convert.ToInt32(Console.ReadLine());    
                            
                        }
                        Console.WriteLine("Foram lidos {0} números pares", contpar);
                        Console.WriteLine("Foram lidos {0} números ímpares", contimpar);
                        Console.WriteLine("A média dos números números pares é {0}", Convert.ToDouble(somapar) / contpar);
                        Console.WriteLine("A média geral é: {0}", somaGeral / contGeral);

                    }
                    break;

                case ConsoleKey.F4:
                    {
                        //Foi feita uma pesquisa entre os habitantes de uma região.
                        //Foram coletados os dados de idade, sexo (M/F) e salário.
                        //Faça um algoritmo que informe:
                        //a) a média de salário do grupo;
                        //b) maior e menor idade do grupo;
                        //c) quantidade de mulheres com salário até R$1000,00.
                        //Encerre a entrada de dados quando for digitada uma idade negativa.

                    }
                    break;

                case ConsoleKey.Escape:
                    {
                        Console.Clear();
                        Console.WriteLine("\n --------------------");
                        Console.WriteLine("|Programa Finalizado!|");
                        Console.WriteLine(" --------------------");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Comando Inexistente!");
                    }
                    break;


            }

            Console.WriteLine("\n --------------------");
            Console.WriteLine("|Programa Finalizado!|");
            Console.WriteLine(" --------------------");

            Console.ReadKey();

        }
    }
}
