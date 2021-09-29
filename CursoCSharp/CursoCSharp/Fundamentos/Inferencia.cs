using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Cleberton"; // O proprio C# olha o tipo do dado e faz a inferência
            Console.WriteLine(nome);

            // As variáveis de tipo implicito sempre devem ser inicializadas com um valor

            // Criando a variável
            int a;
            a = 3;

            // Criando e atribuindo um valor
            int b = 2;

            Console.WriteLine(a + b);

        }
    }
}
