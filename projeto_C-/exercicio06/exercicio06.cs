// 6. Cadastro Simples de Produtos
// Crie uma classe Produto com propriedades Nome, Preço e Quantidade. Permita ao
// usuário cadastrar 3 produtos e depois liste todos com o valor total em estoque (Preço *
// Quantidade).

using System.Runtime.ConstrainedExecution;

namespace projeto_C_.exercicio06
{
	abstract class Exercicio06
	{
		private static int QUANTIDADE_PRODUTO = 3;

		public static void Execute()
		{
			Console.Clear();

			List<Produto> produtos = new List<Produto>();

			//Percorre a lista Quantidade_produto e insere os requisitos conforme entrada do usuário
			//Goes throught the list Quantity_product and insert the requirements as per user input
			Console.WriteLine("Cadastro de Produtos");
			for (int i = 0; i < QUANTIDADE_PRODUTO; i++) {
				Console.WriteLine($"\nProduto {i + 1}:");
				
				Console.Write("Nome: ");
				string name = Console.ReadLine();

				Console.Write("Preço: ");
				double price = double.Parse(Console.ReadLine());
				
				Console.Write("Quantidade: ");
				int quantity = int.Parse(Console.ReadLine());

				produtos.Add(new Produto(name, price, quantity));
			}

			Console.WriteLine("\nLista de Produtos:");

			produtos.ForEach((produto) => {
				Console.WriteLine(produto.getProdutoInfo());
			});
		}
	}
}
