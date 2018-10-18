using System;
using cadastro_usuarioforeach.classes;

namespace cadastro_usuarioforeach
{
    class Program
    {
        static Usuario[] arrayUsuarios;
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

            int qtdMax, opcao=0, contador=0;
            bool emailValido = false, senhaValida=false;

            Console.WriteLine("Informe a quantidade de cadastros!");
            qtdMax = int.Parse(Console.ReadLine());

            arrayUsuarios = new Usuario[qtdMax];

            do {

                MontarMenu();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0: {
                        Console.WriteLine("Volte sempre!");
                        break;
                    }
                    
                    case 1: {
                        if (contador < qtdMax){
                            arrayUsuarios[contador] = new Usuario();

                            #region solicitando nome
                                Console.WriteLine("Informe o seu nome!");
                                arrayUsuarios[contador].nome = Console.ReadLine();
                            #endregion
                            
                            #region solicitando e validando email
                            do {
                                System.Console.WriteLine("Informe seu email!");
                                string email = Console.ReadLine();

                                if (email.Contains("@")) {
                                    emailValido= true;
                                    arrayUsuarios[contador].email = email;
                                }
                                else {
                                    Console.WriteLine("Email inválido!");
                                }

                            } while(!emailValido);
                            #endregion
                        
                            #region solicitando e validando senha
                            do {
                                System.Console.WriteLine("Informe sua senha!");
                                string senha = Console.ReadLine();

                                if (senha.Length >= 4) {
                                    senhaValida= true;
                                    arrayUsuarios[contador].senha = senha;
                                }
                                else {
                                    Console.WriteLine("Senha inválida!");
                                }

                            } while(!senhaValida);
                            #endregion

                            Console.WriteLine("Usuário cadastrado!");
                            contador++;
                        }

                        else {
                            Console.WriteLine("Número máximo de usuários atingido!");
                        }

                        break;
                    }
                    
                    case 2: {
                        ListarUsuarios();
                        break;
                    }
                    
                    case 3: {
                        string email;
                        string senha;
                        
                        #region solicitando e validando email e senha
                        System.Console.WriteLine("Informe seu email!");
                        email = Console.ReadLine();
                            
                        System.Console.WriteLine("Informe sua senha!");
                        senha = Console.ReadLine();
                        ValideEmaileSenha(email,senha);
                        #endregion

                        break;
                    }               
                    
                    default: {
                        Console.WriteLine("Opção inválida!");
                        break;
                    }
                }
            } while(opcao!=0);

        }


        /// <summary>Método que dispões o menu na tela do usuário!</summary>
        static void MontarMenu(){
            Console.WriteLine("Menu de opções, escolha a opção desejada!");
            Console.WriteLine("1. Cadastrar novo usuário");
            Console.WriteLine("2. Listar usuários");
            Console.WriteLine("3. Acessar sistema");
            Console.WriteLine("0. Sair");
        }

        /// <summary> Método que lista todos os usuários na tela!</summary>
        static void ListarUsuarios() {
            foreach (Usuario item in arrayUsuarios)
            {
                if (item != null) {
                Console.WriteLine($"{item.nome}, {item.email}");
                }
            }
        }

        static void ValideEmaileSenha(string email, string senha) {
            bool encontrado = false;
            
            foreach (Usuario item in arrayUsuarios) {
                if(item != null) {
                    if (item.email == email  &&  item.senha == senha) {
                        Console.WriteLine("Acesso permitido!");
                        encontrado = true;
                        break;
                    }
                }
            }

            if (!encontrado) {
                Console.WriteLine("Acesso negado!");
            }
        }
    }
}
