using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Struct(estruturas)(palavra reservada): usado para interface, um tipo de assinatura de uma função. 
 *  Documentação Oficial -> https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/language-specification/structs
*/


namespace CursoCSharp.ClassesEMetodos {

    interface Ponto { // > Método de interface é público, ele não aceita o modificador para 'private'
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }

    internal class Struct {
        public static void Executar() {
            Console.WriteLine("Struct!");


            // variavel do tipo 'Coordenada' (código do curso) -> isso funciona por ser um Struct
            Coordenada coordenadaInicial;// > função de corpo. é possível por conta da Struct,
                                         // se fosse uma class não seria possível!
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Final: ");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);// Parâmetros nomeados
            coordenadaFinal.MoverNaDiagonal(10);
            Console.WriteLine("Coordenada Inicial: ");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }
}
