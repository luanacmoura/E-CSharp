using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa para ler o número de lados de um polígono regular e a
            medida do lado (em cm). Calcular e imprimir o seguinte:
            − Se o número de lados for igual a 3 escrever TRIÂNGULO e o valor da área
            − Se o número de lados for igual a 4 escrever QUADRADO e o valor da sua área.
            − Se o número de lados for igual a 5 escrever PENTÁGONO.*/

            int qtdlados;
            float lado,area;


            Console.WriteLine ("Insira quantidade de lados!");
            qtdlados = int.Parse(Console.ReadLine());
            Console.WriteLine ("Insira o valor dos lados!");
            lado = float.Parse(Console.ReadLine());

            if (qtdlados ==3) {
                area = ((lado * lado) /4 ) * (float) Math.Sqrt(3);
                Console.WriteLine($"É um triângulo com área de {area} cm²!");
            }

            else if (qtdlados ==4) {
                area = lado * lado;
                Console.WriteLine($"É um quadrado com área de {area} cm²!");
            }

            else if (qtdlados==5) {
                Console.WriteLine("É um pentágono!");
            }

            else {
                Console.WriteLine("Erro!");
            }

        }
    }
}
