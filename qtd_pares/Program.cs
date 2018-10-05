using System;

namespace qtd_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Peça um numero para o usuário e e informe os números pares e a quantidade
            de numeros pares no intervalo de 0 ate o numero informado pelo usuário! (naõ conta o 0 e o num então) */
            int num, qtd=0, i=1;

            Console.WriteLine("Insira um número!");
            num = int.Parse(Console.ReadLine());
            
            do {
                if (i%2==0) {
                    qtd ++;
                    Console.WriteLine(i);
                }
                i++;
            }
            while(i<num);

            Console.WriteLine($"A quantidade de números pares é {qtd}!");

            /*maneira alternativa de resolver: -------------------------------------------------------------------------------
            sem if e qtd*/
            
            Console.WriteLine("Escreva um número!");
            num = int.Parse(Console.ReadLine());
            i=2;

            do {
                Console.WriteLine (i);
                i +=2;
            }
            while(i<num);

            Console.WriteLine($"A quantidade de pares é {(num/2) -1}!"); // -1 pq não pode contar o próprio número!
        }
    }
}
