using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosVariaveis
    {
        // palavara reservada params possibilita passar para o método varios parâmetros (com um array)
        public static void Recepicionar (params string[] pessoas) // Receberá um array com todos parâmetros
        {
            foreach (var item in pessoas)
            {
                Console.WriteLine($"Olá {item} seja bem vindo!");
            }
        }

        public static void Executar()
        {
            
           Recepicionar("Lucas", "João", "Maria");

        }
    }
}
