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
            // Passagem por valor (Tanto o nuemro como a copia são independentes)
            // Struct e por valor
            int numero = 3;
            int copiaNumero = numero;

            Console.WriteLine($"Numero: {numero} / Copia: {copiaNumero}");

            // Se alteramos o numero aqui, ele não afeta a copia (pois a passagem é feita por valor)
            numero++;

            // Passagem por valor
            Console.WriteLine($"Numero ++: {numero}");

            // Ja a classe e por referencia, então caso a variavel seja alterada suas copias tambem serão
            // pois a copia é somente uam referencia na memoria
            Dependente dep = new Dependente { Nome = "Cleber", Idade = 28 };

            Dependente copiaDep = dep;

            Console.WriteLine($"Dependente:{dep.Nome} / Copia: {copiaDep.Nome}");

            copiaDep.Nome = "Francisco";

            Console.WriteLine($"Dependente:{dep.Nome} / Copia: {copiaDep.Nome}");

        }
    }
}
