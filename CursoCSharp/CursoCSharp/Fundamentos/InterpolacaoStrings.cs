using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class InterpolacaoStrings
    {
        public static void Executar()
        {
            string nome = "Notbook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // Primeira forma de interpolação
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            // Segunda forma de interpolação (mais eficiente)
            Console.WriteLine($"A marca de computadores {marca} é muito Boa!");

            // Terceira forma de interpolação (mais eficiente)
            Console.WriteLine("O {0} da marca {1} custa {2}", nome, marca, preco);
        }
    }
}
