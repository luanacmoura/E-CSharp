using System;

namespace crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa para ler 3 valores inteiros (considere que não serão lidos
            valores iguais) e escrevê-los em ordem crescente */
            int v1,v2,v3;
            
            Console.WriteLine("Digite o primeiro valor!");
            v1  = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor!");
            v2  = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o terceiro valor!");
            v3  = int.Parse(Console.ReadLine());

            if (v1>v2 && v1>v3) {
                if (v2>v3) {
                    Console.WriteLine($"{v3} {v2} {v1}");
                }
                else {
                    Console.WriteLine($"{v2} {v3} {v1}");
                }
            }
            
            else if (v2>v1 && v2>v3) {
                if (v1>v3) {
                    Console.WriteLine($"{v3}  {v1} {v2}");
                }
                else {
                    Console.WriteLine($"{v1} {v3} {v2}");
                }
            }

            else {
                if (v1>v2) {
                    Console.WriteLine($"{v2}  {v1} {v3}");
                }
                else {
                    Console.WriteLine($"{v1} {v2} {v3}");
                }
            }
        }
    }
}
