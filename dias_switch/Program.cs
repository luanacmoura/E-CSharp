using System;

namespace dias_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa com switch case em que a pessoa insira o número equivalente ao dia da semana e
            ele mostre esse numero */
            int dia;
            Console.WriteLine("Informe o dia da semana! (1 a 7)");
            dia = int.Parse (Console.ReadLine());

            switch (dia)
            {
                case 1: {
                    Console.WriteLine("Domingo");
                    break;
                }

                case 2: {
                    Console.WriteLine("Segunda-feira");
                    break;
                }

                case 3: {
                    Console.WriteLine("Terça-feira");
                    break;
                }

                case 4: {
                    Console.WriteLine ("Quarta-feira");
                    break;
                }

                case 5: {
                    Console.WriteLine ("Quinta-feira");
                    break;
                }

                case 6: {
                    Console.WriteLine ("Sexta-feira");
                    break;
                }

                case 7: {
                    Console.WriteLine ("Sábado");
                    break;
                }
                
                default: {
                    Console.WriteLine ("Erro, dia inválido!");
                    break;
                }
            }

        }
    }
}
