using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Revisao_MVC.Models;

namespace Revisao_MVC.ViewsControllers
{
    public class UsuarioViewController
    {
        public void CadastroUsuario(){
            string nome, email, senha;
            int cont = 0;
            Console.Clear();
            #region View
                System.Console.WriteLine("Informe o seu nome");
                nome = Console.ReadLine();

                System.Console.WriteLine("Informe o seu email");
                email = Console.ReadLine();
                
                System.Console.WriteLine("Informe sua senha");
                senha = Console.ReadLine();
            #endregion

            #region Controller          
                //Recebe a lista de usuários
                List<UsuarioViewModel> lsUsuarios = Listar();

                //O contador vai começar no número de linhas que a lista já tiver!
                if (lsUsuarios!=null) {
                    cont = lsUsuarios.Count;
                }

                //Cria um arquivo excel (csv)! -- Pode ser usado para criar outros como pdf, txt e etc...
                StreamWriter sw = new StreamWriter("usuarios.csv",true); //Esse segundo parâmetro é responsável por determinar se vai ou não escrever no mesmo arquivo! Por default ele é false, ou seja, se eu não mudar esse parametro pra true, a cada vez q eu tentar escrever nele ele vai criar outro arquivo e sobreescrever o existente, deixando apenas as informações inseridas naquele momento...


                UsuarioViewModel usuario = new UsuarioViewModel();
                usuario.Id = cont + 1; //Para que o id não se repita!
                usuario.Nome = nome;
                usuario.Email = email;
                usuario.Senha = senha;
                usuario.DataCriacao = DateTime.Now;

                //Responsável por escrever no arquivo excel!
                sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao}.");
                sw.Close();

                System.Console.WriteLine("Usuário Cadastrado!");
                Console.ReadKey();
            #endregion
        }
    
        public void Login(){
           string email, senha;
           Console.Clear();

            #region View
                System.Console.WriteLine("LOGIN");
                System.Console.WriteLine("Informe seu email");
                email = Console.ReadLine();
                
                System.Console.WriteLine("Informe sua senha");
                senha = Console.ReadLine();
                #endregion

                #region Controller
                //Recebe a lista de usuários
                List<UsuarioViewModel> lsUsuarios = Listar();

                //Percorre a lista
                foreach (UsuarioViewModel item in lsUsuarios)
                {
                    //Caso o que a pessoa inseriu seja válido, retorna usuário logado!
                    if(item.Email == email && item.Senha == senha){
                        System.Console.WriteLine("Usuário Logado");
                        break;
                    }
                }
            #endregion
        }
    
        public void ListarUsuarios(){
            Console.Clear();

            #region Controller
                System.Console.WriteLine("LISTA DE USUÁRIOS");
                //Recebe a lista de usuários
                List<UsuarioViewModel> lsUsuarios = Listar();
            #endregion

            #region View
                //Percorre a lista
                foreach (UsuarioViewModel item in lsUsuarios)
                {
                    //Exibe cada item
                    System.Console.WriteLine($"{item.Id} - {item.Nome}, {item.Email}, criado em: {item.DataCriacao}");
                }
            #endregion
        }

        private List<UsuarioViewModel> Listar(){
            List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel>();
            UsuarioViewModel usuario;
            if (!File.Exists("usuarios.csv")) return null;

            //Cria um array com todas as linhas do usuarios.csv
            string[] usuarios = File.ReadAllLines("usuarios.csv");

            //Percorre cada linha do arquivo!
            foreach (string item in usuarios) {
                //Quebra as linhas em colunas, separando cada coluna pelo ;
                string[] dados = item.Split(';');

                usuario = new UsuarioViewModel();
                usuario.Id = int.Parse(dados[0]); //Insere no usuario Id, o que estiver na primeira coluna do arquivo!
                usuario.Nome = dados[1];
                usuario.Email = dados[2];
                usuario.Senha = dados[3];
                usuario.DataCriacao = DateTime.Parse(dados[4]);
                lsUsuarios.Add(usuario);
            }

            return lsUsuarios; //Retorna a lista para que possa ser usada nos outros métodos!
        }
    }
}