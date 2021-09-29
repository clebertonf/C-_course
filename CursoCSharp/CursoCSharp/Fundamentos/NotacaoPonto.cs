using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            // A notação de ponto é muito importante, usada para utilizar metodos (funcionalidades), no exemplo abaixo
            // utilizando os metodos de string

            var saudacao = "Ola mundo";
            Console.WriteLine(saudacao.ToUpper());

            string nome = "Cleberton".Insert(9, "teste").Replace("teste", " Francisco");
            Console.WriteLine(nome);

            // valores nullos
            string valorTeste = null;
            // Sem a ? ocorrera um erro, pois não é possivel iciciar uma variavel nula;
            // A ? executa algum metodo na variave so se existir algum valor
            Console.WriteLine(valorTeste?.Length);

        }
    }
}
