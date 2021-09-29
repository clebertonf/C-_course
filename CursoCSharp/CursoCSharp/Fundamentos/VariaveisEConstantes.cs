using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Area da circunferencia
            double raio = 5.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é: " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo :" + estaChovendo);

            byte idade = 28;
            Console.WriteLine("Sua idade é " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O saldo de gols é " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salario é: " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros
            Console.WriteLine("Menor int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial: " + populacaoMundial);


            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador é: " + precoComputador);

            double valorMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais!
            Console.WriteLine("Valor de mercado da Apple: " + valorMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas: " + distanciaEntreAsEstrelas); // Para valores muito grandes

            char letra = 'A'; // Aspas simples
            Console.WriteLine("A letra é: " + letra);

            string texto = "Uma cadeia de caracteres";
            Console.WriteLine(texto);
        }
    }
}
