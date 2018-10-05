using System;

namespace divsemoperador
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receba do usuário um número dividendo e o número divisor. Exibir o resultado da divisão do dividendo pelo divisor. Regra: Não é permitido o uso de div ou /. 
            DICA: 
            Para encontrar o resultado da divisão de um dividendo e um divisor é necessário realizar um laço de repetição. */

            int v1,v2, res=0;

            Console.WriteLine("Digite o primeiro valor!");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor!");
            v2 = int.Parse(Console.ReadLine());

            while (v1>=v2) {
                res +=1;
                v1 = v1-v2;
            }

            Console.WriteLine ($"O resultado da divisão é {res}!");



        }
    }
}
