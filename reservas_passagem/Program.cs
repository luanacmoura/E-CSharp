using System;

namespace reservas_passagem
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criar um sistema que realize as reservas de passagem aéreas de uma companhia, 
            o sistema deve conter um menu com as seguintes opções Agendar Viagem e Exibir Viagens. 
            Em agendar viagem deve ser registrado o número da passagem, nome do passageiro e data do voo 
            em Exibir deve listar todas as passagens agendadas. (para 5 passagens)*/
            
            int opcao, i=0, c=0, d=0;
            int [] npassagem = new int[5];
            string[] nome = new string[5];
            DateTime[] data = new DateTime[5];

            while (i < 5){
                Console.WriteLine("Insira a opção referente a ação desejada!");
                Console.WriteLine("1. Agendar Viagem");
                Console.WriteLine("2. Exibir Viagens");
                opcao = int.Parse(Console.ReadLine());

                if (opcao ==1) {
                Console.WriteLine("Registre o número da sua passagem!");
                npassagem[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o nome do passageiro!");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Insira a data do vôo! (dd/mm/aa)");
                data[i] = DateTime.Parse(Console.ReadLine());
                i++;    
                }

                else if (opcao==2) {
                    if (i==0){
                        Console.WriteLine("Não há viagens para exibir!");
                    }
                    else {
                        c = i; // criei a variável c para que ele só mostre a quantidade de viagens que estiver registrada, evitando que, caso só tenha 3 viagens registradas, ele não repita essas mesmas mais duas vezes por ex;
                        while ( d<c) { // e criei a variavel d como outro contador para que ele não altere o i (contador que indica viagens registradas e condição do while, como teria que ser resetado, nunca sairia do laço, pq sempre que passasse por aqui ele ia resetar o contador)
                            Console.WriteLine($"Número da passagem: {npassagem[d]}");
                            Console.WriteLine($"Nome do passageiro: {nome[d]}");
                            Console.WriteLine($"Data do vôo: {data[d].ToShortDateString()}");
                            d++;
                        }
                    }
                }
            }

            Console.WriteLine("Máximo de viagens registradas!");
            Console.WriteLine("Deseja exibir viagens? 1 - Sim, 2 - Não");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1) {
                for (i=0; i<5; i++) {
                    Console.WriteLine($"Número da passagem: {npassagem[i]}");
                    Console.WriteLine($"Nome do passageiro: {nome[i]}");
                    Console.WriteLine($"Data do vôo: {data[i].ToShortDateString()}");
                }
            }
        }
    }
}
