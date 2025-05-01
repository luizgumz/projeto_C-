using projeto_C_.exercicio1;
using projeto_C_.exercicio2;
using projeto_C_.exercicio3;
using projeto_C_.exercicio4;

while(true) {
	try {		
		Console.WriteLine("Exercicios C#");
		Console.WriteLine("1. Exercicio 01");
		Console.WriteLine("2. Exercicio 02");
		Console.WriteLine("3. Exercicio 03");
		Console.WriteLine("4. Exercicio 04");
		Console.WriteLine("5. Exercicio 05");
		Console.WriteLine("6. Exercicio 06");
		Console.WriteLine("7. Exercicio 07");
		Console.WriteLine("8. Exercicio 08");
		Console.WriteLine("9. Exercicio 09");
		Console.WriteLine("10. Exercicio 10\n");

		Console.WriteLine("Qual exercício deseja testar ?");
		int option = int.Parse(Console.ReadLine());
		
		switch(option) {
			case 1:
				Exercicio01.Execute();
				break;
			case 2:
				Exercicio02.Execute();
				break;
			case 3:
				Exercicio03.Execute();
				break;
			default:
				Console.WriteLine("Digite uma opção válida!");
				break;
		}
	} 
	catch (FormatException)
	{
		Console.WriteLine("Digite uma opção válida!");
	}
	finally
	{
		Console.WriteLine("\n\n\n=============================");
		Console.WriteLine("Limpando a tela em 3 segundos!");
		Thread.Sleep(3_000);
		Console.Clear();
	}
}
