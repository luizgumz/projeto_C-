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
            //Variáveis criadas para cada realizar cada verificação separadamente
            //Variables created for each verification separately
            string password;
            bool passwordValidation = false;
            bool isUpperCase = false;
            bool isNumber = false;
            bool isSpecial = false;

            bool isNullOrEmpty = false;

            while(passwordValidation == false)
            {
                Console.Clear();

                //loop's verification to make sure users does'nt write the password correcly(not sending an null or empty input)
                //Verificação em loop para garantir que o usuário escreva o input corretamente(não enviando um input nulo ou vazio)
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

                //Percorre o vetor de caracteres(senha) fazendo as verificações durante o processo
                //It goes through the caracter's array(password) making checks during the process
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
				
                //Imprime o erro para o usuário do que precisa ser corrigido
                //Print the error so the user know what's need to be corrected
                if(!isUpperCase) Console.WriteLine("Deve conter pelo menos um caractere maiúsculo.\n");
                if(!isNumber) Console.WriteLine("Deve conter pelo menos um número.\n");
                if(!isSpecial) Console.WriteLine("Deve conter pelo menos um caractere especial.\n");
                if(password.Length < 8) Console.WriteLine("Deve conter pelo menos 8 caracteres.\n");

                //Se todas as verificações anteriores forem verdade a muda a ValidaçãoSenha então saindo do vetor
                //If every verification ubove are true it changes the main validation and print "success"
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
