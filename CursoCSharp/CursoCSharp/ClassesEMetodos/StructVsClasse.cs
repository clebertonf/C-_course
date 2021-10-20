using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int x;
        public int y;
    }

    public class CPonto
    {
        public int x;
        public int y;
    }
    public class StructVsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { x = 1, y = 3 };
            SPonto copiaPonto1 = ponto1; // Atribuição por valor (mudanças não geram impacto na copia)
            ponto1.x = 3;

            Console.WriteLine("Ponto1 x: {0}",ponto1.x);
            Console.WriteLine("Copia Ponto1 x: {0}", copiaPonto1.x);

            CPonto ponto2 = new CPonto { x = 2, y = 4 };
            CPonto copiaPonto2 = ponto2; // Atribuição por referência (mudanças geram impacto na copia) Apontam para o mesmo local na memoria
            ponto2.x = 4;

            Console.WriteLine("Ponto2 x: {0}", ponto2.x);
            Console.WriteLine("Copia Ponto2 x: {0}", copiaPonto2.x);

        }
    }
}
