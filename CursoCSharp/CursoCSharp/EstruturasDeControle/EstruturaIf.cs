using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar() 
        {
            bool valor = false;

            if (valor)
            {
                Console.WriteLine("A variável é true");
                return;
            }

            Console.WriteLine("A variavel é False");
        }
    }
}
