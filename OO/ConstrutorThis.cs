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

    public class Cachorro: Animal { // Classe Cachorro Herda da class generica ANIMAL
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) { // Criando um construtor base(arg) da classe ANIMAL
            Console.WriteLine($"Cachorro {nome} inicializado!");
        }
    }
    internal class ConstrutorThis {

        public static void Executar() {
            Console.WriteLine("Construtor usando o This");

            var cachorro = new Cachorro("Rex");
            Console.WriteLine(cachorro.Nome);
        }
    }
}
