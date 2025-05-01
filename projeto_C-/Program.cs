using projeto_C_.exercicio01;
using projeto_C_.exercicio02;
using projeto_C_.exercicio03;
using projeto_C_.exercicio04;
// using projeto_C_.exercicio05;
using projeto_C_.exercicio06;
using projeto_C_.exercicio07;
using projeto_C_.exercicio08;
using projeto_C_.exercicio09;
using projeto_C_.exercicio10;

Console.OutputEncoding = System.Text.Encoding.UTF8;

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
			case 4:
				Exercicio04.Execute();
				break;
			case 6:
				Exercicio06.Execute();
				break;
			case 7:
			 	Exercicio07.Execute();
			 	break;
			case 8:
				Exercicio08.Execute();
				break;
			case 9:
				Exercicio09.Execute();
				break;
			case 10:
				Exercicio10.Execute();
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
		Console.WriteLine("\n=============================");
		Console.WriteLine("Pressione ENTER para continuar!");
		
		Console.ReadKey();
	}
}
