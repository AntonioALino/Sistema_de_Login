using System;
using System.Reflection.Metadata.Ecma335;

public class Sistema_de_Login
{
    static void Main(string[] args)
    {

        // Sistema que verifica se o usuário tem acesso ou não, caso ele tiver ele printa uma mensagem de bem vindo, caso não ele dará 5 chances
        // para o usuário continuar tentando, se nessas 5 chances ele ainda assim errar, ele encerra o programa.

        string acesso;

        string usuário;

        int senha;

        int tentativas;

        Console.WriteLine("Você deseja acessar o programa?");
        acesso = Console.ReadLine();    

       for(int i = 0; i < 5; i++) {

            if (acesso == "Sim")
            {
                Console.WriteLine("informe seu usuário");
                usuário = Console.ReadLine();


                Console.WriteLine("Informe sua senha");
                senha = int.Parse(Console.ReadLine());


                if (usuário == "Antonio" && senha == 0)
                {
                    Console.WriteLine("Seja muito bem-vindo Antonio");
                    break;
                }
                else
                {
                    Console.WriteLine("Você errou a senha, tente novamente");
                    
                }

            }
            else
            {
                Console.WriteLine("Até mais");
            }

        }
    }

    
}