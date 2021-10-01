using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pessoa1 = new Pessoa();

             pessoa1.Nome = "Cleberton";
             pessoa1.Idade = 28;

            // Console.WriteLine($"Ola {pessoa1.Nome} você tem {pessoa1.Idade} anos!");
            pessoa1.ApresentarConsole();

            Pessoa pessoa2 = new Pessoa();

            pessoa2.Nome = "Francisco";
            pessoa2.Idade = 33;

            var apresentaçao = pessoa2.Apresentar();
            Console.WriteLine(apresentaçao);
        }
    }
}
