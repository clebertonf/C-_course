using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class Break
    {
        public static void Executar()
        {
            Random randon = new Random();
            int numero = randon.Next(1, 51);

            for (int i = 0; i < 20; i++)
            {
                if (i == numero)
                {
                    Console.WriteLine("É o numero 10", numero);
                    break; // Quanod a condição é alcançada o break finaliza o laço
                }
            }

        }
    }
}
