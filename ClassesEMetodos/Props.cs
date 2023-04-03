using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {
        // qlqr atributo sem definição, por padrão fica private
        double desconto = 0.1; // vamos definir os métodos privados com nome minusculo

        string nome;
        public string Nome { // os métodos publicos vamos iniciar com MAIUSCULO.
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; } // O CSharp permite esta forma de utilizar as propriedades do
                                          // método. O csharp já implicitamente atribui a função default
                                          // do get e set, podendo futuramente ser alterada.

        // Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); // Função Lambda - implicitamente já tem o return
                                               // o mesmo que:
                                               //get {
                                               //    return Preco - (desconto * Preco);
                                               //}
        }

        public CarroOpcional() { } // Construtor Padrão

        public CarroOpcional(string nome, double preco) { // Atribuindo os valores aos parametros
            Nome = nome;
            Preco = preco;
        }

    }

    internal class Props {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar condicionado", 3499.99);
            Console.WriteLine(op1.Nome);
            Console.WriteLine("$" + op1.Preco);
            Console.WriteLine("Valor com desconto $" + op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Blindagem";
            op2.Preco = 25995.90;
            Console.WriteLine(op2.Nome);
            Console.WriteLine("$" + op2.Preco);
            Console.WriteLine("Valor final $" + op2.PrecoComDesconto);
        }
    }
}
