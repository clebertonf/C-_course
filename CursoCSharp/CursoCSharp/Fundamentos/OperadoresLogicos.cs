using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar() 
        {
            var valorTrue = true;
            var valorFalse = false;

            Console.WriteLine("Operador $$ (e)");

            // &&
            Console.WriteLine(valorTrue && valorTrue);
            Console.WriteLine(valorTrue && valorFalse);
            Console.WriteLine(valorFalse && valorTrue);
            Console.WriteLine(valorFalse && valorFalse);

            Console.WriteLine("Operador || (ou)");

            // ||
            Console.WriteLine(valorTrue || valorTrue);
            Console.WriteLine(valorTrue || valorFalse);
            Console.WriteLine(valorFalse || valorTrue);
            Console.WriteLine(valorFalse || valorFalse);

            Console.WriteLine("Operador ! (negação) inverte a resposta");

            // ||
            Console.WriteLine(!(valorTrue || valorTrue));
            Console.WriteLine(!(valorTrue || valorFalse));
            Console.WriteLine(!(valorFalse || valorTrue));
            Console.WriteLine(!(valorFalse || valorFalse));


        }
    }
}
