using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ValorVsReferencia
    {
        public class Dependente 
        {
            public string Nome;
            public int Idade;
        }
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;

            Console.WriteLine($"Numero: {numero} / Copia: {copiaNumero}");

            numero++;

            Console.WriteLine($"Numero ++: {numero}");

            Dependente dep = new Dependente { Nome = "Cleber", Idade = 28 };

            Dependente copiaDep = dep;

            Console.WriteLine($"Dependente:{dep.Nome} / Copia: {copiaDep.Nome}");

            copiaDep.Nome = "Francisco";

            Console.WriteLine($"Dependente:{dep.Nome} / Copia: {copiaDep.Nome}");

        }
    }
}
