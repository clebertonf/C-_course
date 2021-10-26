using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public static class Dicionario
    {
        public static void Executar()
        {
        // Todos métodos de dicionario:
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-5.0
            var filmes = new Dictionary<int, string>();
            filmes.Add(1, "Home aranha");
            filmes.Add(2, "Hora de aventura");

            foreach (var filme in filmes)
            {
                Console.WriteLine(filme);
            }

            // se passar um a chave fora do range ocorrerá um erro
            Console.WriteLine(filmes[1]);
            // se passar uma chave fora do range, retornará valor padrão 
            Console.WriteLine(filmes.GetValueOrDefault(1));

            // só chaves
            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            // só valores
            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            // chave e valor
            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine(filme);
            }

            // chave e valor (utilizando var e o compilador inferindo o tipo)
            foreach (var filme in filmes)
            {
                Console.WriteLine(filme);
            }
        }
    }
}
