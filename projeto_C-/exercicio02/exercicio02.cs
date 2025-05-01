/*
2. Tabuada Completa com Laço Solicite ao usuário um número e imprima a tabuada completa dele (de 1 a 10), utilizando um for.
*/

namespace projeto_C_.exercicio02
{
    abstract class Exercicio02
    {
        public static void Execute() 
        {
			try
			{
				Console.Clear();
				
				//Recebe do usuário qual número da tabuada ele gostaria de ver
				//Receiv from user which multiplication table it would like to see
				Console.WriteLine("=== Exercicio 02 ===");
				Console.WriteLine("Qual tabuada gostaria de ver ?");
				int number = int.Parse(Console.ReadLine());

				//Imprime a tabuada
				//print the multiplication table
				for (int i = 0; i <= 10; i++) 
				{
					Console.WriteLine($"{number} x {i} = {number * 1}");
				}
			} 
			catch (FormatException)
			{
				Console.WriteLine("Formato inválido");
			}
        }
    }
}
