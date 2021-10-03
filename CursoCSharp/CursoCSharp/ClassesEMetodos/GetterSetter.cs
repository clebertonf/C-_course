using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada; // uint

        // Construtor
        public Moto(string marca, string modelo, int cilindrada)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;

            // Para utilizar validações dos metodos set
            // E eviatr que usuario coloque valores negativos, tanto no construtor quanto chamando setCilindrada diretamente
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        // Construtor padrão
        public Moto() { }

        // Metodos get e set (para cada atributo ha um get/set método)

        // Marca
        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        // Modelo

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        // Cilindrada

        public int GetCilindrada()
        {
            return Cilindrada;
        }

        // Com os metodos set ha possibilidades de colocar validações
        public void SetCilindrada(int cilindrada)
        {
            if (cilindrada > 0)
            {
                Cilindrada = cilindrada;
            }

            // Cilindrada = Math.Abs(cilindrada); para aceitar somente numeros positivos

            // Outra opção seria setar o tipo do atributo cilindrada para uint, pois não aceita sinal e
            // por consequência não aceita numeros negativos
        }
    }


    class GetterSetter
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja", 636);
            // get
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            // set
            var moto2 = new Moto("Honda", "CB", 250);
            moto2.SetCilindrada(300);
            Console.WriteLine(moto2.GetCilindrada());

            // Criando classe com construtor padrão
            var moto3 = new Moto();
            moto3.SetModelo("BMW");
            Console.WriteLine(moto3.GetModelo());
        }
    }
}
