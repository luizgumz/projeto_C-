using System;
using System.Globalization;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace projeto_C_.exercicio01
{
    abstract class Exercicio01
    {
        public static void Execute() 
        {
            

            string password;
            bool passwordValidation = false;
            bool isUpperCase = false;
            bool isNumber = false;
            bool isSpecial = false;

            bool isNullOrEmpty = false;

            while(passwordValidation == false)
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("=== Exercicio 01 ===");
                    Console.WriteLine("Digite uma senha: ");
                    password = Console.ReadLine();

                    isNullOrEmpty = string.IsNullOrWhiteSpace(password);

                    if(isNullOrEmpty) 
                    {
                        Console.WriteLine("Erro 1: A senha não deve ser nula ou vazia!\n\n");
                        Console.Clear();
                    }
                }
                while(isNullOrEmpty);

                foreach(char s in password)
                {
                    if(char.IsUpper(s))
                    { 
                        isUpperCase = true;
                        continue;
                    }
                    if(char.IsDigit(s))
                    {
                        isNumber = true;
                        continue;
                    }
                    if("!@#$%¨*()+_=-|/?\\".Contains(s))
                    {
                        isSpecial = true;
                        continue;
                    } 
                }
				
                if(!isUpperCase) Console.WriteLine("Deve conter pelo menos um caractere maiúsculo.\n");
                if(!isNumber) Console.WriteLine("Deve conter pelo menos um número.\n");
                if(!isSpecial) Console.WriteLine("Deve conter pelo menos um caractere especial.\n");
                if(password.Length < 8) Console.WriteLine("Deve conter pelo menos 8 caracteres.\n");

                //Verifica tudo
                if(password.Length >= 8 && isUpperCase && isNumber && isSpecial) {
					passwordValidation = true;
					Console.WriteLine("Senha validada com sucesso!");
				} else {
					Console.WriteLine("\n\n\n=============================");
					Console.WriteLine("Limpando a tela em 3 segundos!");
					Thread.Sleep(3_000);
				}
            }
        } 
    }
}
