using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1; // sem passar visibilidade por padrão sera private
        string nome;
        public string Nome
        {
            get { return "Opcional:" + nome; }
            set { nome = value; }
        }

        // Propriedade auto implementada
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoDesconto { get => Preco - (desconto * Preco); } // Lambda
        // get { reurtn Preco - (desconto * Preco);}  (Segunda forma)

        public CarroOpcional() { }

        public CarroOpcional(string nome, int preco) 
        {
            this.nome = nome;
            Preco = preco;
        }
    }

    class Props_getSet_
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3999);
            Console.WriteLine(op1.PrecoDesconto); // O C# entende que é um acesso a uma prorpiedade e utiliza os get / set

            var op2 = new CarroOpcional();
            op2.Nome = "Direção elétrica";  // o C# utiliza internamente o set para setar o valor, isso não é um acesso direto a atributo
            op2.Preco = 2349;
            Console.WriteLine(op1.Nome);
        }
    }
}
