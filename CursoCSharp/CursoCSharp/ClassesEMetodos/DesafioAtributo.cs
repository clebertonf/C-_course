using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10; // poderia adicionar static, pois o metodo é estatico, então o atributo seria acessivel, sem precisar instanciar propria classe
        public static void Executar()
        {
            var minhaClasse = new DesafioAtributo(); // Para acessar a variavel (a) dentro da classe é necessario Criar uma instancia da propria classe
            Console.WriteLine(minhaClasse.a);
        }
    }
}
