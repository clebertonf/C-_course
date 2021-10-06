using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente 
    {
        public string Nome;
        readonly DateTime Nascimento; // Deixa o atributo imutável, como se fosse uma Const (usado para atributos)
        // Readonly deixa o valor somente de leitura dentro da classe e do objeto ja instanciado

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataNAscimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class AtributosReadonly
    {
        public static void Executar()
        {
            var cliente1 = new Cliente("Cleberton", new DateTime(1993, 09, 21));
            Console.WriteLine(cliente1.GetDataNAscimento());
        }
    }
}
