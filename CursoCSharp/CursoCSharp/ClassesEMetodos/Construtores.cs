using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        // Contrutor padrão

        public Carro() { } // Neste caso, o construtor padrão sera executado caso haja algum erro no contrutor criado

        // Construtor (Nome igual ao nome da Classe)
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }
    class Construtores
    {
        public static void Executar()
        {
            // Primeira forma de instaciar
            Carro carro1 = new Carro("BMW", "325i", 2021);
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ferrari", "Sportiva", 2020);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            // Segunda forma de instaciar
            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2021
            };

            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

            // Terceira forma de instaciar
            var carro4 = new Carro();
            carro4.Fabricante = "Ford";
            carro4.Modelo = "Prisma";
            carro4.Ano = 2019;

            Console.WriteLine($"{carro4.Fabricante} {carro4.Modelo} {carro4.Ano}");
        }
    }
}
