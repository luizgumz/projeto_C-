namespace projeto_C_.exercicio6
{
	class Produto
	{
		public string Nome { get; set; }
		public double Preco { get; set; }
		public int Quantidade { get; set; }

		public Produto(string nome, double preco, int quantidade)
		{
			Nome = nome;
			Preco = preco;
			Quantidade = quantidade;
		}

		public string getProdutoInfo() {
			return $"Nome: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}, Valor Total: {getValorTotal()}";
		}

		private double getValorTotal() {
			return Preco * Quantidade;
		}
	}
}
