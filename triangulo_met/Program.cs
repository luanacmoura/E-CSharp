using System;
using triangulo_met.classes;

namespace triangulo_met
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie a classe Triangulo com os seguintes campos: 
            float ladoA, ladoB, ladoC; 
            Faça os seguintes métodos na classe: 
            bool E Valido() : Retorna true se o triângulo é valido e false caso contrário; 
            string TipoTriangulo(): Retorna uma string contendo escaleno, isósceles ou equilátero. 
            Faça um algoritmo que o usuário insira os lados do triângulo e dispare os métodos do objeto. 
            IMPORTANTE: 
            Considere como verdadeiro as seguintes regras para realizar o exercício: 
            Um triângulo é válido quando: um lado é menor que a soma dos outros dois; 
            Um triângulo é escaleno quando: todos os lados do triângulo são diferentes; 
            Um triângulo é equilátero quando: todos os lados são iguais; 
            Um triângulo é isósceles quando: Não for escaleno ou equilátero.  */

            float ladoA, ladoB, ladoC;
            Triangulo triangulo1 = new Triangulo();

            Console.WriteLine("Digite o valor do primeiro lado!");
            ladoA = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo lado!");
            ladoB = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do terceiro lado!");
            ladoC = float.Parse(Console.ReadLine()); 

            if ( triangulo1.Valido(ladoA,ladoB,ladoC)==true) {
                Console.WriteLine("O triângulo é válido!");
                Console.WriteLine($"O triângulo é do tipo {triangulo1.TipoTriangulo(ladoA,ladoB,ladoC)}!");
            }
            else {
                Console.WriteLine("O triângulo é inválido!");
            }
        }
    }
}
