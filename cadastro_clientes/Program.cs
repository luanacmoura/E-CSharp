using System;
using cadastro_clientes.classe;

namespace cadastro_clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça uma classe Conta que contenha o nome do cliente, o número da conta e o saldo. 
            //Cadastre 3 clientes e ao final mostre os dados de cada cliente e o valor total das contas.

            conta cliente1 = new conta();
            conta cliente2 = new conta();
            conta cliente3 = new conta();

            #region primeiro cliente
            Console.WriteLine ("Insira o nome do primeiro cliente!");
            cliente1.nome = Console.ReadLine();
            Console.WriteLine ("Insira o nº da conta do primeiro cliente!");
            cliente1.num_conta = int.Parse (Console.ReadLine());
            Console.WriteLine ("Insira o saldo do primeiro cliente!");
            cliente1.saldo = float.Parse(Console.ReadLine());
            #endregion

            #region segundo cliente
            Console.WriteLine ("Insira o nome do segundo cliente!");
            cliente2.nome = Console.ReadLine();
            Console.WriteLine ("Insira o nº da conta do segundo cliente!");
            cliente2.num_conta = int.Parse (Console.ReadLine());
            Console.WriteLine ("Insira o saldo do segundo cliente!");
            cliente2.saldo = float.Parse(Console.ReadLine());
            #endregion
            
            #region terceiro cliente
            Console.WriteLine ("Insira o nome do terceiro cliente!");
            cliente3.nome = Console.ReadLine();
            Console.WriteLine ("Insira o nº da conta do terceiro cliente!");
            cliente3.num_conta = int.Parse (Console.ReadLine());
            Console.WriteLine ("Insira o saldo do terceiro cliente!");
            cliente3.saldo = float.Parse(Console.ReadLine());
            #endregion

            Console.WriteLine($"O primeiro cliente se chama {cliente1.nome}, nº da conta {cliente1.num_conta} e tem um saldo de R${cliente1.saldo}");
            Console.WriteLine($"O segundo cliente se chama {cliente2.nome}, nº da conta {cliente2.num_conta} e tem um saldo de R${cliente2.saldo}");
            Console.WriteLine($"O terceiro cliente se chama {cliente3.nome}, nº da conta {cliente3.num_conta} e tem um saldo de R${cliente3.saldo}");
 
        }
    }
}
