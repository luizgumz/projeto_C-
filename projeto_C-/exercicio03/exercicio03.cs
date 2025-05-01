// 3. Cálculo de Fatorial com while
// Peça ao usuário um número inteiro positivo e calcule o fatorial desse número usando
// while.
namespace projeto_C_.exercicio03
{
	abstract class Exercicio03
	{
		public static void Execute()
		{
			while(true) {
				try {
					Console.Clear();

					//Receivs a number from the user
					//Recebe um número do usuário
					Console.WriteLine("Digite um número: ");
					int number = int.Parse(Console.ReadLine());

					bool isValidNumber = number > 0;

					//Verified if is a positiv number
					//Verifica se é um número positivo
					if (!isValidNumber) {
						Console.WriteLine("Você deve digitar um número positivo!");
						Thread.Sleep(3_000);
						continue;
					}

					//Creates variables number and fatorial
					//Cria as variáveis número e fatorial
					int fatorial = 1;
					int i = number;

					while (i > 0) {
						fatorial *= i;
						i--;
					}

					//Print the results
					//Imprime os resultados
					Console.WriteLine($"O fatorial de {number} é {fatorial}");
					break;

				} catch (FormatException) {
					Console.WriteLine("Digite um número válido");
					Thread.Sleep(3_000);
				}
			}
		}
	}	
}
