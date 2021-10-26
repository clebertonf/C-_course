using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class StackCollections
    {
        public static void Executar()
        {
            /*
                 Todos métodos da stack estão em:
            https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-5.0

                O primeiro a entrar é o ultimo a sair
             */
            var pilha = new Stack();
            pilha.Push("Cleber");
            pilha.Push(10);
            pilha.Push(true);

            foreach (var values in pilha)
            {
                Console.WriteLine(values);
            }
        }
    }
}
