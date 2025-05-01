// 10. Lista de Tarefas (To-Do List)
// Permita que o usuário adicione tarefas a uma lista e, ao final, mostre todas as tarefas
// inseridas. Use List<string> e ofereça uma opção para marcar tarefas como
// concluídas.
namespace projeto_C_.exercicio10
{
	abstract class Exercicio10
	{
		public static void Execute()
		{
			Console.Clear();

			Console.WriteLine("=== Seja bem vindo a Lista de Tarefas ===");

			List<string> tarefasParaFazer = [];
			List<string> tarefasResolvidas = [];

			int opcao;

			do {
				opcao = MostrarMenu();

				switch(opcao)
				{
					case 1:
						AdicionarNovaTarefa(tarefasParaFazer);
						break;
					case 2:
						ExibirTodasTarefas(tarefasParaFazer, tarefasResolvidas);
						break;
					case 3:
						ListarTarefasParaFazer(tarefasParaFazer);
						break;
					case 4:
						ListarTarefasResolvidas(tarefasResolvidas);
						break;
					case 5:
						MoverTarefaParaResolvida();
						break;
					case 0:
						Console.WriteLine("Saindo...");
						break;
					default:
						Console.Clear();
						Console.WriteLine("Opção inválida. Tente novamente.");
						break;
				}
			} while (opcao != 0);
		}

		private static int MostrarMenu() {
			while (true) 
			{
				try {
					Console.Clear();
					Console.WriteLine("=== Menu ===");
					Console.WriteLine("1 - Adicionar nova tarefa");
					Console.WriteLine("2 - Listar todas as tarefas");
					Console.WriteLine("3 - Listar tarefas para fazer");
					Console.WriteLine("4 - Listar tarefas resolvidas");
					Console.WriteLine("5 - Mover tarefa para resolvida");
					Console.WriteLine("0 - Sair");
					Console.WriteLine("Escolha uma opção: ");
					
					int opcao = int.Parse(Console.ReadLine());
					
					return opcao;
				} catch (FormatException) {
					Console.Clear();
					Console.WriteLine("Opção inválida. Tente novamente.\n");
				}
			}
		}

		private static void AdicionarNovaTarefa(List<string> tarefasParaFazer) {
			Console.Clear();
			Console.WriteLine("Digite a nova tarefa: ");
			string tarefa = Console.ReadLine();

			if (!string.IsNullOrEmpty(tarefa) && !tarefasParaFazer.Contains(tarefa)) {
				tarefasParaFazer.Add(tarefa);
				Console.WriteLine("Tarefa adicionada com sucesso!");
			} else {
				Console.WriteLine("Tarefa não pode ser vazia.");
			}
		}
		
		private static void ExibirTodasTarefas(List<string> tarefasParaFazer, List<string> tarefasResolvidas) {
			Console.Clear();

			ListarTarefasParaFazer(tarefasParaFazer);
			ListarTarefasResolvidas(tarefasResolvidas);

			Console.WriteLine("\nPressione ENTER para continuar...");
			Console.ReadKey();
		}

		private static void ListarTarefasParaFazer(List<string> tarefasParaFazer) {
			Console.WriteLine("=== Tarefas para fazer ===");
			if (tarefasParaFazer.Count == 0) {
				Console.WriteLine("Nenhuma tarefa encontrada.");
			} else {
				tarefasParaFazer.ForEach(Console.WriteLine);
			}
		}

		private static void ListarTarefasResolvidas(List<string> tarefasResolvidas) {
			Console.WriteLine("\n=== Tarefas resolvidas ===");
			if (tarefasResolvidas.Count == 0) {
				Console.WriteLine("Nenhuma tarefa resolvida.");
			}
			else {
				tarefasResolvidas.ForEach(Console.WriteLine);
			}
		}

		private static void MoverTarefaParaResolvida() {}
	}

}
