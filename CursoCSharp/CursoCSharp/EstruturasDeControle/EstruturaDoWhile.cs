using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string valor = "s";

            do
            {
                Console.Write("O valor é verdadeiro");
                Console.Write("Continuar ? S / N ");
                valor = Console.ReadLine().ToLower();
            } while (valor == "s");

        }
    }
}
