using System;

namespace messwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Peça para o número do mês e informe para o usuário o mês
            correspondente. */
            int mes;
            Console.WriteLine("Insira o número do mês que deseja saber!");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1: {
                    Console.WriteLine("Janeiro");
                    break;
                }
                
                case 2: {
                    Console.WriteLine("Fevereiro");
                    break;
                }

                case 3: {
                    Console.WriteLine("Março");
                    break;
                }

                case 4: {
                    Console.WriteLine("Abril");
                    break;
                }

                case 5: {
                    Console.WriteLine("Maio");
                    break;
                }

                case 6: {
                    Console.WriteLine("Junho");
                    break;
                }
                case 7: {
                    Console.WriteLine("Julho");
                    break;
                }

                case 8: {
                    Console.WriteLine("Agosto");
                    break;
                }

                case 9: {
                    Console.WriteLine("Setembro");
                    break;
                }
                case 10: {
                    Console.WriteLine("Outubro");
                    break;
                }
                case 11: {
                    Console.WriteLine("Novembro");
                    break;
                }
                case 12: {
                    Console.WriteLine("Dezembro");
                    break;
                }

                default: {
                    Console.WriteLine("Valor inválido!");
                    break;
                }
            }
        }
    }
}
