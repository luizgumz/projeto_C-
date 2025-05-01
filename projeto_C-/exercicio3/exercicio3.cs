// 3. Cálculo de Fatorial com while
// Peça ao usuário um número inteiro positivo e calcule o fatorial desse número usando
// while.
namespace projeto_C_.exercicio3
{
	abstract class Exercicio03
	{
		public static void Execute()
		{
			while(true) {
				try {
					Console.Clear();

					Console.WriteLine("Digite um número: ");
					int number = int.Parse(Console.ReadLine());

					bool isValidNumber = number > 0;

					if (!isValidNumber) {
						Console.WriteLine("Você deve digitar um número positivo!");
						Thread.Sleep(3_000);
						continue;
					}

					int fatorial = 1;
					int i = number;

					while (i > 0) {
						fatorial *= i;
						i--;
					}

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
