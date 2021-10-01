using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class Continue
    {
        public static void Executar()
        {
            // continue intorrompe a repetição quando a condição é alcancada e vai para proxima

            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 1)
                {
                    continue; // Só passa para linha 22 caso o número seja par
                }

                Console.WriteLine(i);
            }

            for (int i = 0; i < 20; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
