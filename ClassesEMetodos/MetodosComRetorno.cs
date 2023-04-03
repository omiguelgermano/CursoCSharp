using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    public class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }

    }
    internal class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();

            Console.WriteLine(calculadoraComum.Somar(5, 5));
            Console.WriteLine(calculadoraComum.Subtrair(5, 5));
            Console.WriteLine(calculadoraComum.Multiplicar(5, 5));

            var resultado = calculadoraComum.Somar(10, 55) + calculadoraComum.Subtrair(35, 2) +
                calculadoraComum.Multiplicar(2, 50);
            Console.WriteLine(resultado);

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(5).Multiplicar(5).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(10).Multiplicar(5).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
