/*
2. Tabuada Completa com Laço Solicite ao usuário um número e imprima a tabuada completa dele (de 1 a 10), utilizando um for.
*/

namespace projeto_C_.exercicio2
{
    abstract class Exercicio02
    {
        public static void Execute() 
        {
			try
			{
				Console.WriteLine("=== Exercicio 02 ===");
				Console.WriteLine("Qual tabuada gostaria de ver ?");
				int num = int.Parse(Console.ReadLine());

				for (int i = 0; i <= 10; i++) 
				{
					Console.WriteLine($"{num} x {i} = {num * 1}");
				}
			} 
			catch (FormatException)
			{
				Console.WriteLine("Formato inválido");
			}
        }
    }
}
