using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receber um número inteiro n e outro limite do usuário. Exibir a tabuada do número n do 0 até o limite. */
            int n, lim,i;
            Console.WriteLine("Insira o número!");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira até onde quer que a tabuada vá!");
            lim = int.Parse(Console.ReadLine());

            for (i=0; i<=lim; i++) {
                Console.WriteLine($"{n} x {i} = {n*i}");
            }
        }
    }
}
