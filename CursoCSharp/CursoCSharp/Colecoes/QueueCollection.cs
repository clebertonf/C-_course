using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class QueueCollection
    {
        public static void Executar()
        {
            /*
             * Fila Queue (conceito de uma fila)
             * O primeiro a entrar e o primeiro a sair
             * 
             * Enqueue adiciona um elemento ao final da Queue <T> .

               Dequeue remove o elemento mais antigo do início da Fila <T> .

               Peek peek retorna o elemento mais antigo que está no início da Fila <T>, mas não o remove da Fila <T> .
             */

            var fila = new Queue<string>();
            fila.Enqueue("Cleberton");
            fila.Enqueue("Bruno");
            fila.Enqueue("Thiago");

            Console.WriteLine(fila.Peek());

            // Queue sem o generics
            // posso utilizar qualquer tipo 

            var nomes = new Queue();
            nomes.Enqueue("Cleber");
            nomes.Enqueue(5);

            Console.WriteLine(nomes.Count);
        }
    }
}
