using System;
using cadastro.classes;

namespace cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receber a quantidade de cadastros do usuário.
            Criar 1 vetor onde seja recebido as seguintes informações do usuário:
            Nome;  Idade;   Endereço;
            Receber em um laço todos os valores destacados nos itens. 
            Após receber todos os itens, exibir na tela as informações: Nome, idade e endereço de cada usuário “cadastrado”, 
            ordenando-os com um indicador numérico e mostrando-o de forma inversa.

            Exemplo: 
            2º, João, 18, R. das Rosas ; 
            1º, Maria, 19, R. das Tulipas; */
            int qtd,i;

            Console.WriteLine("Quantos usuários deseja cadastrar?");
            qtd = int.Parse(Console.ReadLine());

            Usuario[] usuario = new Usuario[qtd]; //criando o vetor de objetos

            for (i=0; i<qtd; i++) {
                usuario[i] = new Usuario(); //instanciando o objeto
                Console.WriteLine($"Digite o nome do {i+1}º usuário!");
                usuario[i].nome = Console.ReadLine();

                Console.WriteLine($"Digite a idade do {i+1}º usuário!");
                usuario[i].idade = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o endereço do {i+1}º usuário!");
                usuario[i].endereco = Console.ReadLine();
            }

            for (i=qtd-1; i>=0; i--) {
                Console.WriteLine($"{i+1}º {usuario[i].nome}, {usuario[i].idade} anos, {usuario[i].endereco}!");
            }

        }
    }
}
