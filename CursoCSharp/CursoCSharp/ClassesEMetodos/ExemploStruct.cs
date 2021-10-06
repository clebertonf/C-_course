using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverDiagonal(int ponto);
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverDiagonal (int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    class ExemploStruct
    {
        public static void Executar()
        {
            // Atribuir valores aos atributos sem precisar instanciar a Struct
            Coordenada coordenadaInicial; // Criei uma variavel coordenadaInicial do tipo coordenada
            coordenadaInicial.X = 2; // Atribuir os valores
            coordenadaInicial.Y = 2;

            Console.WriteLine(coordenadaInicial.X);
            Console.WriteLine(coordenadaInicial.Y);

            // Instanciando a Struct

            var CoordenadaInstacia = new Coordenada(9, 1);
            CoordenadaInstacia.MoverDiagonal(10);

            Console.WriteLine(CoordenadaInstacia.X);
            Console.WriteLine(CoordenadaInstacia.Y);

            // Struct possui todas caracteristicas de uma classe, mas não precisa necesariamente ser instanciada
        }
    }
}
