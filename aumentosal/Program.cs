using System;

namespace aumentosal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Utilizando CASE faça um programa que receba o nome, salário
            e código correspondente ao cargo do funcionário e imprima o seu nome,
            salário, código, cargo, Percentual de aumento e salário com aumento de
            acordo com o percentual da tabela abaixo:
            Código Cargo Percentual
            1 Escriturário 50%
            2 Secretário 35%
            3 Caixa 20%
            4 Gerente 10%
            5 Diretor Não tem aumento */

            string nome;
            float salario, aumento, nvsalario;
            int codigo;

            Console.WriteLine ("Digite seu nome!");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite seu salário!");
            salario = float.Parse (Console.ReadLine());

            Console.WriteLine ("Digite o código referente ao seu cargo!");
            Console.WriteLine ("1 - Escrituário");
            Console.WriteLine ("2 - Secretário");
            Console.WriteLine ("3 - Caixa");
            Console.WriteLine ("4 - Gerente");
            Console.WriteLine ("5 - Diretor");
            codigo = int.Parse (Console.ReadLine());

            switch (codigo)
            {
                case 1: {
                    aumento = (50 * salario)/100;
                    nvsalario = salario + aumento;
                    Console.WriteLine ($"Nome: {nome}");
                    Console.WriteLine ($"Salario: R${salario}, cargo {codigo} Escrituário!");
                    Console.WriteLine ("Percentual de aumento: 50%");
                    Console.WriteLine ($"Salário com aumento: R${nvsalario}!");
                    break;
                }

                case 2: {
                    aumento = (35 * salario)/100;
                    nvsalario = salario + aumento;
                    Console.WriteLine ($"Nome: {nome}");
                    Console.WriteLine ($"Salario: R${salario}, cargo {codigo} Secretário!");
                    Console.WriteLine ("Percentual de aumento: 35%");
                    Console.WriteLine ($"Salário com aumento: R${nvsalario}!");
                    break;
                }

                case 3: {
                    aumento = (20 * salario)/100;
                    nvsalario = salario + aumento;
                    Console.WriteLine ($"Nome: {nome}");
                    Console.WriteLine ($"Salario: R${salario}, cargo {codigo} Caixa!");
                    Console.WriteLine ("Percentual de aumento: 20%");
                    Console.WriteLine ($"Salário com aumento: R${nvsalario}!"); 
                    break;
                }

                case 4: {
                    aumento = (10 * salario)/100;
                    nvsalario = salario + aumento;
                    Console.WriteLine ($"Nome: {nome}");
                    Console.WriteLine ($"Salario: R${salario}, cargo {codigo} Gerente!");
                    Console.WriteLine ("Percentual de aumento: 10%");
                    Console.WriteLine ($"Salário com aumento: R${nvsalario}!");
                    break;
                }

                case 5: {
                    Console.WriteLine ($"Nome: {nome}");
                    Console.WriteLine ($"Salario: R${salario}, cargo {codigo} Diretor!");
                    Console.WriteLine ("Percentual de aumento: Não há aumento!");
                    break;
                }

                default: {
                    Console.WriteLine ("Opção inválida!");
                    break;
                }
            }

        }
    }
}
