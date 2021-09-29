using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Arrendondou para cima em uma casa decimal
            Console.WriteLine(valor.ToString("C")); // Currency - formata para valor real (moeda)
            Console.WriteLine(valor.ToString("P")); // Percentual multiplica por 100 e adiciona o %
            Console.WriteLine(valor.ToString("#.##")); // Formata para 2 casas decimais
            Console.WriteLine(valor.ToString("F2")); // Formata para duas casas também

            CultureInfo  cultura = new CultureInfo("en-US"); // Define a cultura da formatação (pt-BR, en-US) etc
            Console.WriteLine(valor.ToString("C0", cultura)); // Moeda sem casas decimais

            // Add zeros a esquerda
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Adiciona 7 zeros a direita (para o numero inteiro ter 10 casas decimais)
        }
    }
}
