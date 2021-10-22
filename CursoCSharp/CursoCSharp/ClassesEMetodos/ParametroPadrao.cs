using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        // Parametros da função sendo passados por padrão
        public static int Somar(int a = 5, int b = 7)
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(3));
            Console.WriteLine(Somar(b: 10));
        }
    }
}
