using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    // Construtor PADRÃO, no qual não tem atribuição de Parametros
    class Carro {
        public string Modelo;// Atributo
        public string Fabricante;// Atributo
        public int Ano;// Atributo

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() { }
    }

    // Um construtor é um método cujo nome é igual ao nome de seu tipo. <DOC C# - https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/constructors> 
    class CarroGrand {
        public string Modelo;//Atributo
        public string Fabricante;//Atributo
        public int Ano;//Atributo

        public CarroGrand(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }

    // Criando um construtor no model da Doc do C# para fixação.
    class Livro {
        public string Categoria;
        public string Descricao;
        public string DescricaoGrand;
        public string Autor;
        public Livro(string categoria, string descricao, string descricaoGrand, string autor) {
            Categoria = categoria;
            Descricao = descricao;
            DescricaoGrand = descricaoGrand;
            Autor = autor;
        }

        public Livro() { }
    }

    internal class Construtores { // Essa classe, assim como as outras, foram adaptadas para rodar mais facilmente no Console por meio do Executar.
        public static void Executar() {
            //Console.WriteLine("Construtor");

            var carro1 = new Carro();
            carro1.Modelo = "325i";
            carro1.Fabricante = "BMW";
            carro1.Ano = 2020;

            Console.WriteLine("{0}  {1}  {2}", carro1.Modelo, carro1.Fabricante, carro1.Ano);

            var bigCar = new CarroGrand("Treiminhão", "Volvo", 2021);
            Console.WriteLine("{0}  {1}  {2}", bigCar.Modelo, bigCar.Fabricante, bigCar.Ano);


            Console.WriteLine();
            Console.WriteLine("Seção Livros!");

            var csharp = new Livro() {
                Categoria = "Programação",
                Descricao = "Livro de Programação na linguagem C#.",
                DescricaoGrand = "Livro para todos os niveis de estudante de Prgramação na linguagem C#.",
                Autor = "Miguel Germano",
            };
            Console.WriteLine($"Categira: {csharp.Categoria}");
            Console.WriteLine($"Descrição breve: {csharp.Descricao}");
            Console.WriteLine($"Descrição: {csharp.DescricaoGrand}");
            Console.WriteLine($"Autor: {csharp.Autor}");



            Console.WriteLine();
            var narnia1 = new Livro("Fantasia", "Livro de ficção e Fantasia", "uma história sobre quatro irmão que por uma guarda-roupas viajam para um país chamado Nárnia.", "CS Liwes");
            Console.WriteLine($"Categira: {narnia1.Categoria}");
            Console.WriteLine($"Descrição breve: {narnia1.Descricao}");
            Console.WriteLine($"Descrição: {narnia1.DescricaoGrand}");
            Console.WriteLine($"Autor: {narnia1.Autor}");

            Console.WriteLine();
            var narnia = new Livro();
            narnia.Categoria = "Fantasia";
            narnia.Descricao = "Livro de Fantasia infanto juvenil";
            narnia.DescricaoGrand = "uma história sobre quatro irmão que por uma guarda-roupas viajam para um país chamado Nárnia.";
            narnia.Autor = "CS Lewis";
            Console.WriteLine($"Categira: {narnia.Categoria}");
            Console.WriteLine($"Descrição breve: {narnia.Descricao}");
            Console.WriteLine($"Descrição: {narnia.DescricaoGrand}");
            Console.WriteLine($"Autor: {narnia.Autor}");
        }
    }
}
