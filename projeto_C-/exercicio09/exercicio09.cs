// 9. Jogo da Adivinhação
// Gere um número aleatório entre 1 e 100. Peça que o usuário tente adivinhar. Após cada
// tentativa, informe se o número é maior ou menor. Conte o número de tentativas.

namespace projeto_C_.exercicio09
{
    abstract class Exercicio09
    {
        public static void Execute()
        {
            Console.Clear();

			// Cria um número aleatório entre 0 e 100
			// Create a random number between 0 and 100
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(0, 101); 
            
            int numero;
            int tentativas = 0;

			// Cria um loop para o usuário tentar adivinhar o número
			// Create a loop for the user to try to guess the number
            do
            {
				// Incrementa a quantidade de tentativas do usuário em 1
				// Increment the number of attempts by 1
                tentativas++;

				// Solicita para que o usuário digite um número entre 0 e 100
				// Ask the user to enter a number between 0 and 100
                Console.WriteLine("Digite um numero entre 0 e 100");
                numero  = int.Parse(Console.ReadLine()); 

				// Verifica se o número digitado é maior, menor ou igual ao número aleatório
				// Check if the number entered is greater, less than or equal to the random number
                if(numero > numeroAleatorio){
                    Console.WriteLine("O numero " + numero + " é maior que o numero aleatorio");
                }else if( numero == numeroAleatorio){
                    Console.WriteLine("Voce acertou o numero " + numeroAleatorio + " é igual ao seu numero " + numero);
                }else{
                    Console.WriteLine("O numero " + numero + " é menor que o numero aleatorio");
                }

                
               // Imprime a quantidade de tentativas
			   // Print the number of attempts
                Console.WriteLine("\nTentativas: " + tentativas);
                
			// Verifica se o número digitado é igual ao número aleatório para sair do loop
			// Check if the number entered is equal to the random number to exit the loop
            } while (numeroAleatorio != numero);
        }
    }
}
