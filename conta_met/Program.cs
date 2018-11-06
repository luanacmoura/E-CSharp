using System;
using conta_met.classes;

namespace conta_met
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crie uma classe ContaBancaria que irá conter os atributos nome, cpf e saldo da conta. 
            O usuário poderá sacar, depositar e mostrar saldo.
	        - O Usuário não poderá sacar um valor maior que seu saldo.
	        - O Usuário não poderá alterar diretamente o seu saldo, o mesmo só poderá ser alterado 
              pelos métodos sacar e depositar. */
            int opcao,sair=0;
            float qtd;
            ContaBancaria conta1 = new ContaBancaria();

            while (sair==0) {
                Console.WriteLine("Qual ação deseja realizar?");
                Console.WriteLine ("1.Sacar");
                Console.WriteLine ("2.Depositar");
                Console.WriteLine ("3.Visualizar Saldo");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: {
                        Console.WriteLine("Quanto dinheiro deseja sacar?");
                        qtd = float.Parse(Console.ReadLine());
                        Console.WriteLine (conta1.Sacar(qtd));
                        break;
                    }
                    
                    case 2: {
                        Console.WriteLine("Quanto dinheiro deseja depositar?");
                        qtd = float.Parse(Console.ReadLine());
                        Console.WriteLine (conta1.Depositar(qtd));
                        break;
                    }

                    case 3: {
                        Console.WriteLine($"O saldo disponível é de: R${conta1.MostrarSaldo()}");
                        break;
                    }
                    default: {
                        Console.WriteLine("Opção inválida!");
                        break;
                    }
                }
                Console.WriteLine("Deseja sair? 0 - Não, 1 - Sim");
                sair = int.Parse(Console.ReadLine());
            }
        }
    }
}
