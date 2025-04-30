using System;
using System.Globalization;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace projeto_C_.exercicio1
{
    abstract class Exercicio01
    {
        /*
        Mínimo de 8 caracteres 
        Pelo menos uma letra maiúscula 
        Pelo menos um número 
        Pelo menos um caractere especial (ex: !, @, #)
        */
        public static void Execute() 
        {
            Console.Clear();

            string senha;
            bool validacaoSenha = false;
            bool verificacaoMaiuscula = false;
            bool verificacaoNumero = false;
            bool verificacaoEspecial = false;


			Console.WriteLine("=== Exercicio 01 ===");
            Console.WriteLine("Digite uma senha: ");
            senha = Console.ReadLine();

            foreach(char s in senha)

            

			Console.WriteLine("================");
        }
    }
}
