using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é sua idade?");
            int idade = int.Parse(Console.ReadLine());

            // CultureInfo.InvariantCulture é utilizado para sempre ser utiliado o ponto (.) para separador de casas deciamis
            Console.WriteLine("Qual é seu Salario?");
            int salario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Ola {nome} você tem {idade} anos!");

        }
    }
}
