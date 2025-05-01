// 9. Jogo da Adivinhação
// Gere um número aleatório entre 1 e 100. Peça que o usuário tente adivinhar. Após cada
// tentativa, informe se o número é maior ou menor. Conte o número de tentativas.

using System.Security.Cryptography;

namespace projeto_C_.exercicio9
{
    abstract class Exercicio09
    {
        public static void Execute()
        {
            Console.Clear();

            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(0, 101); 
            
            int numero;
            int tentativas = 0;

            do 
            {
                tentativas++;

                Console.WriteLine("Digite um numero entre 0 e 100");
                numero  = int.Parse(Console.ReadLine()); 

                if(numero > numeroAleatorio){
                    Console.WriteLine("O numero " + numero + " é maior que o numero aleatorio");
                }else if( numero == numeroAleatorio){
                    Console.WriteLine("Voce acertou o numero " + numeroAleatorio + " é igual ao seu numero " + numero);
                }else{
                    Console.WriteLine("O numero " + numero + " é menor que o numero aleatorio");
                }

                
               
                Console.WriteLine("\nTentativas: " + tentativas);
                
            } while (numeroAleatorio != numero);
        }
    }
}