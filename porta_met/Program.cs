using System;
using porta_met.classes;

namespace porta_met
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie uma classe Porta com os seguintes campos: 
            bool aberta = false; 
            Nela crie os seguintes métodos: 

            void Abrir() : Caso a porta não esteja aberta, exibir a mensagem “A porta abriu”, 
            caso contrário exibir a mensagem: “Não precisa se esforçar pra nada”. 
            Faça uma implementação que simule o estado da porta se encontra aberta. 

            void Fechar() : Caso a porta esteja aberta, exibir a mensagem:
            “A porta fechou”, caso contrário exibir a mensagem “Porta já esta fechada". 
            Faça uma implementação que simule o estado da porta se encontra fechada;  */
            int opcao=2;
            Porta porta1 = new Porta();
            while (opcao != 0) {
                Console.WriteLine("Em que estado a porta esta?");
                Console.WriteLine("1. Aberta");
                Console.WriteLine("2. Fechada");
                opcao = int.Parse(Console.ReadLine());
                if (opcao==1){
                    porta1.aberta = true;
                }

                else {
                    porta1.aberta = false;
                }
                
                Console.WriteLine("Qual ação deseja realizar?");
                Console.WriteLine("1. Abrir");
                Console.WriteLine("2. Fechar");
                Console.WriteLine("0. Sair");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1){
                    porta1.Abrir();
                }
                else if (opcao == 2) {
                    porta1.Fechar();
                }
            }
        }
    }
}
