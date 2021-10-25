using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class SetCollection
    {
        public static void Executar()
        {
            /* 
             * HashSet não aceita repetição
             * Não é indexada
             * Geralmente é usado quando queremos evitar que elementos duplicados sejam colocados na coleção
             */
            var carrinho = new HashSet<Produto>
            {
                new Produto("Camiseta", 19),
                new Produto("Calça", 59)
            };

            Console.WriteLine(carrinho.Count);

        }
    }
}
