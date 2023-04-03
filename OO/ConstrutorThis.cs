using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public class Animal { // CLASSE GENERICA
        public string Nome { get; set; }
        public Animal(string nome) { // CONTRUTOR PAI
            Nome = nome;
        }
    }
    internal class ConstrutorThis {

        public static void Executar() {
            Console.WriteLine("Construtor usando o This");

        }
    }
}
