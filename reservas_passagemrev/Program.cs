using System;
using reservas_passagemrev.classes;

namespace reservas_passagemrev
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Utilizar orientação a objetos para simplificar!
            
            Criar um sistema que realize as reservas de passagem aéreas de uma companhia, 
            o sistema deve conter um menu com as seguintes opções Agendar Viagem e Exibir Viagens. 
            Em agendar viagem deve ser registrado o número da passagem, nome do passageiro e data do voo 
            em Exibir deve listar todas as passagens agendadas. (para 5 passagens)*/
            
            int opcao, i=0, c=0, d=0;
            passagem[] passagens = new passagem[3]; //declarando um vetor de objetos
            


            while (i < 5){
                Console.WriteLine("Insira a opção referente a ação desejada!");
                Console.WriteLine("1. Agendar Viagem");
                Console.WriteLine("2. Exibir Viagens");
                opcao = int.Parse(Console.ReadLine());

                //instanciando um objeto no vetor
                passagens[i] = new passagem();

                if (opcao ==1) {
                Console.WriteLine("Registre o número da sua passagem!");
                passagens[i].npassagem = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira o nome do passageiro!");
                passagens[i].nome = Console.ReadLine();

                Console.WriteLine("Insira a data do vôo! (dd/mm/aa)");
                passagens[i].datadovoo = DateTime.Parse(Console.ReadLine());
                i++;    
                }

                else if (opcao==2) {
                    if (i==0){
                        Console.WriteLine("Não há viagens para exibir!");
                    }
                    else {
                        c = i; // criei a variável c para que ele só mostre a quantidade de viagens que estiver registrada, evitando que, caso só tenha 3 viagens registradas, ele não repita essas mesmas mais duas vezes por ex;
                        while ( d<c) { // e criei a variavel d como outro contador para que ele não altere o i (contador que indica viagens registradas e condição do while, como teria que ser resetado, nunca sairia do laço, pq sempre que passasse por aqui ele ia resetar o contador)
                            Console.WriteLine($"Número da passagem: {passagens[d].npassagem}");
                            Console.WriteLine($"Nome do passageiro: {passagens[d].nome}");
                            Console.WriteLine($"Data do vôo: {passagens[d].datadovoo.ToShortDateString()}");
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
                    Console.WriteLine($"Número da passagem: {passagens[i].npassagem}");
                    Console.WriteLine($"Nome do passageiro: {passagens[i].nome}");
                    Console.WriteLine($"Data do vôo: {passagens[i].datadovoo.ToShortDateString()}");
                }
            }

        }
    }
}
