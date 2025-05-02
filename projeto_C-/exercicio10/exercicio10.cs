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

			// Cria duas listas para armazenar as tarefas
			// Create two lists to store the tasks
			List<string> tarefasParaFazer = [];
			List<string> tarefasResolvidas = [];

			int opcao;

			do {
				// Chama o método MostrarMenu para exibir o menu e obter a opção do usuário
				// Calls the MostrarMenu method to display the menu and get the user's option
				opcao = MostrarMenu();

				switch(opcao)
				{
					case 1:
						// Chama o método AdicionarNovaTarefa para adicionar uma nova tarefa
						// Calls the AdicionarNovaTarefa method to add a new task
						AdicionarNovaTarefa(tarefasParaFazer);
						break;
					case 2:
						// Chama o método ExibirTodasTarefas para exibir todas as tarefas
						// Calls the ExibirTodasTarefas method to display all tasks
						ExibirTodasTarefas(tarefasParaFazer, tarefasResolvidas);
						break;
					case 3:
						// Chama o método ListarTarefasParaFazer para listar as tarefas para fazer
						// Calls the ListarTarefasParaFazer method to list the tasks to do
						ListarTarefasParaFazer(tarefasParaFazer);
						break;
					case 4:
						// Chama o método ListarTarefasResolvidas para listar as tarefas resolvidas
						// Calls the ListarTarefasResolvidas method to list the resolved tasks
						ListarTarefasResolvidas(tarefasResolvidas);
						break;
					case 5:
						// Chama o método MoverTarefaParaResolvida para mover uma tarefa para resolvida
						// Calls the MoverTarefaParaResolvida method to move a task to resolved
						MoverTarefaParaResolvida(tarefasParaFazer, tarefasResolvidas);
						break;
					case 0:
						// Encerra o programa
						// Ends the program
						Console.WriteLine("Saindo...");
						break;
					default:
						// Caso a opção não seja válida, exibe uma mensagem de erro
						// If the option is not valid, display an error message
						Console.Clear();
						Console.WriteLine("Opção inválida. Tente novamente.");
						break;
				}
			} while (opcao != 0);
		}

		private static int MostrarMenu() {
			// Exibe o menu e solicita a opção do usuário
			// Display the menu and ask for the user's option
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
					// Caso o usuário digite algo que não seja um número inteiro, exibe uma mensagem de erro
					// If the user enters something that is not an integer, display an error message
					Console.Clear();
					Console.WriteLine("Opção inválida. Tente novamente.\n");
				}
			}
		}

		private static void AdicionarNovaTarefa(List<string> tarefasParaFazer) {
			Console.Clear();

			// Solicita ao usuário que digite uma nova tarefa
			// Ask the user to enter a new task
			Console.WriteLine("Digite a nova tarefa: ");
			string tarefa = Console.ReadLine();

			// Verifica se a tarefa não está vazia e se já não existe na lista
			// Check if the task is not empty and if it does not already exist in the list
			if (!string.IsNullOrEmpty(tarefa) && !tarefasParaFazer.Contains(tarefa)) {
				// Adiciona a tarefa à lista de tarefas para fazer
				// Add the task to the to-do list
				tarefasParaFazer.Add(tarefa);
				Console.WriteLine("Tarefa adicionada com sucesso!");
			} else {
				// Caso a tarefa já exista ou esteja vazia, exibe uma mensagem de erro
				// If the task already exists or is empty, display an error message
				Console.WriteLine("Não pode cadastrar uma tarefa vazia ou já existente.");
			}

			// Solicita que o usuário cliente ENTER para continuar
			// Ask the user to press ENTER to continue
			Console.WriteLine("\nPressione ENTER para continuar...");
			Console.ReadKey();
		}
		
		private static void ExibirTodasTarefas(List<string> tarefasParaFazer, List<string> tarefasResolvidas) {
			Console.Clear();

			ListarTarefasParaFazer(tarefasParaFazer);
			ListarTarefasResolvidas(tarefasResolvidas);
		}

		private static void ListarTarefasParaFazer(List<string> tarefasParaFazer) {

			// Lista as tarefas para fazer caso existam, se não mostra que não tem nenhuma tarefa
			// List the tasks to do if they exist, otherwise show that there are no tasks
			Console.WriteLine("=== Tarefas para fazer ===");
			if (tarefasParaFazer.Count == 0) {
				Console.WriteLine("Nenhuma tarefa encontrada.");
			} else {
				tarefasParaFazer.ForEach(Console.WriteLine);
			}

			// Solicita que o usuário pressione ENTER para continuar
			// Ask the user to press ENTER to continue
			Console.WriteLine("\nPressione ENTER para continuar...");
			Console.ReadKey();
		}

		private static void ListarTarefasResolvidas(List<string> tarefasResolvidas) {

			// Lista as tarefas resolvidas caso existam, se não mostra que não tem nenhuma tarefa
			// List the resolved tasks if they exist, otherwise show that there are no tasks
			Console.WriteLine("\n=== Tarefas resolvidas ===");
			if (tarefasResolvidas.Count == 0) {
				Console.WriteLine("Nenhuma tarefa resolvida.");
			}
			else {
				tarefasResolvidas.ForEach(Console.WriteLine);
			}

			// Solicita que o usuário pressione ENTER para continuar
			// Ask the user to press ENTER to continue
			Console.WriteLine("\nPressione ENTER para continuar...");
			Console.ReadKey();
		}

		private static void MoverTarefaParaResolvida(List<string> tarefasParaFazer, List<string> tarefasResolvidas) {
			Console.Clear();

			// Lista todas as tarefas
			// List all tasks
			ListarTarefasParaFazer(tarefasParaFazer);
			ListarTarefasResolvidas(tarefasResolvidas);

			// Solicita ao usuário que digite o nome da tarefa que deseja mover para resolvida
			// Ask the user to enter the name of the task they want to move to resolved
			Console.WriteLine("Digite o nome da tarefa que deseja mover para resolvida: ");
			string tarefa = Console.ReadLine();

			// Verifica se a tarefa existe na lista de tarefas para fazer
			// Check if the task exists in the to-do list
			if (tarefasParaFazer.Contains(tarefa)) {
				// Move a tarefa da lista de tarefas para fazer para a lista de tarefas resolvidas
				// Move the task from the to-do list to the resolved tasks list
				tarefasParaFazer.Remove(tarefa);

				// Adiciona a tarefa à lista de tarefas resolvidas
				// Add the task to the resolved tasks list
				tarefasResolvidas.Add(tarefa);
				Console.WriteLine("Tarefa movida para resolvida com sucesso!");
			} else {
				// Caso a tarefa não exista, exibe uma mensagem de erro
				// If the task does not exist, display an error message
				Console.WriteLine("Tarefa não encontrada.");
			}

			// Solicita que o usuário pressione ENTER para continuar
			// Ask the user to press ENTER to continue
			Console.WriteLine("\nPressione ENTER para continuar...");
			Console.ReadKey();
		}
	}

}
