namespace Exercicio03
{
    class Program 
    {
        public static void Main(string[] args)
        {
           Produto produto = new Produto("Arroz", 4, 12.2f);
           Console.WriteLine($"O Preço total do produto SEM desconto: {produto.precoTotal:0.00}");
           
           Console.WriteLine($"O Preço total do produto COM desconto: {produto.precoTotalComDesconto:0.00}");
           
        }
        
        class Produto
        {
            public string ?nome;
            public float quantidade;
            public float precoUnitario;
            public float precoTotal;
            public float precoTotalComDesconto;

            public Produto(string nome, float quantidade, float precoUnitario) 
            {
                this.nome = nome;
                this.quantidade = quantidade;
                this.precoUnitario = precoUnitario;
                this.CalculaPrecoTotal();
                this.CalculaPrecoComDesconto();
            }

            public void CalculaPrecoTotal()
            {
                this.precoTotal = this.quantidade * this.precoUnitario;
            }

            public void CalculaPrecoComDesconto()
            {
                if(this.quantidade <= 5)
                {
                    this.precoTotalComDesconto = this.precoTotal - (this.precoTotal * 0.02f);
                } else if (this.quantidade > 5 && this.quantidade <= 10)
                {
                    this.precoTotalComDesconto = this.precoTotal - (this.precoTotal * 0.03f);
                } else if (this.quantidade > 10)
                {
                    this.precoTotalComDesconto = this.precoTotal - (this.precoTotal * 0.05f);
                }
            }
        }
    }
}