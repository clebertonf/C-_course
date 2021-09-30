using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            // Deve retornar um tipo que é esperado pela variável
            var nota = 7.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reporvado";
            Console.WriteLine(resultado);
        }
    }
}
