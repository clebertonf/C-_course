using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorDeAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10
            num1 -= 10; // num1 = num1 - 10
            num1 *= 10; // num1 = num1 * 10
            num1 /= 10; // num1 = num1 / 10

            Console.WriteLine(num1);

            // Atribuir valor de variável a outra variável
            int a = 10;
            int b = a;

            Console.WriteLine(b);

            // Compartilhando o mesmo espaço de memoria

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);
        }
    }
}
