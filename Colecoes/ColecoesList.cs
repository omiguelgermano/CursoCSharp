using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object? obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }

        //public Produto() { }
    }

    internal class ColecoesList {
        public static void Executar() {
            Console.WriteLine("Coleções List!");

            var livro = new Produto("Game of Throne", 49.9);
            //Console.WriteLine(livro.Nome);
            //Console.WriteLine(livro.Preco);
            //Console.WriteLine("{0} ${1}", livro.Nome, livro.Preco);

            var carrinho = new List<Produto>();// List Generic
            carrinho.Add(livro); // method Add - livro ao carrinho

            var combo = new List<Produto>() { // Criando uma lista e colocando os produtos(itens)
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
            };

            carrinho.AddRange(combo);// AddRange - adiciona varias elementos de uma só vez
            Console.WriteLine(carrinho.Count);// Count - verifica o tamanho da lista

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            // a list permite itens repetidos
            Console.WriteLine(carrinho.Count);// Count - verifica o tamanho da lista
            carrinho.Add(livro);// Adicionando novamente o item.
            Console.WriteLine(carrinho.Count);// Count - verifica o tamanho da lista
        }
    }
}
