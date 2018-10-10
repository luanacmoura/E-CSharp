using System;

namespace array_bool
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um método que recebe um array de inteiros a e devolve um array de boolean
            onde, cada posição indique true se o elemento da posição correspondente de a é positivo e false
            caso seja negativo ou zero.*/
            int i;
            int[] a = new int[5];
            bool[] verif = new bool[5];

            for (i=0; i<5; i++) {
                Console.WriteLine($"Insira o {a[i]}");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (i=0; i<5; i++) {
                if(a[i] <= 0) {
                    verif[i] = false;
                }
                else {
                    verif[i] = true;
                }
            }

            for (i=0; i<5; i++) {
                Console.WriteLine(a[i], verif[i]);
            }
        }
    }
}
