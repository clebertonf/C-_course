using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    // Com enum temos um tipo fechado e controlado por você
    public enum Genero { Acao, Aventura, Comedia }

    public class Filme
    {
        public string Nome;
        public Genero GeneroFilme;
    }
    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Acao; // A conversão faz com que o indice do tipo enum passe para variavel ID
            // ou seja o genero ação é o indice zero
            Console.WriteLine(id);

            // Instanciando a classe
            var Filme = new Filme();
            Filme.Nome = "Hora de aventura";
            Filme.GeneroFilme = Genero.Aventura;

            Console.WriteLine(Filme.Nome);
            Console.WriteLine(Filme.GeneroFilme);        }
    }
}
