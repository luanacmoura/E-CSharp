using System;

namespace media_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa que receba duas notas e retorne a média.
            Para ser aprovado a média do aluno deve ser maior ou igual a 80! 
            Caso esteja entre 50 e 79 ele estará de recuperação, e caso seja menor que 50 estará reprovado! */
            float media, n1, n2;
            char sair='n';
            while (sair=='n'){
                Console.WriteLine("Por favor, insira a primeira nota do aluno!");
                n1 = float.Parse (Console.ReadLine());

                Console.WriteLine("Por favor, insira a segunda nota do aluno!");
                n2 = float.Parse(Console.ReadLine());

                media = (n1+n2)/2;

                Console.Write ($"A média é igual a {media} e");
                if (media >=80) {
                    Console.WriteLine (" o aluno está aprovado!");
                }

                else if (media >= 50){
                    Console.WriteLine (" o aluno está de recuperação!");
                }

                else {
                    Console.WriteLine(" o aluno está reprovado!");
                }

                Console.WriteLine ("Deseja sair? (Digite s para sim, e n para não!");
                sair = char.Parse(Console.ReadLine());
            }
        }
    }
}
