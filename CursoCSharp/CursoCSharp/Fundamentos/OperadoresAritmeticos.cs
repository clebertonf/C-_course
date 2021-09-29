using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var valorTotalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final com desconto é: {valorTotalComDesconto}");

            // IMC
            double peso = 72.0;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); // Pow elevaa potência
            Console.WriteLine("Imc é: {0}", imc);

            // Par ou impar

            int numeroPar = 2;
            int numeroImpar = 3;

            Console.WriteLine(numeroPar % 2); // Resto zero (0) é par
            Console.WriteLine(numeroImpar % 2); // Resto um (1) impar é um
            
        }
    }
}
