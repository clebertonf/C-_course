using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            // Forma 1 de criar um array
            string[] alunos = new string[5];
            alunos[0] = "Carlos";
            alunos[1] = "Lucas";
            alunos[2] = "João";
            alunos[3] = "Marcos";
            alunos[4] = "Kaio";

            Console.WriteLine(alunos[0]);

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            // Forma 2 de criar um array
            double[] notas = { 5.5, 8.6, 6.8, 9.1, 10 };

            foreach (var nota in notas)
            {
                Console.WriteLine(nota);
            }


            char[] letras = { 'C', 'L', 'E', 'B', 'E', 'R' };
            string nome = new string(letras);
            Console.WriteLine(nome);

            // Forma 1 de criação
            string[] dados = new string[5];
            // Forma 2 de criação
            string[] valores = { "nome", "idade"};

        }
    }
}
