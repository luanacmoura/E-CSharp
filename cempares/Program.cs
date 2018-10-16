using System;

namespace cempares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receba um número inteiro par do usuário. Exibir os próximos 100 números pares após o número inserido pelo usuário.*/
            int num, i;
            Console.WriteLine("Insira um número!");
            num = int.Parse(Console.ReadLine());
            if (num%2 == 0){ // se for par
                for (i=0; i<=100; i=i+2 ){
                    Console.WriteLine(num+i);
                }
            }

            else { //se for ímpar
                num++; //soma um pra começar pelo par
                for (i=0; i<=100; i=i+2){
                    Console.WriteLine(num+i);
                }
            }
        }
    }
}
