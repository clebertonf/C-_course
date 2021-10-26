using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Camiseta", 19);
            var p2 = new Produto("Camiseta", 19);
            var p3 = p2;

            Console.WriteLine(p1 == p2); // compara endereço de memoria
            Console.WriteLine(p3 == p2);

            Console.WriteLine(p1.Equals(p2)); // compara endereço de memoria

            // Propria IDE gera o equals / getHashcode (para poder fazer comparação por valor e não por referencia)
        }
    }
}