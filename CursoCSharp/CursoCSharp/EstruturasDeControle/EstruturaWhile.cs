using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
      
            bool continuar = true;

            // Enquanto a expressão for verdadeira execute o bloco

            while (continuar)
            {
                Console.WriteLine("Digite um numero entre 0 e 5");
                int valorDigitado;
                var valor = Console.ReadLine();
                int.TryParse(valor, out valorDigitado);

                if (valorDigitado >=0 && valorDigitado <= 5) 
                {
                    Console.WriteLine($"Obrigado! o numero digitado foi {valorDigitado}");
                } else
                {
                    Console.WriteLine("Opps! o numero deve estar entre 0 e 5!");
                }

                Console.WriteLine("Deseja continuar S / N?");
                var continuarLoop = Console.ReadLine().ToLower();

                if (continuarLoop == "n")
                {
                    continuar = false;
                }
            }

        }
    }
}
