using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ArrayListColection
    {
        public static void Executar()
        {
            /*
             * ArrayList é uma coleção não genérica de objetos cujo tamanho aumenta dinamicamente .
             * É o mesmo que Array, exceto que seu tamanho aumenta dinamicamente. Um ArrayList pode 
             * ser usado para adicionar dados desconhecidos onde você não conhece os tipos e o tamanho 
             * dos dados.
            */

            var arrayListValues = new ArrayList
            {
                "Palavra",
                10,
                true
            };

            Console.WriteLine(arrayListValues.Count);
            arrayListValues.Add(false);
            Console.WriteLine(arrayListValues.Count);

        }
    }
}
 