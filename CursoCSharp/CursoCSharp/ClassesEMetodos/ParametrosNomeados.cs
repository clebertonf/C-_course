using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano); // D2 e os outros são ao formatação de casas decimais
        }
        public static void Executar()
        {
            // sem nomeação
            Formatar(21, 09, 1993);

            // A passagem de parâmetros nomeados tem a intenção de deixar mais claro o código
            Formatar(dia: 02, mes: 10, ano: 2021);
        }
    }
}
