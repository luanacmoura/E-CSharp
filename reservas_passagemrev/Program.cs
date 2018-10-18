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
            
            int opcao, cont=0,contExibir=0;
            Passagem[] passagens = new Passagem[3]; //declarando um vetor de objetos

            do {
                Console.WriteLine ("Selecione uma opção");
                Console.WriteLine ("1 - Agendar Viagem");
                Console.WriteLine ("2 - Exibir Viagens");
                Console.WriteLine ("0 - Sair");
                opcao = int.Parse (Console.ReadLine ());
                switch (opcao) {
                    case 1:
                        {
                            if (cont < 3) {
                                passagens[cont] = new Passagem(); //instanciando o objeto
                                passagens[cont].ReceberDados();                                
                                cont++;
                            } else {
                                Console.WriteLine ("Limite de passagens Excedida");
                            }
                            break;
                        }
                    case 2:
                        {
                            contExibir = 0;
                            while (contExibir < cont) {
                                Console.WriteLine ($"Nome: {passagens[contExibir].nomePassageiro}, Nº Passagem: {passagens[contExibir].numeroPassagem}, Data: {passagens[contExibir].dataVoo.ToShortDateString()}");
                                contExibir++;
                            }
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Obrigado e Thau.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Valor Inválido");
                            break;
                        }
                }

            } while (opcao != 0);


  
  

        }
    }
}
