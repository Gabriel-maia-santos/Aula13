namespace Aula13Uber
{
    public class Usuario
    {
        
        // Propriedade resumida
        public string Nome { get; set; }

        //Propriedade completa
        private int idade;
        public int Idade
        {
            get { return idade; }
            set {
                if(idade > 0){
                idade = value;
                }
            }
        }

        public string Foto {get;set;}
        private string login = "gabriel@gmail.com";
        private string senha = "123456";

        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        public string TipoAcesso { get; set; }


        public bool Login( string login, string senha ){

            if( this.login == login && this.senha == senha ){
                TokenLogin = "90341094u194h901h4192h4h012h4012";
                return true;
            }
            return false;
        }

        public void Logout(){
            TokenLogin = "";
        }
        

    }
}