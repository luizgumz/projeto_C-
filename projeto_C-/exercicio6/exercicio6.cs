// 6. Cadastro Simples de Produtos
// Crie uma classe Produto com propriedades Nome, Preço e Quantidade. Permita ao
// usuário cadastrar 3 produtos e depois liste todos com o valor total em estoque (Preço *
// Quantidade).

using System.Runtime.ConstrainedExecution;

namespace projeto_C_.exercicio6
{
	abstract class Exercicio06
	{
		private static int QUANTIDADE_PRODUTO = 3;

		public static void Execute()
		{
			Console.Clear();

			List<Produto> produtos = new List<Produto>();

			Console.WriteLine("Cadastro de Produtos");
			for (int i = 0; i < QUANTIDADE_PRODUTO; i++) {
				Console.WriteLine($"\nProduto {i + 1}:");
				
				Console.Write("Nome: ");
				string nome = Console.ReadLine();

				Console.Write("Preço: ");
				double preco = double.Parse(Console.ReadLine());
				
				Console.Write("Quantidade: ");
				int quantidade = int.Parse(Console.ReadLine());

				produtos.Add(new Produto(nome, preco, quantidade));
			}

			Console.WriteLine("\nLista de Produtos:");

			produtos.ForEach((produto) => {
				Console.WriteLine(produto.getProdutoInfo());
			});
		}
	}
}
