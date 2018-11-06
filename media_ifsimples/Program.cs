using System;

namespace media_ifsimples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolva um programa que receba duas notas e retorne a média e se está aprovado ou reprovado!
            Para ser aprovado a média do aluno deve ser igual ou maior que 50. Caso contrário será reprovado!*/
            float media, n1,n2;

            Console.WriteLine("Digite a primeira nota!");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota!");
            n2 = float.Parse(Console.ReadLine());

            if (n1 >100) {
                Console.WriteLine("Digite um valor menor ou igual a 100!");
            }
            else if (n1<0) {
                Console.WriteLine("Digite um valor maior que 0!");
            }
            else if (n2 >100) {
                Console.WriteLine("Digite um valor menor ou igual a 100!");
            }
            else if (n2 < 0) {
                Console.WriteLine("Digite um valor maior que 0!");
            }
            else {

                media = (n1+n2)/2;

                if (media >= 50){
                    Console.WriteLine($"A média do aluno é {media}");
                    Console.WriteLine("O aluno está aprovado!");
                }
                else {
                    Console.WriteLine($"A média do aluno é {media}");
                    Console.WriteLine("O aluno está reprovado!");
                }

            }
        }
    }
}
