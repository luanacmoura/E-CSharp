using System;
namespace porta_met.classes
{
    public class Porta
    {
        public bool aberta = false; //começa fechado

        public void Abrir(){
            if (aberta==false){ //se estiver fechado ele abre
                Console.WriteLine("A porta abriu!");
            }
            else { //senão não precisa fazer nada
                Console.WriteLine("Não precisa se esforçar pra nada!");
            }
        }

        public void Fechar(){ 
            if (aberta==true){ // se estiver aberta ele fecha a porta
                Console.WriteLine("A porta fechou!");
            }
            else { // senão já está fechada!
                Console.WriteLine("Porta já está fechada!");
            }
        }
    }
}