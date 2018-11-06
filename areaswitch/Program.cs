using System;

namespace areaswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa com MENU para receber o tipo de objeto
            desejado (Quadrado, Triângulo, Círculo) e calcule sua área.
            Quadrado - AREA<-L1*L2
            Triângulo - AREA<-(B*H)/2
            Círculo - AREA<-PI*R*R */
            int opcao;

            Console.WriteLine("Deseja obter a área de qual figura?");
            Console.WriteLine ("1 - Quadrado");
            Console.WriteLine ("2 - Triângulo");
            Console.WriteLine ("3 - Círculo");
            opcao = int.Parse (Console.ReadLine());

            switch (opcao)
            {
                case 1: {
                    float lado;
                    Console.WriteLine ("Digite o valor do lado!");
                    lado = float.Parse(Console.ReadLine());

                    Console.WriteLine ($"A área do quadrado é {lado*lado}");
                    break;
                }

                case 2: {
                    float bas, alt;
                    Console.WriteLine ("Digite o valor da base!");
                    bas = float.Parse (Console.ReadLine());
                    Console.WriteLine ("Digite o valor da altura!");
                    alt = float.Parse (Console.ReadLine());

                    Console.WriteLine ($"A área do triângulo é igual a {(bas*alt)/2}");    
                    break;
                }

                case 3: {
                    float raio;
                    Console.WriteLine ("Digite o valor do raio!");
                    raio = float.Parse (Console.ReadLine());

                    Console.WriteLine($"A área do círculo é {Math.PI * Math.Pow(raio,2)}");
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
