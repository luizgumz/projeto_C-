namespace projeto_C_.exercicio06
{
	class Produto
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public int Quantity { get; set; }

		public Produto(string nome, double preco, int Quantity)
		{
			Name = nome;
			Price = preco;
			this.Quantity = Quantity;
		}

		public string getProdutoInfo() {
			return $"Nome: {Name}, Preço: {Price}, Quantidade: {Quantity}, Valor Total: {getValorTotal()}";
		}

		private double getValorTotal() {
			return Price * Quantity;
		}
	}
}
