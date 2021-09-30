using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class Switch
    {
        public static void Executar()
        {
            int diaSemana = 5;

            switch (diaSemana)
            {
                case 0: // Podemos fazer dois cases assim
                case 1:
                    Console.WriteLine("Segunda");
                    break;
                case 2:
                    Console.WriteLine("Terca");
                    break;
                case 3:
                    Console.WriteLine("Quarta");
                    break;
                case 4:
                    Console.WriteLine("Quinta");
                    break;
                case 5:
                    Console.WriteLine("Sexta");
                    break;
                default:
                    Console.WriteLine("Ops! esse dia da semana não existe!");
                    break;
            }
        }
    }
}
