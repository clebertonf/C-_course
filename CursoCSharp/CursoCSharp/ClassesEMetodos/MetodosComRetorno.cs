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

        class CalculadoraCadeia
        {
           int memoria; // Variavel interna do método

            public CalculadoraCadeia Somar (int a)
            {
                memoria += a;
                return this; // Retornando o objeto (retorna a prorpria CalculadoraCadeia Somar )
                // Pode-se quando instânciar utilizar a notação ponto
            }

            public CalculadoraCadeia multiplicar(int a)
            {
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Imprimir()
            {
                Console.WriteLine(memoria);
                return this;
            }

            public CalculadoraCadeia Limpar()
            {
                memoria = 0;
                return this;
            }

            public int Resultado() // neste caso as proximas funçoes para encadear seriam as de inteiro, pois esse metodo retorna um inteiro 
            {
               return memoria;
            }
        }

        public static void Executar()
        {
            // Calculadora Normal
            var calculadora = new Calculadora();
            Console.WriteLine(calculadora.Somar(5, 15));
            Console.WriteLine(calculadora.Subtrair(5, 15));
            Console.WriteLine(calculadora.Multiplicar(5, 15));

            // Calculadora Cadeia

            var calculadoraCadeia = new CalculadoraCadeia();
            // Desta forma podemos usar notação ponto
            calculadoraCadeia.Somar(5).Somar(5).multiplicar(3).Imprimir();
        }
    }
}
