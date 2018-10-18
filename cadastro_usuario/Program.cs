using System;
using cadastro_usuario.classes;

namespace cadastro_usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receber a quantidade de cadastros do usuário.
            Criar 1 vetor onde seja recebido as seguintes informações do usuário:
            Nome;  Email;  Senha;
            1 - Mostrar um menu para cadastrar um novo usuário, 
                - Verificar se o e-mail possui @
                - Verificar se a senha tenha ao menos 4 dígitos
            2 - Listar todos os usuários(nome e e-mail)
            3 - Acessar sistema.
                Pedir e-mail e senha e verificar se existe no array, se existir mostrar "Acesso Liberado" 
                senão "Email ou Senha  inválidos"
            4 - Sair */

            int qtd,i,opcao=1, cadastrados=0,qtdcad=0;
            string email, senha;

            Usuario[] usuario = new Usuario[50];

            while(opcao != 4) {

                Console.WriteLine("OPÇÕES");
                Console.WriteLine("1. Cadastrar novo usuário");
                Console.WriteLine("2. Listar usuários");
                Console.WriteLine("3. Acessar sistema");
                Console.WriteLine("4. Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: {
                        Console.WriteLine("Quantos usuários deseja cadastrar?");
                        qtd = int.Parse(Console.ReadLine());

                        for (i=0; i<50; i++) { //tem que ser 50 pois é a quantidade máxima...
                            if (usuario[i]==null){ //só cadastra se não tiver um valor na posição indicada
                                usuario[i] = new Usuario();
                                
                                #region solicitando e validando nome
                                do {
                                    Console.WriteLine($"Digite o nome do {i+1}º usuário!");
                                    usuario[i].nome = Console.ReadLine();

                                    if (usuario[i].nome==null) {
                                        Console.WriteLine("Insira um nome!");
                                    }
                                } while (usuario[i].nome==null);
                                #endregion

                                #region solicitando e validando email
                                do {
                                    Console.WriteLine($"Digite o email do {i+1}º usuário!");
                                    usuario[i].email = Console.ReadLine();

                                    if (!usuario[i].email.Contains("@")) {
                                        Console.WriteLine("Insira um email válido!");
                                    }
                                } while (!usuario[i].email.Contains("@")); // continua no laço enquanto não conter o @
                                #endregion

                                #region solicitando e validando senha
                                do {
                                    Console.WriteLine($"Digite a senha do {i+1}º usuário!");
                                    usuario[i].senha = Console.ReadLine();

                                    if (usuario[i].senha.Length <4) {
                                        Console.WriteLine("A senha precisa conter no mínimo 4 dígitos! Digite novamente!");
                                    }
                                } while(usuario[i].senha.Length <4 );
                                #endregion

                                qtdcad++;// pra que possa posteriormente listar os usuários, fica mais limpo sabendo quantos usuários cadastrados tem no array 
                                cadastrados++;// serve como uma flag para indicar se a qtd inserida pelo usuário ja foi cadastrada 

                                if (cadastrados==qtd ){ //se a pessoa queria cadastrar 2, e já foram cadastrados 2 usuarios, então da break e reinicia o cadastrados
                                    cadastrados=0;
                                    break;
                                }
                            }
                        }
                        break;
                    }

                    case 2: {
                        for (i=0; i<qtdcad; i++) {
                            Console.WriteLine ($"{i+1}º. {usuario[i].nome}, {usuario[i].email}");
                        }
                        break;
                    }

                    case 3: {
                        Console.WriteLine("Digite seu email!");
                        email = Console.ReadLine();

                        Console.WriteLine("Digite sua senha!");
                        senha = Console.ReadLine();

                        for (i=0; i<qtdcad; i++) {
                            if (email == usuario[i].email && senha == usuario[i].senha) {
                                Console.WriteLine("Acesso permitido!");
                                break;
                            }
                            else if (i==qtdcad-1) {
                                Console.WriteLine("Acesso negado! Email e/ou senha inválidos!");
                            }
                        }
                        break;
                    }

                    case 4: {
                        break;
                    }

                    default: {
                        Console.WriteLine("Opção inválida!");
                        break;
                    }
                }
            }
        }
    }
}
