using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            string palavra = "Cleberton";

            foreach (var item in palavra)
            {
                Console.WriteLine(item);
            }

            var aluno = new string[] { "Lucas", "João", "Mario" };

            foreach (var item in aluno)
            {
                Console.WriteLine(item);
            }
        }
    }
}
