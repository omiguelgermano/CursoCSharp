using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {

        // Método de Classe ou Método Estático
        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        // Método de Instância
        public int Somar(int a, int b) { 
            return a * b; 
        }
    }
    internal class MetodosEstaticos {
        public static void Executar() {
            Console.WriteLine("Métodos Estaticos");

            Console.WriteLine(CalculadoraEstatica.Multiplicar(12, 2));

            CalculadoraEstatica calcSoma = new CalculadoraEstatica();
            Console.WriteLine(calcSoma.Somar(2, 2));
        }
    }
}
