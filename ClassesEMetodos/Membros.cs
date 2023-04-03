using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {

            Pessoa sicrano = new Pessoa();//Instanciando uma nova Pessoa | Criando um novo Objeto Pessoa
            sicrano.Nome = "Miguel"; 
            sicrano.Idade = 30;

            Console.WriteLine($"{ sicrano.Nome} tem {sicrano.Idade} anos.");

            Pessoa beltrano = new();//Modo simplificado para chamar o novo Objeto 'Pessoa'
            beltrano.Nome = "Germano";
            beltrano.Idade = 30;
            Console.WriteLine("{0} tem {1} anos.", beltrano.Nome, beltrano.Idade);

            beltrano.ApresentarNoConsole();

            var fulando = new Pessoa();
            fulando.Nome = "Dinah";
            fulando.Idade = 30;

            fulando .ApresentarNoConsole();
            fulando.Zerar();
            fulando.ApresentarNoConsole();
        }
    }
}
