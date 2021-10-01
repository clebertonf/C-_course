using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosComRetorno
    {
        class Calculadora
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Subtrair(int a, int b)
            {
                return a - b;
            }

            public int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }
        public static void Executar()
        {
            var calculadora = new Calculadora();
            Console.WriteLine(calculadora.Somar(5, 15));
            Console.WriteLine(calculadora.Subtrair(5, 15));
            Console.WriteLine(calculadora.Multiplicar(5, 15));
        }
    }
}
