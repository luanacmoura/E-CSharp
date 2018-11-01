using System;
using Revisao_MVC.ViewsControllers;

namespace Revisao_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewController usuarioViewControlller = new UsuarioViewController();
            usuarioViewControlller.CadastroUsuario();

            usuarioViewControlller.ListarUsuarios();
        
            usuarioViewControlller.Login();
        }
    }
}
