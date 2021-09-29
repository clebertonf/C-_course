using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            // Operadores Realcionais (O resultado destas operações é verdadeiro ou falso)
            int numero1 = 10;
            int numero2 = 15;

            Console.WriteLine(numero1 > numero2);
            Console.WriteLine(numero1 < numero2);
            Console.WriteLine(numero1 == numero2);
            Console.WriteLine(numero1 != numero2);
            Console.WriteLine(numero1 >= numero2);
            Console.WriteLine(numero1 <= numero2);
        }
    }
}
