using System;
using System.Globalization;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace projeto_C_.exercicio1
{
    abstract class Exercicio01
    {
        public static void Execute() 
        {
            Console.Clear();

            string password;
            bool passwordValidation = false;
            bool isUpperCase = false;
            bool isNumber = false;
            bool isSpecial = false;

            bool isNullOrEmpty = false;


            


            while(passwordValidation == false)
            {
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
                    if(char.IsUpper(s)) isUpperCase = true;
                    if(char.IsDigit(s)) isNumber = true;
                    if("!@#$%¨*()+_=-|/?\\".Contains(s)) isSpecial = true; 
                }

                if(password.Length >= 8 && isUpperCase && isNumber && isSpecial)
                {
                    passwordValidation = true;
                }
            }
        } 
    }
}
