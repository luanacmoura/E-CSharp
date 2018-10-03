using System;

namespace rodiziocarros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que a pessoa insira o ultimo digito da placa do carro
            e mostre qual é o dia de rodízio! */
            int ultdig;
            Console.WriteLine("Informe o último dígito da placa o seu carro!");
            ultdig = int.Parse (Console.ReadLine());

            switch (ultdig)
            {
                case 1: case 2: {
                    Console.WriteLine("Rodízio na segunda-feira!");
                    break;
                }

                case 3: case 4: {
                    Console.WriteLine("Rodízio na terça-feira!");
                    break;
                }

                case 5: case 6: {
                    Console.WriteLine("Rodízio na quarta-feira!");
                    break;
                }

                case 7: case 8: {
                    Console.WriteLine("Rodízio na quinta-feira!");
                    break;
                }

                case 9: case 0: {
                    Console.WriteLine("Rodízio na sexta-feira!");
                    break;
                }

                default: {
                    Console.WriteLine ("Dígito inválido!");
                    break;
                }
            }
        }
    }
}
