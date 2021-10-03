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
        private int Cilindrada;

        // Construtor
        public Moto(string marca, string modelo, int cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
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

        public void SetCilindrada(int cilindrada)
        {
            Cilindrada = cilindrada;
        }
    }

    
    class GetterSetter
    {
        public static void Executar()
        {

        }
    }
}
