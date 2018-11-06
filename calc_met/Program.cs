using System;
using calc_met.classes;

namespace calc_met
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Transcreva uma classe Calculadora com os seguintes métodos:
            double Somar(double, double) : Retorna a soma dos dois parâmetros;
            double Subtrair(double, double) : Retorna a subtração dos dois parâmetros;
            double Multiplicar(double, double) : Retorna a multiplicação dos dois parâmetros;
            double Dividir(double, double) : Retorna a divisão dos dois parâmetros;
            Faça um algoritmo que use um objeto desta classe e permita que o usuário entre com dois valores e 
            escolha qual método utilizar. */
            int opcao;
            float x, y;
            calculo calculo1 = new calculo ();

            Console.WriteLine("Insira o primeiro número!");
            x = float.Parse (Console.ReadLine());

            Console.WriteLine("Insira o segundo número!");
            y = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual cálculo deseja realizar?");
            Console.WriteLine ("1. Soma");
            Console.WriteLine ("2. Subtração ");
            Console.WriteLine ("3. Multiplicação");
            Console.WriteLine ("4. Divisão ");
            opcao =int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:{
                    Console.WriteLine($"A soma é igual a {calculo1.somar(x,y)}!");
                    break;
                }
                case 2: {
                    Console.WriteLine($"A subtração é igual a {calculo1.subtrair(x,y)}!");
                    break;
                }

                case 3: {
                    Console.WriteLine($"A multiplicação é igual a {calculo1.multiplicar(x,y)}");
                    break;
                }

                case 4: {
                    Console.WriteLine($"A divisão é igual a {calculo1.dividir(x,y)}");
                    break;
                }
            
            }


        }
    }
}
