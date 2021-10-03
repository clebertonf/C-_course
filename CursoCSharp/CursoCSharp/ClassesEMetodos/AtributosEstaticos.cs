using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class AtributosEstaticos
    {
        class Produto
        {
            public string Nome { get; set; }
            public double Preco { get; set; }
            public static double Desconto { get; set; } // É um atributo compartilhado para todas as instancias, e não é acessivel atraves do objeto instanciado
            // Agora é um atributo que é compartilhado entre todas as classes com um valor padrão para todas

            public Produto(string nome, double preco, double desconto)
            {
                Nome = nome;
                Preco = preco;
                Desconto = desconto;
            }

            public Produto() { }

            public double CalcularDesconto()
            {
                return Preco - Preco * Desconto;
            }

        }
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 6, 0.1);
            var produto2 = new Produto("Borracha", 4, 0.3);

            var produto3 = new Produto()
            {
                Nome = "Apontador",
                Preco = 3,
            };

            Produto.Desconto = 0.5; // Como o atributo é statico podemos acessar aqui e todas as instancias terão 50 % de desconto

            Console.WriteLine(produto1.CalcularDesconto());
            Console.WriteLine(produto2.CalcularDesconto());
            Console.WriteLine(produto3.CalcularDesconto());

            // O acesso do atributo estatico dentro da classe pode ser acessado direto
            // E fora da classe deve ser acessado atraves da classe (classe.atributo)
        }
    }
}
