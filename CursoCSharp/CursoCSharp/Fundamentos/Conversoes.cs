using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            // Inserindo um inteiro ao um valor double (de forma  explicita)
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // Conversão implicita / explicita
            double nota = 9.7;
            int notaTruncada = (int)nota; // Converto explicitamente pata Int, para funcionar. (possíveis perdas de informação) (neste caso a linguagem obriga a fazer a conversão)
            Console.WriteLine(notaTruncada); // Tira as casas decimais

            // Converçoes string para inteiro int.Parse
            string numero = "10";
            var valorConvertido = int.Parse(numero);
            Console.WriteLine(valorConvertido);

            // Conversões com classe Convert
            string numero2 = "10";
            var valorConvertido2 = Convert.ToInt32(numero2);
            Console.WriteLine(valorConvertido2);

            // Forma mais segura de Fazer converção TryParse
            string palavra = "15";
            // int numero3;
            int.TryParse(palavra, out int numero3); // Converte em int e coloca o resultado (out) dentro da variavel numero3, caso não consiga coloca 0 por padrão
            Console.WriteLine(numero3);

            // Ultimo exemplo otimizado, lendo do console e mostrando o numero digitado
            Console.WriteLine("Digite um numero");
            int.TryParse(Console.ReadLine(), out int numero4);
            Console.WriteLine($"O numero é: {numero4}");
        }
    }
}
