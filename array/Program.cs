using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa que lê 3 números do meu usuário, armazenar num array e depois mostrar em ordem crescente! */
            int i=0;
            int [] num = new int [3];

            while (i < num.Length) {
                Console.WriteLine($"Digite {i+1}º número!");
                num [i] = int.Parse(Console.ReadLine());
                i++;
            }

            i=0;
            System.Array.Sort(num); //compara os dados do array e reordena em ordem crescente
            while (i < num.Length) {
                Console.WriteLine(num[i]);
                i++;
            }
        }
    }
}
