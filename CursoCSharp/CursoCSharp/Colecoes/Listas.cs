using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public Produto(string nome, int preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string Nome { get; set; }
        public int Preco { get; set; }
    }
    class Listas
    {
        public static void Executar()
        {
            var livro = new Produto("Celular", 1990);
            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var variosProdutos = new List<Produto>
            {
                new Produto("Smart Tv", 3900),
                new Produto("Compuador", 5900),
                new Produto("Monitor", 5900)
            };

            carrinho.AddRange(variosProdutos);

            foreach (var produto in carrinho)
            {
                Console.WriteLine($"{produto.Nome} {produto.Preco}");
            }
        }
    }
}
