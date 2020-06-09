using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro gabriel = new Passageiro();

            System.Console.WriteLine("Digite seu login");
            string login =  Console.ReadLine();

            System.Console.WriteLine("Digite sua senha");
            string senha =  Console.ReadLine();

            gabriel.Login(login, senha);

            if( gabriel.TokenLogin != "" && gabriel.TokenLogin != null ){
                System.Console.WriteLine("Login Autorizado!");
                System.Console.WriteLine(gabriel.TokenLogin);
            }else{
                System.Console.WriteLine("Acesso negado");
            }
        }
    }
}
