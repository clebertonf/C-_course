using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Ola sou {Nome} e tenho {Idade} anos!");
        }

        public void ApresentarConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
