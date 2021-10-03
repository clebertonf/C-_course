using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosEstaticos
    {
        public class CalculadoraEstatica 
        {
            // metodo de classe ou estatico (pode ser acessado sem instanciar a classe)
            public static int somar(int a, int b)
            {
                return a + b;
            }

            // metodo de classe ou estatico
            public static int multiplicar(int a, int b)
            {
                return a * b;
            }

            // metodo de instancia (preciso instanciar a classe para utilizar o metodo)
            public int dividir(int a, int b)
            {
                return a / b;
            }
        }
        public static void Executar()
        {
            var soma = CalculadoraEstatica.somar(15, 2);
            Console.WriteLine(soma);

            var mulpiplica = CalculadoraEstatica.multiplicar(15, 9);
            Console.WriteLine(mulpiplica);

            var divide = new CalculadoraEstatica();
            Console.WriteLine(divide.dividir(10, 2));
        }
    }
}
