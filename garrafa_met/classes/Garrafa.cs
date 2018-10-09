namespace garrafa_met.classes
{
    public class Garrafa
    {
            private float conteudo = 1000;
            public float qtd; 

            public float Encher() {

                return qtd + conteudo;
            }

            public float Esvaziar() {

                return conteudo - qtd;
            }
            public float ExibirQuantia() {
               return conteudo;
            }
        
    }
}