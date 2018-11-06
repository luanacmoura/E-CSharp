using System;
using System.Collections.Generic; //pra que a lista funcione!

namespace soma_media
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receba um número inteiro n do usuário. Em seguida, Receba n números do usuário. Exiba a somatória dos x números inseridos e também a média. 
            DICA: Somatória: É a soma de um conjunto de números. 
            DICA: Média: É a somatória de um conjunto numérico divido por sua quantidade. 
            EXEMPLO: Conjunto A = {1; 2; 3; 4} 
            Somatória do conjunto A: 1 + 2 + 3 + 4 = 10 
            Média do conjunto A: 10 / 4 = 2; onde 10 é a somatória e 4 é a quantidade de elementos do conjunto.*/
            int qtd=0, soma=0, sair=0,num;

            while (sair == 0) {
                Console.WriteLine("Digite um numero!");
                num = int.Parse(Console.ReadLine());                
                soma = soma + num;
                qtd++;
                Console.WriteLine("Deseja sair? 1 - Sim, 0 - Não");
                sair = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A soma dos números é: {soma}");
            Console.WriteLine($"A média dos números é: {soma/qtd}");


        }
    }
}
